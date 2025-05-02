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
            Phone_text.MaxLength = 11;
            HideVisibility();

            UpdateControlVisibility();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearTextFields();
            Option_box.SelectedIndex = -1;
            ID_combo.SelectedIndex = -1;
            ID_combo.Items.Clear();

            UpdateControlVisibility();          
            Option_box.Items.Clear();
            Option_box.Items.Add("Insert");
            Option_box.Items.Add("Edit,Del");
            Option_box.Items.Add("Search");
            if (Categories.Text == "Donor")
            {
                Option_box.Items.Add("Donate");
            }
            else if (Categories.Text == "Volunteer")
            {
                Option_box.Items.Add("Assign");
            }
			else if (Categories.Text == "Admin")
			{
				Option_box.Items.Add("View Donor");
				Option_box.Items.Add("View Payment");
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

			don_name_txt.Visible = false;
			don_name_lbl.Visible = false;
			GetDonorDetailsButton.Visible = false;
			

			GetDonorsByPaymentMethodButton.Visible = false;
			PaymentMethodlabel.Visible = false;
			PaymentMethodTextBox.Visible = false;
			dataGridView.Visible = false;
            Search_button.Visible = false;
            ID_label.Visible = false;   
            ID_combo.Visible = false;
            S_label.Visible = false;
            S_box.Visible = false;
            D_label.Visible = false;
            D_box.Visible = false;
            Del_button.Visible = false;
		}

        private void UpdateControlVisibility()
        {
            ClearTextFields();
            HideVisibility();
            dataGridView.ReadOnly = false;
            dataGridView.DataSource = null;
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
                            Date_text.Text = DateTime.Now.ToString("yyyy-MM-dd");
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
                            Date_text.Text = DateTime.Now.ToString("yyyy-MM-dd");
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
            else if (Option_box.Text == "View Donor")
            {
				
				Email_label.Visible = true;
				Email_text.Visible = true;
				Phone_label.Visible = true;
				Phone_text.Visible = true;
				Payment_label.Visible = true;
				Payment_text.Visible = true;

				don_name_txt.Visible = true;
				don_name_lbl.Visible = true;
				GetDonorDetailsButton.Visible = true;
                ID_label.Visible = true;
                ID_combo.Visible = true;
            }

			else if (Option_box.Text == "View Payment")
			{

				GetDonorsByPaymentMethodButton.Visible = true;
				PaymentMethodlabel.Visible = true;
				PaymentMethodTextBox.Visible = true;
				dataGridView.Visible = true;
                dataGridView.ReadOnly = true;
            }

			else if (Option_box.Text == "Edit,Del")
            {
                dataGridView.Visible = true;
                button2.Visible = true;
                Name_label.Visible = true;
                Name_text.Visible = true;
                Search_button.Visible = true;
                Del_button.Visible = true;
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
                S_label.Visible = true;
                S_box.Visible = true;
                D_label.Visible = true;
                D_box.Visible = true;
                D_box.Text = DateTime.Now.ToString("yyyy-MM-dd");
                ID_box.SelectedIndex = -1;
                ID_box.Items.Clear();
               
                    //Add ID Hereee
                    ID_box.Items.Clear();

                  
                    conn = new OracleConnection(ordb);
                    conn.Open();

                    OracleCommand cmd = new OracleCommand("SELECT Donor_ID FROM Donor", conn);
                    OracleDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        ID_box.Items.Add(dr[0].ToString());
                    }

                    dr.Close();
                    conn.Dispose();

                
            }
            else if (Option_box.Text == "Assign")
            {
                assi_button.Visible = true;
                Vol_ID_box.Visible = true;
                D_ID.Visible = true;
                V_ID.Visible = true;
                Don_ID_box.Visible = true;
                S_label.Visible = true;
                S_box.Visible = true;
                D_label.Visible = true;
                D_box.Visible = true;
                D_box.Text = DateTime.Now.ToString("yyyy-MM-dd");
                Vol_ID_box.SelectedIndex = -1;
                Vol_ID_box.Items.Clear();

                //Add ID Hereee
                Vol_ID_box.Items.Clear();


                conn = new OracleConnection(ordb);
                conn.Open();

                OracleCommand cmd = new OracleCommand("SELECT Volunteer_ID FROM Volunteer", conn);
                OracleDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Vol_ID_box.Items.Add(dr[0].ToString());
                }

                dr.Close();
                conn.Dispose();
                /////////////////////////////////////////////////////////////////////////////////////
                Don_ID_box.SelectedIndex = -1;
                Don_ID_box.Items.Clear();

                //Add ID Hereee
                Don_ID_box.Items.Clear();


                conn = new OracleConnection(ordb);
                conn.Open();

                OracleCommand cmd2 = new OracleCommand("SELECT Donation_ID FROM Donation", conn);
                OracleDataReader dr2 = cmd2.ExecuteReader();

                while (dr2.Read())
                {
                    Don_ID_box.Items.Add(dr2[0].ToString());
                }

                dr2.Close();
                conn.Dispose();
            }
            else if (Option_box.Text == "Request")
            {
                ben_button.Visible = true;
                Type_ID.Visible = true;
                ID_box.Visible = true;
                data_type.Visible = true;
                type_box.Visible = true;
                S_label.Visible = true;
                S_box.Visible = true;
                D_label.Visible = true;
                D_box.Visible = true;
                D_box.Text = DateTime.Now.ToString("yyyy-MM-dd");
                ID_box.SelectedIndex = -1;
                ID_box.Items.Clear();

                //Add ID Hereee
                ID_box.Items.Clear();


                conn = new OracleConnection(ordb);
                conn.Open();

                OracleCommand cmd = new OracleCommand("SELECT Beneficiary_ID FROM Beneficiary", conn);
                OracleDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ID_box.Items.Add(dr[0].ToString());
                }

                dr.Close();
                conn.Dispose();
            }
            else if (Option_box.Text == "Search")
            {
                Search_button.Visible = true;
                ID_label.Visible = true;
                ID_combo.Visible = true;
                if (Option_box.SelectedIndex != -1)
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
                    OracleCommand checkCmd = new OracleCommand($"SELECT COUNT(*) FROM {tableName} WHERE Email = :email", conn);
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
            ClearTextFields();
            UpdateControlVisibility();
            Option_box.SelectedIndex = Option_box.SelectedIndex;
            ID_combo.SelectedIndex = -1;
            ID_combo.Items.Clear();
            if (Option_box.Text == "Search" || Option_box.Text == "View Donor")
            {
                //Add ID Hereee
                ID_combo.Items.Clear();

                string table = Categories.Text;
                if (Option_box.Text == "View Donor")
                {
                    table = "Donor";
                }
                string idColumn = table + "_ID";


                conn = new OracleConnection(ordb);
                conn.Open();

                OracleCommand cmd = new OracleCommand($"SELECT {idColumn} FROM {table}", conn);
                OracleDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ID_combo.Items.Add(dr[0].ToString());
                }

                dr.Close();
                conn.Dispose();

            }
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
            if (string.IsNullOrWhiteSpace(ID_box.Text) || string.IsNullOrWhiteSpace(type_box.Text) ||
                string.IsNullOrWhiteSpace(S_box.Text) || string.IsNullOrWhiteSpace(D_box.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            
                conn = new OracleConnection(ordb);
                conn.Open();

                OracleCommand checkCmd = new OracleCommand("SELECT COUNT(*) FROM Beneficiary WHERE Beneficiary_ID = :id", conn);
                checkCmd.Parameters.Add("id", ID_box.Text);

                int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                if (count == 0)
                {
                    MessageBox.Show("This Beneficiary ID not found.");
                    conn.Close();
                    return;
                }

            OracleCommand cmd = new OracleCommand("INSERT INTO Aid_Request (Beneficiary_ID, Aid_Type,Request_Date,Status) VALUES (:bid, :atype, :bdate, :bstatus)", conn);
                cmd.Parameters.Add("bid", ID_box.Text);
                cmd.Parameters.Add("atype", type_box.Text);
                cmd.Parameters.Add("bdate", Convert.ToDateTime(D_box.Text));
                cmd.Parameters.Add("bstatus", S_box.Text);

            int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Aid Request Submitted.");
                }
                else
                {
                    MessageBox.Show("Aid Request Failed.");
                }

                conn.Dispose();
            


        }

        private void D_button_Click(object sender, EventArgs e)
        {
            //Donation Code Here/////////////////
            if (string.IsNullOrWhiteSpace(ID_box.Text) || string.IsNullOrWhiteSpace(amount_box.Text) ||
                string.IsNullOrWhiteSpace(type_box.Text) || string.IsNullOrWhiteSpace(details_box.Text) ||
                string.IsNullOrWhiteSpace(S_box.Text) || string.IsNullOrWhiteSpace(D_box.Text))
            {
                MessageBox.Show("Please fill in all donation fields.");
                return;
            }

            if (!decimal.TryParse(amount_box.Text, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Please enter a valid donation amount.");
                return;
            }
            conn = new OracleConnection(ordb);
                conn.Open();

            OracleCommand checkCmd = new OracleCommand("SELECT COUNT(*) FROM Donation WHERE Donor_ID = :id", conn);
            checkCmd.Parameters.Add("id", ID_box.Text);

            int count = Convert.ToInt32(checkCmd.ExecuteScalar());
            if (count == 0)
            {
                MessageBox.Show("This Donation ID not found.");
                conn.Dispose();
                return;
            }

            OracleCommand cmd = new OracleCommand("INSERT INTO Donation (Donor_ID, Amount, Donation_Type, Payment_Details, Status, Donation_Date)" +
                    " VALUES (:donor_id, :amount, :type, :details, :status, :adate)", conn);

                cmd.Parameters.Add("donor_id", ID_box.Text);
                cmd.Parameters.Add("amount", Convert.ToDecimal(amount_box.Text));
                cmd.Parameters.Add("type", type_box.Text);
                cmd.Parameters.Add("details", details_box.Text);
                cmd.Parameters.Add("status", S_box.Text);
                cmd.Parameters.Add("adate", Convert.ToDateTime(D_box.Text));

            int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Donation Recorded Successfully.");
                }
                else
                {
                    MessageBox.Show("Donation Failed.");
                }

                conn.Dispose();
           

        }

        private void assi_button_Click(object sender, EventArgs e)
        {
            //Assign Code Here/////////////////
            if (string.IsNullOrWhiteSpace(Vol_ID_box.Text) || string.IsNullOrWhiteSpace(Don_ID_box.Text) ||
                string.IsNullOrWhiteSpace(S_box.Text) || string.IsNullOrWhiteSpace(D_box.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            
                conn = new OracleConnection(ordb);
                conn.Open();

                OracleCommand checkVol = new OracleCommand("SELECT COUNT(*) FROM Volunteer WHERE Volunteer_ID = :vid", conn);
                checkVol.Parameters.Add("vid", Vol_ID_box.Text);
                int volExists = Convert.ToInt32(checkVol.ExecuteScalar());

                if (volExists == 0)
                {
                    MessageBox.Show("Volunteer ID not found.");
                    conn.Dispose();
                    return;
                }

                OracleCommand checkDon = new OracleCommand("SELECT COUNT(*) FROM Donation WHERE Donation_ID = :did", conn);
                checkDon.Parameters.Add("did", Don_ID_box.Text);
                int donExists = Convert.ToInt32(checkDon.ExecuteScalar());

                if (donExists == 0)
                {
                    MessageBox.Show("Donation ID not found.");
                    conn.Dispose();
                    return;
                }

            OracleCommand cmd = new OracleCommand("INSERT INTO Volunteer_Task (Volunteer_ID, Donation_ID, Status, Update_Date) VALUES (:vid, :did, :status, :adate)", conn);
                cmd.Parameters.Add("vid", Vol_ID_box.Text);
                cmd.Parameters.Add("did", Don_ID_box.Text);
                cmd.Parameters.Add("status", S_box.Text);
                cmd.Parameters.Add("adate", Convert.ToDateTime(D_box.Text));

            int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Task Assigned Successfully.");
                }
                else
                {
                    MessageBox.Show("Assignment Failed.");
                }

                conn.Dispose();
           


        }

		private void GetDonorDetailsButton_Click(object sender, EventArgs e)
		{
			string donorID = ID_combo.Text; // Assuming there's a textbox for Donor ID
			if (!string.IsNullOrEmpty(donorID))
			{
				OracleConnection conn = new OracleConnection(ordb);
				conn.Open();

				OracleCommand cmd = new OracleCommand("GetDonorDetails", conn);
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.Add("p_DonorID", OracleDbType.Varchar2).Value = donorID;

				OracleParameter pName = new OracleParameter("p_Name", OracleDbType.Varchar2, 50);
				pName.Direction = ParameterDirection.Output;
				cmd.Parameters.Add(pName);

				OracleParameter pEmail = new OracleParameter("p_Email", OracleDbType.Varchar2, 50);
				pEmail.Direction = ParameterDirection.Output;
				cmd.Parameters.Add(pEmail);

				OracleParameter pPhone = new OracleParameter("p_PhoneNumber", OracleDbType.Varchar2, 15);
				pPhone.Direction = ParameterDirection.Output;
				cmd.Parameters.Add(pPhone);

				OracleParameter pPayment = new OracleParameter("p_PaymentMethod", OracleDbType.Varchar2, 20);
				pPayment.Direction = ParameterDirection.Output;
				cmd.Parameters.Add(pPayment);

				cmd.ExecuteNonQuery();

				// Assign output values to UI fields
				don_name_lbl.Visible = true;
				don_name_txt.Visible = true;
				don_name_txt.Text = pName.Value.ToString();

				Email_label.Visible = true;
				Email_text.Visible = true;
				Email_text.Text = pEmail.Value.ToString();

				Phone_label.Visible = true;
				Phone_text.Visible = true;
				Phone_text.Text = pPhone.Value.ToString();

				//DonorIDlabel.Visible = true;
				//DonorIDTextBox.Visible = true;
				//DonorIDTextBox.Text = donorID;

				Payment_label.Visible = true;
				Payment_text.Visible = true;
				Payment_text.Text = pPayment.Value.ToString();

				conn.Close();
			}
			else
			{
				MessageBox.Show("Please enter a valid Donor ID.");
			}
		}

		private void GetDonorsByPaymentMethodButton_Click(object sender, EventArgs e)
		{
			string paymentMethod = PaymentMethodTextBox.Text; // Assuming there's a textbox for Payment Method
			if (!string.IsNullOrEmpty(paymentMethod))
			{
				OracleConnection conn = new OracleConnection(ordb);
				conn.Open();

				OracleCommand cmd = new OracleCommand("GetDonorsByPaymentMethod", conn);
				cmd.CommandType = CommandType.StoredProcedure;

				// Input parameter
				cmd.Parameters.Add("p_payment_method", OracleDbType.Varchar2).Value = paymentMethod;

				// Output parameter (SYS_REFCURSOR)
				OracleParameter pDonors = new OracleParameter("p_donors", OracleDbType.RefCursor);
				pDonors.Direction = ParameterDirection.Output;
				cmd.Parameters.Add(pDonors);

				// Execute
				cmd.ExecuteNonQuery();

				// Get the reader from the output parameter
				OracleDataReader reader = ((OracleRefCursor)pDonors.Value).GetDataReader();

				// Load into DataTable and bind to DataGridView
				DataTable dt = new DataTable();
				dt.Load(reader);
				dataGridView.DataSource = dt;

				// Enhance DataGridView display
				dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
				dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView.Font, FontStyle.Bold);
				dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
				dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

				conn.Close();
			}
			else
			{
				MessageBox.Show("Please enter a valid payment method.");
			}
		}

        private void ID_combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            //Show Specific row data Here
            if (Option_box.Text == "Search")
            {

                if (string.IsNullOrWhiteSpace(ID_combo.Text))
                {
                    MessageBox.Show("Please select or enter an ID.");
                    return;
                }

                string table = Categories.Text;
                string idColumn = table + "_ID";


                conn = new OracleConnection(ordb);
                conn.Open();

                OracleCommand cmd = new OracleCommand($"SELECT * FROM {table} WHERE {idColumn} = :id", conn);
                cmd.Parameters.Add("id", ID_combo.Text.Trim());

                OracleDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    Name_text.Text = dr["Name"].ToString();
                    Email_text.Text = dr["Email"].ToString();
                    Phone_text.Text = dr["Phone_Number"].ToString();

                    if (table == "Donor")
                    {
                        Payment_text.Text = dr["Payment_Method"].ToString();
                        Date_text.Text = Convert.ToDateTime(dr["Registration_Date"]).ToString("yyyy-MM-dd");
                    }
                    else if (table == "Volunteer")
                    {
                        Skills_text.Text = dr["Skills"].ToString();
                        Available_text.Text = dr["Availability"].ToString();
                        Date_text.Text = Convert.ToDateTime(dr["Registration_Date"]).ToString("yyyy-MM-dd");
                    }
                    else if (table == "Beneficiary")
                    {
                        Address_text.Text = dr["Address"].ToString();
                        Status_text.Text = dr["Status"].ToString();
                    }
                }
                else
                {
                    ClearTextFields();
                    MessageBox.Show("No data found for the selected ID.");
                }

                dr.Close();
                conn.Dispose();
            }
            else if (Option_box.Text == "Edit,Del")
            {
                //show Data Code Here////////////////////////////
               
                string cmdstr = "";
                if (Categories.Text == "Volunteer")
                {
                    cmdstr = $"SELECT * FROM Volunteer WHERE name = :name";

                    using (OracleConnection conn = new OracleConnection(ordb))
                    {
                        OracleCommand cmd = new OracleCommand(cmdstr, conn);
                        cmd.Parameters.Add(new OracleParameter("name", Name_text.Text));
                    }
                }
                else if (Categories.Text == "Donor")
                {
                    cmdstr = $"SELECT * FROM Donor WHERE name = :name";

                    using (OracleConnection conn = new OracleConnection(ordb))
                    {
                        OracleCommand cmd = new OracleCommand(cmdstr, conn);
                        cmd.Parameters.Add(new OracleParameter("name", Name_text.Text));
                    }
                }
                else if (Categories.Text == "Beneficiary")
                {
                    cmdstr = $"SELECT * FROM Beneficiary WHERE name = :name";

                    using (OracleConnection conn = new OracleConnection(ordb))
                    {
                        OracleCommand cmd = new OracleCommand(cmdstr, conn);
                        cmd.Parameters.Add(new OracleParameter("name", Name_text.Text));
                    }
                }
                else if (Categories.Text == "Admin")
                {
                    cmdstr = $"SELECT * FROM Admin WHERE name = :name";

                    using (OracleConnection conn = new OracleConnection(ordb))
                    {
                        OracleCommand cmd = new OracleCommand(cmdstr, conn);
                        cmd.Parameters.Add(new OracleParameter("name", Name_text.Text));
                    }
                }
                adapter = new OracleDataAdapter(cmdstr, ordb);
                ds = new DataSet();
                adapter.SelectCommand.Parameters.Add("name", Name_text.Text);
                adapter.Fill(ds);
                dataGridView.DataSource = ds.Tables[0];               
                dataGridView.Columns[0].ReadOnly = true;
                            
            }
        }
        private void ClearTextFields()
        {
            Name_text.Text = "";
            Email_text.Text = "";
            Phone_text.Text = "";
            Payment_text.Text = "";
            Skills_text.Text = "";
            Available_text.Text = "";
            Address_text.Text = "";
            Status_text.Text = "";
            Date_text.Text = "";
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void Del_button_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                dataGridView.Rows.RemoveAt(dataGridView.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }
    }
}
