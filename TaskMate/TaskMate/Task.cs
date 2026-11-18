using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace TaskMate
{
    public partial class Task : Form
    {
        string connectionString = "User Id=system;Password=vedansh;Data Source=localhost:1521/XE";

        public Task()
        {
            InitializeComponent();
        }

        private void Task_Load(object sender, EventArgs e)
        {
            lblPending.Text =dataGridViewMyDay.Rows.Count.ToString();
            lblUpcoming.Text =dataGridViewImportant.Rows.Count.ToString();
            lblCompleted.Text =dataGridViewPlanned.Rows.Count.ToString();
            LoadData();
        }

        private void LoadData()
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();

                try
                {
                    using (OracleDataAdapter da = new OracleDataAdapter(
                        "SELECT taskname AS \"Task Name\", taskdescription AS \"Description\", taskdate AS \"Date\", taskstatus AS \"Status\" FROM myday", conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridViewMyDay.DataSource = dt;
                    }
                }
                catch (Exception ex) { MessageBox.Show("Error loading MyDay: " + ex.Message); }

                try
                {
                    using (OracleDataAdapter da = new OracleDataAdapter(
                        "SELECT taskname AS \"Task Name\", taskdescription AS \"Description\", taskdate AS \"Date\", taskstatus AS \"Status\" FROM important", conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridViewImportant.DataSource = dt;
                    }
                }
                catch (Exception ex) { MessageBox.Show("Error loading Important: " + ex.Message); }

                try
                {
                    using (OracleDataAdapter da = new OracleDataAdapter(
                        "SELECT taskname AS \"Task Name\", taskdescription AS \"Description\", taskdate AS \"Date\", taskstatus AS \"Status\" FROM planned", conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridViewPlanned.DataSource = dt;
                    }
                }
                catch (Exception ex) { MessageBox.Show("Error loading Planned: " + ex.Message); }

                try
                {
                    string combinedQuery = @"
                        SELECT taskname AS ""Task Name"", taskdescription AS ""Description"", taskdate AS ""Date"", taskstatus AS ""Status"", 'MyDay' AS ""Source"" FROM myday
                        UNION ALL
                        SELECT taskname, taskdescription, taskdate, taskstatus, 'Important' AS ""Source"" FROM important
                        UNION ALL
                        SELECT taskname, taskdescription, taskdate, taskstatus, 'Planned' AS ""Source"" FROM planned";

                    using (OracleDataAdapter da = new OracleDataAdapter(combinedQuery, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridViewTasks.DataSource = dt;
                    }
                }
                catch (Exception ex) { MessageBox.Show("Error loading combined tasks: " + ex.Message); }
            }
        }
    }
}