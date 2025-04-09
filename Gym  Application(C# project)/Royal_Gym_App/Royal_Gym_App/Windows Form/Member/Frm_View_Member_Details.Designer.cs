
namespace Royal_Gym_App.Windows_Form.Member
{
    partial class Frm_View_Member_Details
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
            this.lbl_View_Member = new System.Windows.Forms.Label();
            this.dgv_View_Member = new System.Windows.Forms.DataGridView();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.Pnl_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Member)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_Header
            // 
            this.Pnl_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Pnl_Header.Controls.Add(this.lbl_View_Member);
            this.Pnl_Header.Location = new System.Drawing.Point(12, 12);
            this.Pnl_Header.Name = "Pnl_Header";
            this.Pnl_Header.Size = new System.Drawing.Size(1242, 100);
            this.Pnl_Header.TabIndex = 32;
            // 
            // lbl_View_Member
            // 
            this.lbl_View_Member.AutoSize = true;
            this.lbl_View_Member.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbl_View_Member.Font = new System.Drawing.Font("Copperplate Gothic Bold", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_View_Member.Location = new System.Drawing.Point(354, 10);
            this.lbl_View_Member.Name = "lbl_View_Member";
            this.lbl_View_Member.Size = new System.Drawing.Size(550, 75);
            this.lbl_View_Member.TabIndex = 0;
            this.lbl_View_Member.Text = "View Member ";
            // 
            // dgv_View_Member
            // 
            this.dgv_View_Member.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_View_Member.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View_Member.Location = new System.Drawing.Point(12, 236);
            this.dgv_View_Member.Name = "dgv_View_Member";
            this.dgv_View_Member.RowHeadersWidth = 51;
            this.dgv_View_Member.RowTemplate.Height = 24;
            this.dgv_View_Member.Size = new System.Drawing.Size(1226, 385);
            this.dgv_View_Member.TabIndex = 33;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Red;
            this.btn_Refresh.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Refresh.Location = new System.Drawing.Point(297, 665);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(154, 50);
            this.btn_Refresh.TabIndex = 34;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Red;
            this.btn_Close.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Close.Location = new System.Drawing.Point(799, 665);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(162, 50);
            this.btn_Close.TabIndex = 35;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            // 
            // Frm_View_Member_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1275, 828);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.dgv_View_Member);
            this.Controls.Add(this.Pnl_Header);
            this.Name = "Frm_View_Member_Details";
            this.Text = "View_Member_Details";
            this.Pnl_Header.ResumeLayout(false);
            this.Pnl_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Member)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Header;
        private System.Windows.Forms.Label lbl_View_Member;
        private System.Windows.Forms.DataGridView dgv_View_Member;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Close;
    }
}