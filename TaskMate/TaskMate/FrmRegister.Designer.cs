namespace TaskMate
{
    partial class FrmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegister));
            lbluser = new Label();
            lblpassword = new Label();
            lblconfirm = new Label();
            lblgender = new Label();
            lbldob = new Label();
            txtpass1 = new TextBox();
            txtpass2 = new TextBox();
            txtuser = new TextBox();
            groupBox1 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            dateTimePicker1 = new DateTimePicker();
            btnSub = new Button();
            btnres = new Button();
            label1 = new Label();
            chkShowPass = new CheckBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lbluser
            // 
            lbluser.AutoSize = true;
            lbluser.BackColor = Color.Transparent;
            lbluser.Font = new Font("Segoe UI", 20F);
            lbluser.Location = new Point(231, 289);
            lbluser.Margin = new Padding(2, 0, 2, 0);
            lbluser.Name = "lbluser";
            lbluser.Size = new Size(176, 46);
            lbluser.TabIndex = 0;
            lbluser.Text = "UserName";
            // 
            // lblpassword
            // 
            lblpassword.AutoSize = true;
            lblpassword.BackColor = Color.Transparent;
            lblpassword.Font = new Font("Segoe UI", 20F);
            lblpassword.Location = new Point(247, 347);
            lblpassword.Margin = new Padding(2, 0, 2, 0);
            lblpassword.Name = "lblpassword";
            lblpassword.Size = new Size(160, 46);
            lblpassword.TabIndex = 1;
            lblpassword.Text = "Password";
            // 
            // lblconfirm
            // 
            lblconfirm.AutoSize = true;
            lblconfirm.BackColor = Color.Transparent;
            lblconfirm.Font = new Font("Segoe UI", 20F);
            lblconfirm.Location = new Point(125, 403);
            lblconfirm.Margin = new Padding(2, 0, 2, 0);
            lblconfirm.Name = "lblconfirm";
            lblconfirm.Size = new Size(289, 46);
            lblconfirm.TabIndex = 2;
            lblconfirm.Text = "Confirm Password";
            // 
            // lblgender
            // 
            lblgender.AutoSize = true;
            lblgender.BackColor = Color.Transparent;
            lblgender.Font = new Font("Segoe UI", 20F);
            lblgender.Location = new Point(277, 503);
            lblgender.Margin = new Padding(2, 0, 2, 0);
            lblgender.Name = "lblgender";
            lblgender.Size = new Size(130, 46);
            lblgender.TabIndex = 3;
            lblgender.Text = "Gender";
            // 
            // lbldob
            // 
            lbldob.AutoSize = true;
            lbldob.BackColor = Color.Transparent;
            lbldob.Font = new Font("Segoe UI", 20F);
            lbldob.Location = new Point(198, 563);
            lbldob.Margin = new Padding(2, 0, 2, 0);
            lbldob.Name = "lbldob";
            lbldob.Size = new Size(216, 46);
            lbldob.TabIndex = 4;
            lbldob.Text = "Date Of Birth";
            // 
            // txtpass1
            // 
            txtpass1.Location = new Point(418, 364);
            txtpass1.Margin = new Padding(2);
            txtpass1.Name = "txtpass1";
            txtpass1.PlaceholderText = "   Enter Password";
            txtpass1.Size = new Size(316, 27);
            txtpass1.TabIndex = 5;
            txtpass1.UseSystemPasswordChar = true;
            // 
            // txtpass2
            // 
            txtpass2.Location = new Point(418, 420);
            txtpass2.Margin = new Padding(2);
            txtpass2.Name = "txtpass2";
            txtpass2.PlaceholderText = "   Confirm password";
            txtpass2.Size = new Size(316, 27);
            txtpass2.TabIndex = 6;
            txtpass2.UseSystemPasswordChar = true;
            // 
            // txtuser
            // 
            txtuser.Location = new Point(418, 306);
            txtuser.Margin = new Padding(2);
            txtuser.Name = "txtuser";
            txtuser.PlaceholderText = "   Enter User Name";
            txtuser.Size = new Size(316, 27);
            txtuser.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(418, 503);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(316, 62);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(202, 24);
            radioButton3.Margin = new Padding(2);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(73, 24);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Others";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(97, 24);
            radioButton2.Margin = new Padding(2);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(78, 24);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(5, 24);
            radioButton1.Margin = new Padding(2);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(63, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(423, 578);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(316, 27);
            dateTimePicker1.TabIndex = 3;
            // 
            // btnSub
            // 
            btnSub.BackColor = Color.Black;
            btnSub.ForeColor = SystemColors.ButtonHighlight;
            btnSub.Location = new Point(350, 656);
            btnSub.Margin = new Padding(2);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(150, 40);
            btnSub.TabIndex = 9;
            btnSub.Text = "Register";
            btnSub.UseVisualStyleBackColor = false;
            btnSub.Click += btnSub_Click;
            // 
            // btnres
            // 
            btnres.BackColor = Color.Black;
            btnres.ForeColor = SystemColors.ButtonHighlight;
            btnres.Location = new Point(515, 656);
            btnres.Margin = new Padding(2);
            btnres.Name = "btnres";
            btnres.Size = new Size(150, 40);
            btnres.TabIndex = 10;
            btnres.Text = "Reset";
            btnres.UseVisualStyleBackColor = false;
            btnres.Click += btnres_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Rounded MT Bold", 31.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(326, 188);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(351, 62);
            label1.TabIndex = 11;
            label1.Text = "Registration";
            // 
            // chkShowPass
            // 
            chkShowPass.AutoSize = true;
            chkShowPass.BackColor = Color.Transparent;
            chkShowPass.Location = new Point(418, 460);
            chkShowPass.Name = "chkShowPass";
            chkShowPass.Size = new Size(132, 24);
            chkShowPass.TabIndex = 12;
            chkShowPass.Text = "Show Password";
            chkShowPass.UseVisualStyleBackColor = false;
            chkShowPass.CheckedChanged += chkShowPass_CheckedChanged;
            // 
            // FrmRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1922, 983);
            Controls.Add(chkShowPass);
            Controls.Add(label1);
            Controls.Add(btnres);
            Controls.Add(btnSub);
            Controls.Add(dateTimePicker1);
            Controls.Add(groupBox1);
            Controls.Add(txtuser);
            Controls.Add(txtpass2);
            Controls.Add(txtpass1);
            Controls.Add(lbldob);
            Controls.Add(lblgender);
            Controls.Add(lblconfirm);
            Controls.Add(lblpassword);
            Controls.Add(lbluser);
            Margin = new Padding(2);
            Name = "FrmRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registration Form";
            Load += FrmRegister_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbluser;
        private Label lblpassword;
        private Label lblconfirm;
        private Label lblgender;
        private Label lbldob;
        private TextBox txtpass1;
        private TextBox txtpass2;
        private TextBox txtuser;
        private GroupBox groupBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private DateTimePicker dateTimePicker1;
        private Button btnSub;
        private Button btnres;
        private Label label1;
        private CheckBox chkShowPass;
    }
}