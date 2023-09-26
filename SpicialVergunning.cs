using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SafeContractorApp
{
    public partial class SpicialVergunning : Form
    {
        private void Load_werk()
        {
            cbWerk.Items.Clear();
            cbWerk.Text = string.Empty;
            string query = "select werken from werken";
            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string site_naam = reader["werken"].ToString();
                    cbWerk.Items.Add(site_naam);
                }
                connection.Close();
            }
        }

        private void Load_maatregel()
        {
            cbMaatregel.Items.Clear();
            cbMaatregel.Text = string.Empty;
            string query = "select maatregel from maatregelen";
            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string site_naam = reader["maatregel"].ToString();
                    cbMaatregel.Items.Add(site_naam);
                }
                connection.Close();
            }
        }

        private void Load_Risico()
        {
            cbRisico.Items.Clear();
            cbRisico.Text = string.Empty;
            string query = "select risico from risico";
            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string site_naam = reader["risico"].ToString();
                    cbRisico.Items.Add(site_naam);
                }
                connection.Close();
            }
        }

        private void Load_meeting()
        {
            cbMeting.Items.Clear();
            cbMeting.Text = string.Empty;
            string query = "select meting from metingen";
            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string site_naam = reader["meting"].ToString();
                    cbMeting.Items.Add(site_naam);
                }
                connection.Close();
            }
        }

        private void Load_beschermiddelen()
        {
            cbBeschermidelen.Items.Clear();
            cbBeschermidelen.Text = string.Empty;
            string query = "select beschermiddelen from beschermiddelen";
            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string site_naam = reader["beschermiddelen"].ToString();
                    cbBeschermidelen.Items.Add(site_naam);
                }
                connection.Close();
            }
        }

        private void Load_besloten_maatregelen()
        {
            cbMaatregelen.Items.Clear();
            cbMaatregelen.Text = string.Empty;
            string query = "select besloten_maatregelen from besloten_maatregelen";
            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string site_naam = reader["besloten_maatregelen"].ToString();
                    cbMaatregelen.Items.Add(site_naam);
                }
                connection.Close();
            }
        }


        private void DeleteDataFromTable(string tableName, string columnName, string value)
        {
            string query = $"DELETE FROM {tableName} WHERE {columnName} = @value";
            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@value", value);
                command.ExecuteNonQuery();
            }
        }

        private char Get_catogorie_nummer(string options)
        {
            char cat = '0';
            switch (options)
            {
                case "Aard van het werk":
                    cat = 'A'; break;
                case "Installatatie waaraan gewerkt wordt":
                    cat = 'I'; break;
                case "Omgeving":
                    cat = 'O'; break;
                case "Brandbestandig":
                    cat = 'B';break;
                default: return cat;
            }
            return cat;
        }

        public SpicialVergunning()
        {
            InitializeComponent();
            Load_werk();
            Load_maatregel();
            Load_Risico();
            Load_meeting();
            Load_beschermiddelen();
            Load_besloten_maatregelen();
        }

        private void btnAddWerk_Click(object sender, EventArgs e)
        {
            string query = "insert into werken (werken,type) values (@werken,@type)";
            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@werken", cbWerk.Text);
                command.Parameters.AddWithValue("@type",Get_catogorie_nummer(cbCatogorie.Text));
                MySqlDataReader reader = command.ExecuteReader();
                connection.Close();
            }
            Load_werk();
        }

        private void btnDeleteWork_Click(object sender, EventArgs e)
        {
            DeleteDataFromTable("werken", "werken", cbWerk.Text);
            Load_werk();
        }

        private void btnAddMaatregel_Click(object sender, EventArgs e)
        {
            
            string query = "insert into maatregelen (maatregel) values (@maatregel)";
            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@maatregel", cbMaatregel.Text);
                MySqlDataReader reader = command.ExecuteReader();
                connection.Close();
            }
            Load_maatregel();
        }

        private void btnDeleteMaatregel_Click(object sender, EventArgs e)
        {
            DeleteDataFromTable("maatregelen", "maatregel", cbMaatregel.Text);
            Load_maatregel();
        }

        private void btnAddRisico_Click(object sender, EventArgs e)
        {
            string query = "insert into risico (risico) values (@risico)";
            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@risico", cbRisico.Text);
                MySqlDataReader reader = command.ExecuteReader();
                connection.Close();
            }
            Load_Risico();
        }

        private void btnDeleteRisico_Click(object sender, EventArgs e)
        {
            DeleteDataFromTable("risico", "risico", cbRisico.Text);
            Load_Risico();
        }

        private void btnAddMetingen_Click(object sender, EventArgs e)
        {
            string query = "insert into metingen (meting) values (@meting)";
            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@meting", cbMeting.Text);
                MySqlDataReader reader = command.ExecuteReader();
                connection.Close();
            }
            Load_meeting();
        }

        private void btnDeleteMetingen_Click(object sender, EventArgs e)
        {
            DeleteDataFromTable("metingen", "meting", cbMeting.Text);
            Load_meeting();
        }

        private void btnAddMaatregelen_Click(object sender, EventArgs e)
        {
            string query = "insert into besloten_maatregelen (besloten_maatregelen) values (@besloten_maatregelen)";
            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@besloten_maatregelen", cbMaatregelen.Text);
                MySqlDataReader reader = command.ExecuteReader();
                connection.Close();
            }
            Load_besloten_maatregelen();
        }

        private void btnDeleteMaatregelen_Click(object sender, EventArgs e)
        {
            DeleteDataFromTable("besloten_maatregelen", "besloten_maatregelen", cbMaatregelen.Text);
            Load_besloten_maatregelen();
        }

        private void btnAddBeschermiddelen_Click(object sender, EventArgs e)
        {
            string query = "insert into beschermiddelen (beschermiddelen) values (@beschermiddelen)";
            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@beschermiddelen", cbBeschermidelen.Text);
                MySqlDataReader reader = command.ExecuteReader();
                connection.Close();
            }
            Load_beschermiddelen();
        }

        private void btnDeleteBeschermidellen_Click(object sender, EventArgs e)
        {
            DeleteDataFromTable("beschermiddelen", "beschermiddelen", cbBeschermidelen.Text);
            Load_beschermiddelen();
        }

        private void cbCatogorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            char type = '0';
            switch (cbCatogorie.SelectedIndex)
            {
                case 0:
                    type = 'A'; break;
                case 1:
                    type = 'I'; break;
                case 2:
                    type = 'O'; break;
                case 3:
                    type = 'B'; break;
                default: break;
            }

            cbWerk.Items.Clear();
            cbWerk.Text = string.Empty;
            string query = "select werken from werken where type=@type";
            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@type", type);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string site_naam = reader["werken"].ToString();
                    cbWerk.Items.Add(site_naam);
                }
                connection.Close();
            }
        }
    }
}
