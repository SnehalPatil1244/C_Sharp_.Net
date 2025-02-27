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

namespace Student_Information_Details_App
{
    public partial class Frm_Login_Form : Form
    {
        public Frm_Login_Form()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=ADMIN;Initial Catalog=Student_Information_Details_App;Integrated Security=True;Pooling=False");
        void Con_Open()
        {
            if(Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
        }

        void Con_Close()
        {
            if (Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }


        private void btn_Submit_Click(object sender, EventArgs e)
        {
            Con_Open();

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;
            Cmd.CommandText = "Select Count (*) From Login_Details where username = @Unm And Password = @Pwd";


            Cmd.Parameters.Add("Unm", SqlDbType.VarChar).Value = tb_Username.Text;
            Cmd.Parameters.Add("Pwd", SqlDbType.NVarChar).Value = tb_Password.Text;

            int Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            if (Cnt > 0)
            {
                MessageBox.Show("Login Successful", "WELCOME", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Shared_Content.UName = "Welcome" + tb_Username.Text;

                Frm_Add_Student_Details Obj = new Frm_Add_Student_Details();
                Obj.Show();
                this.Hide();
            }
            else
            {
                lbl_Note.Text = "Invalid Credentials, Enter Correct Details";
                lbl_Note.ForeColor = Color.Red;
            }

            tb_Username.Clear();
            tb_Password.Clear();

            tb_Password.Enabled = false;
            btn_Submit.Enabled = false;

            tb_Username.Focus();
            Con_Close();

        }

        private void tb_Username_TextChanged(object sender, EventArgs e)
        {
            tb_Password.Enabled = true;
            lbl_Note.Visible = true;
        }

        private void tb_Password_TextChanged(object sender, EventArgs e)
        {
            btn_Submit.Enabled = true;
        }
    }
}
