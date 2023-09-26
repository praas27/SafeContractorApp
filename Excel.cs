using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SafeContractorApp
{
    public partial class Excel : Form
    {
        private string FormAquery()
        {
            string query = "SELECT ";
            List<string> conditions = new List<string>();

            if (vegunning_id.Checked) conditions.Add("vegunning_id");
            if (korte_omschrijving.Checked) conditions.Add("korte_omschrijving");
            if (gedetaileerde_omschrijving.Checked) conditions.Add("gedetaileerde_omschrijving");
            if (optie.Checked) conditions.Add("optie");
            if (extra_uitrustingen.Checked) conditions.Add("extra_uitrustingen");
            if (start_datum.Checked) conditions.Add("start_datum");
            if (eind_datum.Checked) conditions.Add("eind_datum");
            if (aantal_personen.Checked) conditions.Add("aantal_personen");
            if (firma_id.Checked) conditions.Add("firma_firma_id");
            if (werknemer_id.Checked) conditions.Add("werknemers_werknemer_id");
            if (voertuig_id.Checked) conditions.Add("voertuigen_voertuig_id");
            if (opdrachtgever_id.Checked) conditions.Add("opdrachtgevers_opdrachtgever_id");
            if (site_id.Checked) conditions.Add("sites_site_id");
            if (vuurvergunning_id.Checked) conditions.Add("vuurvergunning_vuurvergunning_id");
            if (open_vergunning_id.Checked) conditions.Add("open_vergunning_open_vergunning_id");
            if (besloten_vergunning_id.Checked) conditions.Add("besloten_vergunning_besloten_vergunning_id");

            // Combineer de voorwaarden met een logische 'OR' en voeg ze toe aan de query
            query += string.Join(" , ", conditions);

            // Voeg een WHERE-clausule toe voor het vegunning_id-bereik
            query += $" FROM vergunning WHERE vegunning_id >= {int.Parse(tbVan.Text)} AND vegunning_id <= {int.Parse(tbTot.Text)}";

            // Als geen enkel selectievakje is aangevinkt, selecteer dan alles (of pas dit aan naar je behoeften)
            if (conditions.Count == 0)
            {
                query = "SELECT * FROM vergunning";
            }

            return query;
        }


        private void ExportVergunningDataToCSV()
        {
            string query = FormAquery();

            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                // Maak een StreamWriter om het CSV-bestand te schrijven
                using (var writer = new StreamWriter($@"{Properties.Settings.Default.Work}/boekhouding.csv"))
                {
                    // Schrijf de kolomkoppen naar het CSV-bestand
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        writer.Write(reader.GetName(i));
                        if (i < reader.FieldCount - 1)
                        {
                            writer.Write(",");
                        }
                    }
                    writer.WriteLine();

                    // Schrijf de gegevens naar het CSV-bestand
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            writer.Write(reader[i]);
                            if (i < reader.FieldCount - 1)
                            {
                                writer.Write(",");
                            }
                        }
                        writer.WriteLine();
                    }
                }

                connection.Close();
            }
        }


        public Excel()
        {
            InitializeComponent();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ExportVergunningDataToCSV();
        }
    }
}
