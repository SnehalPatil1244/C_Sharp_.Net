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
    public partial class Frm_New_Mobile : Form
    {
        public Frm_New_Mobile()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=ADMIN;Initial Catalog=Shree_Mobile_Shopee_App_DB;Integrated Security=True;Pooling=False");
        void Con_Start()
        {
            if(Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
        }
        void Con_Stop()
        {
            if(Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }


        private void Frm_New_Mobile_Load(object sender, EventArgs e)
        {
            tb_Mobile_Id.Text = Convert.ToString(Auto_Incr());
            tb_Mobile_Id.Focus();

        }
        void Clear_Controls()
        {
            tb_Mobile_Id.Text = Convert.ToString(Auto_Incr());
            tb_Mobile_Name.Clear();
            tb_Mobile_Brand.Clear();
            dtp_Date.ResetText();
            tb_Purchase_Rate.Clear();
            tb_Sale_Rate.Clear();

            tb_Mobile_Id.Focus();
        }
        int Auto_Incr()
        {
            Con_Start();
            int Cnt = 0;

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;
            Cmd.CommandText = "Select Count (*)From Product_Details";
            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());
            Cmd.Dispose();

            if(Cnt > 0)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = "select max(Mobile_Id) from Product_Details";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            }
            else
            {
                Cnt = 0;
            }

            tb_Mobile_Id.Text = Convert.ToString(Cnt);

            Con_Stop();

            return Cnt + 1;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Start();

            if (tb_Mobile_Id.Text != "" && tb_Mobile_Name.Text != "" && tb_Mobile_Brand.Text != "" && tb_Purchase_Rate.Text != "" && tb_Sale_Rate.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;
                Cmd.CommandText = "Insert Into Product_Details Values (@MId, @Name, @MBrand, @DT, @PPrice, @SPrice)";

                Cmd.Parameters.Add("MId", SqlDbType.Int).Value = tb_Mobile_Id.Text;
                Cmd.Parameters.Add("Name", SqlDbType.NVarChar).Value = tb_Mobile_Name.Text;
                Cmd.Parameters.Add("MBrand", SqlDbType.NVarChar).Value = tb_Mobile_Brand.Text;
                Cmd.Parameters.Add("DT", SqlDbType.Date).Value = dtp_Date.Text;
                Cmd.Parameters.Add("PPrice", SqlDbType.Money).Value = tb_Purchase_Rate.Text;
                Cmd.Parameters.Add("SPrice", SqlDbType.Money).Value = tb_Sale_Rate.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Saved Succesfully", "SAVED", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();


            }
            else
            {
                MessageBox.Show("Incomplet Data", "Error", MessageBoxButtons.OK);
                Clear_Controls();

            }


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
        
    



