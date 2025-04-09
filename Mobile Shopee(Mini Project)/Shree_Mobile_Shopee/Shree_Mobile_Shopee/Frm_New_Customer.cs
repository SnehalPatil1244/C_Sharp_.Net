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
    public partial class Frm_New_Customer : Form
    {
        public Frm_New_Customer()
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

        void Clear_Controls()
        {
            tb_Customer_Id.Text = Convert.ToString(Auto_Incr());
            tb_Customer_Name.Clear();
            dtp_Bill_Date.ResetText();
            tb_Mobile_No.Clear();
            cmb_Product_Name.SelectedIndex = -1;
            tb_Price.Clear();
            tb_Quantity.Clear();
            tb_Total_Price.Clear();
            tb_Total_Bill.Clear();


            tb_Customer_Id.Focus();
        }

        private void Frm_New_Customer_Load(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (tb_Quantity.Text != "" && tb_Price.Text != "" && cmb_Product_Name.Text != "" && tb_Total_Price.Text != "")
            {
                dgv_New_Customer.Rows.Add(PCnt, cmb_Product_Name.Text, tb_Price.Text, tb_Quantity.Text, tb_Total_Price.Text);
                double Bill = Convert.ToDouble(tb_Total_Bill.Text) + Convert.ToDouble(tb_Total_Price.Text);

                tb_Total_Bill.Text = Convert.ToString(Bill);
            }
            tb_Total_Price.Clear();
            tb_Price.Clear();
            tb_Quantity.Clear();
            cmb_Product_Name.SelectedIndex = -1;

            PCnt++;


        }

        private void grpBox_Purchase_Details_Enter(object sender, EventArgs e)
        {

        }
    }
}
 