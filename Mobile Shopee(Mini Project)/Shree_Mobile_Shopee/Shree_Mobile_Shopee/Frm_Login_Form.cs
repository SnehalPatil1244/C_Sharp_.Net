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

namespace Shree_Mobile_Shopee
{
    public partial class Frm_Login_Form : Form
    {
        public Frm_Login_Form()
        {
            InitializeComponent();

        }

        SqlConnection Con = new SqlConnection(@"Data Source=ADMIN;Initial Catalog=Shree_Mobile_Shopee_App_DB;Integrated Security=True;Pooling=False");

        void Con_Start()
        {
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
        }
        void Con_Stop()
        {
            if (Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }

            private void Btn_Submit_Click(object sender, EventArgs e)
        {
            Con_Start();
            int Cnt = 0;
            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;
            Cmd.CommandText = "Select Count(*)From Login_Details Where UserName = @unm And Password = @pwd";
            Cmd.Parameters.Add("@Unm", SqlDbType.NVarChar).Value = tb_UserName.Text;
            Cmd.Parameters.Add("@pwd", SqlDbType.NVarChar).Value = Tb_Password.Text;

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());
            if (Cnt > 0)
            {
                MessageBox.Show("Login Success", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Frm_Main_Form obj = new Frm_Main_Form();
                obj.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Login Failed", "Re-Enter Details", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            tb_UserName.Clear();
            Tb_Password.Clear();
            Tb_Password.Enabled = false;
            Btn_Submit.Enabled = false;

            Con_Stop();
         }

        private void text_Change(object sender, EventArgs e)
        {
            Tb_Password.Enabled = true;

        }

        private void Text_Changed(object sender, EventArgs e)
        {
            Btn_Submit.Enabled = true;

        }
    }
}
