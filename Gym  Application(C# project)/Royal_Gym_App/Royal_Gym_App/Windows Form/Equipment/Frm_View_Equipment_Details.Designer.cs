
namespace Royal_Gym_App.Windows_Form.Equipment
{
    partial class Frm_View_Equipment_Details
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
            this.lbl_Equipment_List = new System.Windows.Forms.Label();
            this.cmb_Equipment_Type = new System.Windows.Forms.ComboBox();
            this.lbl_Equipment_Type = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.dgv_View_Member = new System.Windows.Forms.DataGridView();
            this.Pnl_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Member)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_Header
            // 
            this.Pnl_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Pnl_Header.Controls.Add(this.lbl_Equipment_List);
            this.Pnl_Header.Location = new System.Drawing.Point(14, 57);
            this.Pnl_Header.Name = "Pnl_Header";
            this.Pnl_Header.Size = new System.Drawing.Size(1242, 100);
            this.Pnl_Header.TabIndex = 42;
            // 
            // lbl_Equipment_List
            // 
            this.lbl_Equipment_List.AutoSize = true;
            this.lbl_Equipment_List.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbl_Equipment_List.Font = new System.Drawing.Font("Copperplate Gothic Bold", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Equipment_List.Location = new System.Drawing.Point(344, 14);
            this.lbl_Equipment_List.Name = "lbl_Equipment_List";
            this.lbl_Equipment_List.Size = new System.Drawing.Size(617, 75);
            this.lbl_Equipment_List.TabIndex = 0;
            this.lbl_Equipment_List.Text = "Equipment List ";
            // 
            // cmb_Equipment_Type
            // 
            this.cmb_Equipment_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Equipment_Type.FormattingEnabled = true;
            this.cmb_Equipment_Type.Location = new System.Drawing.Point(674, 213);
            this.cmb_Equipment_Type.Name = "cmb_Equipment_Type";
            this.cmb_Equipment_Type.Size = new System.Drawing.Size(263, 37);
            this.cmb_Equipment_Type.TabIndex = 47;
            // 
            // lbl_Equipment_Type
            // 
            this.lbl_Equipment_Type.AutoSize = true;
            this.lbl_Equipment_Type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl_Equipment_Type.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Equipment_Type.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Equipment_Type.Location = new System.Drawing.Point(256, 213);
            this.lbl_Equipment_Type.Name = "lbl_Equipment_Type";
            this.lbl_Equipment_Type.Size = new System.Drawing.Size(210, 34);
            this.lbl_Equipment_Type.TabIndex = 46;
            this.lbl_Equipment_Type.Text = "Equipment Type";
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Red;
            this.btn_Close.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Close.Location = new System.Drawing.Point(775, 722);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(162, 50);
            this.btn_Close.TabIndex = 45;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Red;
            this.btn_Refresh.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Refresh.Location = new System.Drawing.Point(312, 722);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(154, 50);
            this.btn_Refresh.TabIndex = 44;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            // 
            // dgv_View_Member
            // 
            this.dgv_View_Member.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_View_Member.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View_Member.Location = new System.Drawing.Point(18, 300);
            this.dgv_View_Member.Name = "dgv_View_Member";
            this.dgv_View_Member.RowHeadersWidth = 51;
            this.dgv_View_Member.RowTemplate.Height = 24;
            this.dgv_View_Member.Size = new System.Drawing.Size(1242, 396);
            this.dgv_View_Member.TabIndex = 43;
            // 
            // View_Equipment_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1275, 828);
            this.Controls.Add(this.Pnl_Header);
            this.Controls.Add(this.cmb_Equipment_Type);
            this.Controls.Add(this.lbl_Equipment_Type);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.dgv_View_Member);
            this.Name = "View_Equipment_Details";
            this.Text = "View_Equipment_Details";
            this.Pnl_Header.ResumeLayout(false);
            this.Pnl_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Member)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Header;
        private System.Windows.Forms.Label lbl_Equipment_List;
        private System.Windows.Forms.ComboBox cmb_Equipment_Type;
        private System.Windows.Forms.Label lbl_Equipment_Type;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.DataGridView dgv_View_Member;
    }
}