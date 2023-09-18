using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SafeContractorApp
{
    public partial class Openvergunning : Form
    {
        private void Load_Maatregelen_CB()
        {
            string query = "select maatregel from maatregelen";
            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string maatregel = reader["maatregel"].ToString();
                    cbMaatregelen.Items.Add(maatregel);
                }
                connection.Close();
            }
        }

        private string Formaat_producten()
        {
            string product = "";
            product = chbOntvlambaar.Checked ? product + "1" : product + "0";
            product = chbBijtend.Checked ? product + "2" : product + "0";
            product = chbGezond.Checked ? product + "3" : product + "0";
            product = chbGinder.Checked ? product + "4" : product + "0";
            return product;
        }

        private string Formaat_uitvoerder()
        {
            return chbUitvoerder.Checked ? "1" : "0";
        }

        private string Formaat_kopie()
        {
            string kopie = "";
            kopie = chbPreventiedienst.Checked ? kopie + "1" : kopie + "0";
            kopie = chbControlkamer.Checked ? kopie + "2" : kopie + "0";
            return kopie;
        }

        private int Get_maatregel_Id(string maatregel)
        {
            int id = 0;
            string query = "SELECT maatregelen_id FROM maatregelen where maatregel=@maatregel;";
            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@maatregel", maatregel);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    id = int.Parse(reader["maatregelen_id"].ToString());
                }
                connection.Close();
            }
            return id;
        }

        public Openvergunning()
        {
            InitializeComponent();
            Load_Maatregelen_CB();
        }

        private void tbAdd_Click(object sender, EventArgs e)
        {
            lsbMaatregelen.Items.Add(cbMaatregelen.Text);
            lsbParaaf.Items.Add(tbExtra.Text);
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "INSERT INTO open_vergunning (datum, start_time, eind_time, afdeling, leiding, product, werkbeschrijving, uitvoerder, kopie) " +
                    "VALUES(@datum, @start_time,@eind_time, @afdeling, @leiding, @product, @werkbeschrijving, @uitvoerder,@kopie);";
                using (var connection = new MySqlConnection(Globaal.user))
                {
                    connection.Open();
                    var command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@datum", dtpDatum.Value);
                    command.Parameters.AddWithValue("@start_time", stpVan.Value);
                    command.Parameters.AddWithValue("@eind_time", dtpTot.Value);
                    command.Parameters.AddWithValue("@afdeling", tbAfdeling.Text);
                    command.Parameters.AddWithValue("@leiding", tbLeiding.Text);
                    command.Parameters.AddWithValue("@product", Formaat_producten());//
                    command.Parameters.AddWithValue("@werkbeschrijving",tbWerkbeschrijving.Text);
                    command.Parameters.AddWithValue("@uitvoerder", Formaat_uitvoerder());
                    command.Parameters.AddWithValue("@kopie", Formaat_kopie());
                    command.ExecuteNonQuery();
                    connection.Close();
                }

                int id = 0;
                query = "SELECT open_vergunning_id FROM open_vergunning ORDER BY open_vergunning_id DESC LIMIT 1;";
                using (var connection = new MySqlConnection(Globaal.user))
                {
                    connection.Open();
                    var command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        id = int.Parse(reader["open_vergunning_id"].ToString());
                        Globaal.openId = id;
                    }
                    connection.Close();
                }

                query = "INSERT INTO maatregelen_has_open_vergunning (maatregelen_maatregelen_id, open_vergunning_open_vergunning_id, antwoord, extra)" +
                    "VALUES(@maatregelen_maatregelen_id, @open_vergunning_open_vergunning_id, @antwoord, @extra);";
                for (int i = 0; i < lsbMaatregelen.Items.Count; i++)
                {
                    using (var connection = new MySqlConnection(Globaal.user))
                    {
                        connection.Open();
                        var command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@extra", lsbParaaf.Items[i].ToString());
                        command.Parameters.AddWithValue("@open_vergunning_open_vergunning_id", id);
                        command.Parameters.AddWithValue("@maatregelen_maatregelen_id", Get_maatregel_Id(lsbMaatregelen.Items[i].ToString()));
                        command.Parameters.AddWithValue("@antwoord", 'J');
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
                this.Close();
            }
            catch { }
        }

        private void cbMaatregelen_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbExtra.Text = string.Empty;
        }
    }
}
