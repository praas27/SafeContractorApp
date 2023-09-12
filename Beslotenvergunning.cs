using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
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
    public partial class Beslotenvergunning : Form
    {
        private void Load_risico()
        {
            string query = "select risico from risico";
            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string risico = reader["risico"].ToString();
                    cbRisico.Items.Add(risico);
                }
                connection.Close();
            }
        }

        private void Load_meting()
        {
            string query = "select meting from metingen";
            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string meting = reader["meting"].ToString();
                    cbMetingen.Items.Add(meting);
                }
                connection.Close();
            }
        }

        private void Load_besloten_maatregelen()
        {
            string query = "select besloten_maatregelen from besloten_maatregelen";
            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string besloten_maatregelen = reader["besloten_maatregelen"].ToString();
                    cbMaatregel.Items.Add(besloten_maatregelen);
                }
                connection.Close();
            }
        }

        private void Load_beschermiddelen()
        {
            string query = "select beschermiddelen from beschermiddelen";
            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string beschermiddelen = reader["beschermiddelen"].ToString();
                    cbBeschermings.Items.Add(beschermiddelen);
                }
                connection.Close();
            }
        }

        private int Get_metingen_Id(string meting)
        {
            int id = 0;
            string query = "SELECT metingen_id FROM metingen where meting=@meting;";
            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@meting", meting);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    id = int.Parse(reader["metingen_id"].ToString());
                }
                connection.Close();
            }
            return id;
        }

        private int Get_besloten_maatregelen_Id(string maatregel)
        {
            int id = 0;
            string query = "SELECT besloten_maatregelen_id FROM besloten_maatregelen where besloten_maatregelen=@besloten_maatregelen;";
            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@besloten_maatregelen", maatregel);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    id = int.Parse(reader["besloten_maatregelen_id"].ToString());
                }
                connection.Close();
            }
            return id;
        }

        private int Get_risico_id(string risico)
        {
            int id = 0;
            string query = "SELECT risico_id FROM risico where risico=@risico;";
            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@risico", risico);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    id = int.Parse(reader["risico_id"].ToString());
                }
                connection.Close();
            }
            return id;
        }

        private int Get_beschermiddelen_beschermiddelen_id(string beschermiddelen)
        {
            int id = 0;
            string query = "SELECT beschermiddelen_id FROM beschermiddelen where beschermiddelen=@beschermiddelen;";
            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@beschermiddelen", beschermiddelen);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    id = int.Parse(reader["beschermiddelen_id"].ToString());
                }
                connection.Close();
            }
            return id;
        }

        public Beslotenvergunning()
        {
            InitializeComponent();
            Load_beschermiddelen();
            Load_besloten_maatregelen();
            Load_meting();
            Load_risico();
        }

        private void cbMetingen_SelectedIndexChanged(object sender, EventArgs e)
        {
            lsbMeting.Items.Add(cbMetingen.Text);
            lsbMetingParaaf.Items.Add(tbMetingen.Text);
        }

        private void cbRisico_SelectedIndexChanged(object sender, EventArgs e)
        {
            lsbRisico.Items.Add(cbRisico.Text);
        }

        private void cbMaatregel_SelectedIndexChanged(object sender, EventArgs e)
        {
            lsbMaatregelen.Items.Add(cbMaatregel.Text);
            lsbMaatregelParaaf.Items.Add(tbMaatregel.Text);
        }

        private void cbBeschermings_SelectedIndexChanged(object sender, EventArgs e)
        {
            lsbBescherm.Items.Add(cbBescherm.Text);
        }

        private void tbMetingen_Enter(object sender, EventArgs e)
        {
            //lsbMetingParaaf.Items[lsbMeting.Items.Count-1] = tbMetingen.Text;
        }

        private void tbMaatregel_Enter(object sender, EventArgs e)
        {
            //lsbMaatregelen.Items[lsbMaatregelen.Items.Count - 1] = tbMaatregel.Text;
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "INSERT INTO besloten_vergunning" +
                    "(datum, start, stop, afdeling, ruimte, werkbeschrijving, product)" +
                    "VALUES" +
                    "(@datum, @start, @stop, @afdeling, @ruimte, @werkbeschrijving, @product)";
                using (var connection = new MySqlConnection(Globaal.user))
                {
                    connection.Open();
                    var command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@datum", dtpDatum.Value);
                    command.Parameters.AddWithValue("@start", stpVan.Value);
                    command.Parameters.AddWithValue("@stop", dtpTot.Value);
                    command.Parameters.AddWithValue("@afdeling", tbAfdeling.Text);
                    command.Parameters.AddWithValue("@ruimte", tbRuimte.Text);
                    command.Parameters.AddWithValue("@werkbeschrijving", tbWerkbeschrjving.Text);
                    command.Parameters.AddWithValue("@product", tbProduct.Text);
                    command.ExecuteNonQuery();
                    connection.Close();
                }

                int id = 0;
                query = "SELECT besloten_vergunning_id FROM besloten_vergunning ORDER BY besloten_vergunning_id DESC LIMIT 1;";
                using (var connection = new MySqlConnection(Globaal.user))
                {
                    connection.Open();
                    var command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        id = int.Parse(reader["besloten_vergunning_id"].ToString());
                        Globaal.sluitId = id;
                    }
                    connection.Close();
                }

                query = "INSERT INTO maatregelen_has_besloten_vergunningen " +
                    "(paraaf, besloten_vergunning_besloten_vergunning_id, besloten_maatregelen_besloten_maatregelen_id)" +
                    "VALUES" +
                    "(@paraaf, @besloten_vergunning_besloten_vergunning_id, @besloten_maatregelen_besloten_maatregelen_id);";
           
                for (int i = 0; i < lsbMaatregelen.Items.Count; i++)
                {
                     int tetst1 = id;
                    int test2 = Get_besloten_maatregelen_Id(lsbMaatregelen.Items[i].ToString());
                    using (var connection = new MySqlConnection(Globaal.user))
                    {
                        connection.Open();
                        var command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@paraaf", lsbMaatregelParaaf.Items[i].ToString());
                        command.Parameters.AddWithValue("@besloten_vergunning_besloten_vergunning_id", id);
                        command.Parameters.AddWithValue("@besloten_maatregelen_besloten_maatregelen_id", Get_besloten_maatregelen_Id(lsbMaatregelen.Items[i].ToString()));
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }

                query = "INSERT INTO meting_has_besloten_vergunnning " +
                    "(paraaf, metingen_metingen_id, besloten_vergunning_besloten_vergunning_id)" +
                    "VALUES" +
                    "(@paraaf, @metingen_metingen_id, @besloten_vergunning_besloten_vergunning_id);";
                for (int i = 0; i < lsbMeting.Items.Count; i++)
                {
                    using (var connection = new MySqlConnection(Globaal.user))
                    {
                        connection.Open();
                        var command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@paraaf", lsbMetingParaaf.Items[i].ToString());
                        command.Parameters.AddWithValue("@besloten_vergunning_besloten_vergunning_id", id);
                        command.Parameters.AddWithValue("@metingen_metingen_id", Get_metingen_Id(lsbMeting.Items[i].ToString()));
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }

                query = "INSERT INTO risico_has_besloten_vergunning " +
                    "(risico_risico_id, besloten_vergunning_besloten_vergunning_id)" +
                    "VALUES" +
                    "(@risico_risico_id, @besloten_vergunning_besloten_vergunning_id);";
                for (int i = 0; i < lsbRisico.Items.Count; i++)
                {
                    using (var connection = new MySqlConnection(Globaal.user))
                    {
                        connection.Open();
                        var command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@besloten_vergunning_besloten_vergunning_id", id);
                        command.Parameters.AddWithValue("@risico_risico_id", Get_risico_id(lsbRisico.Items[i].ToString()));
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }

                query = "INSERT INTO besloten_vergunning_has_beschermiddelen " +
                    "(besloten_vergunning_besloten_vergunning_id, beschermiddelen_beschermiddelen_id)" +
                    "VALUES" +
                    "(@besloten_vergunning_besloten_vergunning_id, @beschermiddelen_beschermiddelen_id);";
                for (int i = 0; i < lsbBescherm.Items.Count; i++)
                {
                    using (var connection = new MySqlConnection(Globaal.user))
                    {
                        connection.Open();
                        var command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@besloten_vergunning_besloten_vergunning_id", id);
                        command.Parameters.AddWithValue("@beschermiddelen_beschermiddelen_id", Get_beschermiddelen_beschermiddelen_id(lsbBescherm.Items[i].ToString()));
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
                this.Close();
            }
            catch { }
        }
    }
}
