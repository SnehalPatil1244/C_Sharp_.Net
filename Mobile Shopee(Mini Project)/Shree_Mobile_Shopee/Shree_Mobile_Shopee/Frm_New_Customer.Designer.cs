
namespace Shree_Mobile_Shopee
{
    partial class Frm_New_Customer
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
            this.btn_Log_Out = new System.Windows.Forms.Button();
            this.lbl_Add_New_Customer = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.grpBox_Customer_Details = new System.Windows.Forms.GroupBox();
            this.lbl_Customer_Id = new System.Windows.Forms.Label();
            this.lbl_Customer_Name = new System.Windows.Forms.Label();
            this.lbl_Bill_Date = new System.Windows.Forms.Label();
            this.lbl_Mobile_No = new System.Windows.Forms.Label();
            this.tb_Customer_Id = new System.Windows.Forms.TextBox();
            this.tb_Customer_Name = new System.Windows.Forms.TextBox();
            this.tb_Mobile_No = new System.Windows.Forms.TextBox();
            this.dtp_Bill_Date = new System.Windows.Forms.DateTimePicker();
            this.grpBox_Purchase_Details = new System.Windows.Forms.GroupBox();
            this.lbl_Mobile = new System.Windows.Forms.Label();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.lbl_Total_Price = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.cmb_Mobile = new System.Windows.Forms.ComboBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.dgv_New_Customer = new System.Windows.Forms.DataGridView();
            this.lbl_Total_Bill = new System.Windows.Forms.Label();
            this.tb_Total_Bill = new System.Windows.Forms.TextBox();
            this.Pnl_Header.SuspendLayout();
            this.grpBox_Customer_Details.SuspendLayout();
            this.grpBox_Purchase_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_New_Customer)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_Header
            // 
            this.Pnl_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Pnl_Header.Controls.Add(this.btn_Back);
            this.Pnl_Header.Controls.Add(this.btn_Log_Out);
            this.Pnl_Header.Controls.Add(this.lbl_Add_New_Customer);
            this.Pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Header.Name = "Pnl_Header";
            this.Pnl_Header.Size = new System.Drawing.Size(1299, 103);
            this.Pnl_Header.TabIndex = 20;
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.BackColor = System.Drawing.Color.White;
            this.btn_Log_Out.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log_Out.ForeColor = System.Drawing.Color.Red;
            this.btn_Log_Out.Location = new System.Drawing.Point(1145, 3);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(151, 48);
            this.btn_Log_Out.TabIndex = 24;
            this.btn_Log_Out.Text = "Log Out";
            this.btn_Log_Out.UseVisualStyleBackColor = false;
            // 
            // lbl_Add_New_Customer
            // 
            this.lbl_Add_New_Customer.AutoSize = true;
            this.lbl_Add_New_Customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_Add_New_Customer.Font = new System.Drawing.Font("Copperplate Gothic Bold", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_New_Customer.Location = new System.Drawing.Point(294, 9);
            this.lbl_Add_New_Customer.Name = "lbl_Add_New_Customer";
            this.lbl_Add_New_Customer.Size = new System.Drawing.Size(765, 75);
            this.lbl_Add_New_Customer.TabIndex = 0;
            this.lbl_Add_New_Customer.Text = "Add New Customer";
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.White;
            this.btn_Back.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.Red;
            this.btn_Back.Location = new System.Drawing.Point(3, 3);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(151, 48);
            this.btn_Back.TabIndex = 27;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            // 
            // grpBox_Customer_Details
            // 
            this.grpBox_Customer_Details.Controls.Add(this.dtp_Bill_Date);
            this.grpBox_Customer_Details.Controls.Add(this.tb_Mobile_No);
            this.grpBox_Customer_Details.Controls.Add(this.tb_Customer_Name);
            this.grpBox_Customer_Details.Controls.Add(this.tb_Customer_Id);
            this.grpBox_Customer_Details.Controls.Add(this.lbl_Mobile_No);
            this.grpBox_Customer_Details.Controls.Add(this.lbl_Bill_Date);
            this.grpBox_Customer_Details.Controls.Add(this.lbl_Customer_Name);
            this.grpBox_Customer_Details.Controls.Add(this.lbl_Customer_Id);
            this.grpBox_Customer_Details.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_Customer_Details.ForeColor = System.Drawing.Color.Red;
            this.grpBox_Customer_Details.Location = new System.Drawing.Point(0, 97);
            this.grpBox_Customer_Details.Name = "grpBox_Customer_Details";
            this.grpBox_Customer_Details.Size = new System.Drawing.Size(1299, 252);
            this.grpBox_Customer_Details.TabIndex = 21;
            this.grpBox_Customer_Details.TabStop = false;
            this.grpBox_Customer_Details.Text = "Customer Details";
            // 
            // lbl_Customer_Id
            // 
            this.lbl_Customer_Id.AutoSize = true;
            this.lbl_Customer_Id.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer_Id.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Customer_Id.Location = new System.Drawing.Point(62, 73);
            this.lbl_Customer_Id.Name = "lbl_Customer_Id";
            this.lbl_Customer_Id.Size = new System.Drawing.Size(185, 39);
            this.lbl_Customer_Id.TabIndex = 0;
            this.lbl_Customer_Id.Text = "Customer Id";
            // 
            // lbl_Customer_Name
            // 
            this.lbl_Customer_Name.AutoSize = true;
            this.lbl_Customer_Name.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Customer_Name.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer_Name.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Customer_Name.Location = new System.Drawing.Point(62, 157);
            this.lbl_Customer_Name.Name = "lbl_Customer_Name";
            this.lbl_Customer_Name.Size = new System.Drawing.Size(238, 39);
            this.lbl_Customer_Name.TabIndex = 1;
            this.lbl_Customer_Name.Text = "Customer Name";
            // 
            // lbl_Bill_Date
            // 
            this.lbl_Bill_Date.AutoSize = true;
            this.lbl_Bill_Date.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bill_Date.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Bill_Date.Location = new System.Drawing.Point(731, 73);
            this.lbl_Bill_Date.Name = "lbl_Bill_Date";
            this.lbl_Bill_Date.Size = new System.Drawing.Size(139, 39);
            this.lbl_Bill_Date.TabIndex = 2;
            this.lbl_Bill_Date.Text = "Bill Date";
            // 
            // lbl_Mobile_No
            // 
            this.lbl_Mobile_No.AutoSize = true;
            this.lbl_Mobile_No.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile_No.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Mobile_No.Location = new System.Drawing.Point(731, 157);
            this.lbl_Mobile_No.Name = "lbl_Mobile_No";
            this.lbl_Mobile_No.Size = new System.Drawing.Size(164, 39);
            this.lbl_Mobile_No.TabIndex = 3;
            this.lbl_Mobile_No.Text = "Mobile No";
            // 
            // tb_Customer_Id
            // 
            this.tb_Customer_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Customer_Id.Location = new System.Drawing.Point(344, 68);
            this.tb_Customer_Id.Name = "tb_Customer_Id";
            this.tb_Customer_Id.Size = new System.Drawing.Size(298, 45);
            this.tb_Customer_Id.TabIndex = 29;
            // 
            // tb_Customer_Name
            // 
            this.tb_Customer_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Customer_Name.Location = new System.Drawing.Point(344, 157);
            this.tb_Customer_Name.Name = "tb_Customer_Name";
            this.tb_Customer_Name.Size = new System.Drawing.Size(298, 45);
            this.tb_Customer_Name.TabIndex = 30;
            // 
            // tb_Mobile_No
            // 
            this.tb_Mobile_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mobile_No.Location = new System.Drawing.Point(927, 152);
            this.tb_Mobile_No.Name = "tb_Mobile_No";
            this.tb_Mobile_No.Size = new System.Drawing.Size(321, 45);
            this.tb_Mobile_No.TabIndex = 31;
            // 
            // dtp_Bill_Date
            // 
            this.dtp_Bill_Date.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Bill_Date.Location = new System.Drawing.Point(927, 66);
            this.dtp_Bill_Date.Name = "dtp_Bill_Date";
            this.dtp_Bill_Date.Size = new System.Drawing.Size(321, 46);
            this.dtp_Bill_Date.TabIndex = 32;
            // 
            // grpBox_Purchase_Details
            // 
            this.grpBox_Purchase_Details.Controls.Add(this.btn_Add);
            this.grpBox_Purchase_Details.Controls.Add(this.cmb_Mobile);
            this.grpBox_Purchase_Details.Controls.Add(this.textBox3);
            this.grpBox_Purchase_Details.Controls.Add(this.textBox2);
            this.grpBox_Purchase_Details.Controls.Add(this.textBox1);
            this.grpBox_Purchase_Details.Controls.Add(this.lbl_Total_Price);
            this.grpBox_Purchase_Details.Controls.Add(this.lbl_Quantity);
            this.grpBox_Purchase_Details.Controls.Add(this.lbl_Price);
            this.grpBox_Purchase_Details.Controls.Add(this.lbl_Mobile);
            this.grpBox_Purchase_Details.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_Purchase_Details.ForeColor = System.Drawing.Color.Red;
            this.grpBox_Purchase_Details.Location = new System.Drawing.Point(3, 355);
            this.grpBox_Purchase_Details.Name = "grpBox_Purchase_Details";
            this.grpBox_Purchase_Details.Size = new System.Drawing.Size(1293, 166);
            this.grpBox_Purchase_Details.TabIndex = 22;
            this.grpBox_Purchase_Details.TabStop = false;
            this.grpBox_Purchase_Details.Text = "Purchase Details";
            // 
            // lbl_Mobile
            // 
            this.lbl_Mobile.AutoSize = true;
            this.lbl_Mobile.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Mobile.Location = new System.Drawing.Point(97, 44);
            this.lbl_Mobile.Name = "lbl_Mobile";
            this.lbl_Mobile.Size = new System.Drawing.Size(122, 39);
            this.lbl_Mobile.TabIndex = 4;
            this.lbl_Mobile.Text = "Mobile ";
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Price.Location = new System.Drawing.Point(383, 44);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(86, 39);
            this.lbl_Price.TabIndex = 5;
            this.lbl_Price.Text = "Price";
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantity.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Quantity.Location = new System.Drawing.Point(634, 44);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(134, 39);
            this.lbl_Quantity.TabIndex = 6;
            this.lbl_Quantity.Text = "Quantity";
            // 
            // lbl_Total_Price
            // 
            this.lbl_Total_Price.AutoSize = true;
            this.lbl_Total_Price.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total_Price.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Total_Price.Location = new System.Drawing.Point(892, 44);
            this.lbl_Total_Price.Name = "lbl_Total_Price";
            this.lbl_Total_Price.Size = new System.Drawing.Size(164, 39);
            this.lbl_Total_Price.TabIndex = 7;
            this.lbl_Total_Price.Text = "Total Price";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(599, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(219, 45);
            this.textBox1.TabIndex = 32;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(882, 95);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(218, 45);
            this.textBox2.TabIndex = 33;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(319, 95);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(219, 45);
            this.textBox3.TabIndex = 34;
            // 
            // cmb_Mobile
            // 
            this.cmb_Mobile.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Mobile.FormattingEnabled = true;
            this.cmb_Mobile.Location = new System.Drawing.Point(30, 95);
            this.cmb_Mobile.Name = "cmb_Mobile";
            this.cmb_Mobile.Size = new System.Drawing.Size(222, 45);
            this.cmb_Mobile.TabIndex = 35;
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Add.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Add.Location = new System.Drawing.Point(1113, 64);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(168, 48);
            this.btn_Add.TabIndex = 36;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Save.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Save.Location = new System.Drawing.Point(810, 743);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(183, 48);
            this.btn_Save.TabIndex = 37;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            // 
            // dgv_New_Customer
            // 
            this.dgv_New_Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_New_Customer.Location = new System.Drawing.Point(3, 527);
            this.dgv_New_Customer.Name = "dgv_New_Customer";
            this.dgv_New_Customer.RowHeadersWidth = 51;
            this.dgv_New_Customer.RowTemplate.Height = 24;
            this.dgv_New_Customer.Size = new System.Drawing.Size(1293, 194);
            this.dgv_New_Customer.TabIndex = 23;
            // 
            // lbl_Total_Bill
            // 
            this.lbl_Total_Bill.AutoSize = true;
            this.lbl_Total_Bill.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total_Bill.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Total_Bill.Location = new System.Drawing.Point(109, 741);
            this.lbl_Total_Bill.Name = "lbl_Total_Bill";
            this.lbl_Total_Bill.Size = new System.Drawing.Size(152, 39);
            this.lbl_Total_Bill.TabIndex = 38;
            this.lbl_Total_Bill.Text = "Total_Bill";
            // 
            // tb_Total_Bill
            // 
            this.tb_Total_Bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Total_Bill.Location = new System.Drawing.Point(332, 741);
            this.tb_Total_Bill.Name = "tb_Total_Bill";
            this.tb_Total_Bill.Size = new System.Drawing.Size(298, 45);
            this.tb_Total_Bill.TabIndex = 33;
            // 
            // Frm_New_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1296, 803);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tb_Total_Bill);
            this.Controls.Add(this.lbl_Total_Bill);
            this.Controls.Add(this.dgv_New_Customer);
            this.Controls.Add(this.grpBox_Purchase_Details);
            this.Controls.Add(this.grpBox_Customer_Details);
            this.Controls.Add(this.Pnl_Header);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_New_Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_New_Customer";
            this.Pnl_Header.ResumeLayout(false);
            this.Pnl_Header.PerformLayout();
            this.grpBox_Customer_Details.ResumeLayout(false);
            this.grpBox_Customer_Details.PerformLayout();
            this.grpBox_Purchase_Details.ResumeLayout(false);
            this.grpBox_Purchase_Details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_New_Customer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Header;
        private System.Windows.Forms.Button btn_Log_Out;
        private System.Windows.Forms.Label lbl_Add_New_Customer;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.GroupBox grpBox_Customer_Details;
        private System.Windows.Forms.Label lbl_Mobile_No;
        private System.Windows.Forms.Label lbl_Bill_Date;
        private System.Windows.Forms.Label lbl_Customer_Name;
        private System.Windows.Forms.Label lbl_Customer_Id;
        private System.Windows.Forms.DateTimePicker dtp_Bill_Date;
        private System.Windows.Forms.TextBox tb_Mobile_No;
        private System.Windows.Forms.TextBox tb_Customer_Name;
        private System.Windows.Forms.TextBox tb_Customer_Id;
        private System.Windows.Forms.GroupBox grpBox_Purchase_Details;
        private System.Windows.Forms.ComboBox cmb_Mobile;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_Total_Price;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Label lbl_Mobile;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.DataGridView dgv_New_Customer;
        private System.Windows.Forms.Label lbl_Total_Bill;
        private System.Windows.Forms.TextBox tb_Total_Bill;
    }
}