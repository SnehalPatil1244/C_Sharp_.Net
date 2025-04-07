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

        }
    }
}
