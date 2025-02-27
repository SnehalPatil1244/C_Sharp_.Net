
namespace Student_Information_Details_App
{
    partial class Frm_Student_List
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
            this.dgv_Student_List = new System.Windows.Forms.DataGridView();
            this.btn_Log_Out = new System.Windows.Forms.Button();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.pnl_Student_List = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_UName = new System.Windows.Forms.Label();
            this.btn_Student_List = new System.Windows.Forms.Button();
            this.btn_Update_Student = new System.Windows.Forms.Button();
            this.btn_Search_Student = new System.Windows.Forms.Button();
            this.btn_Add_New_Student = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Student_List)).BeginInit();
            this.pnl_Student_List.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Student_List
            // 
            this.dgv_Student_List.AllowUserToOrderColumns = true;
            this.dgv_Student_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Student_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Student_List.Location = new System.Drawing.Point(342, 132);
            this.dgv_Student_List.Name = "dgv_Student_List";
            this.dgv_Student_List.RowHeadersWidth = 51;
            this.dgv_Student_List.RowTemplate.Height = 24;
            this.dgv_Student_List.Size = new System.Drawing.Size(1030, 578);
            this.dgv_Student_List.TabIndex = 16;
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.BackColor = System.Drawing.Color.White;
            this.btn_Log_Out.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log_Out.ForeColor = System.Drawing.Color.Red;
            this.btn_Log_Out.Location = new System.Drawing.Point(882, 35);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(131, 43);
            this.btn_Log_Out.TabIndex = 15;
            this.btn_Log_Out.Text = "Log Out";
            this.btn_Log_Out.UseVisualStyleBackColor = false;
            this.btn_Log_Out.Click += new System.EventHandler(this.btn_Log_Out_Click);
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.Color.PeachPuff;
            this.lbl_Header.Font = new System.Drawing.Font("Californian FB", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Header.Location = new System.Drawing.Point(327, 24);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(377, 76);
            this.lbl_Header.TabIndex = 13;
            this.lbl_Header.Text = " Student List";
            // 
            // pnl_Student_List
            // 
            this.pnl_Student_List.BackColor = System.Drawing.Color.PeachPuff;
            this.pnl_Student_List.Controls.Add(this.btn_Log_Out);
            this.pnl_Student_List.Controls.Add(this.lbl_Header);
            this.pnl_Student_List.Location = new System.Drawing.Point(333, -1);
            this.pnl_Student_List.Name = "pnl_Student_List";
            this.pnl_Student_List.Size = new System.Drawing.Size(1050, 127);
            this.pnl_Student_List.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbl_UName);
            this.panel1.Controls.Add(this.btn_Student_List);
            this.panel1.Controls.Add(this.btn_Update_Student);
            this.panel1.Controls.Add(this.btn_Search_Student);
            this.panel1.Controls.Add(this.btn_Add_New_Student);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 711);
            this.panel1.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Student_Information_Details_App.Properties.Resources.school_image;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(335, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_UName
            // 
            this.lbl_UName.AutoSize = true;
            this.lbl_UName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UName.ForeColor = System.Drawing.Color.Fuchsia;
            this.lbl_UName.Location = new System.Drawing.Point(96, 624);
            this.lbl_UName.Name = "lbl_UName";
            this.lbl_UName.Size = new System.Drawing.Size(114, 36);
            this.lbl_UName.TabIndex = 42;
            this.lbl_UName.Text = "UName";
            // 
            // btn_Student_List
            // 
            this.btn_Student_List.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Student_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Student_List.ForeColor = System.Drawing.Color.Blue;
            this.btn_Student_List.Location = new System.Drawing.Point(32, 520);
            this.btn_Student_List.Name = "btn_Student_List";
            this.btn_Student_List.Size = new System.Drawing.Size(248, 47);
            this.btn_Student_List.TabIndex = 41;
            this.btn_Student_List.Text = "Student List";
            this.btn_Student_List.UseVisualStyleBackColor = false;
            this.btn_Student_List.Click += new System.EventHandler(this.btn_Student_List_Click);
            // 
            // btn_Update_Student
            // 
            this.btn_Update_Student.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Update_Student.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update_Student.ForeColor = System.Drawing.Color.Blue;
            this.btn_Update_Student.Location = new System.Drawing.Point(32, 413);
            this.btn_Update_Student.Name = "btn_Update_Student";
            this.btn_Update_Student.Size = new System.Drawing.Size(248, 47);
            this.btn_Update_Student.TabIndex = 40;
            this.btn_Update_Student.Text = "Update Student";
            this.btn_Update_Student.UseVisualStyleBackColor = false;
            this.btn_Update_Student.Click += new System.EventHandler(this.btn_Update_Student_Click);
            // 
            // btn_Search_Student
            // 
            this.btn_Search_Student.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Search_Student.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search_Student.ForeColor = System.Drawing.Color.Blue;
            this.btn_Search_Student.Location = new System.Drawing.Point(32, 290);
            this.btn_Search_Student.Name = "btn_Search_Student";
            this.btn_Search_Student.Size = new System.Drawing.Size(248, 47);
            this.btn_Search_Student.TabIndex = 39;
            this.btn_Search_Student.Text = "Search Student";
            this.btn_Search_Student.UseVisualStyleBackColor = false;
            this.btn_Search_Student.Click += new System.EventHandler(this.btn_Search_Student_Click);
            // 
            // btn_Add_New_Student
            // 
            this.btn_Add_New_Student.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Add_New_Student.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_New_Student.ForeColor = System.Drawing.Color.Blue;
            this.btn_Add_New_Student.Location = new System.Drawing.Point(32, 169);
            this.btn_Add_New_Student.Name = "btn_Add_New_Student";
            this.btn_Add_New_Student.Size = new System.Drawing.Size(248, 47);
            this.btn_Add_New_Student.TabIndex = 38;
            this.btn_Add_New_Student.Text = "Add New Student";
            this.btn_Add_New_Student.UseVisualStyleBackColor = false;
            this.btn_Add_New_Student.Click += new System.EventHandler(this.btn_Add_New_Student_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.Blue;
            this.btn_Close.Location = new System.Drawing.Point(673, 716);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(202, 47);
            this.btn_Close.TabIndex = 19;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // Frm_Student_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 770);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_Student_List);
            this.Controls.Add(this.dgv_Student_List);
            this.Name = "Frm_Student_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student_List";
            this.Load += new System.EventHandler(this.Frm_Student_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Student_List)).EndInit();
            this.pnl_Student_List.ResumeLayout(false);
            this.pnl_Student_List.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Student_List;
        private System.Windows.Forms.Button btn_Log_Out;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Panel pnl_Student_List;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Add_New_Student;
        private System.Windows.Forms.Button btn_Search_Student;
        private System.Windows.Forms.Button btn_Update_Student;
        private System.Windows.Forms.Button btn_Student_List;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_UName;
        private System.Windows.Forms.Button btn_Close;
    }
}