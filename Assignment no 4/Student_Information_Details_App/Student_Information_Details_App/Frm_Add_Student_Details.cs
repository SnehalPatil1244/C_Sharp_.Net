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
    public partial class Frm_Add_Student_Details : Form
    {
        public Frm_Add_Student_Details()
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
            if(Con.State != ConnectionState.Closed)
            {
                Con.Close();
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
            tb_Roll_No.Text = Convert.ToString(Auto_Incr());
            tb_Name.Clear();
            tb_Mob_No.Clear();
            dtp_DOB.ResetText();
            cmb_Course.ResetText();

            tb_Name.Focus();
        }

        int Auto_Incr()
        {
            int Cnt = 0;
            Con_Open();
            SqlCommand Cmd1 = new SqlCommand();

            Cmd1.Connection = Con;
            Cmd1.CommandText = "Select Count(*) From Add_Student_Details";

            Cnt = Convert.ToInt32(Cmd1.ExecuteScalar());
            Cmd1.Dispose();

            if (Cnt > 0)
            {
                Cmd1.Connection = Con;
                Cmd1.CommandText = "Select Max(Roll_No) from Add_Student_Details";

                Cnt = Convert.ToInt32(Cmd1.ExecuteScalar());
            }
            else
            {
                Cnt = 100;
            }

            Con_Close();

            return Cnt + 1;
        }

        private void Frm_Add_Student_Details_Load(object sender, EventArgs e)
        {
            lbl_UName.Text = Shared_Content.UName;
            tb_Roll_No.Text = Convert.ToString(Auto_Incr());

            tb_Roll_No.Focus();
            cmb_Course.SelectedIndex = 1;
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Roll_No.Text != "" && tb_Name.Text != "" && tb_Mob_No.Text != "" && cmb_Course.Text != "")
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;
                cmd.CommandText = "Insert Into Add_Student_Details values(@RNo , @Nm , @MobNo, @Dob, @Course)";

                cmd.Parameters.Add("RNo", SqlDbType.Int).Value = tb_Roll_No.Text;
                cmd.Parameters.Add("Nm", SqlDbType.VarChar).Value = tb_Name.Text;
                cmd.Parameters.Add("MobNo", SqlDbType.Decimal).Value = tb_Mob_No.Text;
                cmd.Parameters.Add("Dob", SqlDbType.Date).Value = dtp_DOB.Text;
                cmd.Parameters.Add("Course", SqlDbType.NVarChar).Value = cmb_Course.Text;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Saved Successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();
            }
            else
            {
                MessageBox.Show("Incomplete Info.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Con_Close();
        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Are You Sure Do You Want To LogOut???", "LOGGING OUT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Res == DialogResult.Yes)
            {
                Frm_Login_Form Obj = new Frm_Login_Form();
                Obj.Show();
                this.Hide();
            }

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Are you Sure Do You Want To Close This App???", "CLOSING", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if ( Res == DialogResult.Yes)
            {
                this.Close();
            }

        }
    }
}
