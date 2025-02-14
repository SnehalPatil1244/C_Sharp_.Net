
namespace MCA_Student_Admission_App
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
            this.components = new System.ComponentModel.Container();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.btn_Add_New_Student = new System.Windows.Forms.Button();
            this.btn_Log_Out = new System.Windows.Forms.Button();
            this.dgv_Student_List = new System.Windows.Forms.DataGridView();
            this.mCAStudentAdmissionAppDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mCA_Student_Admission_App_DBDataSet = new MCA_Student_Admission_App.MCA_Student_Admission_App_DBDataSet();
            this.mCA_Student_Admission_App_DBDataSet1 = new MCA_Student_Admission_App.MCA_Student_Admission_App_DBDataSet1();
            this.studentDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.student_DetailsTableAdapter = new MCA_Student_Admission_App.MCA_Student_Admission_App_DBDataSet1TableAdapters.Student_DetailsTableAdapter();
            this.rollNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Student_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mCAStudentAdmissionAppDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mCA_Student_Admission_App_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mCA_Student_Admission_App_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbl_Header.Font = new System.Drawing.Font("Californian FB", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Header.Location = new System.Drawing.Point(455, 34);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(377, 76);
            this.lbl_Header.TabIndex = 9;
            this.lbl_Header.Text = " Student List";
            // 
            // btn_Add_New_Student
            // 
            this.btn_Add_New_Student.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Add_New_Student.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_New_Student.ForeColor = System.Drawing.Color.Blue;
            this.btn_Add_New_Student.Location = new System.Drawing.Point(488, 647);
            this.btn_Add_New_Student.Name = "btn_Add_New_Student";
            this.btn_Add_New_Student.Size = new System.Drawing.Size(319, 56);
            this.btn_Add_New_Student.TabIndex = 10;
            this.btn_Add_New_Student.Text = "Add New Student";
            this.btn_Add_New_Student.UseVisualStyleBackColor = false;
            this.btn_Add_New_Student.Click += new System.EventHandler(this.btn_Add_New_Student_Click);
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.BackColor = System.Drawing.Color.White;
            this.btn_Log_Out.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log_Out.ForeColor = System.Drawing.Color.Red;
            this.btn_Log_Out.Location = new System.Drawing.Point(1132, 12);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(139, 43);
            this.btn_Log_Out.TabIndex = 11;
            this.btn_Log_Out.Text = "Log Out";
            this.btn_Log_Out.UseVisualStyleBackColor = false;
            this.btn_Log_Out.Click += new System.EventHandler(this.btn_Log_Out_Click);
            // 
            // dgv_Student_List
            // 
            this.dgv_Student_List.AllowUserToAddRows = false;
            this.dgv_Student_List.AllowUserToDeleteRows = false;
            this.dgv_Student_List.AutoGenerateColumns = false;
            this.dgv_Student_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Student_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Student_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rollNoDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.mobNoDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn});
            this.dgv_Student_List.DataSource = this.studentDetailsBindingSource;
            this.dgv_Student_List.Location = new System.Drawing.Point(32, 146);
            this.dgv_Student_List.Name = "dgv_Student_List";
            this.dgv_Student_List.ReadOnly = true;
            this.dgv_Student_List.RowHeadersWidth = 51;
            this.dgv_Student_List.RowTemplate.Height = 24;
            this.dgv_Student_List.Size = new System.Drawing.Size(1239, 446);
            this.dgv_Student_List.TabIndex = 12;
            // 
            // mCAStudentAdmissionAppDBDataSetBindingSource
            // 
            this.mCAStudentAdmissionAppDBDataSetBindingSource.DataSource = this.mCA_Student_Admission_App_DBDataSet;
            this.mCAStudentAdmissionAppDBDataSetBindingSource.Position = 0;
            // 
            // mCA_Student_Admission_App_DBDataSet
            // 
            this.mCA_Student_Admission_App_DBDataSet.DataSetName = "MCA_Student_Admission_App_DBDataSet";
            this.mCA_Student_Admission_App_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mCA_Student_Admission_App_DBDataSet1
            // 
            this.mCA_Student_Admission_App_DBDataSet1.DataSetName = "MCA_Student_Admission_App_DBDataSet1";
            this.mCA_Student_Admission_App_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentDetailsBindingSource
            // 
            this.studentDetailsBindingSource.DataMember = "Student_Details";
            this.studentDetailsBindingSource.DataSource = this.mCA_Student_Admission_App_DBDataSet1;
            // 
            // student_DetailsTableAdapter
            // 
            this.student_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // rollNoDataGridViewTextBoxColumn
            // 
            this.rollNoDataGridViewTextBoxColumn.DataPropertyName = "Roll_No";
            this.rollNoDataGridViewTextBoxColumn.HeaderText = "Roll_No";
            this.rollNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rollNoDataGridViewTextBoxColumn.Name = "rollNoDataGridViewTextBoxColumn";
            this.rollNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobNoDataGridViewTextBoxColumn
            // 
            this.mobNoDataGridViewTextBoxColumn.DataPropertyName = "Mob_No";
            this.mobNoDataGridViewTextBoxColumn.HeaderText = "Mob_No";
            this.mobNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mobNoDataGridViewTextBoxColumn.Name = "mobNoDataGridViewTextBoxColumn";
            this.mobNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "D_O_B";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "D_O_B";
            this.dOBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            this.dOBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "Course";
            this.courseDataGridViewTextBoxColumn.HeaderText = "Course";
            this.courseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            this.courseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Frm_Student_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 770);
            this.Controls.Add(this.dgv_Student_List);
            this.Controls.Add(this.btn_Log_Out);
            this.Controls.Add(this.btn_Add_New_Student);
            this.Controls.Add(this.lbl_Header);
            this.Name = "Frm_Student_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student List";
            this.Load += new System.EventHandler(this.Frm_Student_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Student_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mCAStudentAdmissionAppDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mCA_Student_Admission_App_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mCA_Student_Admission_App_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Button btn_Add_New_Student;
        private System.Windows.Forms.Button btn_Log_Out;
        private System.Windows.Forms.DataGridView dgv_Student_List;
        private System.Windows.Forms.BindingSource mCAStudentAdmissionAppDBDataSetBindingSource;
        private MCA_Student_Admission_App_DBDataSet mCA_Student_Admission_App_DBDataSet;
        private MCA_Student_Admission_App_DBDataSet1 mCA_Student_Admission_App_DBDataSet1;
        private System.Windows.Forms.BindingSource studentDetailsBindingSource;
        private MCA_Student_Admission_App_DBDataSet1TableAdapters.Student_DetailsTableAdapter student_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rollNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
    }
}