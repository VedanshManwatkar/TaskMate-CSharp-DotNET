namespace TaskMate
{
    partial class Important
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Important));
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            radioButtonCompleted = new RadioButton();
            radioButtonPending = new RadioButton();
            buttonView = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            buttonInsert = new Button();
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
            db = new Label();
            label8 = new Label();
            lblUpcoming = new Label();
            panel8 = new Panel();
            panel5 = new Panel();
            dvc = new Label();
            label5 = new Label();
            lblCompleted = new Label();
            panel6 = new Panel();
            panel3 = new Panel();
            sbd = new Label();
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
            dataGridView1.Location = new Point(39, 238);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(931, 580);
            dataGridView1.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(buttonView);
            panel1.Controls.Add(buttonUpdate);
            panel1.Controls.Add(buttonDelete);
            panel1.Controls.Add(buttonInsert);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(textBoxDescription);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(dateTimePickerDeadline);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(textBoxTask);
            panel1.Controls.Add(label13);
            panel1.Location = new Point(988, 238);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(878, 580);
            panel1.TabIndex = 13;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButtonCompleted);
            groupBox1.Controls.Add(radioButtonPending);
            groupBox1.Location = new Point(293, 271);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(439, 67);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            // 
            // radioButtonCompleted
            // 
            radioButtonCompleted.AutoSize = true;
            radioButtonCompleted.Font = new Font("Segoe UI", 13F);
            radioButtonCompleted.Location = new Point(54, 22);
            radioButtonCompleted.Margin = new Padding(2);
            radioButtonCompleted.Name = "radioButtonCompleted";
            radioButtonCompleted.Size = new Size(112, 34);
            radioButtonCompleted.TabIndex = 9;
            radioButtonCompleted.TabStop = true;
            radioButtonCompleted.Text = "Pending";
            radioButtonCompleted.UseVisualStyleBackColor = true;
            // 
            // radioButtonPending
            // 
            radioButtonPending.AutoSize = true;
            radioButtonPending.Font = new Font("Segoe UI", 13F);
            radioButtonPending.Location = new Point(260, 22);
            radioButtonPending.Margin = new Padding(2);
            radioButtonPending.Name = "radioButtonPending";
            radioButtonPending.Size = new Size(142, 34);
            radioButtonPending.TabIndex = 10;
            radioButtonPending.TabStop = true;
            radioButtonPending.Text = "Completed";
            radioButtonPending.UseVisualStyleBackColor = true;
            // 
            // buttonView
            // 
            buttonView.Font = new Font("Segoe UI", 14F);
            buttonView.Location = new Point(450, 460);
            buttonView.Margin = new Padding(2);
            buttonView.Name = "buttonView";
            buttonView.Size = new Size(190, 80);
            buttonView.TabIndex = 21;
            buttonView.Text = "View";
            buttonView.UseVisualStyleBackColor = true;
            buttonView.Click += buttonView_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Font = new Font("Segoe UI", 14F);
            buttonUpdate.Location = new Point(644, 460);
            buttonUpdate.Margin = new Padding(2);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(190, 80);
            buttonUpdate.TabIndex = 20;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Font = new Font("Segoe UI", 14F);
            buttonDelete.Location = new Point(256, 460);
            buttonDelete.Margin = new Padding(2);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(190, 80);
            buttonDelete.TabIndex = 19;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonInsert
            // 
            buttonInsert.Font = new Font("Segoe UI", 14F);
            buttonInsert.Location = new Point(62, 460);
            buttonInsert.Margin = new Padding(2);
            buttonInsert.Name = "buttonInsert";
            buttonInsert.Size = new Size(190, 80);
            buttonInsert.TabIndex = 18;
            buttonInsert.Text = "Insert";
            buttonInsert.UseVisualStyleBackColor = true;
            buttonInsert.Click += buttonInsert_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 15F);
            label12.Location = new Point(203, 291);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(81, 35);
            label12.TabIndex = 8;
            label12.Text = "Status";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(302, 162);
            textBoxDescription.Margin = new Padding(2);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(430, 118);
            textBoxDescription.TabIndex = 7;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 15F);
            label15.Location = new Point(156, 162);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(142, 35);
            label15.TabIndex = 6;
            label15.Text = "Description";
            // 
            // dateTimePickerDeadline
            // 
            dateTimePickerDeadline.Location = new Point(302, 119);
            dateTimePickerDeadline.Margin = new Padding(2);
            dateTimePickerDeadline.Name = "dateTimePickerDeadline";
            dateTimePickerDeadline.Size = new Size(430, 27);
            dateTimePickerDeadline.TabIndex = 5;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 15F);
            label14.Location = new Point(217, 112);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(67, 35);
            label14.TabIndex = 4;
            label14.Text = "Date";
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(302, 67);
            textBoxTask.Margin = new Padding(2);
            textBoxTask.Name = "textBoxTask";
            textBoxTask.Size = new Size(430, 27);
            textBoxTask.TabIndex = 3;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 15F);
            label13.Location = new Point(163, 59);
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
            panel9.Location = new Point(1484, 53);
            panel9.Margin = new Padding(2);
            panel9.Name = "panel9";
            panel9.Size = new Size(382, 129);
            panel9.TabIndex = 17;
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
            panel7.Controls.Add(db);
            panel7.Controls.Add(label8);
            panel7.Controls.Add(lblUpcoming);
            panel7.Controls.Add(panel8);
            panel7.Location = new Point(1038, 53);
            panel7.Margin = new Padding(2);
            panel7.Name = "panel7";
            panel7.Size = new Size(333, 129);
            panel7.TabIndex = 16;
            // 
            // db
            // 
            db.AutoSize = true;
            db.Font = new Font("Segoe UI", 15F);
            db.Location = new Point(110, 54);
            db.Margin = new Padding(2, 0, 2, 0);
            db.Name = "db";
            db.Size = new Size(86, 35);
            db.TabIndex = 9;
            db.Text = "Events";
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
            lblUpcoming.Location = new Point(16, 22);
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
            panel5.Controls.Add(dvc);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(lblCompleted);
            panel5.Controls.Add(panel6);
            panel5.Location = new Point(564, 53);
            panel5.Margin = new Padding(2);
            panel5.Name = "panel5";
            panel5.Size = new Size(333, 129);
            panel5.TabIndex = 15;
            // 
            // dvc
            // 
            dvc.AutoSize = true;
            dvc.Font = new Font("Segoe UI", 15F);
            dvc.Location = new Point(97, 54);
            dvc.Margin = new Padding(2, 0, 2, 0);
            dvc.Name = "dvc";
            dvc.Size = new Size(134, 35);
            dvc.TabIndex = 6;
            dvc.Text = "completed";
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
            lblCompleted.Location = new Point(14, 22);
            lblCompleted.Margin = new Padding(2, 0, 2, 0);
            lblCompleted.Name = "lblCompleted";
            lblCompleted.Size = new Size(58, 67);
            lblCompleted.TabIndex = 4;
            lblCompleted.Text = "0";
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
            panel3.Controls.Add(sbd);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(lblPending);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(51, 52);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(333, 129);
            panel3.TabIndex = 14;
            // 
            // sbd
            // 
            sbd.AutoSize = true;
            sbd.Font = new Font("Segoe UI", 15F);
            sbd.Location = new Point(90, 54);
            sbd.Margin = new Padding(2, 0, 2, 0);
            sbd.Name = "sbd";
            sbd.Size = new Size(107, 35);
            sbd.TabIndex = 3;
            sbd.Text = "pending";
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
            lblPending.Location = new Point(12, 22);
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
            // Important
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
            Name = "Important";
            Text = "Important";
            Load += Important_Load;
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
        private RadioButton radioButtonPending;
        private RadioButton radioButtonCompleted;
        private Label label12;
        private TextBox textBoxDescription;
        private Label label15;
        private DateTimePicker dateTimePickerDeadline;
        private Label label14;
        private TextBox textBoxTask;
        private Label label13;
        private Button buttonView;
        private Button buttonUpdate;
        private Button buttonDelete;
        private Button buttonInsert;
        private GroupBox groupBox1;
        private Panel panel9;
        private Label label10;
        private Label label11;
        private Panel panel7;
        private Label db;
        private Label label8;
        private Panel panel8;
        private Panel panel5;
        private Label dvc;
        private Label label5;
        private Panel panel6;
        private Panel panel3;
        private Label sbd;
        private Label label2;
        private Panel panel4;
        private Label lblUpcoming;
        private Label lblCompleted;
        private Label lblPending;
    }
}