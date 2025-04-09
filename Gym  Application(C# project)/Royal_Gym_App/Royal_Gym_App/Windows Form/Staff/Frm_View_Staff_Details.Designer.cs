
namespace Royal_Gym_App.Windows_Form.Staff
{
    partial class Frm_View_Staff_Details
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
            this.lbl_Staff_List = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.dgv_View_Member = new System.Windows.Forms.DataGridView();
            this.lbl_Designation = new System.Windows.Forms.Label();
            this.cmb_Designation = new System.Windows.Forms.ComboBox();
            this.Pnl_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Member)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_Header
            // 
            this.Pnl_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Pnl_Header.Controls.Add(this.lbl_Staff_List);
            this.Pnl_Header.Location = new System.Drawing.Point(12, 33);
            this.Pnl_Header.Name = "Pnl_Header";
            this.Pnl_Header.Size = new System.Drawing.Size(1242, 100);
            this.Pnl_Header.TabIndex = 36;
            this.Pnl_Header.Paint += new System.Windows.Forms.PaintEventHandler(this.Pnl_Header_Paint);
            // 
            // lbl_Staff_List
            // 
            this.lbl_Staff_List.AutoSize = true;
            this.lbl_Staff_List.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbl_Staff_List.Font = new System.Drawing.Font("Copperplate Gothic Bold", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Staff_List.Location = new System.Drawing.Point(446, 13);
            this.lbl_Staff_List.Name = "lbl_Staff_List";
            this.lbl_Staff_List.Size = new System.Drawing.Size(432, 75);
            this.lbl_Staff_List.TabIndex = 0;
            this.lbl_Staff_List.Text = "Staff List ";
            this.lbl_Staff_List.Click += new System.EventHandler(this.lbl_Staff_List_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Red;
            this.btn_Close.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Close.Location = new System.Drawing.Point(773, 698);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(162, 50);
            this.btn_Close.TabIndex = 39;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Red;
            this.btn_Refresh.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Refresh.Location = new System.Drawing.Point(358, 698);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(154, 50);
            this.btn_Refresh.TabIndex = 38;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // dgv_View_Member
            // 
            this.dgv_View_Member.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_View_Member.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View_Member.Location = new System.Drawing.Point(16, 276);
            this.dgv_View_Member.Name = "dgv_View_Member";
            this.dgv_View_Member.RowHeadersWidth = 51;
            this.dgv_View_Member.RowTemplate.Height = 24;
            this.dgv_View_Member.Size = new System.Drawing.Size(1242, 396);
            this.dgv_View_Member.TabIndex = 37;
            this.dgv_View_Member.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_View_Member_CellContentClick);
            // 
            // lbl_Designation
            // 
            this.lbl_Designation.AutoSize = true;
            this.lbl_Designation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl_Designation.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Designation.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Designation.Location = new System.Drawing.Point(254, 189);
            this.lbl_Designation.Name = "lbl_Designation";
            this.lbl_Designation.Size = new System.Drawing.Size(317, 34);
            this.lbl_Designation.TabIndex = 40;
            this.lbl_Designation.Text = " Search Staff Designation";
            this.lbl_Designation.Click += new System.EventHandler(this.lbl_Designation_Click);
            // 
            // cmb_Designation
            // 
            this.cmb_Designation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Designation.FormattingEnabled = true;
            this.cmb_Designation.Location = new System.Drawing.Point(724, 186);
            this.cmb_Designation.Name = "cmb_Designation";
            this.cmb_Designation.Size = new System.Drawing.Size(263, 37);
            this.cmb_Designation.TabIndex = 41;
            // 
            // View_Staff_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1275, 828);
            this.Controls.Add(this.cmb_Designation);
            this.Controls.Add(this.lbl_Designation);
            this.Controls.Add(this.Pnl_Header);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.dgv_View_Member);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "View_Staff_Details";
            this.Text = "View_Staff_Details";
            this.Pnl_Header.ResumeLayout(false);
            this.Pnl_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Member)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Header;
        private System.Windows.Forms.Label lbl_Staff_List;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.DataGridView dgv_View_Member;
        private System.Windows.Forms.Label lbl_Designation;
        private System.Windows.Forms.ComboBox cmb_Designation;
    }
}