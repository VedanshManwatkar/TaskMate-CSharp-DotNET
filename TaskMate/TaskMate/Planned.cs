using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;


namespace TaskMate
{
    public partial class Planned : Form
    {
        string connectionString = "User Id=system;Password=vedansh;Data Source=localhost:1521/XE";

        public Planned()
        {
            InitializeComponent();
        }

        private void Planned_Load(object sender, EventArgs e)
        {

        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxTask.Text))
            {
                MessageBox.Show("Task name cannot be empty!", "Validation Error");
                return;
            }

            if (dateTimePickerDeadline.Value.Date < DateTime.Today)
            {
                MessageBox.Show("Date cannot be in the past!", "Validation Error");
                return;
            }

            if (textBoxDescription.Text.Length > 50)
            {
                MessageBox.Show("Description too long!", "Validation Error");
                return;
            }

            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO planned (taskname, taskdescription, taskdate, taskstatus) " +
                               "VALUES (:taskname, :taskdescription, :taskdate, :taskstatus)";

                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.Parameters.Add(":taskname", textBoxTask.Text);
                    cmd.Parameters.Add(":taskdescription", textBoxDescription.Text);
                    cmd.Parameters.Add(":taskdate", dateTimePickerDeadline.Value);
                    cmd.Parameters.Add(":taskstatus", radioButtonCompleted.Checked ? "completed" : "pending");

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Task inserted successfully!", "Success");
                    }
                    catch (OracleException ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Database Error");
                    }
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxTask.Text))
            {
                MessageBox.Show("Task name cannot be empty!", "Validation Error");
                return;
            }

            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE planned SET taskdescription = :taskdescription, " +
                               "taskdate = :taskdate, taskstatus = :taskstatus " +
                               "WHERE taskname = :taskname";

                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.Parameters.Add(":taskdescription", textBoxDescription.Text);
                    cmd.Parameters.Add(":taskdate", dateTimePickerDeadline.Value);
                    cmd.Parameters.Add(":taskstatus", radioButtonCompleted.Checked ? "completed" : "pending");
                    cmd.Parameters.Add(":taskname", textBoxTask.Text);

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                        MessageBox.Show("Task updated successfully!", "Success");
                    else
                        MessageBox.Show("Task not found!", "Info");
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxTask.Text))
            {
                MessageBox.Show("Enter the task name to delete!", "Validation Error");
                return;
            }

            if (!radioButtonCompleted.Checked)
            {
                MessageBox.Show("Mark the task as completed before removing.", "Validation Error");
                return;
            }

            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM planned WHERE taskname = :taskname";

                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.Parameters.Add(":taskname", textBoxTask.Text);

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                        MessageBox.Show("Task removed successfully!", "Success");
                    else
                        MessageBox.Show("Task not found!", "Info");
                }
            }
        }
        private void buttonView_Click(object sender, EventArgs e)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT taskname, taskdescription, taskdate, taskstatus FROM planned";

                using (OracleDataAdapter da = new OracleDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                    int pendingCount = dt.AsEnumerable().Count(row => row.Field<string>("taskstatus") == "pending");

                    int upcomingCount = dt.AsEnumerable().Count(row => row.Field<DateTime>("taskdate").Date > DateTime.Today);

                    lblPending.Text =pendingCount.ToString();
                    lblUpcoming.Text =upcomingCount.ToString();
                }
            }
        }
    }
}
