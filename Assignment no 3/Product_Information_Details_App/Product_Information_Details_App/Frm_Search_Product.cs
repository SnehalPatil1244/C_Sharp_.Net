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
    public partial class Frm_Search_Product : Form
    {
        public Frm_Search_Product()
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
            tb_Product_Id.Text = Convert.ToString(Auto_Incr());
            tb_Product_Name.Clear();
            dtp_Packing_Date.ResetText();
            dtp_Expiry_Date.ResetText();
            tb_Price.Clear();

            tb_Product_Name.Focus();
        }

        int Auto_Incr()
        {
            int Cnt = 0;
            Con_Open();
            SqlCommand Cmd1 = new SqlCommand();
            Cmd1.Connection = Con;
            Cmd1.CommandText = "Select Count(*) from Add_Product_Details";

            Cnt = Convert.ToInt32(Cmd1.ExecuteScalar());

            Cmd1.Dispose();

            if (Cnt > 0)
            {
                Cmd1.Connection = Con;
                Cmd1.CommandText = "Select Max(Product_Id) from Add_Product_Details";

                Cnt = Convert.ToInt32(Cmd1.ExecuteScalar());
            }
            else
            {
                Cnt = 100;
            }
            Con_Close();
            return Cnt + 1;
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

        

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Con;
            cmd.CommandText = "Select * From Add_Product_Details where Product_Id = @PId";

            cmd.Parameters.Add("PId", SqlDbType.Int).Value = tb_Product_Id.Text;

            SqlDataReader Dr = cmd.ExecuteReader();

            if (Dr.Read())
            {
                tb_Product_Name.Text = Dr.GetString(Dr.GetOrdinal("Product_Name"));
                dtp_Packing_Date.Text = (Dr["Packing_Date"].ToString());
                dtp_Expiry_Date.Text = (Dr["Expiry_Date"].ToString());
                tb_Price.Text = (Dr["Price"].ToString());
            }
            else
            {
                MessageBox.Show("Invalid Product Id", "NO PRODUCT FIND", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_Product_Id.Clear();
            }
            Con_Close();

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Add_Product_Click(object sender, EventArgs e)
        {
            Frm_Add_Product_Details Obj = new Frm_Add_Product_Details();
            Obj.Show();
            this.Hide();
        }

        private void btn_Product_List_Click(object sender, EventArgs e)
        {
            Frm_Product_List Obj = new Frm_Product_List();
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

    }
}
