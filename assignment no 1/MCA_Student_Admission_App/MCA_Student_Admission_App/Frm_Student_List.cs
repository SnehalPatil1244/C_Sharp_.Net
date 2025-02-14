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
    public partial class Frm_Student_List : Form
    {
        public Frm_Student_List()
        {
            InitializeComponent();
        }

        private void btn_Add_New_Student_Click(object sender, EventArgs e)
        {

            Frm_Add_New_Student obj = new Frm_Add_New_Student();
            obj.Show();
            this.Hide();
        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            Frm_Login obj = new Frm_Login();
            obj.Show();
            this.Hide();
        }

        private void Frm_Student_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mCA_Student_Admission_App_DBDataSet1.Student_Details' table. You can move, or remove it, as needed.
            this.student_DetailsTableAdapter.Fill(this.mCA_Student_Admission_App_DBDataSet1.Student_Details);

        }
    }
}
