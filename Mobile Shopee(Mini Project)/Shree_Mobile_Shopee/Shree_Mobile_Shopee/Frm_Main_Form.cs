using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shree_Mobile_Shopee
{
    public partial class Frm_Main_Form : Form
    {
        public Frm_Main_Form()
        {
            InitializeComponent();
        }

        private void btn_Mobiles_Click(object sender, EventArgs e)
        {
            Frm_Mobile_Form obj = new Frm_Mobile_Form();
            obj.Show();
            this.Hide();

        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            Frm_Customer_Form obj = new Frm_Customer_Form();
            obj.Show();
            this.Hide();
        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Are You Sure You Want To Log Out ?", "LogOut", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(Result  == DialogResult.Yes)
            {
                Frm_Login_Form obj = new Frm_Login_Form();
                obj.Show();
                this.Hide();

            }
                 
        }
    }
}
