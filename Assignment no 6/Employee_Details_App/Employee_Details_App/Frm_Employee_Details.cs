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
    public partial class Frm_Employee_Details : Form
    {
        public Frm_Employee_Details()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string Result = "";
            bool Flag = true, Lflag = true;

            if (tb_Employee_Name.Text != "")
            {
                Result += tb_Employee_Name.Text + " is from Department ";
                lbl_Error_Name.Visible = false;

            }
            else
            {
                lbl_Error_Name.Visible = true;
                Flag = false;
            }
            if (cmb_Employee_Dept.Text != "")
            {
                Result += cmb_Employee_Dept.Text;
                lbl_Error_Department.Visible = false;
            }
            else
            {
                lbl_Error_Department.Visible = true;
                Flag = false;
            }
            if (rb_Male.Checked == true)
            {
                Result += ", is " + rb_Male.Text + " Work At ";
                lbl_Error_Gender.Visible = false;

            }
            else if (rb_Female.Checked == true)
            {
                Result += ", is " + rb_Female.Text + " Work at ";
                lbl_Error_Gender.Visible = false;
            }
            else
            {
                lbl_Error_Gender.Visible = true;
                Flag = false;
            }
            if (rb_Morning.Checked == true)
            {
                Result += rb_Morning.Text + " Known";
                lbl_Error_Shift_Time.Visible = false;
            }
            else if (rb_Evening.Checked == true)
            {
                Result += rb_Evening.Text + " Known ";
                lbl_Error_Shift_Time.Visible = false;
            }
            else if (rb_Night.Checked == true)
            {
                Result += rb_Night.Text + " Known ";
                lbl_Error_Shift_Time.Visible = false;
            }
            else
            {
                lbl_Error_Shift_Time.Visible = true;
                Flag = false;
            }
            if (cb_Marathi.Checked == true)
            {
                Result += cb_Marathi.Text + ", ";
                lbl_Error_Language.Visible = false;
                Lflag = false;

            }
            if (cb_Hindi.Checked == true)
            {
                Result += cb_Hindi.Text + ", ";
                lbl_Error_Language.Visible = false;
                Lflag = false;
            }
            if (cb_English.Checked == true)
            {
                Result += cb_English.Text + ", ";
                lbl_Error_Language.Visible = false;
                Lflag = false;
            }
            if (cb_French.Checked == true)
            {
                Result += cb_French.Text + ", ";
                lbl_Error_Language.Visible = false;
                Lflag = false;
            }
            if (Lflag == true)
            {
                lbl_Error_Language.Visible = true;
                Flag = false;
            }
            int Cnt = clb_Hobbies.CheckedItems.Count;

            if (Cnt > 0)
            {
                lbl_Error_Hobbies.Visible = false;
                Result += " And Has Hobbies as ";

                for (int i = 0; i < clb_Hobbies.Items.Count; i++)
                {
                    if (clb_Hobbies.GetItemChecked(i))
                    {
                        if (Cnt > 1)
                        {
                            Result += clb_Hobbies.Items[i] + " ,";
                        }
                        else
                        {
                            Result += clb_Hobbies.Items[i] + ".";
                            break;
                        }

                        Cnt--;
                    }
                }

            }
            else
            {
                lbl_Error_Hobbies.Visible = true;
                Flag = false;
            }

            if (Flag == false)
            {
                //MessageBox.Show("Incomplte Data","Fill Required Details",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lbl_Outout.Visible = false;
            }
            else
            {
                lbl_Outout.Text = Result;
                lbl_Outout.Visible = true;
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            tb_Employee_Name.Clear();
            cmb_Employee_Dept.SelectedIndex = -1;

            rb_Male.Checked = false;
            rb_Female.Checked = false;

            rb_Morning.Checked = false;
            rb_Evening.Checked = false;
            rb_Night.Checked = false;

            cb_Marathi.Checked = false;
            cb_Hindi.Checked = false;
            cb_French.Checked = false;
            cb_English.Checked = false;

            for (int i = 0; i < clb_Hobbies.Items.Count; i++)
            {
                clb_Hobbies.SetItemChecked(i, false);
            }

            lbl_Outout.Visible = false;
        }
    }
}

