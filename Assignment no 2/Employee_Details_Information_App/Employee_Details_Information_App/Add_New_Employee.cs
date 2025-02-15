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

namespace Employee_Details_Information_App
{
    public partial class Frm_Add_Employee_Details : Form
    {
        public Frm_Add_Employee_Details()
        {
            InitializeComponent ();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=ADMIN;Initial Catalog=Employee_Details_Information_App_DB;Integrated Security=True;Pooling=False");

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


        private void Frm_Add_Employee_Details_Load(object sender, EventArgs e)
        {
            lbl_UName.Text = Shared_Content.UName;
            tb_Employee_Id.Text = Convert.ToString(Auto_Incr());

            tb_Employee_Id.Focus();
            cmb_Department.SelectedIndex = 1;
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

        private void Only_Number(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }


        }
        void Clear_Controls()
        {
            tb_Employee_Id.Text = Convert.ToString(Auto_Incr());
            tb_Employee_Name.Clear();
            tb_Mob_No.Clear();
            dtp_Joinning_Date.ResetText();
            cmb_Department.SelectedIndex = 1;

            tb_Employee_Name.Focus();

        }
        int Auto_Incr()
        {
            int Cnt = 0;
            Con_Open();
            SqlCommand Cmd1 = new SqlCommand();

            Cmd1.Connection = Con;
            Cmd1.CommandText = "Select Count(*) from Employee_Details";

            Cnt = Convert.ToInt32(Cmd1.ExecuteScalar());
            Cmd1.Dispose();

            if (Cnt > 0)
            {
                Cmd1.Connection = Con;
                Cmd1.CommandText = "Select Max(Employee_Id) from Employee_Details";

                Cnt = Convert.ToInt32(Cmd1.ExecuteScalar());
            }
            else
            {
                Cnt = 100;
            }

            Con_Close();
            return Cnt + 1;
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();
            if (tb_Employee_Id.Text != "" && tb_Employee_Name.Text !="" && tb_Mob_No.Text != ""  && cmb_Department.Text != "" && tb_Salary.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;
                Cmd.CommandText = "Insert Into Employee_Details Values(@Employee_Id,@Employee_Name,@Mob_No,@Joinning_Date,@Department,@Salary)";

                Cmd.Parameters.Add("Employee_Id", SqlDbType.Int).Value = tb_Employee_Id.Text;
                Cmd.Parameters.Add("Employee_Name", SqlDbType.VarChar).Value = tb_Employee_Name.Text;
                Cmd.Parameters.Add("Mob_No", SqlDbType.Decimal).Value = tb_Mob_No.Text;
                Cmd.Parameters.Add("Joinning_Date", SqlDbType.Date).Value = dtp_Joinning_Date.Text;
                Cmd.Parameters.Add("Department", SqlDbType.NVarChar).Value = cmb_Department.Text;
                Cmd.Parameters.Add("Salary", SqlDbType.Money).Value = tb_Salary.Text;

                Cmd.ExecuteNonQuery();
                MessageBox.Show("Record Saved Successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Controls();
            }
            else
            {
                MessageBox.Show("Incomplete Info.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clear_Controls();

            }
            Con.Close();
          
        }

        private void btn_Employee_List_Click(object sender, EventArgs e)
        {
            Frm_Employee_Details_List Obj = new Frm_Employee_Details_List();
            Obj.Show();
            this.Hide();

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Are You Sure Do You Want To Close This App???", "CLOSING", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Res == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Are You Sure Do You Want To LogOut??", "LOGGING OUT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Res == DialogResult.Yes)
            {
                Frm_Add_Employee_Details Obj = new Frm_Add_Employee_Details();
                Obj.Show();
                this.Hide();
            }
        }
    }
        
    }
    
    
    
    
    

