using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class Admin : Form
    {
        private string Firma_naam_pv = "";
        private string weknemers_naam_pv = "";
        private string opdrachtgevers_naam_pv = "";
        private string site_naam_pv = "";
        private string voertuigen_naam_pv = "";

        private void Load_opdrachtgever()
        {
            cbOpdrachtgever.Items.Clear();
            cbOpdrachtgever.Text = string.Empty;
            tbGSMnummer_opdrachtgever.Text = string.Empty;
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
            cbSite.Items.Clear();
            cbSite.Text = string.Empty;
            tbSiteverantwoordelijke.Text = string.Empty;
            tbGSMnummer_site.Text = string.Empty;
            tbNoodnummer.Text = string.Empty;   
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

        private void Load_voetuigen(int firma_firma_id)
        {
            cbVoertuigen.Items.Clear();
            cbVoertuigen.Text = string.Empty;
            tbMerk.Text = string.Empty;
            string query = "select voertuig_naam from voertuigen where firma_firma_id = @firma_firma_id";
            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@firma_firma_id", firma_firma_id);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string voertuig_naam = reader["voertuig_naam"].ToString();
                    cbVoertuigen.Items.Add(voertuig_naam);
                }
                connection.Close();
            }
        }

        private void Load_werknemer(int firma_firma_id)
        {
            cbWerknemer.Items.Clear();
            cbWerknemer.Text = string.Empty;
            tbGSMnummer_werknemer.Text = string.Empty;
            dtpExamen.Value = DateTime.Now;
            string query = "select werknemer_naam from werknemers where firma_firma_id = @firma_firma_id";
            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@firma_firma_id", firma_firma_id);
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
            cbFirma.Items.Clear();
            cbFirma.Text = string.Empty;
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

        public Admin()
        {
            InitializeComponent();
            Load_firma();
            Load_site();
            Load_opdrachtgever();
        }


        private void btnAdd_Firma_Click(object sender, EventArgs e)
        {
            
            string query = "insert into firma (firma_naam) values (@firma_naam)";
            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@firma_naam", cbFirma.Text);
                MySqlDataReader reader = command.ExecuteReader(); 
                connection.Close();
            }
            Load_firma();
        }

        private void btnAdd_Werkenemer_Click(object sender, EventArgs e)
        {
            string query = "insert into werknemers (werknemer_naam,datum_examen,gsm_nummer,firma_firma_id) values (@werknemers_naam,@datum_examen,@gsm_nummer,@firma_firma_id)";
            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@werknemers_naam", cbWerknemer.Text);
                command.Parameters.AddWithValue("@datum_examen", DateTime.Parse(dtpExamen.Text));
                command.Parameters.AddWithValue("@gsm_nummer", tbGSMnummer_werknemer.Text);
                command.Parameters.AddWithValue("@firma_firma_id", Globaal.GetIdFromTable("firma","firma",cbFirma.Text));
                MySqlDataReader reader = command.ExecuteReader();
                connection.Close();
            }
            Load_werknemer(Globaal.GetIdFromTable("firma", "firma", cbFirma.Text));
        }

        private void btnAdd_Voertuigen_Click(object sender, EventArgs e)
        {
            string query = "insert into voertuigen (voertuig_naam,merk,firma_firma_id) values (@voertuig_naam,@merk,@firma_firma_id)";
            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@voertuig_naam", cbVoertuigen.Text);
                command.Parameters.AddWithValue("@merk", tbMerk.Text);
                command.Parameters.AddWithValue("@firma_firma_id", Globaal.GetIdFromTable("firma", "firma", cbFirma.Text));
                MySqlDataReader reader = command.ExecuteReader();
                connection.Close();
            }
            Load_voetuigen(Globaal.GetIdFromTable("firma", "firma", cbFirma.Text));
        }

        private void btnAdd_Opdrachtgever_Click(object sender, EventArgs e)
        {
            string query = "insert into opdrachtgevers (opdrachtgever_naam,gsm_nummer) values (@opdrachtgever_naam,@gsm_nummer)";
            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@opdrachtgever_naam", cbOpdrachtgever.Text);
                command.Parameters.AddWithValue("@gsm_nummer", tbGSMnummer_opdrachtgever.Text);
                MySqlDataReader reader = command.ExecuteReader();
                connection.Close();
            }
            Load_opdrachtgever();
        }

        private void btnAdd_Site_Click(object sender, EventArgs e)
        {
            string query = "insert into sites (site_naam,siteverantwoordelijke,gsm_nummer,noodnummer) values (@site_naam,@siteverantwoordelijke,@gsm_nummer,@noodnummer)";
            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@site_naam", cbSite.Text);
                command.Parameters.AddWithValue("@siteverantwoordelijke", tbSiteverantwoordelijke.Text);
                command.Parameters.AddWithValue("@gsm_nummer", tbGSMnummer_site.Text);
                command.Parameters.AddWithValue("@noodnummer", tbNoodnummer.Text);
                MySqlDataReader reader = command.ExecuteReader();
                connection.Close();
            }
            Load_site();
        }

        private void cbFirma_SelectedIndexChanged(object sender, EventArgs e)
        {
            Firma_naam_pv = cbFirma.Text;
            Load_voetuigen(Globaal.GetIdFromTable("firma", "firma", cbFirma.Text));
            Load_werknemer(Globaal.GetIdFromTable("firma", "firma", cbFirma.Text));
        }

        private void cbWerknemer_SelectedIndexChanged(object sender, EventArgs e)
        {
            weknemers_naam_pv = cbWerknemer.Text;
            string query = "select datum_examen,gsm_nummer from werknemers where werknemer_naam=@werknemer_naam";
            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@werknemer_naam", cbWerknemer.Text);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    DateTime datum_examen = DateTime.Parse(reader["datum_examen"].ToString());
                    string gsm_nummer = reader["gsm_nummer"].ToString();
                    dtpExamen.Value = datum_examen;
                    tbGSMnummer_werknemer.Text = gsm_nummer;
                }
                connection.Close();
            }
        }

        private void cbVoertuigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            voertuigen_naam_pv = cbVoertuigen.Text;
            string query = "select merk from voertuigen where voertuig_naam=@voertuig_naam";
            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@voertuig_naam", cbVoertuigen.Text);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string merk = reader["merk"].ToString();
                    tbMerk.Text = merk;
                }
                connection.Close();
            }
        }

        private void cbOpdrachtgever_SelectedIndexChanged(object sender, EventArgs e)
        {
            opdrachtgevers_naam_pv = cbOpdrachtgever.Text;
            string query = "select gsm_nummer from opdrachtgevers where opdrachtgever_naam=@opdrachtgever_naam";
            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@opdrachtgever_naam", cbOpdrachtgever.Text);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string gsm_nummer = reader["gsm_nummer"].ToString();
                    tbGSMnummer_opdrachtgever.Text = gsm_nummer;
                }
                connection.Close();
            }
        }

        private void cbSite_SelectedIndexChanged(object sender, EventArgs e)
        {
            site_naam_pv= cbSite.Text;
            string query = "select siteverantwoordelijke,gsm_nummer,noodnummer from sites where site_naam=@site_naam";
            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@site_naam", cbSite.Text);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string sitenaamveranwoordelijke = reader["siteverantwoordelijke"].ToString();
                    tbSiteverantwoordelijke.Text = sitenaamveranwoordelijke;
                    string gsm_nummer = reader["gsm_nummer"].ToString();
                    tbGSMnummer_site.Text = gsm_nummer;
                    string noodnummer = reader["noodnummer"].ToString();
                    tbNoodnummer.Text = noodnummer;
                }
                connection.Close();
            }
        }

        private void btnUpdate_Firma_Click(object sender, EventArgs e)
        {
            int firma_id = Globaal.GetIdFromTable("firma", "firma", Firma_naam_pv);
            string query = "update firma set firma_naam = @firma_naam where firma_id=@firma_id";
            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@firma_id", firma_id);
                command.Parameters.AddWithValue("@firma_naam", cbFirma.Text);
                MySqlDataReader reader = command.ExecuteReader();
                connection.Close();
            }
            Load_firma();
        }

        private void btnUpdate_Werknemer_Click(object sender, EventArgs e)
        {
            int werknemer_id = Globaal.GetIdFromTable("werknemers", "werknemer", weknemers_naam_pv);
            string query = "update werknemers set werknemer_naam=@werknemer_naam, datum_examen=@datum_examen, gsm_nummer=@gsm_nummer where werknemer_id=@werknemer_id";
            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@werknemer_id", werknemer_id);
                command.Parameters.AddWithValue("@werknemer_naam", cbWerknemer.Text);
                command.Parameters.AddWithValue("@datum_examen", DateTime.Parse(dtpExamen.Text));
                command.Parameters.AddWithValue("@gsm_nummer", tbGSMnummer_werknemer.Text);
                MySqlDataReader reader = command.ExecuteReader();
                connection.Close();
            }
            Load_werknemer(Globaal.GetIdFromTable("firma", "firma", cbFirma.Text));
        }

        private void btnUpdate_Voertuigen_Click(object sender, EventArgs e)
        {
            int voertuig_id = Globaal.GetIdFromTable("voertuigen", "voertuig", voertuigen_naam_pv);
            string query = "update voertuigen set voertuig_naam =@voertuig_naam, merk=@merk where voertuig_id=@voertuig_id";
            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@voertuig_id", voertuig_id);
                command.Parameters.AddWithValue("@voertuig_naam", cbVoertuigen.Text);
                command.Parameters.AddWithValue("@merk", tbMerk.Text);
                MySqlDataReader reader = command.ExecuteReader();
                connection.Close();
            }
            Load_voetuigen(Globaal.GetIdFromTable("firma", "firma", cbFirma.Text));
        }

        private void btnUpdate_Opdrachtgever_Click(object sender, EventArgs e)
        {
            int opdrachtgever_id = Globaal.GetIdFromTable("opdrachtgevers", "opdrachtgever", opdrachtgevers_naam_pv);
            string query = "update opdrachtgevers set opdrachtgever_naam =@opdrachtgever_naam, gsm_nummer=@gsm_nummer where opdrachtgever_id=@opdrachtgever_id";
            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@opdrachtgever_id", opdrachtgever_id);
                command.Parameters.AddWithValue("@opdrachtgever_naam", cbOpdrachtgever.Text);
                command.Parameters.AddWithValue("@gsm_nummer", tbGSMnummer_opdrachtgever.Text);
                MySqlDataReader reader = command.ExecuteReader();
                connection.Close();
            }
            Load_opdrachtgever();
        }

        private void btnUpdate_Sitenaam_Click(object sender, EventArgs e)
        {
            int site_id = Globaal.GetIdFromTable("sites", "site", site_naam_pv);
            string query = "update sites set site_naam=@site_naam, siteverantwoordelijke=@siteverantwoordelijke, gsm_nummer=@gsm_nummer, noodnummer=@noodnummer where site_id=@site_id";
            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@site_id", site_id);
                command.Parameters.AddWithValue("@site_naam", cbSite.Text);
                command.Parameters.AddWithValue("@siteverantwoordelijke", tbSiteverantwoordelijke.Text);
                command.Parameters.AddWithValue("@gsm_nummer", tbGSMnummer_site.Text);
                command.Parameters.AddWithValue("@noodnummer", tbNoodnummer.Text);
                MySqlDataReader reader = command.ExecuteReader();
                connection.Close();
            }
            Load_site();
        }

        private void btnDelete_Firma_Click(object sender, EventArgs e)
        {
            Globaal.DeleteDataFromTable("firma", "firma", cbFirma.Text);
            Load_firma();
        }

        private void btnDelete_Werknemer_Click(object sender, EventArgs e)
        {
            Globaal.DeleteDataFromTable("werknemers", "werknemer", cbWerknemer.Text);
            Load_werknemer(Globaal.GetIdFromTable("firma", "firma", cbFirma.Text));
        }

        private void btnDelete_Voertuigen_Click(object sender, EventArgs e)
        {
            Globaal.DeleteDataFromTable("voertuigen", "voertuig", cbVoertuigen.Text);
            Load_voetuigen(Globaal.GetIdFromTable("firma", "firma", cbFirma.Text));
        }

        private void btnDelete_Opdrachtgever_Click(object sender, EventArgs e)
        {
            Globaal.DeleteDataFromTable("opdrachtgevers", " opdrachtgever", cbOpdrachtgever.Text);
            Load_opdrachtgever();
        }

        private void btnDelete_Site_Click(object sender, EventArgs e)
        {
            Globaal.DeleteDataFromTable("sites", "site", cbSite.Text);
            Load_site();
        }
    }
}
