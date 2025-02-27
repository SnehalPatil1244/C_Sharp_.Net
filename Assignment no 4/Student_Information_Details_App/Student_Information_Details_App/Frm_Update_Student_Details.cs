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
    public partial class Frm_Update_Student_Details : Form
    {
        public Frm_Update_Student_Details()
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
            {
                Con.Close();
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
        void Control_Enable()
        {
            tb_Name.Enabled = true;
            tb_Mob_No.Enabled = true;
            dtp__D_O_B.Enabled = true;
            cmb_Course.Enabled = true;
            tb_Roll_No.Enabled = false;
        }
        void Control_Disable()
        {
            tb_Name.Enabled = false;
            tb_Mob_No.Enabled = false;
            dtp__D_O_B.Enabled = false;
            cmb_Course.Enabled = false;
            tb_Roll_No.Enabled = true;
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
            if (Res == DialogResult.Yes)
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
            if (Res == DialogResult.Yes)
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
            Control_Enable();


            Con_Close();

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Con_Open();
            if (tb_Name.Text != "" && tb_Mob_No.Text != "" && cmb_Course.Text != "")
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;

                cmd.CommandText = "Update Add_Student_Details Set Name = @Nm,D_O_B = @Dob,Mob_No = @Mob_No,Course = @Course where Roll_No = @RNo";
                cmd.Parameters.Add("RNo", SqlDbType.Int).Value = tb_Roll_No.Text;
                cmd.Parameters.Add("Nm", SqlDbType.VarChar).Value = tb_Name.Text;
                cmd.Parameters.Add("Dob", SqlDbType.Date).Value = dtp__D_O_B.Value.Date;
                cmd.Parameters.Add("Mob_No", SqlDbType.Decimal).Value = tb_Mob_No.Text;
                cmd.Parameters.Add("Course", SqlDbType.NVarChar).Value = cmb_Course.Text;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Update Successfully!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();
                Control_Disable();
            }
            else
            {
                MessageBox.Show("1 st Fill All Fields", "Incomplete Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            Con_Close();
            }

        private void btn_Add_New_Student_Click(object sender, EventArgs e)
        {
            Frm_Add_Student_Details obj = new Frm_Add_Student_Details();
            obj.Show();
            this.Hide();
        }

        private void btn_Search_Student_Click(object sender, EventArgs e)
        {
            Frm_Search_Student_Details obj = new Frm_Search_Student_Details();
            obj.Show();
            this.Hide();
        }

        private void btn_Student_List_Click(object sender, EventArgs e)
        {
            Frm_Student_List obj = new Frm_Student_List();
            obj.Show();
            this.Hide();
        }
    }
    }
    

