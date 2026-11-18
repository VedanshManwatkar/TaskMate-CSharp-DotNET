namespace TaskMate
{

    public partial class Form1 : Form
    {
        int cnt = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1800;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Hide();
            FrmLogin frm1 = new FrmLogin();
            frm1.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
