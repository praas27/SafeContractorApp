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
        private void GetIn()
        {
            //string connectionString = "server=127.0.0.1;database=safecontractorappdb_4;uid=root;pwd=lijn-applications_29_08_2023;";
            string server = tbHost.Text;
            string database = tbDatabase.Text;
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            string connectionString = $"Server={server};Database={database};User ID={username};Password={password};";

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    Globaal.username = tbUsername.Text;
                    Globaal.host = tbHost.Text;
                    Globaal.database = tbDatabase.Text;
                    lbFeedback.Text = "Connection opened successfully.";
                    Globaal.foutcode = "Welcome";
                    connection.Close();
                    Globaal.user = connectionString;
                    this.Hide();
                    Home ss = new Home();
                    ss.Show();
                }
            }
            catch (Exception ex)
            {
                Globaal.foutcode = "Error";
                lbFeedback.Text = $"Error: {ex.Message}";
            }
            Properties.Settings.Default.host = tbHost.Text;
            Properties.Settings.Default.database = tbDatabase.Text;
            Properties.Settings.Default.Save();
        }

        public Login()
        {
            InitializeComponent();
            tbHost.Text = Properties.Settings.Default.host;
            tbDatabase.Text = Properties.Settings.Default.database;
            tbPassword.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            GetIn();
        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Perform the desired action here
                GetIn();

                // Prevent the TextBox from processing the Enter key further
                e.Handled = true;
            }
        }
    }
}
