using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SafeContractorApp
{
    public partial class AadVergunningen : Form
    {
        private void Load_opdrachtgever()
        {
            string query = "select opdrachtgever_naam from opdrachtgevers";
            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string opdrachtgever_naam = reader["opdrachtgever_naam"].ToString();
                    cbOpdrachtgever.Items.Add(opdrachtgever_naam);
                }
                connection.Close();
            }
        }

        private void Load_site()
        {
            string query = "select site_naam from sites";
            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string site_naam = reader["site_naam"].ToString();
                    cbSite.Items.Add(site_naam);
                }
                connection.Close();
            }
        }

        private void Load_voetuigen()
        {
            string query = "select voertuig_naam from voertuigen";
            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string voertuig_naam = reader["voertuig_naam"].ToString();
                    cbVoertuigen.Items.Add(voertuig_naam);
                }
                connection.Close();
            }
        }

        private void Load_werknemer()
        {
            string query = "select werknemer_naam from werknemers";
            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string werknemer_naam = reader["werknemer_naam"].ToString();
                    cbWerknemer.Items.Add(werknemer_naam);
                }
                connection.Close();
            }
        }

        private void Load_firma()
        {
            string query = "select firma_naam from firma";
            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string firma_naam = reader["firma_naam"].ToString();
                    cbFirma.Items.Add(firma_naam);
                }
                connection.Close();
            }
        }

        private int GetIdFromTable(string tableName, string columnName, string value)
        {
            int id = 0;
            string query = $"SELECT {columnName}_id FROM {tableName} WHERE {columnName}_naam = @value";

            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@value", value);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    id = int.Parse(reader[$"{columnName}_id"].ToString());
                }
                connection.Close();
            }

            return id;
        }


        public AadVergunningen()
        {
            InitializeComponent();
            Load_firma();
            Load_site();
            Load_voetuigen();
            Load_werknemer();
            Load_opdrachtgever();
        }


        private void btnSumit_Click(object sender, EventArgs e)
        {
            try
            {
                int firma_id = GetIdFromTable("firma", "firma", cbFirma.Text);
                int werknemer_id = GetIdFromTable("werknemers", "werknemer", cbWerknemer.Text);
                int opdrachtgever_id = GetIdFromTable("opdrachtgevers", "opdrachtgever", cbOpdrachtgever.Text);
                int voertuig_id = GetIdFromTable("voertuigen", "voertuig", cbVoertuigen.Text);
                int site_id = GetIdFromTable("sites", "site", cbSite.Text);

                string query = "INSERT INTO vergunning " +
                    "(firma_firma_id, werknemers_werknemer_id, opdrachtgevers_opdrachtgever_id, voertuigen_voertuig_id, sites_site_id," +
                    "start_datum, eind_datum, aantal_personen, korte_omschrijving, gedetaileerde_omschrijving, optie, extra_uitrustingen) " +
                    "VALUES " +
                    "(@firma_firma_id, @werknemers_werknemer_id, @opdrachtgevers_opdrachtgever_id, @voertuigen_voertuig_id, @sites_site_id," +
                    "@start_datum, @eind_datum, @aantal_personen, @korte_omschrijving, @gedetaileerde_omschrijving, @optie, @extra_uitrustingen)";

                using (var connection = new MySqlConnection(Globaal.user))
                {
                    connection.Open();
                    var command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@firma_firma_id", firma_id);
                    command.Parameters.AddWithValue("@werknemers_werknemer_id", werknemer_id);
                    command.Parameters.AddWithValue("@opdrachtgevers_opdrachtgever_id", opdrachtgever_id);
                    command.Parameters.AddWithValue("@voertuigen_voertuig_id", voertuig_id);
                    command.Parameters.AddWithValue("@sites_site_id", site_id);
                    command.Parameters.AddWithValue("@start_datum", dtpStart.Value);
                    command.Parameters.AddWithValue("@eind_datum", dtpStop.Value);
                    command.Parameters.AddWithValue("@aantal_personen", Convert.ToInt32(nupPersonen.Text));
                    command.Parameters.AddWithValue("@korte_omschrijving", tbKorte.Text);
                    command.Parameters.AddWithValue("@gedetaileerde_omschrijving", tbGetaileerde.Text);
                    command.Parameters.AddWithValue("@optie", tbToelatingen.Text);
                    command.Parameters.AddWithValue("@extra_uitrustingen", tbExtra.Text);
                    command.ExecuteNonQuery();
                    connection.Close(); 
                }

                int id = 0;
                query = "SELECT vegunning_id FROM vergunning ORDER BY vegunning_id DESC LIMIT 1;";
                using (var connection = new MySqlConnection(Globaal.user))
                {
                    connection.Open();
                    var command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        id = int.Parse(reader["vegunning_id"].ToString());
                    }
                    connection.Close();
                }

                if (chbVuurvergunning.Checked)
                {
                    query = "update vergunning set vuurvergunning_vuurvergunning_id = @vuurvergunning_vuurvergunning_id where vegunning_id=@vegunning_id";
                    using (var connection = new MySqlConnection(Globaal.user))
                    {
                        connection.Open();
                        var command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@vuurvergunning_vuurvergunning_id", Globaal.vuurId);
                        command.Parameters.AddWithValue("@vegunning_id", id);
                        MySqlDataReader reader = command.ExecuteReader();
                        connection.Close();
                    }
                }
                if (chbOpenvergunning.Checked)
                {
                    query = "update vergunning set open_vergunning_open_vergunning_id = @open_vergunning_open_vergunning_id where vegunning_id=@vegunning_id";
                    using (var connection = new MySqlConnection(Globaal.user))
                    {
                        connection.Open();
                        var command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@open_vergunning_open_vergunning_id", Globaal.openId);
                        command.Parameters.AddWithValue("@vegunning_id", id);
                        MySqlDataReader reader = command.ExecuteReader();
                        connection.Close();
                    }
                }
                if (chbBeslotenvergunning.Checked)
                {
                    query = "update vergunning set besloten_vergunning_besloten_vergunning_id = @besloten_vergunning_besloten_vergunning_id where vegunning_id=@vegunning_id";
                    using (var connection = new MySqlConnection(Globaal.user))
                    {
                        connection.Open();
                        var command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@besloten_vergunning_besloten_vergunning_id", Globaal.sluitId);
                        command.Parameters.AddWithValue("@vegunning_id", id);
                        MySqlDataReader reader = command.ExecuteReader();
                        connection.Close();
                    }
                }
                cbFirma.Text = string.Empty;
                cbWerknemer.Text = string.Empty;
                cbOpdrachtgever.Text = string.Empty;
                cbVoertuigen.Text = string.Empty;
                cbSite.Text = string.Empty;
                dtpStart.Value = DateTime.Now;
                dtpStop.Value = DateTime.Now;
                nupPersonen.Value = 0;
                tbKorte.Text = string.Empty;
                tbGetaileerde.Text = string.Empty;
                tbToelatingen.Text = string.Empty;
                tbExtra.Text = string.Empty;
            }
            catch { }
            
        }

        private void chbVuurvergunning_CheckedChanged(object sender, EventArgs e)
        {
            if (chbVuurvergunning.Checked)
            {
                Vuurvergunning ss = new Vuurvergunning();
                ss.Show();
            }
        }

        private void chbBeslotenvergunning_CheckedChanged(object sender, EventArgs e)
        {
            if (chbBeslotenvergunning.Checked)
            {
                Beslotenvergunning ss = new Beslotenvergunning();
                ss.Show();
            }
        }

        private void chbOpenvergunning_CheckedChanged(object sender, EventArgs e)
        {
            if (chbOpenvergunning.Checked)
            {
                Openvergunning ss = new Openvergunning();
                ss.Show();
            }
        }
    }
}
