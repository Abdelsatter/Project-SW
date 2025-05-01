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
            this.Payment_text = new System.Windows.Forms.TextBox();
            this.Status_text = new System.Windows.Forms.TextBox();
            this.Status_label = new System.Windows.Forms.Label();
            this.Address_text = new System.Windows.Forms.TextBox();
            this.Address_label = new System.Windows.Forms.Label();
            this.Available_text = new System.Windows.Forms.TextBox();
            this.Available_label = new System.Windows.Forms.Label();
            this.Skills_text = new System.Windows.Forms.TextBox();
            this.Skills_label = new System.Windows.Forms.Label();
            this.Date_text = new System.Windows.Forms.TextBox();
            this.Date_label = new System.Windows.Forms.Label();
            this.Option_label = new System.Windows.Forms.Label();
            this.Option_box = new System.Windows.Forms.ComboBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.Type_ID = new System.Windows.Forms.Label();
            this.ID_box = new System.Windows.Forms.TextBox();
            this.D_amount = new System.Windows.Forms.Label();
            this.amount_box = new System.Windows.Forms.TextBox();
            this.details_box = new System.Windows.Forms.TextBox();
            this.D_details = new System.Windows.Forms.Label();
            this.type_box = new System.Windows.Forms.TextBox();
            this.data_type = new System.Windows.Forms.Label();
            this.Don_ID_box = new System.Windows.Forms.TextBox();
            this.D_ID = new System.Windows.Forms.Label();
            this.Vol_ID_box = new System.Windows.Forms.TextBox();
            this.V_ID = new System.Windows.Forms.Label();
            this.D_button = new System.Windows.Forms.Button();
            this.assi_button = new System.Windows.Forms.Button();
            this.ben_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Category_label
            // 
            this.Category_label.AutoSize = true;
            this.Category_label.Location = new System.Drawing.Point(31, 39);
            this.Category_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Category_label.Name = "Category_label";
            this.Category_label.Size = new System.Drawing.Size(49, 13);
            this.Category_label.TabIndex = 0;
            this.Category_label.Text = "Category";
            // 
            // Categories
            // 
            this.Categories.FormattingEnabled = true;
            this.Categories.Items.AddRange(new object[] {
            "Donor",
            "Volunteer",
            "Beneficiary",
            "Admin"});
            this.Categories.Location = new System.Drawing.Point(82, 37);
            this.Categories.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Categories.Name = "Categories";
            this.Categories.Size = new System.Drawing.Size(92, 21);
            this.Categories.TabIndex = 1;
            this.Categories.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(237, 306);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Name_label
            // 
            this.Name_label.AutoSize = true;
            this.Name_label.Location = new System.Drawing.Point(260, 14);
            this.Name_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(35, 13);
            this.Name_label.TabIndex = 3;
            this.Name_label.Text = "Name";
            // 
            // Name_text
            // 
            this.Name_text.Location = new System.Drawing.Point(307, 11);
            this.Name_text.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name_text.Name = "Name_text";
            this.Name_text.Size = new System.Drawing.Size(132, 20);
            this.Name_text.TabIndex = 4;
            // 
            // Email_label
            // 
            this.Email_label.AutoSize = true;
            this.Email_label.Location = new System.Drawing.Point(260, 77);
            this.Email_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Email_label.Name = "Email_label";
            this.Email_label.Size = new System.Drawing.Size(32, 13);
            this.Email_label.TabIndex = 5;
            this.Email_label.Text = "Email";
            // 
            // Email_text
            // 
            this.Email_text.Location = new System.Drawing.Point(307, 75);
            this.Email_text.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Email_text.Name = "Email_text";
            this.Email_text.Size = new System.Drawing.Size(132, 20);
            this.Email_text.TabIndex = 6;
            // 
            // Phone_label
            // 
            this.Phone_label.AutoSize = true;
            this.Phone_label.Location = new System.Drawing.Point(252, 103);
            this.Phone_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Phone_label.Name = "Phone_label";
            this.Phone_label.Size = new System.Drawing.Size(55, 13);
            this.Phone_label.TabIndex = 7;
            this.Phone_label.Text = "Phone No";
            // 
            // Phone_text
            // 
            this.Phone_text.Location = new System.Drawing.Point(307, 101);
            this.Phone_text.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Phone_text.Name = "Phone_text";
            this.Phone_text.Size = new System.Drawing.Size(132, 20);
            this.Phone_text.TabIndex = 8;
            // 
            // Payment_label
            // 
            this.Payment_label.AutoSize = true;
            this.Payment_label.Location = new System.Drawing.Point(221, 132);
            this.Payment_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Payment_label.Name = "Payment_label";
            this.Payment_label.Size = new System.Drawing.Size(87, 13);
            this.Payment_label.TabIndex = 9;
            this.Payment_label.Text = "Payment Method";
            // 
            // Payment_text
            // 
            this.Payment_text.Location = new System.Drawing.Point(307, 128);
            this.Payment_text.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Payment_text.Name = "Payment_text";
            this.Payment_text.Size = new System.Drawing.Size(132, 20);
            this.Payment_text.TabIndex = 10;
            // 
            // Status_text
            // 
            this.Status_text.Location = new System.Drawing.Point(307, 232);
            this.Status_text.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Status_text.Name = "Status_text";
            this.Status_text.Size = new System.Drawing.Size(132, 20);
            this.Status_text.TabIndex = 18;
            // 
            // Status_label
            // 
            this.Status_label.AutoSize = true;
            this.Status_label.Location = new System.Drawing.Point(269, 235);
            this.Status_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Status_label.Name = "Status_label";
            this.Status_label.Size = new System.Drawing.Size(37, 13);
            this.Status_label.TabIndex = 17;
            this.Status_label.Text = "Status";
            // 
            // Address_text
            // 
            this.Address_text.Location = new System.Drawing.Point(307, 206);
            this.Address_text.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Address_text.Name = "Address_text";
            this.Address_text.Size = new System.Drawing.Size(132, 20);
            this.Address_text.TabIndex = 16;
            // 
            // Address_label
            // 
            this.Address_label.AutoSize = true;
            this.Address_label.Location = new System.Drawing.Point(259, 208);
            this.Address_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Address_label.Name = "Address_label";
            this.Address_label.Size = new System.Drawing.Size(45, 13);
            this.Address_label.TabIndex = 15;
            this.Address_label.Text = "Address";
            // 
            // Available_text
            // 
            this.Available_text.Location = new System.Drawing.Point(307, 180);
            this.Available_text.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Available_text.Name = "Available_text";
            this.Available_text.Size = new System.Drawing.Size(132, 20);
            this.Available_text.TabIndex = 14;
            // 
            // Available_label
            // 
            this.Available_label.AutoSize = true;
            this.Available_label.Location = new System.Drawing.Point(248, 182);
            this.Available_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Available_label.Name = "Available_label";
            this.Available_label.Size = new System.Drawing.Size(56, 13);
            this.Available_label.TabIndex = 13;
            this.Available_label.Text = "Availability";
            // 
            // Skills_text
            // 
            this.Skills_text.Location = new System.Drawing.Point(307, 155);
            this.Skills_text.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Skills_text.Name = "Skills_text";
            this.Skills_text.Size = new System.Drawing.Size(132, 20);
            this.Skills_text.TabIndex = 12;
            // 
            // Skills_label
            // 
            this.Skills_label.AutoSize = true;
            this.Skills_label.Location = new System.Drawing.Point(260, 158);
            this.Skills_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Skills_label.Name = "Skills_label";
            this.Skills_label.Size = new System.Drawing.Size(31, 13);
            this.Skills_label.TabIndex = 11;
            this.Skills_label.Text = "Skills";
            // 
            // Date_text
            // 
            this.Date_text.Location = new System.Drawing.Point(307, 260);
            this.Date_text.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Date_text.Name = "Date_text";
            this.Date_text.Size = new System.Drawing.Size(132, 20);
            this.Date_text.TabIndex = 20;
            // 
            // Date_label
            // 
            this.Date_label.AutoSize = true;
            this.Date_label.Location = new System.Drawing.Point(219, 262);
            this.Date_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Date_label.Name = "Date_label";
            this.Date_label.Size = new System.Drawing.Size(89, 13);
            this.Date_label.TabIndex = 19;
            this.Date_label.Text = "Registration Date";
            // 
            // Option_label
            // 
            this.Option_label.AutoSize = true;
            this.Option_label.Location = new System.Drawing.Point(31, 81);
            this.Option_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Option_label.Name = "Option_label";
            this.Option_label.Size = new System.Drawing.Size(38, 13);
            this.Option_label.TabIndex = 21;
            this.Option_label.Text = "Option";
            // 
            // Option_box
            // 
            this.Option_box.FormattingEnabled = true;
            this.Option_box.Items.AddRange(new object[] {
            "Edit,Del",
            "Insert"});
            this.Option_box.Location = new System.Drawing.Point(82, 79);
            this.Option_box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Option_box.Name = "Option_box";
            this.Option_box.Size = new System.Drawing.Size(92, 21);
            this.Option_box.TabIndex = 22;
            this.Option_box.SelectedIndexChanged += new System.EventHandler(this.Option_box_SelectedIndexChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(185, 39);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(404, 312);
            this.dataGridView.TabIndex = 23;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(118, 318);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 28);
            this.button2.TabIndex = 24;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Type_ID
            // 
            this.Type_ID.AutoSize = true;
            this.Type_ID.Location = new System.Drawing.Point(467, 53);
            this.Type_ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Type_ID.Name = "Type_ID";
            this.Type_ID.Size = new System.Drawing.Size(18, 13);
            this.Type_ID.TabIndex = 25;
            this.Type_ID.Text = "ID";
            // 
            // ID_box
            // 
            this.ID_box.Location = new System.Drawing.Point(490, 50);
            this.ID_box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ID_box.Name = "ID_box";
            this.ID_box.Size = new System.Drawing.Size(76, 20);
            this.ID_box.TabIndex = 26;
            // 
            // D_amount
            // 
            this.D_amount.AutoSize = true;
            this.D_amount.Location = new System.Drawing.Point(451, 79);
            this.D_amount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.D_amount.Name = "D_amount";
            this.D_amount.Size = new System.Drawing.Size(43, 13);
            this.D_amount.TabIndex = 27;
            this.D_amount.Text = "Amount";
            // 
            // amount_box
            // 
            this.amount_box.Location = new System.Drawing.Point(490, 76);
            this.amount_box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.amount_box.Name = "amount_box";
            this.amount_box.Size = new System.Drawing.Size(76, 20);
            this.amount_box.TabIndex = 28;
            // 
            // details_box
            // 
            this.details_box.Location = new System.Drawing.Point(490, 128);
            this.details_box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.details_box.Name = "details_box";
            this.details_box.Size = new System.Drawing.Size(76, 20);
            this.details_box.TabIndex = 32;
            // 
            // D_details
            // 
            this.D_details.AutoSize = true;
            this.D_details.Location = new System.Drawing.Point(453, 130);
            this.D_details.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.D_details.Name = "D_details";
            this.D_details.Size = new System.Drawing.Size(39, 13);
            this.D_details.TabIndex = 31;
            this.D_details.Text = "Details";
            // 
            // type_box
            // 
            this.type_box.Location = new System.Drawing.Point(490, 101);
            this.type_box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.type_box.Name = "type_box";
            this.type_box.Size = new System.Drawing.Size(76, 20);
            this.type_box.TabIndex = 30;
            // 
            // data_type
            // 
            this.data_type.AutoSize = true;
            this.data_type.Location = new System.Drawing.Point(457, 103);
            this.data_type.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.data_type.Name = "data_type";
            this.data_type.Size = new System.Drawing.Size(31, 13);
            this.data_type.TabIndex = 29;
            this.data_type.Text = "Type";
            // 
            // Don_ID_box
            // 
            this.Don_ID_box.Location = new System.Drawing.Point(490, 184);
            this.Don_ID_box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Don_ID_box.Name = "Don_ID_box";
            this.Don_ID_box.Size = new System.Drawing.Size(76, 20);
            this.Don_ID_box.TabIndex = 36;
            // 
            // D_ID
            // 
            this.D_ID.AutoSize = true;
            this.D_ID.Location = new System.Drawing.Point(451, 184);
            this.D_ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.D_ID.Name = "D_ID";
            this.D_ID.Size = new System.Drawing.Size(41, 13);
            this.D_ID.TabIndex = 35;
            this.D_ID.Text = "Don ID";
            // 
            // Vol_ID_box
            // 
            this.Vol_ID_box.Location = new System.Drawing.Point(490, 158);
            this.Vol_ID_box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Vol_ID_box.Name = "Vol_ID_box";
            this.Vol_ID_box.Size = new System.Drawing.Size(76, 20);
            this.Vol_ID_box.TabIndex = 34;
            // 
            // V_ID
            // 
            this.V_ID.AutoSize = true;
            this.V_ID.Location = new System.Drawing.Point(453, 160);
            this.V_ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.V_ID.Name = "V_ID";
            this.V_ID.Size = new System.Drawing.Size(36, 13);
            this.V_ID.TabIndex = 33;
            this.V_ID.Text = "Vol ID";
            // 
            // D_button
            // 
            this.D_button.Location = new System.Drawing.Point(453, 306);
            this.D_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.D_button.Name = "D_button";
            this.D_button.Size = new System.Drawing.Size(61, 26);
            this.D_button.TabIndex = 37;
            this.D_button.Text = "Donate";
            this.D_button.UseVisualStyleBackColor = true;
            this.D_button.Click += new System.EventHandler(this.D_button_Click);
            // 
            // assi_button
            // 
            this.assi_button.Location = new System.Drawing.Point(453, 267);
            this.assi_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.assi_button.Name = "assi_button";
            this.assi_button.Size = new System.Drawing.Size(58, 28);
            this.assi_button.TabIndex = 38;
            this.assi_button.Text = "Assign";
            this.assi_button.UseVisualStyleBackColor = true;
            this.assi_button.Click += new System.EventHandler(this.assi_button_Click);
            // 
            // ben_button
            // 
            this.ben_button.Location = new System.Drawing.Point(453, 235);
            this.ben_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ben_button.Name = "ben_button";
            this.ben_button.Size = new System.Drawing.Size(58, 28);
            this.ben_button.TabIndex = 39;
            this.ben_button.Text = "Request";
            this.ben_button.UseVisualStyleBackColor = true;
            this.ben_button.Click += new System.EventHandler(this.ben_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.ben_button);
            this.Controls.Add(this.assi_button);
            this.Controls.Add(this.D_button);
            this.Controls.Add(this.Don_ID_box);
            this.Controls.Add(this.D_ID);
            this.Controls.Add(this.Vol_ID_box);
            this.Controls.Add(this.V_ID);
            this.Controls.Add(this.details_box);
            this.Controls.Add(this.D_details);
            this.Controls.Add(this.type_box);
            this.Controls.Add(this.data_type);
            this.Controls.Add(this.amount_box);
            this.Controls.Add(this.D_amount);
            this.Controls.Add(this.ID_box);
            this.Controls.Add(this.Type_ID);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.Option_box);
            this.Controls.Add(this.Option_label);
            this.Controls.Add(this.Date_text);
            this.Controls.Add(this.Date_label);
            this.Controls.Add(this.Status_text);
            this.Controls.Add(this.Status_label);
            this.Controls.Add(this.Address_text);
            this.Controls.Add(this.Address_label);
            this.Controls.Add(this.Available_text);
            this.Controls.Add(this.Available_label);
            this.Controls.Add(this.Skills_text);
            this.Controls.Add(this.Skills_label);
            this.Controls.Add(this.Payment_text);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.TextBox Payment_text;
        private System.Windows.Forms.TextBox Status_text;
        private System.Windows.Forms.Label Status_label;
        private System.Windows.Forms.TextBox Address_text;
        private System.Windows.Forms.Label Address_label;
        private System.Windows.Forms.TextBox Available_text;
        private System.Windows.Forms.Label Available_label;
        private System.Windows.Forms.TextBox Skills_text;
        private System.Windows.Forms.Label Skills_label;
        private System.Windows.Forms.TextBox Date_text;
        private System.Windows.Forms.Label Date_label;
        private System.Windows.Forms.Label Option_label;
        private System.Windows.Forms.ComboBox Option_box;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Type_ID;
        private System.Windows.Forms.TextBox ID_box;
        private System.Windows.Forms.Label D_amount;
        private System.Windows.Forms.TextBox amount_box;
        private System.Windows.Forms.TextBox details_box;
        private System.Windows.Forms.Label D_details;
        private System.Windows.Forms.TextBox type_box;
        private System.Windows.Forms.Label data_type;
        private System.Windows.Forms.TextBox Don_ID_box;
        private System.Windows.Forms.Label D_ID;
        private System.Windows.Forms.TextBox Vol_ID_box;
        private System.Windows.Forms.Label V_ID;
        private System.Windows.Forms.Button D_button;
        private System.Windows.Forms.Button assi_button;
        private System.Windows.Forms.Button ben_button;
    }
}

