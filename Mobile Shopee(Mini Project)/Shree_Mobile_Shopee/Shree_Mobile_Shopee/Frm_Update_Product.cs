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
    public partial class Frm_Update_Product : Form
    {
        public Frm_Update_Product()
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

        void Control_Enable()
        {
            tb_Mobile_Name.Enabled = true;
            tb_Mobile_Brand.Enabled = true;
            dtp_Date.Enabled = true;
            tb_Purchase_Rate.Enabled = true;
            tb_Sale_Rate.Enabled = true;

            tb_Mobile_Id.Enabled = false;
        }
        void Control_Disable()
        {
            tb_Mobile_Name.Enabled = false;
            tb_Mobile_Brand.Enabled = false;
            dtp_Date.Enabled = false;
            tb_Purchase_Rate.Enabled = false;
            tb_Sale_Rate.Enabled = false;

            tb_Mobile_Id.Enabled = true;
        }

        void Clear_Controls()
        {
            tb_Mobile_Id.Clear();
            tb_Mobile_Name.Clear();
            tb_Mobile_Brand.Clear();
            dtp_Date.ResetText();
            tb_Purchase_Rate.Clear();
            tb_Sale_Rate.Clear();

            tb_Mobile_Id.Focus();
        }

        

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Start();

            if (tb_Mobile_Id.Text != "")
            {
                SqlCommand cmd = new SqlCommand("select * from Product_Details where Mobile_Id = " + tb_Mobile_Id.Text + "", Con);
                var obj = cmd.ExecuteReader();

                if (obj.Read())
                {
                    tb_Mobile_Name.Text = Convert.ToString(obj["Mobile_Name"].ToString());
                    tb_Mobile_Brand.Text = Convert.ToString(obj["Mobile_Brand"].ToString());
                    dtp_Date.Text = obj["Date"].ToString();
                    tb_Purchase_Rate.Text = (obj["Purchase_Rate"].ToString());
                    tb_Sale_Rate.Text = (obj["Sale_Rate"].ToString());

                    Control_Enable();
                }
                else
                {
                    MessageBox.Show("Invalid Roll No", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_Mobile_Id.Clear();
                    tb_Mobile_Id.Focus();

                }

            }
            else
            {
                MessageBox.Show("First Fill The Roll_NO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Con_Stop();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Con_Start();
            if (tb_Mobile_Id.Text != "" && tb_Mobile_Name.Text != "" && tb_Mobile_Brand.Text != "" && tb_Purchase_Rate.Text != "" && tb_Sale_Rate.Text != "")
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;

                cmd.CommandText = "Update Product_Details Set Mobile_Name=@Name, Mobile_Brand=@MBrand, Date=@DT, Purchase_Rate=@PPrice, Sale_Rate=@SPrice where Mobile_Id=@MId";

                cmd.Parameters.Add("MId", SqlDbType.Int).Value = tb_Mobile_Id.Text;
                cmd.Parameters.Add("Name", SqlDbType.NVarChar).Value = tb_Mobile_Name.Text;
                cmd.Parameters.Add("MBrand", SqlDbType.NVarChar).Value = tb_Mobile_Brand.Text;
                cmd.Parameters.Add("DT", SqlDbType.Date).Value = dtp_Date.Text;
                cmd.Parameters.Add("PPrice", SqlDbType.Money).Value = tb_Purchase_Rate.Text;
                cmd.Parameters.Add("SPrice", SqlDbType.Money).Value = tb_Sale_Rate.Text;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Update Successfully!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();
                Control_Disable();
                tb_Mobile_Id.Focus();
            }
            else
            {
                MessageBox.Show("1 st Fill All Fields", "Incomplete Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
