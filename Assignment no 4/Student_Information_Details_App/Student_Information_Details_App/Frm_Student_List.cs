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
    public partial class Frm_Student_List : Form
    {
        public Frm_Student_List()
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


        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Are you Sure Do you want to Logout??", "LOGGING OUT", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if(Res == DialogResult.Yes)
            {
                Frm_Login_Form Obj = new Frm_Login_Form();
                Obj.Show();
                this.Hide();
            }
        }
        private void btn_Add_New_Student_Click(object sender, EventArgs e)
        {
            Frm_Add_Student_Details Obj = new Frm_Add_Student_Details();
            Obj.Show();
            this.Hide();
        }

        private void btn_Search_Student_Click(object sender, EventArgs e)
        {
            Frm_Add_Student_Details Obj = new Frm_Add_Student_Details();
            Obj.Show();
            this.Hide();

        }

        private void btn_Update_Student_Click(object sender, EventArgs e)
        {
            Frm_Update_Student_Details Obj = new Frm_Update_Student_Details();
            Obj.Show();
            this.Hide();
        }

        private void btn_Student_List_Click(object sender, EventArgs e)
        {
            Frm_Student_List Obj = new Frm_Student_List();
            Obj.Show();
            this.Hide();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Are You Sure Do You Want To Close This App??", "CLOSING", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if ( Res == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Frm_Student_List_Load(object sender, EventArgs e)
        {
            lbl_UName.Text = Shared_Content.UName;
            Con_Open(); 
            dgv_Student_List.DataSource = "";
            SqlDataAdapter SDA = new SqlDataAdapter("Select * From Add_Student_Details", Con);

            DataTable dt = new DataTable();
            SDA.Fill(dt);

            dgv_Student_List.DataSource = dt;
            Con_Close();
        }
    }
}
