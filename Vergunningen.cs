using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SafeContractorApp
{
    public partial class Vergunningen : Form
    {
        private void LoadVergunningData()
        {
            string query = "SELECT * FROM vergunning";

            using (var connection = new MySqlConnection(Connection.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvVergunning.DataSource = dataTable;
                connection.Close();
            }
        }


        public Vergunningen()
        {
            InitializeComponent();
            LoadVergunningData();
        }
    }
}
