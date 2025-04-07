
namespace Shree_Mobile_Shopee
{
    partial class Frm_Customer_Form
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
            this.btn_Log_Out = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Add_New_Customer = new System.Windows.Forms.Button();
            this.btn_Search_Customer = new System.Windows.Forms.Button();
            this.picBox_Customer_Form = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Customer_Form)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.BackColor = System.Drawing.Color.White;
            this.btn_Log_Out.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log_Out.ForeColor = System.Drawing.Color.Red;
            this.btn_Log_Out.Location = new System.Drawing.Point(1123, 26);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(151, 48);
            this.btn_Log_Out.TabIndex = 25;
            this.btn_Log_Out.Text = "Log Out";
            this.btn_Log_Out.UseVisualStyleBackColor = false;
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.White;
            this.btn_Back.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.Red;
            this.btn_Back.Location = new System.Drawing.Point(652, 26);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(151, 48);
            this.btn_Back.TabIndex = 26;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            // 
            // btn_Add_New_Customer
            // 
            this.btn_Add_New_Customer.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_New_Customer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Add_New_Customer.Location = new System.Drawing.Point(743, 224);
            this.btn_Add_New_Customer.Name = "btn_Add_New_Customer";
            this.btn_Add_New_Customer.Size = new System.Drawing.Size(429, 55);
            this.btn_Add_New_Customer.TabIndex = 27;
            this.btn_Add_New_Customer.Text = "Add New Customer";
            this.btn_Add_New_Customer.UseVisualStyleBackColor = true;
            // 
            // btn_Search_Customer
            // 
            this.btn_Search_Customer.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search_Customer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Search_Customer.Location = new System.Drawing.Point(757, 419);
            this.btn_Search_Customer.Name = "btn_Search_Customer";
            this.btn_Search_Customer.Size = new System.Drawing.Size(415, 55);
            this.btn_Search_Customer.TabIndex = 28;
            this.btn_Search_Customer.Text = "Search Customer";
            this.btn_Search_Customer.UseVisualStyleBackColor = true;
            // 
            // picBox_Customer_Form
            // 
            this.picBox_Customer_Form.BackColor = System.Drawing.Color.White;
            this.picBox_Customer_Form.Image = global::Shree_Mobile_Shopee.Properties.Resources.cust;
            this.picBox_Customer_Form.Location = new System.Drawing.Point(-2, 0);
            this.picBox_Customer_Form.Name = "picBox_Customer_Form";
            this.picBox_Customer_Form.Size = new System.Drawing.Size(631, 704);
            this.picBox_Customer_Form.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_Customer_Form.TabIndex = 0;
            this.picBox_Customer_Form.TabStop = false;
            // 
            // Frm_Customer_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1296, 703);
            this.Controls.Add(this.btn_Search_Customer);
            this.Controls.Add(this.btn_Add_New_Customer);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Log_Out);
            this.Controls.Add(this.picBox_Customer_Form);
            this.Name = "Frm_Customer_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Customer_Form";
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Customer_Form)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox_Customer_Form;
        private System.Windows.Forms.Button btn_Log_Out;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Add_New_Customer;
        private System.Windows.Forms.Button btn_Search_Customer;
    }
}