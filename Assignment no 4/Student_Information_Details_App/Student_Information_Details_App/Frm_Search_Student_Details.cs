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
    public partial class Frm_Search_Student_Details : Form
    {
        public Frm_Search_Student_Details()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=ADMIN;Initial Catalog=Student_Information_Details_App;Integrated Security=True;Pooling=False");

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
            { Con.Close(); 
            }
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        void Clear_Controls()
        {
            tb_Roll_No.Clear();
            tb_Name.Clear();
            tb_Mob_No.Clear();
            dtp__D_O_B.ResetText();
            cmb_Course.ResetText();

            tb_Name.Focus();
        }

        
        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Are You Sure Do You Want  To LogOut??", "LOGGING OUT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if ( Res == DialogResult.Yes)
            {
                Frm_Login_Form Obj = new Frm_Login_Form();
                Obj.Show();
                this.Hide();
            }

        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Are You Sure Do You Want To Close This App??", "CLOGING", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if ( Res == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Con;
            cmd.CommandText = "Select * from Add_Student_Details where Roll_No = @RNo";

            cmd.Parameters.Add("RNo", SqlDbType.Int).Value = tb_Roll_No.Text;

            SqlDataReader Dr = cmd.ExecuteReader();

            if (Dr.Read())
            {
                tb_Name.Text = Dr.GetString(Dr.GetOrdinal("Name"));
                tb_Mob_No.Text = (Dr["Mob_No"].ToString());
                dtp__D_O_B.Text = (Dr["D_O_B"].ToString());
                cmb_Course.Text = (Dr["Course"].ToString());
            }
            else
            {
                MessageBox.Show("Invalid Roll_No", "NO ROLL NO FIND", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_Roll_No.Clear();
            }
            Con_Close();

        }


        private void btn_Add_New_Student_Click(object sender, EventArgs e)
        {
            Frm_Add_Student_Details Obj = new Frm_Add_Student_Details();
            Obj.Show();
            this.Hide();
        }

        private void btn_Search_Student_Click(object sender, EventArgs e)
        {
            Frm_Search_Student_Details Obj = new Frm_Search_Student_Details();
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

       
    }
}
