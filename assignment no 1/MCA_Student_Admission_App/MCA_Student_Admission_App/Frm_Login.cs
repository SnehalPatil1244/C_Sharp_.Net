using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCA_Student_Admission_App
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }



        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if ((tb_Username.Text == "Admin" && tb_Password.Text == "123") || (tb_Username.Text == "s" && tb_Password.Text == "s"))


            {
                Frm_Add_New_Student obj = new Frm_Add_New_Student();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Credentials", "LOGIN FAILED", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tb_Username.Clear();
            tb_Password.Clear();

            tb_Username.Focus();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
