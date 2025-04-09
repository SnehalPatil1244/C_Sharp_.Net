
namespace Shree_Mobile_Shopee
{
    partial class Frm_View_Mobile_List
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
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Log_Out = new System.Windows.Forms.Button();
            this.lbl_View_Mobile_List = new System.Windows.Forms.Label();
            this.dgv_Mobile_List = new System.Windows.Forms.DataGridView();
            this.Pnl_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Mobile_List)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_Header
            // 
            this.Pnl_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Pnl_Header.Controls.Add(this.btn_Back);
            this.Pnl_Header.Controls.Add(this.btn_Log_Out);
            this.Pnl_Header.Controls.Add(this.lbl_View_Mobile_List);
            this.Pnl_Header.Location = new System.Drawing.Point(1, 0);
            this.Pnl_Header.Name = "Pnl_Header";
            this.Pnl_Header.Size = new System.Drawing.Size(1299, 106);
            this.Pnl_Header.TabIndex = 40;
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.White;
            this.btn_Back.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.Red;
            this.btn_Back.Location = new System.Drawing.Point(3, 3);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(151, 48);
            this.btn_Back.TabIndex = 1;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.BackColor = System.Drawing.Color.White;
            this.btn_Log_Out.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log_Out.ForeColor = System.Drawing.Color.Red;
            this.btn_Log_Out.Location = new System.Drawing.Point(1145, 3);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(151, 48);
            this.btn_Log_Out.TabIndex = 2;
            this.btn_Log_Out.Text = "Log Out";
            this.btn_Log_Out.UseVisualStyleBackColor = false;
            this.btn_Log_Out.Click += new System.EventHandler(this.btn_Log_Out_Click);
            // 
            // lbl_View_Mobile_List
            // 
            this.lbl_View_Mobile_List.AutoSize = true;
            this.lbl_View_Mobile_List.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_View_Mobile_List.Font = new System.Drawing.Font("Copperplate Gothic Bold", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_View_Mobile_List.Location = new System.Drawing.Point(341, 20);
            this.lbl_View_Mobile_List.Name = "lbl_View_Mobile_List";
            this.lbl_View_Mobile_List.Size = new System.Drawing.Size(659, 75);
            this.lbl_View_Mobile_List.TabIndex = 0;
            this.lbl_View_Mobile_List.Text = "View Mobile List";
            // 
            // dgv_Mobile_List
            // 
            this.dgv_Mobile_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Mobile_List.Location = new System.Drawing.Point(12, 120);
            this.dgv_Mobile_List.Name = "dgv_Mobile_List";
            this.dgv_Mobile_List.RowHeadersWidth = 51;
            this.dgv_Mobile_List.RowTemplate.Height = 24;
            this.dgv_Mobile_List.Size = new System.Drawing.Size(1272, 571);
            this.dgv_Mobile_List.TabIndex = 41;
            // 
            // Frm_View_Mobile_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1296, 703);
            this.Controls.Add(this.dgv_Mobile_List);
            this.Controls.Add(this.Pnl_Header);
            this.Name = "Frm_View_Mobile_List";
            this.Text = "Frm_View_Mobile_List";
            this.Load += new System.EventHandler(this.Frm_View_Mobile_List_Load);
            this.Pnl_Header.ResumeLayout(false);
            this.Pnl_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Mobile_List)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Header;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Log_Out;
        private System.Windows.Forms.Label lbl_View_Mobile_List;
        private System.Windows.Forms.DataGridView dgv_Mobile_List;
    }
}