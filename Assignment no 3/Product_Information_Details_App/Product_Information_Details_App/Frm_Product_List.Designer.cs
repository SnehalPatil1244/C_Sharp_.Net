
namespace Product_Information_Details_App
{
    partial class Frm_Product_List
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
            this.lbl_Header = new System.Windows.Forms.Label();
            this.dgv_Product_List = new System.Windows.Forms.DataGridView();
            this.btn_Product_Search = new System.Windows.Forms.Button();
            this.btn_Add_Product = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Log_Out = new System.Windows.Forms.Button();
            this.lbl_UName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product_List)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbl_Header.Font = new System.Drawing.Font("Californian FB", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Header.Location = new System.Drawing.Point(480, 33);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(368, 76);
            this.lbl_Header.TabIndex = 10;
            this.lbl_Header.Text = "Product List";
            // 
            // dgv_Product_List
            // 
            this.dgv_Product_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Product_List.Location = new System.Drawing.Point(12, 146);
            this.dgv_Product_List.Name = "dgv_Product_List";
            this.dgv_Product_List.RowHeadersWidth = 51;
            this.dgv_Product_List.RowTemplate.Height = 24;
            this.dgv_Product_List.Size = new System.Drawing.Size(1304, 479);
            this.dgv_Product_List.TabIndex = 1;
            
            // 
            // btn_Product_Search
            // 
            this.btn_Product_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Product_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Product_Search.ForeColor = System.Drawing.Color.Blue;
            this.btn_Product_Search.Location = new System.Drawing.Point(90, 670);
            this.btn_Product_Search.Name = "btn_Product_Search";
            this.btn_Product_Search.Size = new System.Drawing.Size(232, 47);
            this.btn_Product_Search.TabIndex = 3;
            this.btn_Product_Search.Text = "Product Search";
            this.btn_Product_Search.UseVisualStyleBackColor = false;
            this.btn_Product_Search.Click += new System.EventHandler(this.btn_Product_Search_Click);
            // 
            // btn_Add_Product
            // 
            this.btn_Add_Product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Add_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Product.ForeColor = System.Drawing.Color.Blue;
            this.btn_Add_Product.Location = new System.Drawing.Point(506, 670);
            this.btn_Add_Product.Name = "btn_Add_Product";
            this.btn_Add_Product.Size = new System.Drawing.Size(232, 47);
            this.btn_Add_Product.TabIndex = 2;
            this.btn_Add_Product.Text = "Add Product";
            this.btn_Add_Product.UseVisualStyleBackColor = false;
            this.btn_Add_Product.Click += new System.EventHandler(this.btn_Add_Product_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.Blue;
            this.btn_Close.Location = new System.Drawing.Point(977, 670);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(202, 47);
            this.btn_Close.TabIndex = 4;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.BackColor = System.Drawing.Color.White;
            this.btn_Log_Out.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log_Out.ForeColor = System.Drawing.Color.Red;
            this.btn_Log_Out.Location = new System.Drawing.Point(1157, 33);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(139, 43);
            this.btn_Log_Out.TabIndex = 5;
            this.btn_Log_Out.Text = "Log Out";
            this.btn_Log_Out.UseVisualStyleBackColor = false;
            this.btn_Log_Out.Click += new System.EventHandler(this.btn_Log_Out_Click);
            // 
            // lbl_UName
            // 
            this.lbl_UName.AutoSize = true;
            this.lbl_UName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UName.ForeColor = System.Drawing.Color.Fuchsia;
            this.lbl_UName.Location = new System.Drawing.Point(12, 18);
            this.lbl_UName.Name = "lbl_UName";
            this.lbl_UName.Size = new System.Drawing.Size(114, 36);
            this.lbl_UName.TabIndex = 18;
            this.lbl_UName.Text = "UName";
            // 
            // Frm_Product_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1328, 758);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_UName);
            this.Controls.Add(this.btn_Log_Out);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Add_Product);
            this.Controls.Add(this.btn_Product_Search);
            this.Controls.Add(this.dgv_Product_List);
            this.Controls.Add(this.lbl_Header);
            this.Name = "Frm_Product_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product_List";
            this.Load += new System.EventHandler(this.Frm_Product_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product_List)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.DataGridView dgv_Product_List;
        private System.Windows.Forms.Button btn_Product_Search;
        private System.Windows.Forms.Button btn_Add_Product;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Log_Out;
        private System.Windows.Forms.Label lbl_UName;
    }
}