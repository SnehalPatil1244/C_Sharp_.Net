using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Details_Information_App
{
    public partial class Frm_Employee_Details_List : Form
    {
        public Frm_Employee_Details_List()
        {
            InitializeComponent();
        }

        private void btn_Add_New_Employee_Click(object sender, EventArgs e)
        {
            Frm_Add_Employee_Details Obj = new Frm_Add_Employee_Details();
            Obj.Show();
            this.Hide();
        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Are You Sure Do You Want To logOut???", "LOGGING OUT", MessageBoxButtons.YesNo);
            if (Res == DialogResult.Yes)
            {
                Frm_Login_Form Obj = new Frm_Login_Form();
                Obj.Show();
                this.Hide();
            }
        }

        private void Frm_Employee_Details_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employee_Details_Information_App_DBDataSet.Employee_Details' table. You can move, or remove it, as needed.
            this.employee_DetailsTableAdapter.Fill(this.employee_Details_Information_App_DBDataSet.Employee_Details);
            lbl_UName.Text = Shared_Content.UName;
           
        }
    }
}