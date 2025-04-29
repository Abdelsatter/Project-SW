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
        string ordb = "Data Source = orcl;User Id = scott;Password = tiger;";
        OracleConnection conn;
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
            Phone_text.MaxLength = 11;
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
                //show Data Code Here////////////////////////////



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

                if (!IsPhoneNumberValid(Phone_text.Text))
                {
                    MessageBox.Show("Please enter a valid phone number with exactly 11 digits.");
                    return;
                }

                // If all fields are filled, show the success message
                if (allFieldsFilled)
                {
                    MessageBox.Show("Data Saved Successfully!");
                    //Insert Row Code Here//////////////////////
                    conn = new OracleConnection(ordb);
                    conn.Open();
                    // Check if the email already exists in the database
                    string tableName = Categories.Text;
                    OracleCommand checkCmd = new OracleCommand("SELECT COUNT(*) FROM Donor WHERE Email = :email", conn);
                    checkCmd.Parameters.Add("email", Email_text.Text);
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("Email already exists.");
                        return;
                    }

                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = conn;

                    if (Categories.Text == "Donor")
                    {
                        cmd.CommandText = "INSERT INTO Donor (Name, Email, Phone_Number, Payment_Method) VALUES (:name, :email, :phone, :payment)";
                        cmd.Parameters.Add("name", Name_text.Text);
                        cmd.Parameters.Add("email", Email_text.Text);
                        cmd.Parameters.Add("phone", Phone_text.Text);
                        cmd.Parameters.Add("payment", Payment_text.Text);
                    }
                    else if (Categories.Text == "Volunteer")
                    {
                        cmd.CommandText = "INSERT INTO Volunteer (Name, Email, Phone_Number, Skills, Availability) VALUES (:name, :email, :phone, :skills, :availability)";
                        cmd.Parameters.Add("name", Name_text.Text);
                        cmd.Parameters.Add("email", Email_text.Text);
                        cmd.Parameters.Add("phone", Phone_text.Text);
                        cmd.Parameters.Add("skills", Skills_text.Text);
                        cmd.Parameters.Add("availability", Available_text.Text);
                    }
                    else if (Categories.Text == "Beneficiary")
                    {
                        cmd.CommandText = "INSERT INTO Beneficiary (Name, Email, Phone_Number, Address, Status) VALUES (:name, :email, :phone, :address, :status)";
                        cmd.Parameters.Add("name", Name_text.Text);
                        cmd.Parameters.Add("email", Email_text.Text);
                        cmd.Parameters.Add("phone", Phone_text.Text);
                        cmd.Parameters.Add("address", Address_text.Text);
                        cmd.Parameters.Add("status", Status_text.Text);
                    }
                    else if (Categories.Text == "Admin")
                    {
                        cmd.CommandText = "INSERT INTO Admin (Name, Email, Phone_Number) VALUES (:name, :email, :phone)";
                        cmd.Parameters.Add("name", Name_text.Text);
                        cmd.Parameters.Add("email", Email_text.Text);
                        cmd.Parameters.Add("phone", Phone_text.Text);
                    }

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Inserted successfully into " + Categories.Text + " table.");
                    }
                    else
                    {
                        MessageBox.Show("Insert failed.");
                    }

                    conn.Dispose();

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
        private bool IsPhoneNumberValid(string phoneNumber)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, @"^\d{11}$");
        }
        private void Option_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateControlVisibility();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Save Update or Delete Here////////////////////



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
