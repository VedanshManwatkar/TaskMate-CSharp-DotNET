using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskMate
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtname.Text))
            {
                MessageBox.Show("Enter Username");
                txtname.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtpass.Text))
            {
                MessageBox.Show("Enter Password");
                txtpass.Focus();
                return;
            }

            if (txtname.Text == "admin" && txtpass.Text == "1234")
            {
                MessageBox.Show("Login Successful");
                Menu frm = new Menu();
                this.Hide();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
                txtpass.Clear();
                txtpass.Focus();
            }
        }


        private void btnsignup_Click(object sender, EventArgs e)
        {
            FrmRegister frm = new FrmRegister();
            this.Hide();
            frm.Show();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtname.Text = "";
            txtpass.Text = "";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtpass.PasswordChar = '*';

        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnlogin.PerformClick();
            }
        }
    }
}
