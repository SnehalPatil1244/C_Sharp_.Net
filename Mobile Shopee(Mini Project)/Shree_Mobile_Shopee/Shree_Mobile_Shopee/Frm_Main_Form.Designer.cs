
namespace Shree_Mobile_Shopee
{
    partial class Frm_Main_Form
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
            this.lbl_Shree_Mobile_Shopee = new System.Windows.Forms.Label();
            this.btn_Mobiles = new System.Windows.Forms.Button();
            this.btn_Customer = new System.Windows.Forms.Button();
            this.picBox_Customer = new System.Windows.Forms.PictureBox();
            this.picBox_Mobile = new System.Windows.Forms.PictureBox();
            this.Pnl_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Customer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Mobile)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_Header
            // 
            this.Pnl_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Pnl_Header.Controls.Add(this.btn_Log_Out);
            this.Pnl_Header.Controls.Add(this.lbl_Shree_Mobile_Shopee);
            this.Pnl_Header.Location = new System.Drawing.Point(1, 0);
            this.Pnl_Header.Name = "Pnl_Header";
            this.Pnl_Header.Size = new System.Drawing.Size(1299, 103);
            this.Pnl_Header.TabIndex = 19;
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.BackColor = System.Drawing.Color.White;
            this.btn_Log_Out.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log_Out.ForeColor = System.Drawing.Color.Red;
            this.btn_Log_Out.Location = new System.Drawing.Point(1145, 3);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(151, 48);
            this.btn_Log_Out.TabIndex = 3;
            this.btn_Log_Out.Text = "Log Out";
            this.btn_Log_Out.UseVisualStyleBackColor = false;
            this.btn_Log_Out.Click += new System.EventHandler(this.btn_Log_Out_Click);
            // 
            // lbl_Shree_Mobile_Shopee
            // 
            this.lbl_Shree_Mobile_Shopee.AutoSize = true;
            this.lbl_Shree_Mobile_Shopee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_Shree_Mobile_Shopee.Font = new System.Drawing.Font("Copperplate Gothic Bold", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Shree_Mobile_Shopee.Location = new System.Drawing.Point(235, 12);
            this.lbl_Shree_Mobile_Shopee.Name = "lbl_Shree_Mobile_Shopee";
            this.lbl_Shree_Mobile_Shopee.Size = new System.Drawing.Size(840, 75);
            this.lbl_Shree_Mobile_Shopee.TabIndex = 0;
            this.lbl_Shree_Mobile_Shopee.Text = "Shree Mobile Shopee";
            // 
            // btn_Mobiles
            // 
            this.btn_Mobiles.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Mobiles.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Mobiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Mobiles.Location = new System.Drawing.Point(233, 643);
            this.btn_Mobiles.Name = "btn_Mobiles";
            this.btn_Mobiles.Size = new System.Drawing.Size(183, 48);
            this.btn_Mobiles.TabIndex = 1;
            this.btn_Mobiles.Text = "Mobiles";
            this.btn_Mobiles.UseVisualStyleBackColor = false;
            this.btn_Mobiles.Click += new System.EventHandler(this.btn_Mobiles_Click);
            // 
            // btn_Customer
            // 
            this.btn_Customer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Customer.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Customer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Customer.Location = new System.Drawing.Point(872, 643);
            this.btn_Customer.Name = "btn_Customer";
            this.btn_Customer.Size = new System.Drawing.Size(185, 53);
            this.btn_Customer.TabIndex = 2;
            this.btn_Customer.Text = "Customer";
            this.btn_Customer.UseVisualStyleBackColor = false;
            this.btn_Customer.Click += new System.EventHandler(this.btn_Customer_Click);
            // 
            // picBox_Customer
            // 
            this.picBox_Customer.Image = global::Shree_Mobile_Shopee.Properties.Resources.cust;
            this.picBox_Customer.Location = new System.Drawing.Point(653, 98);
            this.picBox_Customer.Name = "picBox_Customer";
            this.picBox_Customer.Size = new System.Drawing.Size(644, 529);
            this.picBox_Customer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_Customer.TabIndex = 21;
            this.picBox_Customer.TabStop = false;
            // 
            // picBox_Mobile
            // 
            this.picBox_Mobile.Image = global::Shree_Mobile_Shopee.Properties.Resources.mobile_img;
            this.picBox_Mobile.Location = new System.Drawing.Point(1, 98);
            this.picBox_Mobile.Name = "picBox_Mobile";
            this.picBox_Mobile.Size = new System.Drawing.Size(653, 529);
            this.picBox_Mobile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_Mobile.TabIndex = 20;
            this.picBox_Mobile.TabStop = false;
            // 
            // Frm_Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1296, 703);
            this.Controls.Add(this.btn_Customer);
            this.Controls.Add(this.btn_Mobiles);
            this.Controls.Add(this.picBox_Customer);
            this.Controls.Add(this.picBox_Mobile);
            this.Controls.Add(this.Pnl_Header);
            this.Name = "Frm_Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Main_Form";
            this.Pnl_Header.ResumeLayout(false);
            this.Pnl_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Customer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Mobile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Header;
        private System.Windows.Forms.Label lbl_Shree_Mobile_Shopee;
        private System.Windows.Forms.PictureBox picBox_Mobile;
        private System.Windows.Forms.PictureBox picBox_Customer;
        private System.Windows.Forms.Button btn_Mobiles;
        private System.Windows.Forms.Button btn_Customer;
        private System.Windows.Forms.Button btn_Log_Out;
    }
}