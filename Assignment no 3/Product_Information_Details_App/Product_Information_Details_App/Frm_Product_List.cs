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

namespace Product_Information_Details_App
{
    public partial class Frm_Product_List : Form
    {
        public Frm_Product_List()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=ADMIN;Initial Catalog=Product_Information_Details_App_DB;Integrated Security=True;Pooling=False");

        void Con_Open()
        {
            if (Con.State != ConnectionState.Open)
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


        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Are You Sure Do You Want To LogOut??", "LOGGING OUT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Res == DialogResult.Yes)
            {
                Frm_Login_Form Obj = new Frm_Login_Form();
                Obj.Show();
                this.Hide();
            }
        }

        private void btn_Product_Search_Click(object sender, EventArgs e)
        {
            Frm_Search_Product Obj = new Frm_Search_Product();
            Obj.Show();
            this.Hide();
        }

        private void btn_Add_Product_Click(object sender, EventArgs e)
        {
            Frm_Add_Product_Details Obj = new Frm_Add_Product_Details();
            Obj.Show();
            this.Hide();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Are You Sure  Do You Want To Close This App??", "CLOSING", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Res == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Frm_Product_List_Load(object sender, EventArgs e)
        {
            lbl_UName.Text = Shared_Content.UName;
            Con_Open();
            dgv_Product_List.DataSource = "";
            SqlDataAdapter SDA = new SqlDataAdapter("Select * from Add_Product_Details", Con);

            DataTable dt = new DataTable();
            SDA.Fill(dt);

            dgv_Product_List.DataSource = dt;
            Con_Close();
        }

        
    }
}
