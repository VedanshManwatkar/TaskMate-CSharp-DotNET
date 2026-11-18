namespace TaskMate
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            txtpass = new TextBox();
            txtname = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            lblpass = new Label();
            lblname = new Label();
            label2 = new Label();
            btnlogin = new Button();
            btnreset = new Button();
            btnsignup = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtpass
            // 
            txtpass.Font = new Font("Segoe UI", 12F);
            txtpass.Location = new Point(1311, 393);
            txtpass.Margin = new Padding(2);
            txtpass.Multiline = true;
            txtpass.Name = "txtpass";
            txtpass.PasswordChar = '*';
            txtpass.PlaceholderText = "     Enter Password";
            txtpass.Size = new Size(207, 38);
            txtpass.TabIndex = 2;
            // 
            // txtname
            // 
            txtname.Font = new Font("Segoe UI", 12F);
            txtname.Location = new Point(1311, 333);
            txtname.Margin = new Padding(2);
            txtname.Multiline = true;
            txtname.Name = "txtname";
            txtname.PlaceholderText = "     Enter User Name";
            txtname.Size = new Size(207, 38);
            txtname.TabIndex = 1;
            txtname.TextChanged += textBox2_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1272, 333);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1272, 393);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // lblpass
            // 
            lblpass.AutoSize = true;
            lblpass.BackColor = Color.Transparent;
            lblpass.Font = new Font("Calibri", 20F);
            lblpass.ForeColor = Color.Black;
            lblpass.Location = new Point(1095, 393);
            lblpass.Margin = new Padding(2, 0, 2, 0);
            lblpass.Name = "lblpass";
            lblpass.Size = new Size(149, 41);
            lblpass.TabIndex = 5;
            lblpass.Text = "Password";
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.BackColor = Color.Transparent;
            lblname.Font = new Font("Calibri", 20F);
            lblname.ForeColor = Color.Black;
            lblname.Location = new Point(1095, 337);
            lblname.Margin = new Padding(2, 0, 2, 0);
            lblname.Name = "lblname";
            lblname.Size = new Size(164, 41);
            lblname.TabIndex = 6;
            lblname.Text = "UserName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(1216, 522);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(204, 20);
            label2.TabIndex = 8;
            label2.Text = "If You Don't Have An Account";
            // 
            // btnlogin
            // 
            btnlogin.BackColor = SystemColors.WindowText;
            btnlogin.ForeColor = SystemColors.ButtonFace;
            btnlogin.Location = new Point(1186, 476);
            btnlogin.Margin = new Padding(2);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(120, 32);
            btnlogin.TabIndex = 9;
            btnlogin.Text = "Log in";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // btnreset
            // 
            btnreset.BackColor = SystemColors.WindowText;
            btnreset.ForeColor = SystemColors.ButtonFace;
            btnreset.Location = new Point(1311, 476);
            btnreset.Margin = new Padding(2);
            btnreset.Name = "btnreset";
            btnreset.Size = new Size(120, 32);
            btnreset.TabIndex = 10;
            btnreset.Text = "Reset";
            btnreset.UseVisualStyleBackColor = false;
            btnreset.Click += btnreset_Click;
            // 
            // btnsignup
            // 
            btnsignup.BackColor = SystemColors.WindowText;
            btnsignup.ForeColor = SystemColors.ButtonFace;
            btnsignup.Location = new Point(1244, 569);
            btnsignup.Margin = new Padding(2);
            btnsignup.Name = "btnsignup";
            btnsignup.Size = new Size(120, 32);
            btnsignup.TabIndex = 11;
            btnsignup.Text = "Sign up";
            btnsignup.UseVisualStyleBackColor = false;
            btnsignup.Click += btnsignup_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(btnsignup);
            panel1.Controls.Add(txtpass);
            panel1.Controls.Add(btnreset);
            panel1.Controls.Add(txtname);
            panel1.Controls.Add(btnlogin);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblpass);
            panel1.Controls.Add(lblname);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1922, 983);
            panel1.TabIndex = 12;
            panel1.Paint += panel1_Paint;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1922, 983);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Form";
            Load += FrmLogin_Load;
            KeyDown += FrmLogin_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtpass;
        private TextBox txtname;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label lblpass;
        private Label lblname;
        private Label label2;
        private Button btnlogin;
        private Button btnreset;
        private Button btnsignup;
        private Panel panel1;
    }
}