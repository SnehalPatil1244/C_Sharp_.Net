
namespace Royal_Gym_App.Windows_Form.Staff
{
    partial class Frm_Staff_Details
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
            this.Pnl_Header = new System.Windows.Forms.Panel();
            this.lbl_Staff_Details = new System.Windows.Forms.Label();
            this.grpb_Personal_Details = new System.Windows.Forms.GroupBox();
            this.cmb_Designation = new System.Windows.Forms.ComboBox();
            this.dtp_Joining_Date = new System.Windows.Forms.DateTimePicker();
            this.tb_Staff_Name = new System.Windows.Forms.TextBox();
            this.tb_Staff_Id = new System.Windows.Forms.TextBox();
            this.lbl_Designation = new System.Windows.Forms.Label();
            this.lbl_Joining_Date = new System.Windows.Forms.Label();
            this.lbl_Staff_Name = new System.Windows.Forms.Label();
            this.lbl_Staff_Id = new System.Windows.Forms.Label();
            this.grpb_More_Details = new System.Windows.Forms.GroupBox();
            this.tb_Experience = new System.Windows.Forms.TextBox();
            this.lbl_Experience = new System.Windows.Forms.Label();
            this.tb_Note = new System.Windows.Forms.TextBox();
            this.tb_Email_Id = new System.Windows.Forms.TextBox();
            this.tb_Adhar_No = new System.Windows.Forms.TextBox();
            this.tb_Salary = new System.Windows.Forms.TextBox();
            this.tb_Certifications = new System.Windows.Forms.TextBox();
            this.tb_Mobile_No = new System.Windows.Forms.TextBox();
            this.lbl_Note = new System.Windows.Forms.Label();
            this.lbl_Email_Id = new System.Windows.Forms.Label();
            this.lbl_Adhar_No = new System.Windows.Forms.Label();
            this.lbl_Salary = new System.Windows.Forms.Label();
            this.lbl_Certifications = new System.Windows.Forms.Label();
            this.lbl_Mobile_No = new System.Windows.Forms.Label();
            this.grpb_Bank_Details = new System.Windows.Forms.GroupBox();
            this.tb_Account_No = new System.Windows.Forms.TextBox();
            this.tb_Bank_Details = new System.Windows.Forms.TextBox();
            this.lbl_Account_No = new System.Windows.Forms.Label();
            this.lbl_Bank_Details = new System.Windows.Forms.Label();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.Pnl_Header.SuspendLayout();
            this.grpb_Personal_Details.SuspendLayout();
            this.grpb_More_Details.SuspendLayout();
            this.grpb_Bank_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_Header
            // 
            this.Pnl_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Pnl_Header.Controls.Add(this.lbl_Staff_Details);
            this.Pnl_Header.Location = new System.Drawing.Point(12, 12);
            this.Pnl_Header.Name = "Pnl_Header";
            this.Pnl_Header.Size = new System.Drawing.Size(1242, 100);
            this.Pnl_Header.TabIndex = 33;
            // 
            // lbl_Staff_Details
            // 
            this.lbl_Staff_Details.AutoSize = true;
            this.lbl_Staff_Details.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbl_Staff_Details.Font = new System.Drawing.Font("Copperplate Gothic Bold", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Staff_Details.Location = new System.Drawing.Point(269, 14);
            this.lbl_Staff_Details.Name = "lbl_Staff_Details";
            this.lbl_Staff_Details.Size = new System.Drawing.Size(739, 75);
            this.lbl_Staff_Details.TabIndex = 0;
            this.lbl_Staff_Details.Text = "Add Staff Details ";
            // 
            // grpb_Personal_Details
            // 
            this.grpb_Personal_Details.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grpb_Personal_Details.Controls.Add(this.cmb_Designation);
            this.grpb_Personal_Details.Controls.Add(this.dtp_Joining_Date);
            this.grpb_Personal_Details.Controls.Add(this.tb_Staff_Name);
            this.grpb_Personal_Details.Controls.Add(this.tb_Staff_Id);
            this.grpb_Personal_Details.Controls.Add(this.lbl_Designation);
            this.grpb_Personal_Details.Controls.Add(this.lbl_Joining_Date);
            this.grpb_Personal_Details.Controls.Add(this.lbl_Staff_Name);
            this.grpb_Personal_Details.Controls.Add(this.lbl_Staff_Id);
            this.grpb_Personal_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpb_Personal_Details.ForeColor = System.Drawing.Color.Red;
            this.grpb_Personal_Details.Location = new System.Drawing.Point(12, 151);
            this.grpb_Personal_Details.Name = "grpb_Personal_Details";
            this.grpb_Personal_Details.Size = new System.Drawing.Size(1251, 165);
            this.grpb_Personal_Details.TabIndex = 34;
            this.grpb_Personal_Details.TabStop = false;
            this.grpb_Personal_Details.Text = "Personal Details";
            // 
            // cmb_Designation
            // 
            this.cmb_Designation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Designation.FormattingEnabled = true;
            this.cmb_Designation.Location = new System.Drawing.Point(926, 108);
            this.cmb_Designation.Name = "cmb_Designation";
            this.cmb_Designation.Size = new System.Drawing.Size(263, 37);
            this.cmb_Designation.TabIndex = 7;
            // 
            // dtp_Joining_Date
            // 
            this.dtp_Joining_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Joining_Date.Location = new System.Drawing.Point(926, 39);
            this.dtp_Joining_Date.Name = "dtp_Joining_Date";
            this.dtp_Joining_Date.Size = new System.Drawing.Size(263, 34);
            this.dtp_Joining_Date.TabIndex = 6;
            // 
            // tb_Staff_Name
            // 
            this.tb_Staff_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Staff_Name.Location = new System.Drawing.Point(265, 111);
            this.tb_Staff_Name.Name = "tb_Staff_Name";
            this.tb_Staff_Name.Size = new System.Drawing.Size(258, 34);
            this.tb_Staff_Name.TabIndex = 5;
            // 
            // tb_Staff_Id
            // 
            this.tb_Staff_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Staff_Id.Location = new System.Drawing.Point(265, 50);
            this.tb_Staff_Id.Name = "tb_Staff_Id";
            this.tb_Staff_Id.Size = new System.Drawing.Size(258, 34);
            this.tb_Staff_Id.TabIndex = 4;
            // 
            // lbl_Designation
            // 
            this.lbl_Designation.AutoSize = true;
            this.lbl_Designation.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Designation.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Designation.Location = new System.Drawing.Point(707, 107);
            this.lbl_Designation.Name = "lbl_Designation";
            this.lbl_Designation.Size = new System.Drawing.Size(155, 34);
            this.lbl_Designation.TabIndex = 3;
            this.lbl_Designation.Text = "Designation";
            // 
            // lbl_Joining_Date
            // 
            this.lbl_Joining_Date.AutoSize = true;
            this.lbl_Joining_Date.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Joining_Date.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Joining_Date.Location = new System.Drawing.Point(707, 39);
            this.lbl_Joining_Date.Name = "lbl_Joining_Date";
            this.lbl_Joining_Date.Size = new System.Drawing.Size(164, 34);
            this.lbl_Joining_Date.TabIndex = 2;
            this.lbl_Joining_Date.Text = "Joining Date";
            // 
            // lbl_Staff_Name
            // 
            this.lbl_Staff_Name.AutoSize = true;
            this.lbl_Staff_Name.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Staff_Name.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Staff_Name.Location = new System.Drawing.Point(60, 111);
            this.lbl_Staff_Name.Name = "lbl_Staff_Name";
            this.lbl_Staff_Name.Size = new System.Drawing.Size(151, 34);
            this.lbl_Staff_Name.TabIndex = 1;
            this.lbl_Staff_Name.Text = "Staff Name";
            // 
            // lbl_Staff_Id
            // 
            this.lbl_Staff_Id.AutoSize = true;
            this.lbl_Staff_Id.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Staff_Id.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Staff_Id.Location = new System.Drawing.Point(60, 49);
            this.lbl_Staff_Id.Name = "lbl_Staff_Id";
            this.lbl_Staff_Id.Size = new System.Drawing.Size(104, 34);
            this.lbl_Staff_Id.TabIndex = 0;
            this.lbl_Staff_Id.Text = "Staff Id";
            // 
            // grpb_More_Details
            // 
            this.grpb_More_Details.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grpb_More_Details.Controls.Add(this.tb_Experience);
            this.grpb_More_Details.Controls.Add(this.lbl_Experience);
            this.grpb_More_Details.Controls.Add(this.tb_Note);
            this.grpb_More_Details.Controls.Add(this.tb_Email_Id);
            this.grpb_More_Details.Controls.Add(this.tb_Adhar_No);
            this.grpb_More_Details.Controls.Add(this.tb_Salary);
            this.grpb_More_Details.Controls.Add(this.tb_Certifications);
            this.grpb_More_Details.Controls.Add(this.tb_Mobile_No);
            this.grpb_More_Details.Controls.Add(this.lbl_Note);
            this.grpb_More_Details.Controls.Add(this.lbl_Email_Id);
            this.grpb_More_Details.Controls.Add(this.lbl_Adhar_No);
            this.grpb_More_Details.Controls.Add(this.lbl_Salary);
            this.grpb_More_Details.Controls.Add(this.lbl_Certifications);
            this.grpb_More_Details.Controls.Add(this.lbl_Mobile_No);
            this.grpb_More_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpb_More_Details.ForeColor = System.Drawing.Color.Red;
            this.grpb_More_Details.Location = new System.Drawing.Point(12, 322);
            this.grpb_More_Details.Name = "grpb_More_Details";
            this.grpb_More_Details.Size = new System.Drawing.Size(1251, 274);
            this.grpb_More_Details.TabIndex = 35;
            this.grpb_More_Details.TabStop = false;
            this.grpb_More_Details.Text = "More Details";
            this.grpb_More_Details.Enter += new System.EventHandler(this.grpb_More_Details_Enter);
            // 
            // tb_Experience
            // 
            this.tb_Experience.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Experience.Location = new System.Drawing.Point(256, 232);
            this.tb_Experience.Name = "tb_Experience";
            this.tb_Experience.Size = new System.Drawing.Size(276, 34);
            this.tb_Experience.TabIndex = 14;
            // 
            // lbl_Experience
            // 
            this.lbl_Experience.AutoSize = true;
            this.lbl_Experience.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Experience.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Experience.Location = new System.Drawing.Point(60, 237);
            this.lbl_Experience.Name = "lbl_Experience";
            this.lbl_Experience.Size = new System.Drawing.Size(146, 34);
            this.lbl_Experience.TabIndex = 13;
            this.lbl_Experience.Text = "Experience";
            // 
            // tb_Note
            // 
            this.tb_Note.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Note.Location = new System.Drawing.Point(926, 173);
            this.tb_Note.Name = "tb_Note";
            this.tb_Note.Size = new System.Drawing.Size(263, 83);
            this.tb_Note.TabIndex = 11;
            // 
            // tb_Email_Id
            // 
            this.tb_Email_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Email_Id.Location = new System.Drawing.Point(926, 106);
            this.tb_Email_Id.Name = "tb_Email_Id";
            this.tb_Email_Id.Size = new System.Drawing.Size(263, 34);
            this.tb_Email_Id.TabIndex = 10;
            // 
            // tb_Adhar_No
            // 
            this.tb_Adhar_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Adhar_No.Location = new System.Drawing.Point(926, 39);
            this.tb_Adhar_No.Name = "tb_Adhar_No";
            this.tb_Adhar_No.Size = new System.Drawing.Size(263, 34);
            this.tb_Adhar_No.TabIndex = 9;
            // 
            // tb_Salary
            // 
            this.tb_Salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Salary.Location = new System.Drawing.Point(256, 173);
            this.tb_Salary.Name = "tb_Salary";
            this.tb_Salary.Size = new System.Drawing.Size(276, 34);
            this.tb_Salary.TabIndex = 8;
            // 
            // tb_Certifications
            // 
            this.tb_Certifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Certifications.Location = new System.Drawing.Point(256, 105);
            this.tb_Certifications.Name = "tb_Certifications";
            this.tb_Certifications.Size = new System.Drawing.Size(276, 34);
            this.tb_Certifications.TabIndex = 7;
            // 
            // tb_Mobile_No
            // 
            this.tb_Mobile_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mobile_No.Location = new System.Drawing.Point(256, 39);
            this.tb_Mobile_No.Name = "tb_Mobile_No";
            this.tb_Mobile_No.Size = new System.Drawing.Size(276, 34);
            this.tb_Mobile_No.TabIndex = 6;
            // 
            // lbl_Note
            // 
            this.lbl_Note.AutoSize = true;
            this.lbl_Note.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Note.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Note.Location = new System.Drawing.Point(707, 172);
            this.lbl_Note.Name = "lbl_Note";
            this.lbl_Note.Size = new System.Drawing.Size(73, 34);
            this.lbl_Note.TabIndex = 5;
            this.lbl_Note.Text = "Note";
            // 
            // lbl_Email_Id
            // 
            this.lbl_Email_Id.AutoSize = true;
            this.lbl_Email_Id.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email_Id.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Email_Id.Location = new System.Drawing.Point(707, 104);
            this.lbl_Email_Id.Name = "lbl_Email_Id";
            this.lbl_Email_Id.Size = new System.Drawing.Size(115, 34);
            this.lbl_Email_Id.TabIndex = 4;
            this.lbl_Email_Id.Text = "Email Id";
            // 
            // lbl_Adhar_No
            // 
            this.lbl_Adhar_No.AutoSize = true;
            this.lbl_Adhar_No.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Adhar_No.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Adhar_No.Location = new System.Drawing.Point(707, 38);
            this.lbl_Adhar_No.Name = "lbl_Adhar_No";
            this.lbl_Adhar_No.Size = new System.Drawing.Size(134, 34);
            this.lbl_Adhar_No.TabIndex = 3;
            this.lbl_Adhar_No.Text = "Adhar No";
            // 
            // lbl_Salary
            // 
            this.lbl_Salary.AutoSize = true;
            this.lbl_Salary.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Salary.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Salary.Location = new System.Drawing.Point(60, 173);
            this.lbl_Salary.Name = "lbl_Salary";
            this.lbl_Salary.Size = new System.Drawing.Size(89, 34);
            this.lbl_Salary.TabIndex = 2;
            this.lbl_Salary.Text = "Salary";
            // 
            // lbl_Certifications
            // 
            this.lbl_Certifications.AutoSize = true;
            this.lbl_Certifications.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Certifications.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Certifications.Location = new System.Drawing.Point(60, 105);
            this.lbl_Certifications.Name = "lbl_Certifications";
            this.lbl_Certifications.Size = new System.Drawing.Size(172, 34);
            this.lbl_Certifications.TabIndex = 1;
            this.lbl_Certifications.Text = "Certifications";
            // 
            // lbl_Mobile_No
            // 
            this.lbl_Mobile_No.AutoSize = true;
            this.lbl_Mobile_No.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile_No.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Mobile_No.Location = new System.Drawing.Point(60, 39);
            this.lbl_Mobile_No.Name = "lbl_Mobile_No";
            this.lbl_Mobile_No.Size = new System.Drawing.Size(144, 34);
            this.lbl_Mobile_No.TabIndex = 0;
            this.lbl_Mobile_No.Text = "Mobile No";
            // 
            // grpb_Bank_Details
            // 
            this.grpb_Bank_Details.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grpb_Bank_Details.Controls.Add(this.tb_Account_No);
            this.grpb_Bank_Details.Controls.Add(this.tb_Bank_Details);
            this.grpb_Bank_Details.Controls.Add(this.lbl_Account_No);
            this.grpb_Bank_Details.Controls.Add(this.lbl_Bank_Details);
            this.grpb_Bank_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpb_Bank_Details.ForeColor = System.Drawing.Color.Red;
            this.grpb_Bank_Details.Location = new System.Drawing.Point(12, 602);
            this.grpb_Bank_Details.Name = "grpb_Bank_Details";
            this.grpb_Bank_Details.Size = new System.Drawing.Size(1251, 116);
            this.grpb_Bank_Details.TabIndex = 36;
            this.grpb_Bank_Details.TabStop = false;
            this.grpb_Bank_Details.Text = "Bank Details";
            // 
            // tb_Account_No
            // 
            this.tb_Account_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Account_No.Location = new System.Drawing.Point(926, 42);
            this.tb_Account_No.Name = "tb_Account_No";
            this.tb_Account_No.Size = new System.Drawing.Size(263, 34);
            this.tb_Account_No.TabIndex = 3;
            // 
            // tb_Bank_Details
            // 
            this.tb_Bank_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Bank_Details.Location = new System.Drawing.Point(256, 16);
            this.tb_Bank_Details.Name = "tb_Bank_Details";
            this.tb_Bank_Details.Size = new System.Drawing.Size(276, 83);
            this.tb_Bank_Details.TabIndex = 2;
            // 
            // lbl_Account_No
            // 
            this.lbl_Account_No.AutoSize = true;
            this.lbl_Account_No.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Account_No.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Account_No.Location = new System.Drawing.Point(707, 38);
            this.lbl_Account_No.Name = "lbl_Account_No";
            this.lbl_Account_No.Size = new System.Drawing.Size(160, 34);
            this.lbl_Account_No.TabIndex = 1;
            this.lbl_Account_No.Text = "Account No";
            // 
            // lbl_Bank_Details
            // 
            this.lbl_Bank_Details.AutoSize = true;
            this.lbl_Bank_Details.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bank_Details.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Bank_Details.Location = new System.Drawing.Point(60, 38);
            this.lbl_Bank_Details.Name = "lbl_Bank_Details";
            this.lbl_Bank_Details.Size = new System.Drawing.Size(166, 34);
            this.lbl_Bank_Details.TabIndex = 0;
            this.lbl_Bank_Details.Text = "Bank Details";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Red;
            this.btn_Refresh.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Refresh.Location = new System.Drawing.Point(341, 739);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(154, 50);
            this.btn_Refresh.TabIndex = 29;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Red;
            this.btn_Save.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Save.Location = new System.Drawing.Point(691, 739);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(162, 50);
            this.btn_Save.TabIndex = 37;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // Staff_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1275, 828);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.grpb_Bank_Details);
            this.Controls.Add(this.grpb_More_Details);
            this.Controls.Add(this.grpb_Personal_Details);
            this.Controls.Add(this.Pnl_Header);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Staff_Details";
            this.Text = "Staff_Details";
            this.Pnl_Header.ResumeLayout(false);
            this.Pnl_Header.PerformLayout();
            this.grpb_Personal_Details.ResumeLayout(false);
            this.grpb_Personal_Details.PerformLayout();
            this.grpb_More_Details.ResumeLayout(false);
            this.grpb_More_Details.PerformLayout();
            this.grpb_Bank_Details.ResumeLayout(false);
            this.grpb_Bank_Details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Header;
        private System.Windows.Forms.Label lbl_Staff_Details;
        private System.Windows.Forms.GroupBox grpb_Personal_Details;
        private System.Windows.Forms.Label lbl_Designation;
        private System.Windows.Forms.Label lbl_Joining_Date;
        private System.Windows.Forms.Label lbl_Staff_Name;
        private System.Windows.Forms.Label lbl_Staff_Id;
        private System.Windows.Forms.ComboBox cmb_Designation;
        private System.Windows.Forms.DateTimePicker dtp_Joining_Date;
        private System.Windows.Forms.TextBox tb_Staff_Name;
        private System.Windows.Forms.TextBox tb_Staff_Id;
        private System.Windows.Forms.GroupBox grpb_More_Details;
        private System.Windows.Forms.Label lbl_Note;
        private System.Windows.Forms.Label lbl_Email_Id;
        private System.Windows.Forms.Label lbl_Adhar_No;
        private System.Windows.Forms.Label lbl_Salary;
        private System.Windows.Forms.Label lbl_Certifications;
        private System.Windows.Forms.Label lbl_Mobile_No;
        private System.Windows.Forms.TextBox tb_Note;
        private System.Windows.Forms.TextBox tb_Email_Id;
        private System.Windows.Forms.TextBox tb_Adhar_No;
        private System.Windows.Forms.TextBox tb_Salary;
        private System.Windows.Forms.TextBox tb_Certifications;
        private System.Windows.Forms.TextBox tb_Mobile_No;
        private System.Windows.Forms.GroupBox grpb_Bank_Details;
        private System.Windows.Forms.TextBox tb_Account_No;
        private System.Windows.Forms.TextBox tb_Bank_Details;
        private System.Windows.Forms.Label lbl_Account_No;
        private System.Windows.Forms.Label lbl_Bank_Details;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label lbl_Experience;
        private System.Windows.Forms.TextBox tb_Experience;
    }
}