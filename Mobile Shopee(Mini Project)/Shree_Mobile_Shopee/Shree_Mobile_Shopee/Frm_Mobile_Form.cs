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
    public partial class Frm_Mobile_Form : Form
    {
        public Frm_Mobile_Form()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Frm_Main_Form obj = new Frm_Main_Form();
            obj.Show();
            this.Hide();
        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("You Want To LogOut??", "LOGGING OUT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(res == DialogResult.Yes)
            {
                Frm_Login_Form obj = new Frm_Login_Form();
                obj.Show();
                this.Hide();
            }


        }

        private void btn_Add_New_Mobile_Click(object sender, EventArgs e)
        {
            Frm_New_Mobile obj = new Frm_New_Mobile();
            obj.Show();
            this.Hide();

        }

        private void btn_Update_Mobile_Click(object sender, EventArgs e)
        {
            Frm_Update_Product obj = new Frm_Update_Product();
            obj.Show();
            this.Hide();
        }

        private void btn_View_Mobile_List_Click(object sender, EventArgs e)
        {
            Frm_View_Mobile_List obj = new Frm_View_Mobile_List();
            obj.Show();
            this.Hide();
        }
    }
}
