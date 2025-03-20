
namespace Employee_Details_App
{
    partial class Frm_Employee_Details
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
            this.cb_English = new System.Windows.Forms.CheckBox();
            this.cb_Marathi = new System.Windows.Forms.CheckBox();
            this.lbl_Outout = new System.Windows.Forms.Label();
            this.lbl_Error_Hobbies = new System.Windows.Forms.Label();
            this.lbl_Error_Language = new System.Windows.Forms.Label();
            this.lbl_Error_Shift_Time = new System.Windows.Forms.Label();
            this.lbl_Error_Gender = new System.Windows.Forms.Label();
            this.lbl_Error_Department = new System.Windows.Forms.Label();
            this.lbl_Error_Name = new System.Windows.Forms.Label();
            this.clb_Hobbies = new System.Windows.Forms.CheckedListBox();
            this.gb_Known_Language = new System.Windows.Forms.GroupBox();
            this.cb_French = new System.Windows.Forms.CheckBox();
            this.cb_Hindi = new System.Windows.Forms.CheckBox();
            this.lbl_Hobbies = new System.Windows.Forms.Label();
            this.lbl_Known_Language = new System.Windows.Forms.Label();
            this.gb_Shift_Time = new System.Windows.Forms.GroupBox();
            this.rb_Night = new System.Windows.Forms.RadioButton();
            this.rb_Evening = new System.Windows.Forms.RadioButton();
            this.rb_Morning = new System.Windows.Forms.RadioButton();
            this.gb_Gender = new System.Windows.Forms.GroupBox();
            this.rb_Female = new System.Windows.Forms.RadioButton();
            this.rb_Male = new System.Windows.Forms.RadioButton();
            this.cmb_Employee_Dept = new System.Windows.Forms.ComboBox();
            this.tb_Employee_Name = new System.Windows.Forms.TextBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.lbl_Output = new System.Windows.Forms.Label();
            this.lbl_Shift_Time = new System.Windows.Forms.Label();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_Employee_Department = new System.Windows.Forms.Label();
            this.lbl_Employee_Name = new System.Windows.Forms.Label();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.gb_Known_Language.SuspendLayout();
            this.gb_Shift_Time.SuspendLayout();
            this.gb_Gender.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_English
            // 
            this.cb_English.AutoSize = true;
            this.cb_English.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_English.Location = new System.Drawing.Point(33, 57);
            this.cb_English.Margin = new System.Windows.Forms.Padding(4);
            this.cb_English.Name = "cb_English";
            this.cb_English.Size = new System.Drawing.Size(86, 24);
            this.cb_English.TabIndex = 1;
            this.cb_English.Text = "English";
            this.cb_English.UseVisualStyleBackColor = true;
            // 
            // cb_Marathi
            // 
            this.cb_Marathi.AutoSize = true;
            this.cb_Marathi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Marathi.Location = new System.Drawing.Point(33, 23);
            this.cb_Marathi.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Marathi.Name = "cb_Marathi";
            this.cb_Marathi.Size = new System.Drawing.Size(87, 24);
            this.cb_Marathi.TabIndex = 0;
            this.cb_Marathi.Text = "Marathi";
            this.cb_Marathi.UseVisualStyleBackColor = true;
            // 
            // lbl_Outout
            // 
            this.lbl_Outout.AutoSize = true;
            this.lbl_Outout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Outout.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Outout.Location = new System.Drawing.Point(201, 579);
            this.lbl_Outout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Outout.Name = "lbl_Outout";
            this.lbl_Outout.Size = new System.Drawing.Size(71, 25);
            this.lbl_Outout.TabIndex = 56;
            this.lbl_Outout.Text = "Output";
            // 
            // lbl_Error_Hobbies
            // 
            this.lbl_Error_Hobbies.AutoSize = true;
            this.lbl_Error_Hobbies.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Error_Hobbies.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_Error_Hobbies.Location = new System.Drawing.Point(1171, 469);
            this.lbl_Error_Hobbies.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Error_Hobbies.Name = "lbl_Error_Hobbies";
            this.lbl_Error_Hobbies.Size = new System.Drawing.Size(156, 20);
            this.lbl_Error_Hobbies.TabIndex = 55;
            this.lbl_Error_Hobbies.Text = "Select The Hobbies";
            this.lbl_Error_Hobbies.Visible = false;
            // 
            // lbl_Error_Language
            // 
            this.lbl_Error_Language.AutoSize = true;
            this.lbl_Error_Language.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Error_Language.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_Error_Language.Location = new System.Drawing.Point(1145, 275);
            this.lbl_Error_Language.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Error_Language.Name = "lbl_Error_Language";
            this.lbl_Error_Language.Size = new System.Drawing.Size(176, 20);
            this.lbl_Error_Language.TabIndex = 54;
            this.lbl_Error_Language.Text = "Select The Languages";
            this.lbl_Error_Language.Visible = false;
            // 
            // lbl_Error_Shift_Time
            // 
            this.lbl_Error_Shift_Time.AutoSize = true;
            this.lbl_Error_Shift_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Error_Shift_Time.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_Error_Shift_Time.Location = new System.Drawing.Point(563, 470);
            this.lbl_Error_Shift_Time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Error_Shift_Time.Name = "lbl_Error_Shift_Time";
            this.lbl_Error_Shift_Time.Size = new System.Drawing.Size(164, 20);
            this.lbl_Error_Shift_Time.TabIndex = 53;
            this.lbl_Error_Shift_Time.Text = "Select Any One Shift";
            this.lbl_Error_Shift_Time.Visible = false;
            // 
            // lbl_Error_Gender
            // 
            this.lbl_Error_Gender.AutoSize = true;
            this.lbl_Error_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Error_Gender.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_Error_Gender.Location = new System.Drawing.Point(536, 359);
            this.lbl_Error_Gender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Error_Gender.Name = "lbl_Error_Gender";
            this.lbl_Error_Gender.Size = new System.Drawing.Size(185, 20);
            this.lbl_Error_Gender.TabIndex = 52;
            this.lbl_Error_Gender.Text = "Select Any One Gender";
            this.lbl_Error_Gender.Visible = false;
            // 
            // lbl_Error_Department
            // 
            this.lbl_Error_Department.AutoSize = true;
            this.lbl_Error_Department.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Error_Department.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_Error_Department.Location = new System.Drawing.Point(587, 252);
            this.lbl_Error_Department.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Error_Department.Name = "lbl_Error_Department";
            this.lbl_Error_Department.Size = new System.Drawing.Size(142, 20);
            this.lbl_Error_Department.TabIndex = 51;
            this.lbl_Error_Department.Text = "Enter Department";
            this.lbl_Error_Department.Visible = false;
            // 
            // lbl_Error_Name
            // 
            this.lbl_Error_Name.AutoSize = true;
            this.lbl_Error_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Error_Name.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_Error_Name.Location = new System.Drawing.Point(595, 160);
            this.lbl_Error_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Error_Name.Name = "lbl_Error_Name";
            this.lbl_Error_Name.Size = new System.Drawing.Size(137, 20);
            this.lbl_Error_Name.TabIndex = 50;
            this.lbl_Error_Name.Text = "Enter Name First";
            this.lbl_Error_Name.Visible = false;
            // 
            // clb_Hobbies
            // 
            this.clb_Hobbies.BackColor = System.Drawing.Color.LightGray;
            this.clb_Hobbies.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clb_Hobbies.FormattingEnabled = true;
            this.clb_Hobbies.Items.AddRange(new object[] {
            "Reading",
            "Dancing",
            "Cycling",
            "Gamming",
            "Coocking",
            "Driving"});
            this.clb_Hobbies.Location = new System.Drawing.Point(949, 305);
            this.clb_Hobbies.Margin = new System.Windows.Forms.Padding(4);
            this.clb_Hobbies.Name = "clb_Hobbies";
            this.clb_Hobbies.Size = new System.Drawing.Size(396, 151);
            this.clb_Hobbies.TabIndex = 49;
            // 
            // gb_Known_Language
            // 
            this.gb_Known_Language.BackColor = System.Drawing.Color.LightGray;
            this.gb_Known_Language.Controls.Add(this.cb_French);
            this.gb_Known_Language.Controls.Add(this.cb_Hindi);
            this.gb_Known_Language.Controls.Add(this.cb_English);
            this.gb_Known_Language.Controls.Add(this.cb_Marathi);
            this.gb_Known_Language.Location = new System.Drawing.Point(949, 171);
            this.gb_Known_Language.Margin = new System.Windows.Forms.Padding(4);
            this.gb_Known_Language.Name = "gb_Known_Language";
            this.gb_Known_Language.Padding = new System.Windows.Forms.Padding(4);
            this.gb_Known_Language.Size = new System.Drawing.Size(397, 101);
            this.gb_Known_Language.TabIndex = 48;
            this.gb_Known_Language.TabStop = false;
            this.gb_Known_Language.Text = "Known Language";
            // 
            // cb_French
            // 
            this.cb_French.AutoSize = true;
            this.cb_French.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_French.Location = new System.Drawing.Point(223, 57);
            this.cb_French.Margin = new System.Windows.Forms.Padding(4);
            this.cb_French.Name = "cb_French";
            this.cb_French.Size = new System.Drawing.Size(83, 24);
            this.cb_French.TabIndex = 3;
            this.cb_French.Text = "French";
            this.cb_French.UseVisualStyleBackColor = true;
            // 
            // cb_Hindi
            // 
            this.cb_Hindi.AutoSize = true;
            this.cb_Hindi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Hindi.Location = new System.Drawing.Point(223, 23);
            this.cb_Hindi.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Hindi.Name = "cb_Hindi";
            this.cb_Hindi.Size = new System.Drawing.Size(70, 24);
            this.cb_Hindi.TabIndex = 2;
            this.cb_Hindi.Text = "Hindi";
            this.cb_Hindi.UseVisualStyleBackColor = true;
            // 
            // lbl_Hobbies
            // 
            this.lbl_Hobbies.AutoSize = true;
            this.lbl_Hobbies.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hobbies.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Hobbies.Location = new System.Drawing.Point(812, 305);
            this.lbl_Hobbies.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Hobbies.Name = "lbl_Hobbies";
            this.lbl_Hobbies.Size = new System.Drawing.Size(106, 29);
            this.lbl_Hobbies.TabIndex = 47;
            this.lbl_Hobbies.Text = "Hobbies";
            // 
            // lbl_Known_Language
            // 
            this.lbl_Known_Language.AutoSize = true;
            this.lbl_Known_Language.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Known_Language.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Known_Language.Location = new System.Drawing.Point(812, 122);
            this.lbl_Known_Language.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Known_Language.Name = "lbl_Known_Language";
            this.lbl_Known_Language.Size = new System.Drawing.Size(222, 29);
            this.lbl_Known_Language.TabIndex = 46;
            this.lbl_Known_Language.Text = "Known Languages";
            // 
            // gb_Shift_Time
            // 
            this.gb_Shift_Time.BackColor = System.Drawing.Color.LightGray;
            this.gb_Shift_Time.Controls.Add(this.rb_Night);
            this.gb_Shift_Time.Controls.Add(this.rb_Evening);
            this.gb_Shift_Time.Controls.Add(this.rb_Morning);
            this.gb_Shift_Time.ForeColor = System.Drawing.Color.Black;
            this.gb_Shift_Time.Location = new System.Drawing.Point(341, 400);
            this.gb_Shift_Time.Margin = new System.Windows.Forms.Padding(4);
            this.gb_Shift_Time.Name = "gb_Shift_Time";
            this.gb_Shift_Time.Padding = new System.Windows.Forms.Padding(4);
            this.gb_Shift_Time.Size = new System.Drawing.Size(405, 66);
            this.gb_Shift_Time.TabIndex = 43;
            this.gb_Shift_Time.TabStop = false;
            this.gb_Shift_Time.Text = "Time";
            // 
            // rb_Night
            // 
            this.rb_Night.AutoSize = true;
            this.rb_Night.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Night.Location = new System.Drawing.Point(303, 23);
            this.rb_Night.Margin = new System.Windows.Forms.Padding(4);
            this.rb_Night.Name = "rb_Night";
            this.rb_Night.Size = new System.Drawing.Size(69, 24);
            this.rb_Night.TabIndex = 7;
            this.rb_Night.TabStop = true;
            this.rb_Night.Text = "Night";
            this.rb_Night.UseVisualStyleBackColor = true;
            // 
            // rb_Evening
            // 
            this.rb_Evening.AutoSize = true;
            this.rb_Evening.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Evening.Location = new System.Drawing.Point(168, 23);
            this.rb_Evening.Margin = new System.Windows.Forms.Padding(4);
            this.rb_Evening.Name = "rb_Evening";
            this.rb_Evening.Size = new System.Drawing.Size(89, 24);
            this.rb_Evening.TabIndex = 6;
            this.rb_Evening.TabStop = true;
            this.rb_Evening.Text = "Evening";
            this.rb_Evening.UseVisualStyleBackColor = true;
            // 
            // rb_Morning
            // 
            this.rb_Morning.AutoSize = true;
            this.rb_Morning.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Morning.Location = new System.Drawing.Point(41, 23);
            this.rb_Morning.Margin = new System.Windows.Forms.Padding(4);
            this.rb_Morning.Name = "rb_Morning";
            this.rb_Morning.Size = new System.Drawing.Size(90, 24);
            this.rb_Morning.TabIndex = 5;
            this.rb_Morning.TabStop = true;
            this.rb_Morning.Text = "Morning";
            this.rb_Morning.UseVisualStyleBackColor = true;
            // 
            // gb_Gender
            // 
            this.gb_Gender.BackColor = System.Drawing.Color.LightGray;
            this.gb_Gender.Controls.Add(this.rb_Female);
            this.gb_Gender.Controls.Add(this.rb_Male);
            this.gb_Gender.ForeColor = System.Drawing.Color.Black;
            this.gb_Gender.Location = new System.Drawing.Point(341, 289);
            this.gb_Gender.Margin = new System.Windows.Forms.Padding(4);
            this.gb_Gender.Name = "gb_Gender";
            this.gb_Gender.Padding = new System.Windows.Forms.Padding(4);
            this.gb_Gender.Size = new System.Drawing.Size(405, 66);
            this.gb_Gender.TabIndex = 42;
            this.gb_Gender.TabStop = false;
            this.gb_Gender.Text = "Gender";
            // 
            // rb_Female
            // 
            this.rb_Female.AutoSize = true;
            this.rb_Female.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Female.Location = new System.Drawing.Point(233, 23);
            this.rb_Female.Margin = new System.Windows.Forms.Padding(4);
            this.rb_Female.Name = "rb_Female";
            this.rb_Female.Size = new System.Drawing.Size(85, 24);
            this.rb_Female.TabIndex = 4;
            this.rb_Female.TabStop = true;
            this.rb_Female.Text = "Female";
            this.rb_Female.UseVisualStyleBackColor = true;
            // 
            // rb_Male
            // 
            this.rb_Male.AutoSize = true;
            this.rb_Male.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Male.Location = new System.Drawing.Point(69, 23);
            this.rb_Male.Margin = new System.Windows.Forms.Padding(4);
            this.rb_Male.Name = "rb_Male";
            this.rb_Male.Size = new System.Drawing.Size(66, 24);
            this.rb_Male.TabIndex = 3;
            this.rb_Male.TabStop = true;
            this.rb_Male.Text = "Male";
            this.rb_Male.UseVisualStyleBackColor = true;
            // 
            // cmb_Employee_Dept
            // 
            this.cmb_Employee_Dept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Employee_Dept.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Employee_Dept.FormattingEnabled = true;
            this.cmb_Employee_Dept.Items.AddRange(new object[] {
            "Development",
            "Analist",
            "Tester",
            "Manager",
            "Coder"});
            this.cmb_Employee_Dept.Location = new System.Drawing.Point(341, 214);
            this.cmb_Employee_Dept.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_Employee_Dept.Name = "cmb_Employee_Dept";
            this.cmb_Employee_Dept.Size = new System.Drawing.Size(404, 34);
            this.cmb_Employee_Dept.TabIndex = 41;
            // 
            // tb_Employee_Name
            // 
            this.tb_Employee_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Employee_Name.Location = new System.Drawing.Point(341, 123);
            this.tb_Employee_Name.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Employee_Name.Name = "tb_Employee_Name";
            this.tb_Employee_Name.Size = new System.Drawing.Size(404, 32);
            this.tb_Employee_Name.TabIndex = 40;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_Refresh.Location = new System.Drawing.Point(556, 511);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(173, 48);
            this.btn_Refresh.TabIndex = 44;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_Submit.Location = new System.Drawing.Point(926, 511);
            this.btn_Submit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(173, 48);
            this.btn_Submit.TabIndex = 45;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // lbl_Output
            // 
            this.lbl_Output.AutoSize = true;
            this.lbl_Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Output.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Output.Location = new System.Drawing.Point(81, 571);
            this.lbl_Output.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Output.Name = "lbl_Output";
            this.lbl_Output.Size = new System.Drawing.Size(104, 36);
            this.lbl_Output.TabIndex = 34;
            this.lbl_Output.Text = "Output";
            // 
            // lbl_Shift_Time
            // 
            this.lbl_Shift_Time.AutoSize = true;
            this.lbl_Shift_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Shift_Time.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Shift_Time.Location = new System.Drawing.Point(60, 400);
            this.lbl_Shift_Time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Shift_Time.Name = "lbl_Shift_Time";
            this.lbl_Shift_Time.Size = new System.Drawing.Size(128, 29);
            this.lbl_Shift_Time.TabIndex = 35;
            this.lbl_Shift_Time.Text = "Shift Time";
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Gender.Location = new System.Drawing.Point(60, 305);
            this.lbl_Gender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(96, 29);
            this.lbl_Gender.TabIndex = 36;
            this.lbl_Gender.Text = "Gender";
            // 
            // lbl_Employee_Department
            // 
            this.lbl_Employee_Department.AutoSize = true;
            this.lbl_Employee_Department.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee_Department.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Employee_Department.Location = new System.Drawing.Point(60, 213);
            this.lbl_Employee_Department.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Employee_Department.Name = "lbl_Employee_Department";
            this.lbl_Employee_Department.Size = new System.Drawing.Size(266, 29);
            this.lbl_Employee_Department.TabIndex = 37;
            this.lbl_Employee_Department.Text = "Employee Department";
            // 
            // lbl_Employee_Name
            // 
            this.lbl_Employee_Name.AutoSize = true;
            this.lbl_Employee_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee_Name.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Employee_Name.Location = new System.Drawing.Point(60, 123);
            this.lbl_Employee_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Employee_Name.Name = "lbl_Employee_Name";
            this.lbl_Employee_Name.Size = new System.Drawing.Size(202, 29);
            this.lbl_Employee_Name.TabIndex = 38;
            this.lbl_Employee_Name.Text = "Employee Name";
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lbl_Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lbl_Header.Location = new System.Drawing.Point(476, 22);
            this.lbl_Header.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(489, 67);
            this.lbl_Header.TabIndex = 39;
            this.lbl_Header.Text = "Employee Details";
            // 
            // Frm_Employee_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1407, 628);
            this.Controls.Add(this.lbl_Outout);
            this.Controls.Add(this.lbl_Error_Hobbies);
            this.Controls.Add(this.lbl_Error_Language);
            this.Controls.Add(this.lbl_Error_Shift_Time);
            this.Controls.Add(this.lbl_Error_Gender);
            this.Controls.Add(this.lbl_Error_Department);
            this.Controls.Add(this.lbl_Error_Name);
            this.Controls.Add(this.clb_Hobbies);
            this.Controls.Add(this.gb_Known_Language);
            this.Controls.Add(this.lbl_Hobbies);
            this.Controls.Add(this.lbl_Known_Language);
            this.Controls.Add(this.gb_Shift_Time);
            this.Controls.Add(this.gb_Gender);
            this.Controls.Add(this.cmb_Employee_Dept);
            this.Controls.Add(this.tb_Employee_Name);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.lbl_Output);
            this.Controls.Add(this.lbl_Shift_Time);
            this.Controls.Add(this.lbl_Gender);
            this.Controls.Add(this.lbl_Employee_Department);
            this.Controls.Add(this.lbl_Employee_Name);
            this.Controls.Add(this.lbl_Header);
            this.Name = "Frm_Employee_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Employee_Details";
            this.gb_Known_Language.ResumeLayout(false);
            this.gb_Known_Language.PerformLayout();
            this.gb_Shift_Time.ResumeLayout(false);
            this.gb_Shift_Time.PerformLayout();
            this.gb_Gender.ResumeLayout(false);
            this.gb_Gender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cb_English;
        private System.Windows.Forms.CheckBox cb_Marathi;
        private System.Windows.Forms.Label lbl_Outout;
        private System.Windows.Forms.Label lbl_Error_Hobbies;
        private System.Windows.Forms.Label lbl_Error_Language;
        private System.Windows.Forms.Label lbl_Error_Shift_Time;
        private System.Windows.Forms.Label lbl_Error_Gender;
        private System.Windows.Forms.Label lbl_Error_Department;
        private System.Windows.Forms.Label lbl_Error_Name;
        private System.Windows.Forms.CheckedListBox clb_Hobbies;
        private System.Windows.Forms.GroupBox gb_Known_Language;
        private System.Windows.Forms.CheckBox cb_French;
        private System.Windows.Forms.CheckBox cb_Hindi;
        private System.Windows.Forms.Label lbl_Hobbies;
        private System.Windows.Forms.Label lbl_Known_Language;
        private System.Windows.Forms.GroupBox gb_Shift_Time;
        private System.Windows.Forms.RadioButton rb_Night;
        private System.Windows.Forms.RadioButton rb_Evening;
        private System.Windows.Forms.RadioButton rb_Morning;
        private System.Windows.Forms.GroupBox gb_Gender;
        private System.Windows.Forms.RadioButton rb_Female;
        private System.Windows.Forms.RadioButton rb_Male;
        private System.Windows.Forms.ComboBox cmb_Employee_Dept;
        private System.Windows.Forms.TextBox tb_Employee_Name;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Label lbl_Output;
        private System.Windows.Forms.Label lbl_Shift_Time;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_Employee_Department;
        private System.Windows.Forms.Label lbl_Employee_Name;
        private System.Windows.Forms.Label lbl_Header;
    }
}

