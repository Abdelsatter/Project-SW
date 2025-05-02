namespace Project_SW
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Category_label = new System.Windows.Forms.Label();
            this.Categories = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Name_label = new System.Windows.Forms.Label();
            this.Name_text = new System.Windows.Forms.TextBox();
            this.Email_label = new System.Windows.Forms.Label();
            this.Email_text = new System.Windows.Forms.TextBox();
            this.Phone_label = new System.Windows.Forms.Label();
            this.Phone_text = new System.Windows.Forms.TextBox();
            this.Payment_label = new System.Windows.Forms.Label();
            this.Status_label = new System.Windows.Forms.Label();
            this.Address_text = new System.Windows.Forms.TextBox();
            this.Address_label = new System.Windows.Forms.Label();
            this.Available_label = new System.Windows.Forms.Label();
            this.Skills_label = new System.Windows.Forms.Label();
            this.Date_text = new System.Windows.Forms.TextBox();
            this.Date_label = new System.Windows.Forms.Label();
            this.Option_label = new System.Windows.Forms.Label();
            this.Option_box = new System.Windows.Forms.ComboBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.Type_ID = new System.Windows.Forms.Label();
            this.D_amount = new System.Windows.Forms.Label();
            this.amount_box = new System.Windows.Forms.TextBox();
            this.details_box = new System.Windows.Forms.TextBox();
            this.D_details = new System.Windows.Forms.Label();
            this.data_type = new System.Windows.Forms.Label();
            this.D_ID = new System.Windows.Forms.Label();
            this.V_ID = new System.Windows.Forms.Label();
            this.D_button = new System.Windows.Forms.Button();
            this.assi_button = new System.Windows.Forms.Button();
            this.ben_button = new System.Windows.Forms.Button();
            this.GetDonorDetailsButton = new System.Windows.Forms.Button();
            this.don_name_txt = new System.Windows.Forms.TextBox();
            this.don_name_lbl = new System.Windows.Forms.Label();
            this.GetDonorsByPaymentMethodButton = new System.Windows.Forms.Button();
            this.PaymentMethodlabel = new System.Windows.Forms.Label();
            this.ID_label = new System.Windows.Forms.Label();
            this.Search_button = new System.Windows.Forms.Button();
            this.ID_combo = new System.Windows.Forms.ComboBox();
            this.Back_button = new System.Windows.Forms.Button();
            this.ID_box = new System.Windows.Forms.ComboBox();
            this.Vol_ID_box = new System.Windows.Forms.ComboBox();
            this.Don_ID_box = new System.Windows.Forms.ComboBox();
            this.S_label = new System.Windows.Forms.Label();
            this.D_label = new System.Windows.Forms.Label();
            this.D_box = new System.Windows.Forms.TextBox();
            this.Payment_text = new System.Windows.Forms.ComboBox();
            this.PaymentMethodTextBox = new System.Windows.Forms.ComboBox();
            this.type_box = new System.Windows.Forms.ComboBox();
            this.S_box = new System.Windows.Forms.ComboBox();
            this.Status_text = new System.Windows.Forms.ComboBox();
            this.Available_text = new System.Windows.Forms.ComboBox();
            this.Skills_text = new System.Windows.Forms.ComboBox();
            this.Del_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Category_label
            // 
            this.Category_label.AutoSize = true;
            this.Category_label.Location = new System.Drawing.Point(41, 48);
            this.Category_label.Name = "Category_label";
            this.Category_label.Size = new System.Drawing.Size(62, 16);
            this.Category_label.TabIndex = 0;
            this.Category_label.Text = "Category";
            // 
            // Categories
            // 
            this.Categories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Categories.FormattingEnabled = true;
            this.Categories.Items.AddRange(new object[] {
            "Donor",
            "Volunteer",
            "Beneficiary",
            "Admin"});
            this.Categories.Location = new System.Drawing.Point(109, 46);
            this.Categories.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Categories.Name = "Categories";
            this.Categories.Size = new System.Drawing.Size(121, 24);
            this.Categories.TabIndex = 1;
            this.Categories.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(316, 377);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Name_label
            // 
            this.Name_label.AutoSize = true;
            this.Name_label.Location = new System.Drawing.Point(347, 17);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(44, 16);
            this.Name_label.TabIndex = 3;
            this.Name_label.Text = "Name";
            // 
            // Name_text
            // 
            this.Name_text.Location = new System.Drawing.Point(409, 14);
            this.Name_text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name_text.Name = "Name_text";
            this.Name_text.Size = new System.Drawing.Size(175, 22);
            this.Name_text.TabIndex = 4;
            // 
            // Email_label
            // 
            this.Email_label.AutoSize = true;
            this.Email_label.Location = new System.Drawing.Point(347, 95);
            this.Email_label.Name = "Email_label";
            this.Email_label.Size = new System.Drawing.Size(41, 16);
            this.Email_label.TabIndex = 5;
            this.Email_label.Text = "Email";
            // 
            // Email_text
            // 
            this.Email_text.Location = new System.Drawing.Point(409, 92);
            this.Email_text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Email_text.Name = "Email_text";
            this.Email_text.Size = new System.Drawing.Size(175, 22);
            this.Email_text.TabIndex = 6;
            // 
            // Phone_label
            // 
            this.Phone_label.AutoSize = true;
            this.Phone_label.Location = new System.Drawing.Point(336, 127);
            this.Phone_label.Name = "Phone_label";
            this.Phone_label.Size = new System.Drawing.Size(67, 16);
            this.Phone_label.TabIndex = 7;
            this.Phone_label.Text = "Phone No";
            // 
            // Phone_text
            // 
            this.Phone_text.Location = new System.Drawing.Point(409, 124);
            this.Phone_text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Phone_text.Name = "Phone_text";
            this.Phone_text.Size = new System.Drawing.Size(175, 22);
            this.Phone_text.TabIndex = 8;
            // 
            // Payment_label
            // 
            this.Payment_label.AutoSize = true;
            this.Payment_label.Location = new System.Drawing.Point(295, 162);
            this.Payment_label.Name = "Payment_label";
            this.Payment_label.Size = new System.Drawing.Size(108, 16);
            this.Payment_label.TabIndex = 9;
            this.Payment_label.Text = "Payment Method";
            // 
            // Status_label
            // 
            this.Status_label.AutoSize = true;
            this.Status_label.Location = new System.Drawing.Point(359, 289);
            this.Status_label.Name = "Status_label";
            this.Status_label.Size = new System.Drawing.Size(44, 16);
            this.Status_label.TabIndex = 17;
            this.Status_label.Text = "Status";
            // 
            // Address_text
            // 
            this.Address_text.Location = new System.Drawing.Point(409, 254);
            this.Address_text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Address_text.Name = "Address_text";
            this.Address_text.Size = new System.Drawing.Size(175, 22);
            this.Address_text.TabIndex = 16;
            // 
            // Address_label
            // 
            this.Address_label.AutoSize = true;
            this.Address_label.Location = new System.Drawing.Point(345, 256);
            this.Address_label.Name = "Address_label";
            this.Address_label.Size = new System.Drawing.Size(58, 16);
            this.Address_label.TabIndex = 15;
            this.Address_label.Text = "Address";
            // 
            // Available_label
            // 
            this.Available_label.AutoSize = true;
            this.Available_label.Location = new System.Drawing.Point(331, 224);
            this.Available_label.Name = "Available_label";
            this.Available_label.Size = new System.Drawing.Size(72, 16);
            this.Available_label.TabIndex = 13;
            this.Available_label.Text = "Availability";
            // 
            // Skills_label
            // 
            this.Skills_label.AutoSize = true;
            this.Skills_label.Location = new System.Drawing.Point(347, 194);
            this.Skills_label.Name = "Skills_label";
            this.Skills_label.Size = new System.Drawing.Size(39, 16);
            this.Skills_label.TabIndex = 11;
            this.Skills_label.Text = "Skills";
            // 
            // Date_text
            // 
            this.Date_text.Location = new System.Drawing.Point(409, 320);
            this.Date_text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Date_text.Name = "Date_text";
            this.Date_text.Size = new System.Drawing.Size(175, 22);
            this.Date_text.TabIndex = 20;
            // 
            // Date_label
            // 
            this.Date_label.AutoSize = true;
            this.Date_label.Location = new System.Drawing.Point(292, 322);
            this.Date_label.Name = "Date_label";
            this.Date_label.Size = new System.Drawing.Size(111, 16);
            this.Date_label.TabIndex = 19;
            this.Date_label.Text = "Registration Date";
            // 
            // Option_label
            // 
            this.Option_label.AutoSize = true;
            this.Option_label.Location = new System.Drawing.Point(41, 100);
            this.Option_label.Name = "Option_label";
            this.Option_label.Size = new System.Drawing.Size(46, 16);
            this.Option_label.TabIndex = 21;
            this.Option_label.Text = "Option";
            // 
            // Option_box
            // 
            this.Option_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Option_box.FormattingEnabled = true;
            this.Option_box.Location = new System.Drawing.Point(109, 97);
            this.Option_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Option_box.Name = "Option_box";
            this.Option_box.Size = new System.Drawing.Size(121, 24);
            this.Option_box.TabIndex = 22;
            this.Option_box.SelectedIndexChanged += new System.EventHandler(this.Option_box_SelectedIndexChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(247, 40);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(539, 331);
            this.dataGridView.TabIndex = 23;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(157, 391);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 34);
            this.button2.TabIndex = 24;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Type_ID
            // 
            this.Type_ID.AutoSize = true;
            this.Type_ID.Location = new System.Drawing.Point(623, 65);
            this.Type_ID.Name = "Type_ID";
            this.Type_ID.Size = new System.Drawing.Size(20, 16);
            this.Type_ID.TabIndex = 25;
            this.Type_ID.Text = "ID";
            // 
            // D_amount
            // 
            this.D_amount.AutoSize = true;
            this.D_amount.Location = new System.Drawing.Point(601, 97);
            this.D_amount.Name = "D_amount";
            this.D_amount.Size = new System.Drawing.Size(52, 16);
            this.D_amount.TabIndex = 27;
            this.D_amount.Text = "Amount";
            // 
            // amount_box
            // 
            this.amount_box.Location = new System.Drawing.Point(653, 94);
            this.amount_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.amount_box.Name = "amount_box";
            this.amount_box.Size = new System.Drawing.Size(121, 22);
            this.amount_box.TabIndex = 28;
            // 
            // details_box
            // 
            this.details_box.Location = new System.Drawing.Point(653, 158);
            this.details_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.details_box.Name = "details_box";
            this.details_box.Size = new System.Drawing.Size(121, 22);
            this.details_box.TabIndex = 32;
            // 
            // D_details
            // 
            this.D_details.AutoSize = true;
            this.D_details.Location = new System.Drawing.Point(604, 160);
            this.D_details.Name = "D_details";
            this.D_details.Size = new System.Drawing.Size(49, 16);
            this.D_details.TabIndex = 31;
            this.D_details.Text = "Details";
            // 
            // data_type
            // 
            this.data_type.AutoSize = true;
            this.data_type.Location = new System.Drawing.Point(609, 127);
            this.data_type.Name = "data_type";
            this.data_type.Size = new System.Drawing.Size(39, 16);
            this.data_type.TabIndex = 29;
            this.data_type.Text = "Type";
            // 
            // D_ID
            // 
            this.D_ID.AutoSize = true;
            this.D_ID.Location = new System.Drawing.Point(601, 226);
            this.D_ID.Name = "D_ID";
            this.D_ID.Size = new System.Drawing.Size(48, 16);
            this.D_ID.TabIndex = 35;
            this.D_ID.Text = "Don ID";
            // 
            // V_ID
            // 
            this.V_ID.AutoSize = true;
            this.V_ID.Location = new System.Drawing.Point(604, 197);
            this.V_ID.Name = "V_ID";
            this.V_ID.Size = new System.Drawing.Size(43, 16);
            this.V_ID.TabIndex = 33;
            this.V_ID.Text = "Vol ID";
            // 
            // D_button
            // 
            this.D_button.Location = new System.Drawing.Point(604, 377);
            this.D_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.D_button.Name = "D_button";
            this.D_button.Size = new System.Drawing.Size(81, 32);
            this.D_button.TabIndex = 37;
            this.D_button.Text = "Donate";
            this.D_button.UseVisualStyleBackColor = true;
            this.D_button.Click += new System.EventHandler(this.D_button_Click);
            // 
            // assi_button
            // 
            this.assi_button.Location = new System.Drawing.Point(653, 375);
            this.assi_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.assi_button.Name = "assi_button";
            this.assi_button.Size = new System.Drawing.Size(77, 34);
            this.assi_button.TabIndex = 38;
            this.assi_button.Text = "Assign";
            this.assi_button.UseVisualStyleBackColor = true;
            this.assi_button.Click += new System.EventHandler(this.assi_button_Click);
            // 
            // ben_button
            // 
            this.ben_button.Location = new System.Drawing.Point(697, 376);
            this.ben_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ben_button.Name = "ben_button";
            this.ben_button.Size = new System.Drawing.Size(77, 34);
            this.ben_button.TabIndex = 39;
            this.ben_button.Text = "Request";
            this.ben_button.UseVisualStyleBackColor = true;
            this.ben_button.Click += new System.EventHandler(this.ben_button_Click);
            // 
            // GetDonorDetailsButton
            // 
            this.GetDonorDetailsButton.Location = new System.Drawing.Point(29, 207);
            this.GetDonorDetailsButton.Margin = new System.Windows.Forms.Padding(4);
            this.GetDonorDetailsButton.Name = "GetDonorDetailsButton";
            this.GetDonorDetailsButton.Size = new System.Drawing.Size(191, 49);
            this.GetDonorDetailsButton.TabIndex = 42;
            this.GetDonorDetailsButton.Text = "Get Donor Details";
            this.GetDonorDetailsButton.UseVisualStyleBackColor = true;
            this.GetDonorDetailsButton.Click += new System.EventHandler(this.GetDonorDetailsButton_Click);
            // 
            // don_name_txt
            // 
            this.don_name_txt.Location = new System.Drawing.Point(409, 62);
            this.don_name_txt.Margin = new System.Windows.Forms.Padding(4);
            this.don_name_txt.Name = "don_name_txt";
            this.don_name_txt.Size = new System.Drawing.Size(175, 22);
            this.don_name_txt.TabIndex = 43;
            // 
            // don_name_lbl
            // 
            this.don_name_lbl.AutoSize = true;
            this.don_name_lbl.Location = new System.Drawing.Point(312, 65);
            this.don_name_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.don_name_lbl.Name = "don_name_lbl";
            this.don_name_lbl.Size = new System.Drawing.Size(84, 16);
            this.don_name_lbl.TabIndex = 44;
            this.don_name_lbl.Text = "Donor Name";
            // 
            // GetDonorsByPaymentMethodButton
            // 
            this.GetDonorsByPaymentMethodButton.Location = new System.Drawing.Point(29, 226);
            this.GetDonorsByPaymentMethodButton.Margin = new System.Windows.Forms.Padding(4);
            this.GetDonorsByPaymentMethodButton.Name = "GetDonorsByPaymentMethodButton";
            this.GetDonorsByPaymentMethodButton.Size = new System.Drawing.Size(193, 52);
            this.GetDonorsByPaymentMethodButton.TabIndex = 45;
            this.GetDonorsByPaymentMethodButton.Text = "Get Donors Payment Method";
            this.GetDonorsByPaymentMethodButton.UseVisualStyleBackColor = true;
            this.GetDonorsByPaymentMethodButton.Click += new System.EventHandler(this.GetDonorsByPaymentMethodButton_Click);
            // 
            // PaymentMethodlabel
            // 
            this.PaymentMethodlabel.AutoSize = true;
            this.PaymentMethodlabel.Location = new System.Drawing.Point(64, 175);
            this.PaymentMethodlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PaymentMethodlabel.Name = "PaymentMethodlabel";
            this.PaymentMethodlabel.Size = new System.Drawing.Size(108, 16);
            this.PaymentMethodlabel.TabIndex = 47;
            this.PaymentMethodlabel.Text = "Payment Method";
            // 
            // ID_label
            // 
            this.ID_label.AutoSize = true;
            this.ID_label.Location = new System.Drawing.Point(67, 140);
            this.ID_label.Name = "ID_label";
            this.ID_label.Size = new System.Drawing.Size(20, 16);
            this.ID_label.TabIndex = 48;
            this.ID_label.Text = "ID";
            // 
            // Search_button
            // 
            this.Search_button.Location = new System.Drawing.Point(431, 377);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(85, 32);
            this.Search_button.TabIndex = 49;
            this.Search_button.Text = "Search";
            this.Search_button.UseVisualStyleBackColor = true;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // ID_combo
            // 
            this.ID_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ID_combo.FormattingEnabled = true;
            this.ID_combo.Location = new System.Drawing.Point(109, 137);
            this.ID_combo.Name = "ID_combo";
            this.ID_combo.Size = new System.Drawing.Size(121, 24);
            this.ID_combo.TabIndex = 50;
            this.ID_combo.SelectedIndexChanged += new System.EventHandler(this.ID_combo_SelectedIndexChanged);
            // 
            // Back_button
            // 
            this.Back_button.Location = new System.Drawing.Point(13, 9);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(57, 27);
            this.Back_button.TabIndex = 51;
            this.Back_button.Text = "Back";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // ID_box
            // 
            this.ID_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ID_box.FormattingEnabled = true;
            this.ID_box.Location = new System.Drawing.Point(653, 60);
            this.ID_box.Name = "ID_box";
            this.ID_box.Size = new System.Drawing.Size(121, 24);
            this.ID_box.TabIndex = 52;
            // 
            // Vol_ID_box
            // 
            this.Vol_ID_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Vol_ID_box.FormattingEnabled = true;
            this.Vol_ID_box.Location = new System.Drawing.Point(653, 191);
            this.Vol_ID_box.Name = "Vol_ID_box";
            this.Vol_ID_box.Size = new System.Drawing.Size(121, 24);
            this.Vol_ID_box.TabIndex = 53;
            // 
            // Don_ID_box
            // 
            this.Don_ID_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Don_ID_box.FormattingEnabled = true;
            this.Don_ID_box.Location = new System.Drawing.Point(653, 224);
            this.Don_ID_box.Name = "Don_ID_box";
            this.Don_ID_box.Size = new System.Drawing.Size(121, 24);
            this.Don_ID_box.TabIndex = 54;
            // 
            // S_label
            // 
            this.S_label.AutoSize = true;
            this.S_label.Location = new System.Drawing.Point(603, 256);
            this.S_label.Name = "S_label";
            this.S_label.Size = new System.Drawing.Size(44, 16);
            this.S_label.TabIndex = 55;
            this.S_label.Text = "Status";
            // 
            // D_label
            // 
            this.D_label.AutoSize = true;
            this.D_label.Location = new System.Drawing.Point(607, 286);
            this.D_label.Name = "D_label";
            this.D_label.Size = new System.Drawing.Size(36, 16);
            this.D_label.TabIndex = 56;
            this.D_label.Text = "Date";
            // 
            // D_box
            // 
            this.D_box.Location = new System.Drawing.Point(653, 283);
            this.D_box.Name = "D_box";
            this.D_box.Size = new System.Drawing.Size(121, 22);
            this.D_box.TabIndex = 57;
            // 
            // Payment_text
            // 
            this.Payment_text.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Payment_text.FormattingEnabled = true;
            this.Payment_text.Items.AddRange(new object[] {
            "Cash",
            "Visa",
            "Credit"});
            this.Payment_text.Location = new System.Drawing.Point(409, 159);
            this.Payment_text.Name = "Payment_text";
            this.Payment_text.Size = new System.Drawing.Size(175, 24);
            this.Payment_text.TabIndex = 59;
            // 
            // PaymentMethodTextBox
            // 
            this.PaymentMethodTextBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PaymentMethodTextBox.FormattingEnabled = true;
            this.PaymentMethodTextBox.Items.AddRange(new object[] {
            "Cash",
            "Visa",
            "Credit"});
            this.PaymentMethodTextBox.Location = new System.Drawing.Point(51, 195);
            this.PaymentMethodTextBox.Name = "PaymentMethodTextBox";
            this.PaymentMethodTextBox.Size = new System.Drawing.Size(135, 24);
            this.PaymentMethodTextBox.TabIndex = 60;
            // 
            // type_box
            // 
            this.type_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type_box.FormattingEnabled = true;
            this.type_box.Items.AddRange(new object[] {
            "Money",
            "Food",
            "Clothes"});
            this.type_box.Location = new System.Drawing.Point(653, 127);
            this.type_box.Name = "type_box";
            this.type_box.Size = new System.Drawing.Size(121, 24);
            this.type_box.TabIndex = 61;
            // 
            // S_box
            // 
            this.S_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.S_box.FormattingEnabled = true;
            this.S_box.Items.AddRange(new object[] {
            "Pending",
            "Assigned",
            "Collected",
            "Delivered"});
            this.S_box.Location = new System.Drawing.Point(653, 253);
            this.S_box.Name = "S_box";
            this.S_box.Size = new System.Drawing.Size(121, 24);
            this.S_box.TabIndex = 62;
            // 
            // Status_text
            // 
            this.Status_text.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Status_text.FormattingEnabled = true;
            this.Status_text.Items.AddRange(new object[] {
            "Pending",
            "Assigned",
            "Collected",
            "Delivered"});
            this.Status_text.Location = new System.Drawing.Point(409, 286);
            this.Status_text.Name = "Status_text";
            this.Status_text.Size = new System.Drawing.Size(174, 24);
            this.Status_text.TabIndex = 63;
            // 
            // Available_text
            // 
            this.Available_text.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Available_text.FormattingEnabled = true;
            this.Available_text.Items.AddRange(new object[] {
            "Available Anytime",
            "Not Available Currently",
            "On Call"});
            this.Available_text.Location = new System.Drawing.Point(409, 223);
            this.Available_text.Name = "Available_text";
            this.Available_text.Size = new System.Drawing.Size(175, 24);
            this.Available_text.TabIndex = 64;
            // 
            // Skills_text
            // 
            this.Skills_text.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Skills_text.FormattingEnabled = true;
            this.Skills_text.Items.AddRange(new object[] {
            "Communication",
            "Teamwork",
            "Organization",
            "Leadership",
            "Problem-Solving"});
            this.Skills_text.Location = new System.Drawing.Point(409, 193);
            this.Skills_text.Name = "Skills_text";
            this.Skills_text.Size = new System.Drawing.Size(174, 24);
            this.Skills_text.TabIndex = 65;
            // 
            // Del_button
            // 
            this.Del_button.Location = new System.Drawing.Point(316, 377);
            this.Del_button.Name = "Del_button";
            this.Del_button.Size = new System.Drawing.Size(87, 33);
            this.Del_button.TabIndex = 66;
            this.Del_button.Text = "Delete";
            this.Del_button.UseVisualStyleBackColor = true;
            this.Del_button.Click += new System.EventHandler(this.Del_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Del_button);
            this.Controls.Add(this.Skills_text);
            this.Controls.Add(this.Available_text);
            this.Controls.Add(this.Status_text);
            this.Controls.Add(this.S_box);
            this.Controls.Add(this.type_box);
            this.Controls.Add(this.PaymentMethodTextBox);
            this.Controls.Add(this.Payment_text);
            this.Controls.Add(this.D_box);
            this.Controls.Add(this.D_label);
            this.Controls.Add(this.S_label);
            this.Controls.Add(this.Don_ID_box);
            this.Controls.Add(this.Vol_ID_box);
            this.Controls.Add(this.ID_box);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.ID_combo);
            this.Controls.Add(this.Search_button);
            this.Controls.Add(this.ID_label);
            this.Controls.Add(this.PaymentMethodlabel);
            this.Controls.Add(this.GetDonorsByPaymentMethodButton);
            this.Controls.Add(this.don_name_lbl);
            this.Controls.Add(this.don_name_txt);
            this.Controls.Add(this.GetDonorDetailsButton);
            this.Controls.Add(this.ben_button);
            this.Controls.Add(this.assi_button);
            this.Controls.Add(this.D_button);
            this.Controls.Add(this.D_ID);
            this.Controls.Add(this.V_ID);
            this.Controls.Add(this.details_box);
            this.Controls.Add(this.D_details);
            this.Controls.Add(this.data_type);
            this.Controls.Add(this.amount_box);
            this.Controls.Add(this.D_amount);
            this.Controls.Add(this.Type_ID);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.Option_box);
            this.Controls.Add(this.Option_label);
            this.Controls.Add(this.Date_text);
            this.Controls.Add(this.Date_label);
            this.Controls.Add(this.Status_label);
            this.Controls.Add(this.Address_text);
            this.Controls.Add(this.Address_label);
            this.Controls.Add(this.Available_label);
            this.Controls.Add(this.Skills_label);
            this.Controls.Add(this.Payment_label);
            this.Controls.Add(this.Phone_text);
            this.Controls.Add(this.Phone_label);
            this.Controls.Add(this.Email_text);
            this.Controls.Add(this.Email_label);
            this.Controls.Add(this.Name_text);
            this.Controls.Add(this.Name_label);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Categories);
            this.Controls.Add(this.Category_label);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Category_label;
        private System.Windows.Forms.ComboBox Categories;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Name_label;
        private System.Windows.Forms.TextBox Name_text;
        private System.Windows.Forms.Label Email_label;
        private System.Windows.Forms.TextBox Email_text;
        private System.Windows.Forms.Label Phone_label;
        private System.Windows.Forms.TextBox Phone_text;
        private System.Windows.Forms.Label Payment_label;
        private System.Windows.Forms.Label Status_label;
        private System.Windows.Forms.TextBox Address_text;
        private System.Windows.Forms.Label Address_label;
        private System.Windows.Forms.Label Available_label;
        private System.Windows.Forms.Label Skills_label;
        private System.Windows.Forms.TextBox Date_text;
        private System.Windows.Forms.Label Date_label;
        private System.Windows.Forms.Label Option_label;
        private System.Windows.Forms.ComboBox Option_box;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Type_ID;
        private System.Windows.Forms.Label D_amount;
        private System.Windows.Forms.TextBox amount_box;
        private System.Windows.Forms.TextBox details_box;
        private System.Windows.Forms.Label D_details;
        private System.Windows.Forms.Label data_type;
        private System.Windows.Forms.Label D_ID;
        private System.Windows.Forms.Label V_ID;
        private System.Windows.Forms.Button D_button;
        private System.Windows.Forms.Button assi_button;
        private System.Windows.Forms.Button ben_button;
		private System.Windows.Forms.Button GetDonorDetailsButton;
		private System.Windows.Forms.TextBox don_name_txt;
		private System.Windows.Forms.Label don_name_lbl;
		private System.Windows.Forms.Button GetDonorsByPaymentMethodButton;
		private System.Windows.Forms.Label PaymentMethodlabel;
        private System.Windows.Forms.Label ID_label;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.ComboBox ID_combo;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.ComboBox ID_box;
        private System.Windows.Forms.ComboBox Vol_ID_box;
        private System.Windows.Forms.ComboBox Don_ID_box;
        private System.Windows.Forms.Label S_label;
        private System.Windows.Forms.Label D_label;
        private System.Windows.Forms.TextBox D_box;
        private System.Windows.Forms.ComboBox Payment_text;
        private System.Windows.Forms.ComboBox PaymentMethodTextBox;
        private System.Windows.Forms.ComboBox type_box;
        private System.Windows.Forms.ComboBox S_box;
        private System.Windows.Forms.ComboBox Status_text;
        private System.Windows.Forms.ComboBox Available_text;
        private System.Windows.Forms.ComboBox Skills_text;
        private System.Windows.Forms.Button Del_button;
    }
}

