using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCA_Student_Admission_App
{
    public partial class Frm_Add_New_Student : Form
    {
        public Frm_Add_New_Student()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=ADMIN;Initial Catalog=MCA_Student_Admission_App_DB;Integrated Security=True;Pooling=False");
        void Con_Open()


        {
            if(Con.State !=ConnectionState.Open)
            {
                Con.Open();
            }
        }

        void Con_Close()
        {
            if(Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }
        void Clear_Controls()
        {
            tb_Roll_No.Clear();
            tb_Name.Clear();
            tb_Mob_No.Clear();
            dtp_DOB.ResetText();
            cmb_Course.SelectedIndex = 1;

            tb_Roll_No.Focus();
            
        }

        private void Frm_Add_New_Student_Load(object sender, EventArgs e)
        {
            tb_Roll_No.Focus();
            cmb_Course.SelectedIndex = 1;

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Roll_No.Text != "" && tb_Name.Text != "" && tb_Mob_No.Text != "" && cmb_Course.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;
                Cmd.CommandText = "Insert Into Student_Details Values(@RNo, @Nm, @MobNo, @Dob, @Course)";

                Cmd.Parameters.Add("RNo", SqlDbType.Int).Value = tb_Roll_No.Text;
                Cmd.Parameters.Add("NM", SqlDbType.VarChar).Value = tb_Name.Text;

                Cmd.Parameters.Add("MobNo", SqlDbType.Decimal).Value = tb_Mob_No.Text;

                Cmd.Parameters.Add("Dob", SqlDbType.Date).Value = dtp_DOB.Text;

                Cmd.Parameters.Add("Course", SqlDbType.NVarChar).Value = cmb_Course.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Saved Successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Controls();
            }
            else
            {
                MessageBox.Show("Incomplete Info.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Con_Close();

        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            Frm_Login obj = new Frm_Login();
            obj.Show();
            this.Hide();
        }

        private void btn_Student_List_Click(object sender, EventArgs e)
        {
            Frm_Student_List obj = new Frm_Student_List();
            obj.Show();
            this.Hide();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

