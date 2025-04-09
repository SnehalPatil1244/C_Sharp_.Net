
namespace Royal_Gym_App.Windows_Form.Packages.Member_Package
{
    partial class View_Member_Package_Details
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
            this.lbl_Member_package_List = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.dgv_View_Member_Package = new System.Windows.Forms.DataGridView();
            this.lbl_Member_Type = new System.Windows.Forms.Label();
            this.cmb_Member_Type = new System.Windows.Forms.ComboBox();
            this.Pnl_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Member_Package)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_Header
            // 
            this.Pnl_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Pnl_Header.Controls.Add(this.lbl_Member_package_List);
            this.Pnl_Header.Location = new System.Drawing.Point(12, 12);
            this.Pnl_Header.Name = "Pnl_Header";
            this.Pnl_Header.Size = new System.Drawing.Size(1242, 100);
            this.Pnl_Header.TabIndex = 42;
            // 
            // lbl_Member_package_List
            // 
            this.lbl_Member_package_List.AutoSize = true;
            this.lbl_Member_package_List.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbl_Member_package_List.Font = new System.Drawing.Font("Copperplate Gothic Bold", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Member_package_List.Location = new System.Drawing.Point(227, 10);
            this.lbl_Member_package_List.Name = "lbl_Member_package_List";
            this.lbl_Member_package_List.Size = new System.Drawing.Size(843, 75);
            this.lbl_Member_package_List.TabIndex = 0;
            this.lbl_Member_package_List.Text = "Member package List";
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
            this.btn_Refresh.Location = new System.Drawing.Point(360, 722);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(154, 50);
            this.btn_Refresh.TabIndex = 44;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            // 
            // dgv_View_Member_Package
            // 
            this.dgv_View_Member_Package.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_View_Member_Package.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View_Member_Package.Location = new System.Drawing.Point(12, 263);
            this.dgv_View_Member_Package.Name = "dgv_View_Member_Package";
            this.dgv_View_Member_Package.RowHeadersWidth = 51;
            this.dgv_View_Member_Package.RowTemplate.Height = 24;
            this.dgv_View_Member_Package.Size = new System.Drawing.Size(1242, 423);
            this.dgv_View_Member_Package.TabIndex = 43;
            // 
            // lbl_Member_Type
            // 
            this.lbl_Member_Type.AutoSize = true;
            this.lbl_Member_Type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl_Member_Type.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Member_Type.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Member_Type.Location = new System.Drawing.Point(309, 187);
            this.lbl_Member_Type.Name = "lbl_Member_Type";
            this.lbl_Member_Type.Size = new System.Drawing.Size(182, 34);
            this.lbl_Member_Type.TabIndex = 48;
            this.lbl_Member_Type.Text = "Member Type";
            // 
            // cmb_Member_Type
            // 
            this.cmb_Member_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Member_Type.FormattingEnabled = true;
            this.cmb_Member_Type.Location = new System.Drawing.Point(725, 188);
            this.cmb_Member_Type.Name = "cmb_Member_Type";
            this.cmb_Member_Type.Size = new System.Drawing.Size(247, 37);
            this.cmb_Member_Type.TabIndex = 49;
            // 
            // View_Member_Package_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1275, 828);
            this.Controls.Add(this.cmb_Member_Type);
            this.Controls.Add(this.lbl_Member_Type);
            this.Controls.Add(this.Pnl_Header);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.dgv_View_Member_Package);
            this.Name = "View_Member_Package_Details";
            this.Text = "View Member Package";
            this.Pnl_Header.ResumeLayout(false);
            this.Pnl_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Member_Package)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Header;
        private System.Windows.Forms.Label lbl_Member_package_List;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.DataGridView dgv_View_Member_Package;
        private System.Windows.Forms.Label lbl_Member_Type;
        private System.Windows.Forms.ComboBox cmb_Member_Type;
    }
}