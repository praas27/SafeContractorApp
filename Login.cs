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
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connectionString = "server=127.0.0.1;database=safecontractorappdb;uid=root;pwd=lijn-applications_29_08_2023;";
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    lbFeedback.Text = "Connection opened successfully.";
                }
            }
            catch (Exception ex)
            {
                lbFeedback.Text = $"Error: {ex.Message}";
            }
        }
    }
}
