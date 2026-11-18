using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TaskMate
{
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (txtpass1.Text.Length == 0)
            {
                MessageBox.Show("Enter Password");
                txtpass1.Focus();

            }
            if (txtpass2.Text.Length == 0)
            {
                MessageBox.Show("Enter Confirm Password");
                txtpass2.Focus();

            }
            if (txtuser.Text.Length == 0)
            {
                MessageBox.Show("Enter UserName");
                txtuser.Focus();

            }
            if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false)
            {
                MessageBox.Show("Select Gender");
            }
            if (txtpass1.Text != txtpass2.Text)
            {
                MessageBox.Show("Enter same password");
            }

            else
            {
                MessageBox.Show("Account Created Sucessfully");
                Menu m = new Menu();
                this.Hide();
                m.Show();
            }
        }

        private void btnres_Click(object sender, EventArgs e)
        {
            txtpass1.Text = "";
            txtpass2.Text = "";
            txtuser.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtpass1.UseSystemPasswordChar = !chkShowPass.Checked;
            txtpass2.UseSystemPasswordChar = !chkShowPass.Checked;
        }
    }
}
