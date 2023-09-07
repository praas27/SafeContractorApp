using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SafeContractorApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            tbHost.Text = Properties.Settings.Default.host;
            tbDatabase.Text = Properties.Settings.Default.database;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connectionString = "server=127.0.0.1;database=safecontractorappdb_4;uid=root;pwd=lijn-applications_29_08_2023;";
            string server = tbHost.Text;
            string database = tbDatabase.Text;
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            //string connectionString = $"Server={server};Database={database};User ID={username};Password={password};";

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    Connection.username = tbUsername.Text;
                    Connection.host = tbHost.Text;
                    Connection.database = tbDatabase.Text;
                    lbFeedback.Text = "Connection opened successfully.";
                    Connection.foutcode = "Welcome";
                    connection.Close();
                    Connection.user = connectionString;
                    this.Hide();
                    Home ss = new Home();
                    ss.Show();
                }
            }
            catch (Exception ex)
            {
                Connection.foutcode = "Error";
                lbFeedback.Text = $"Error: {ex.Message}";
            }
            Properties.Settings.Default.host = tbHost.Text;
            Properties.Settings.Default.database = tbDatabase.Text;
            Properties.Settings.Default.Save();
        }
    }
}
