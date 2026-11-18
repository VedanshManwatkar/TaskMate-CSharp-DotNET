namespace TaskMate
{
    partial class MyDay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyDay));
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            button4 = new Button();
            label12 = new Label();
            textBoxDescription = new TextBox();
            label15 = new Label();
            dateTimePickerDeadline = new DateTimePicker();
            label14 = new Label();
            textBoxTask = new TextBox();
            label13 = new Label();
            panel9 = new Panel();
            label10 = new Label();
            label11 = new Label();
            panel7 = new Panel();
            dvsd = new Label();
            label8 = new Label();
            lblUpcoming = new Label();
            panel8 = new Panel();
            panel5 = new Panel();
            dsv = new Label();
            label5 = new Label();
            lblCompleted = new Label();
            panel6 = new Panel();
            panel3 = new Panel();
            av = new Label();
            label2 = new Label();
            lblPending = new Label();
            panel4 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel9.SuspendLayout();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.LightCyan;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.LightCyan;
            dataGridView1.Location = new Point(30, 242);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(955, 595);
            dataGridView1.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(textBoxDescription);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(dateTimePickerDeadline);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(textBoxTask);
            panel1.Controls.Add(label13);
            panel1.Location = new Point(990, 242);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(903, 595);
            panel1.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Location = new Point(303, 294);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(461, 67);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 13F);
            radioButton1.Location = new Point(61, 20);
            radioButton1.Margin = new Padding(2);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(112, 34);
            radioButton1.TabIndex = 9;
            radioButton1.TabStop = true;
            radioButton1.Text = "Pending";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 13F);
            radioButton2.Location = new Point(257, 22);
            radioButton2.Margin = new Padding(2);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(142, 34);
            radioButton2.TabIndex = 10;
            radioButton2.TabStop = true;
            radioButton2.Text = "Completed";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14F);
            button3.Location = new Point(459, 448);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(190, 80);
            button3.TabIndex = 17;
            button3.Text = "View";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14F);
            button2.Location = new Point(653, 448);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(190, 80);
            button2.TabIndex = 16;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F);
            button1.Location = new Point(265, 448);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(190, 80);
            button1.TabIndex = 15;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 14F);
            button4.Location = new Point(71, 448);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(190, 80);
            button4.TabIndex = 14;
            button4.Text = "Insert";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 15F);
            label12.Location = new Point(217, 314);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(81, 35);
            label12.TabIndex = 8;
            label12.Text = "Status";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(303, 169);
            textBoxDescription.Margin = new Padding(2);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(452, 118);
            textBoxDescription.TabIndex = 7;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 15F);
            label15.Location = new Point(159, 169);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(142, 35);
            label15.TabIndex = 6;
            label15.Text = "Description";
            // 
            // dateTimePickerDeadline
            // 
            dateTimePickerDeadline.Location = new Point(303, 126);
            dateTimePickerDeadline.Margin = new Padding(2);
            dateTimePickerDeadline.Name = "dateTimePickerDeadline";
            dateTimePickerDeadline.Size = new Size(452, 27);
            dateTimePickerDeadline.TabIndex = 5;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 15F);
            label14.Location = new Point(223, 119);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(67, 35);
            label14.TabIndex = 4;
            label14.Text = "Date";
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(303, 74);
            textBoxTask.Margin = new Padding(2);
            textBoxTask.Name = "textBoxTask";
            textBoxTask.Size = new Size(452, 27);
            textBoxTask.TabIndex = 3;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 15F);
            label13.Location = new Point(166, 74);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(135, 35);
            label13.TabIndex = 2;
            label13.Text = "Task Name";
            // 
            // panel9
            // 
            panel9.Controls.Add(label10);
            panel9.Controls.Add(label11);
            panel9.Location = new Point(1486, 44);
            panel9.Margin = new Padding(2);
            panel9.Name = "panel9";
            panel9.Size = new Size(382, 129);
            panel9.TabIndex = 12;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 15F);
            label10.Location = new Point(23, 78);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(293, 35);
            label10.TabIndex = 11;
            label10.Text = "Complete Project Outline";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(23, 22);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(236, 46);
            label11.TabIndex = 10;
            label11.Text = "Weekly Focus";
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(dvsd);
            panel7.Controls.Add(label8);
            panel7.Controls.Add(lblUpcoming);
            panel7.Controls.Add(panel8);
            panel7.Location = new Point(1040, 44);
            panel7.Margin = new Padding(2);
            panel7.Name = "panel7";
            panel7.Size = new Size(333, 129);
            panel7.TabIndex = 11;
            // 
            // dvsd
            // 
            dvsd.AutoSize = true;
            dvsd.Font = new Font("Segoe UI", 15F);
            dvsd.Location = new Point(110, 54);
            dvsd.Margin = new Padding(2, 0, 2, 0);
            dvsd.Name = "dvsd";
            dvsd.Size = new Size(86, 35);
            dvsd.TabIndex = 9;
            dvsd.Text = "Events";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label8.ForeColor = Color.DarkGray;
            label8.Location = new Point(103, 11);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(186, 46);
            label8.TabIndex = 8;
            label8.Text = "Upcoming";
            // 
            // lblUpcoming
            // 
            lblUpcoming.AutoSize = true;
            lblUpcoming.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            lblUpcoming.ForeColor = Color.DarkSlateGray;
            lblUpcoming.Location = new Point(21, 21);
            lblUpcoming.Margin = new Padding(2, 0, 2, 0);
            lblUpcoming.Name = "lblUpcoming";
            lblUpcoming.Size = new Size(58, 67);
            lblUpcoming.TabIndex = 7;
            lblUpcoming.Text = "0";
            // 
            // panel8
            // 
            panel8.BackColor = Color.LightBlue;
            panel8.Location = new Point(0, 102);
            panel8.Margin = new Padding(2);
            panel8.Name = "panel8";
            panel8.Size = new Size(333, 26);
            panel8.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(dsv);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(lblCompleted);
            panel5.Controls.Add(panel6);
            panel5.Location = new Point(566, 44);
            panel5.Margin = new Padding(2);
            panel5.Name = "panel5";
            panel5.Size = new Size(333, 129);
            panel5.TabIndex = 10;
            // 
            // dsv
            // 
            dsv.AutoSize = true;
            dsv.Font = new Font("Segoe UI", 15F);
            dsv.Location = new Point(97, 54);
            dsv.Margin = new Padding(2, 0, 2, 0);
            dsv.Name = "dsv";
            dsv.Size = new Size(134, 35);
            dsv.TabIndex = 6;
            dsv.Text = "completed";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label5.ForeColor = Color.DarkGray;
            label5.Location = new Point(95, 11);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(104, 46);
            label5.TabIndex = 5;
            label5.Text = "Tasks";
            // 
            // lblCompleted
            // 
            lblCompleted.AutoSize = true;
            lblCompleted.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            lblCompleted.ForeColor = Color.DarkSlateGray;
            lblCompleted.Location = new Point(33, 21);
            lblCompleted.Margin = new Padding(2, 0, 2, 0);
            lblCompleted.Name = "lblCompleted";
            lblCompleted.Size = new Size(58, 67);
            lblCompleted.TabIndex = 4;
            lblCompleted.Text = "0";
            lblCompleted.Click += lblCompleted_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.PaleGreen;
            panel6.Location = new Point(0, 102);
            panel6.Margin = new Padding(2);
            panel6.Name = "panel6";
            panel6.Size = new Size(333, 26);
            panel6.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(av);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(lblPending);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(53, 43);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(333, 129);
            panel3.TabIndex = 9;
            // 
            // av
            // 
            av.AutoSize = true;
            av.Font = new Font("Segoe UI", 15F);
            av.Location = new Point(90, 54);
            av.Margin = new Padding(2, 0, 2, 0);
            av.Name = "av";
            av.Size = new Size(107, 35);
            av.TabIndex = 3;
            av.Text = "pending";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label2.ForeColor = Color.DarkGray;
            label2.Location = new Point(90, 11);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(104, 46);
            label2.TabIndex = 2;
            label2.Text = "Tasks";
            // 
            // lblPending
            // 
            lblPending.AutoSize = true;
            lblPending.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            lblPending.ForeColor = Color.DarkSlateGray;
            lblPending.Location = new Point(19, 22);
            lblPending.Margin = new Padding(2, 0, 2, 0);
            lblPending.Name = "lblPending";
            lblPending.Size = new Size(58, 67);
            lblPending.TabIndex = 1;
            lblPending.Text = "0";
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightCyan;
            panel4.Location = new Point(0, 102);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(333, 26);
            panel4.TabIndex = 0;
            // 
            // MyDay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1923, 866);
            Controls.Add(panel9);
            Controls.Add(panel7);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "MyDay";
            Text = "MyDay";
            Load += MyDay_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private Panel panel1;
        private TextBox textBoxDescription;
        private Label label15;
        private DateTimePicker dateTimePickerDeadline;
        private Label label14;
        private TextBox textBoxTask;
        private Label label13;
        private Button button4;
        private Label label12;
        private Button button3;
        private Button button2;
        private Button button1;
        private GroupBox groupBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Panel panel9;
        private Label label10;
        private Label label11;
        private Panel panel7;
        private Label dvsd;
        private Label label8;
        private Panel panel8;
        private Panel panel5;
        private Label dsv;
        private Label label5;
        private Panel panel6;
        private Panel panel3;
        private Label av;
        private Label label2;
        private Panel panel4;
        private Label lblUpcoming;
        private Label lblCompleted;
        private Label lblPending;
    }
}