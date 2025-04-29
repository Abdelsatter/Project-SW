using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_SW
{ 

    public partial class Form1 : Form
    {
        OracleDataAdapter adapter;
        OracleCommandBuilder commandBuilder;
        DataSet ds;

        public Form1()
        {
            InitializeComponent(); 

        }

        
        private void Form1_Load(object sender, EventArgs e)
        {            
            Categories.SelectedIndex = -1;
            Option_box.SelectedIndex = -1;
            Date_text.Text = DateTime.Now.ToString("yyyy-MM-dd");             
            Date_text.ReadOnly = true;            
            Date_text.BackColor = SystemColors.Control;

            HideVisibility();

            UpdateControlVisibility();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Option_box.SelectedIndex = -1;
            UpdateControlVisibility();          
            Option_box.Items.Clear();
            Option_box.Items.Add("Insert");
            Option_box.Items.Add("Edit,Del");

            if (Categories.Text == "Donor")
            {
                Option_box.Items.Add("Donate");
            }
            else if (Categories.Text == "Volunteer")
            {
                Option_box.Items.Add("Assign");
            }
            else if (Categories.Text == "Beneficiary")
            {
                Option_box.Items.Add("Request");
            }
        }
        private void HideVisibility()
        {
            Name_text.Visible = false;
            Name_label.Visible = false;
            Email_text.Visible = false;
            Email_label.Visible = false;
            Phone_text.Visible = false;
            Phone_label.Visible = false;
            Payment_text.Visible = false;
            Payment_label.Visible = false;
            Skills_text.Visible = false;
            Skills_label.Visible = false;
            Available_text.Visible = false;
            Available_label.Visible = false;
            Address_text.Visible = false;
            Address_label.Visible = false;
            Status_text.Visible = false;
            Status_label.Visible = false;
            Date_text.Visible = false;
            Date_label.Visible = false;
            dataGridView.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            ben_button.Visible = false;
            assi_button.Visible = false;    
            D_button.Visible = false;
            Type_ID.Visible = false;
            ID_box.Visible = false;
            amount_box.Visible = false;
            D_amount.Visible = false;
            data_type.Visible = false;  
            type_box.Visible = false;
            D_details.Visible = false;
            details_box.Visible = false;
            Vol_ID_box.Visible = false;
            D_ID.Visible = false;
            V_ID.Visible = false;
            Don_ID_box.Visible = false;
        }

        private void UpdateControlVisibility()
        {
            HideVisibility();
            
            if (Option_box.Text == "Insert")
            {
                
                button1.Visible = true;
                if (Categories.SelectedItem != null)
                {
                    switch (Categories.SelectedItem.ToString())
                    {
                        case "Volunteer":
                            Name_label.Visible = true;
                            Name_text.Visible = true;
                            Email_label.Visible = true;
                            Email_text.Visible = true;
                            Phone_label.Visible = true;
                            Phone_text.Visible = true;
                            Skills_label.Visible = true;
                            Skills_text.Visible = true;
                            Available_label.Visible = true;
                            Available_text.Visible = true;
                            Date_label.Visible = true;
                            Date_text.Visible = true;                          
                            break;
                        case "Donor":
                            Name_label.Visible = true;
                            Name_text.Visible = true;
                            Email_label.Visible = true;
                            Email_text.Visible = true;
                            Phone_label.Visible = true;
                            Phone_text.Visible = true;
                            Payment_label.Visible = true;
                            Payment_text.Visible = true;
                            Date_label.Visible = true;
                            Date_text.Visible = true;                          
                            break;
                        case "Beneficiary":
                            Name_label.Visible = true;
                            Name_text.Visible = true;
                            Email_label.Visible = true;
                            Email_text.Visible = true;
                            Phone_label.Visible = true;
                            Phone_text.Visible = true;
                            Address_label.Visible = true;
                            Address_text.Visible = true;
                            Status_label.Visible = true;
                            Status_text.Visible = true;                            
                            break;
                        case "Admin":
                            Name_label.Visible = true;
                            Name_text.Visible = true;
                            Email_label.Visible = true;
                            Email_text.Visible = true;
                            Phone_label.Visible = true;
                            Phone_text.Visible = true;                           
                            break;
                    }
                }
            }
            else if(Option_box.Text == "Edit,Del")
            {
                dataGridView.Visible = true;
                button2.Visible = true;
                Name_label.Visible = true;
                Name_text.Visible = true;
                //show Data Code Here////////////////////////////
                string constr = "Data source=orcl;user Id=scott;password=tiger;";
                string cmdstr = "";
                if (Categories.Text == "Volunteer")
                {
                    cmdstr = $"SELECT * FROM Volunteer WHERE name = :name";

                    using (OracleConnection conn = new OracleConnection(constr))
                    {
                        OracleCommand cmd = new OracleCommand(cmdstr, conn);
                        cmd.Parameters.Add(new OracleParameter("name", Name_text.Text));
                    }
                }   
                else if(Categories.Text =="Donor")
                {
                    cmdstr = $"SELECT * FROM Donor WHERE name = :name";

                    using (OracleConnection conn = new OracleConnection(constr))
                    {
                        OracleCommand cmd = new OracleCommand(cmdstr, conn);
                        cmd.Parameters.Add(new OracleParameter("name", Name_text.Text));
                    }
                }
                else if(Categories.Text== "Beneficiary")
                {
                    cmdstr = $"SELECT * FROM Beneficiary WHERE name = :name";

                    using (OracleConnection conn = new OracleConnection(constr))
                    {
                        OracleCommand cmd = new OracleCommand(cmdstr, conn);
                        cmd.Parameters.Add(new OracleParameter("name", Name_text.Text));
                    }
                }
                else if(Categories.Text =="Admin")
                {
                    cmdstr = $"SELECT * FROM Admin WHERE name = :name";

                    using (OracleConnection conn = new OracleConnection(constr))
                    {
                        OracleCommand cmd = new OracleCommand(cmdstr, conn);
                        cmd.Parameters.Add(new OracleParameter("name", Name_text.Text));
                    }
                }
                adapter = new OracleDataAdapter(cmdstr, constr);
                ds=new DataSet();
                adapter.Fill(ds);
                dataGridView.DataSource= ds.Tables[0];


            }
            else if (Option_box.Text == "Donate")
            {
                D_button.Visible = true;
                Type_ID.Visible = true;
                ID_box.Visible = true;
                amount_box.Visible = true;
                D_amount.Visible = true;
                data_type.Visible = true;
                type_box.Visible = true;
                D_details.Visible = true;
                details_box.Visible = true;
            }
            else if (Option_box.Text == "Assign")
            {
                assi_button.Visible = true;
                Vol_ID_box.Visible = true;
                D_ID.Visible = true;
                V_ID.Visible = true;
                Don_ID_box.Visible = true;
            }
            else if (Option_box.Text == "Request")
            {
                ben_button.Visible = true;
                Type_ID.Visible = true;
                ID_box.Visible = true;
                data_type.Visible = true;
                type_box.Visible = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (Categories.SelectedIndex != -1 )
            {
                bool allFieldsFilled = true;

                
                if (Categories.Text == "Volunteer")
                {
                    
                    if (string.IsNullOrEmpty(Name_text.Text) ||
                        string.IsNullOrEmpty(Email_text.Text) ||
                        string.IsNullOrEmpty(Phone_text.Text) ||
                        string.IsNullOrEmpty(Skills_text.Text) ||
                        string.IsNullOrEmpty(Available_text.Text) ||
                        string.IsNullOrEmpty(Date_text.Text))
                    {
                        allFieldsFilled = false;
                    }
                }
                
                else if (Categories.Text == "Donor")
                {
                    if (string.IsNullOrEmpty(Name_text.Text) ||
                        string.IsNullOrEmpty(Email_text.Text) ||
                        string.IsNullOrEmpty(Phone_text.Text) ||
                        string.IsNullOrEmpty(Payment_text.Text) ||
                        string.IsNullOrEmpty(Date_text.Text))
                    {
                        allFieldsFilled = false;
                    }
                }
                
                else if (Categories.Text == "Beneficiary")
                {
                    if (string.IsNullOrEmpty(Name_text.Text) ||
                        string.IsNullOrEmpty(Email_text.Text) ||
                        string.IsNullOrEmpty(Phone_text.Text) ||
                        string.IsNullOrEmpty(Address_text.Text) ||
                        string.IsNullOrEmpty(Status_text.Text))
                    {
                        allFieldsFilled = false;
                    }
                }
                
                else if (Categories.Text == "Admin")
                {
                    if (string.IsNullOrEmpty(Name_text.Text) ||
                        string.IsNullOrEmpty(Email_text.Text) ||
                        string.IsNullOrEmpty(Phone_text.Text))
                    {
                        allFieldsFilled = false;
                    }
                }

                // If all fields are filled, show the success message
                if (allFieldsFilled)
                {
                    MessageBox.Show("Data Saved Successfully!");
                    //Insert Row Code Here//////////////////////



                }
                else
                {
                    MessageBox.Show("Please fill in all the required fields.");
                }
            }
            else
            {
                MessageBox.Show("Please select a category.");
            }
        }

        private void Option_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateControlVisibility();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Save Update or Delete Here////////////////////
            commandBuilder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);


        }
         
        private void ben_button_Click(object sender, EventArgs e)
        {
            //Request_Aid Code Here/////////////////



        }

        private void D_button_Click(object sender, EventArgs e)
        {
            //Donation Code Here/////////////////


        }

        private void assi_button_Click(object sender, EventArgs e)
        {
            //Assign Code Here/////////////////



        }
    }
}
