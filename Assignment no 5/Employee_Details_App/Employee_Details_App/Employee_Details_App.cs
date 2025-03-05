using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Details_App
{
    public partial class Employee_Details_App : Form
    {
        public Employee_Details_App()
        {
            InitializeComponent();
        }

        private void Employee_Details_App_Load(object sender, EventArgs e)
        {
            tb_Employee_Name.Focus();
        }

        private void only_Text(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsLetter(e.KeyChar)|| (e.KeyChar== (char)Keys.Back) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar == (char)Keys.ShiftKey) || (e.KeyChar == (char)Keys.CapsLock)))
            {
                e.Handled = true;
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            tb_Employee_Name.Text = "";
            cb_Employee_Department.SelectedIndex = -1;
            rb_Male.Checked = false;
            rb_Female.Checked = false;
            rb_Morning.Checked = false;
            rb_Evening.Checked = false;
            rb_Night.Checked = false;
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string Result = "";
            bool flag = false;

            if(tb_Employee_Name.Text!="")
            {
                Result = tb_Employee_Name.Text;

                if(cb_Employee_Department.Text != "")
                {
                    Result += " Form Department " + cb_Employee_Department.Text + " is ";

                    if(rb_Male.Checked == true)
                    {
                        Result += rb_Male.Text + " Canditates prefers shift timing";
                    }
                    else if(rb_Female.Checked == true)
                    {
                        Result += rb_Female.Text + " candidates prefers shift timing ";
                    }
                    else
                    {
                        MessageBox.Show(" Select Gender of employee");
                    }


                    if(rb_Morning.Checked == true)
                    {
                        Result += rb_Morning.Text + ".";

                    }
                    else if(rb_Evening.Checked == true)
                    {
                        Result += rb_Evening.Text + ".";
                    }
                    else if(rb_Night.Checked == true)
                    {
                        Result += rb_Night.Text + ".";
                    }
                    else
                    {
                        MessageBox.Show(" Select Shift timing");
                        flag = true;
                    }
                }
                else
                {
                    MessageBox.Show(" select Employee Deparment");
                    flag = true;
                }
            }
            else
            {
                MessageBox.Show(" Enter Employee Name ");
                flag = true;
            }
            if (flag == false)
            {
                tb_Output.Text = Result;
            }
        }
    }
}
