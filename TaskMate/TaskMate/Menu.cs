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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            this.Hide();
            frm.Show();

        }

        private void HighlightButton(Button activeButton)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button btn)
                    btn.BackColor = Color.FloralWhite;
            }
            activeButton.BackColor = Color.LightGray;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            HighlightButton((Button)sender);

            panel1.Controls.Clear();

            MyDay MyDay = new MyDay();
            MyDay.TopLevel = false;
            panel1.Controls.Add(MyDay);
            MyDay.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HighlightButton((Button)sender);

            panel1.Controls.Clear();

            Important Important = new Important();
            Important.TopLevel = false;
            panel1.Controls.Add(Important);
            Important.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HighlightButton((Button)sender);

            panel1.Controls.Clear();

            Planned Planned = new Planned();
            Planned.TopLevel = false;
            panel1.Controls.Add(Planned);
            Planned.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HighlightButton((Button)sender);

            panel1.Controls.Clear();

            Task task = new Task();
            task.TopLevel = false;
            panel1.Controls.Add(task);
            task.Show();
        }
    }
}
