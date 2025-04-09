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
    public partial class Frm_View_Mobile_List : Form
    {
        public Frm_View_Mobile_List()
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


        private void Frm_View_Mobile_List_Load(object sender, EventArgs e)
        {
            Con_Start();

            dgv_Mobile_List.DataSource = "";
            SqlDataAdapter SDA = new SqlDataAdapter("Select * From Product_Details", Con);

            DataTable dt = new DataTable();
            SDA.Fill(dt);

            dgv_Mobile_List.DataSource = dt;

            Con_Stop();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Frm_Mobile_Form obj = new Frm_Mobile_Form();
            obj.Show();
            this.Hide();
        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("You Want To LogOut??", "LOGGING OUT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Res == DialogResult.Yes)
            {
                Frm_Login_Form Obj = new Frm_Login_Form();
                Obj.Show();
                this.Hide();
            }
        }

    }
}
