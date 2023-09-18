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
    public partial class Vuurvergunning : Form
    {
        private void Load_werk()
        {
            cbBrand.Items.Clear();
            cbOmgeving.Items.Clear();
            cbInstallatie.Items.Clear();
            cbAard.Items.Clear();
            cbBrand.Text = string.Empty;
            cbOmgeving.Text = string.Empty;
            cbInstallatie.Text = string.Empty;
            cbAard.Text = string.Empty;
            string query = "select * from werken";
            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string werken = reader["werken"].ToString();
                    char eenType = char.Parse(reader["type"].ToString());
                    switch(eenType)
                    {
                        case 'A':
                            cbAard.Items.Add(werken); break;
                        case 'I':
                            cbInstallatie.Items.Add(werken); break;
                        case 'B':
                            cbBrand.Items.Add(werken); break;
                        case 'O':
                            cbOmgeving.Items.Add(werken); break;
                        default: break;
                    }
                }
                connection.Close();
            }
        }
        
        private int Get_werken_Id(string werken, char type)
        {
            int id = 0;
            string query = "SELECT werken_id FROM werken where werken=@werken and type=@type;";
            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@werken", werken);
                command.Parameters.AddWithValue("@type", type);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    id = int.Parse(reader["werken_id"].ToString());
                }
                connection.Close();
            }
            return id;
        }

        public Vuurvergunning()
        {
            InitializeComponent();
            Load_werk();
        }

        private void cbAard_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbInstallatie_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbOmgeving_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSumit_Click(object sender, EventArgs e)
        {
            //try
            //{
                string query = "INSERT INTO vuurvergunning (" +
                "datum,start_time,end_time,verlenging,bijkomnde_maatregelen) " +
                "VALUES (@datum,@start_time,@end_time,@verlenging,@bijkomnde_maatregelen);";
                using (var connection = new MySqlConnection(Globaal.user))
                {
                    connection.Open();
                    var command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@datum", dtpDatum.Value);
                    command.Parameters.AddWithValue("@start_time", stpVan.Value);
                    command.Parameters.AddWithValue("@end_time", dtpTot.Value);
                    command.Parameters.AddWithValue("@verlenging", int.Parse(tbVerlenging.Text));
                    command.Parameters.AddWithValue("@bijkomnde_maatregelen", tbMaatregelen.Text);
                    command.ExecuteNonQuery();
                    connection.Close();
                }

                int id = 0;
                query = "SELECT vuurvergunning_id FROM vuurvergunning ORDER BY vuurvergunning_id DESC LIMIT 1;";
                using (var connection = new MySqlConnection(Globaal.user))
                {
                    connection.Open();
                    var command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        id = int.Parse(reader["vuurvergunning_id"].ToString());
                        Globaal.vuurId = id;
                    }
                    connection.Close();
                }

                query = "INSERT INTO werken_has_vuurvergunning " +
                    "(extra,vuurvergunning_vuurvergunning_id,werken_werken_id) " +
                    "VALUES (@extra,@vuurvergunning_vuurvergunning_id,@werken_werken_id);";
                for (int i = 0; i < lbxAard.Items.Count; i++)
                {
                    using (var connection = new MySqlConnection(Globaal.user))
                    {
                        connection.Open();
                        var command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@extra", lbxAardP.Items[i].ToString());
                        command.Parameters.AddWithValue("@vuurvergunning_vuurvergunning_id", id);
                        command.Parameters.AddWithValue("@werken_werken_id", Get_werken_Id(lbxAard.Items[i].ToString(), 'A'));
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }

                for (int i = 0; i < lbxOmpgeving.Items.Count; i++)
                {
                    using (var connection = new MySqlConnection(Globaal.user))
                    {
                        connection.Open();
                        var command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@extra", lbxOmpgevingP.Items[i].ToString());
                        command.Parameters.AddWithValue("@vuurvergunning_vuurvergunning_id", id);
                        command.Parameters.AddWithValue("@werken_werken_id", Get_werken_Id(lbxOmpgeving.Items[i].ToString(), 'O'));
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }

                for (int i = 0; i < lbxBrand.Items.Count; i++)
                {
                    using (var connection = new MySqlConnection(Globaal.user))
                    {
                        connection.Open();
                        var command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@extra", lbxBrandP.Items[i].ToString());
                        command.Parameters.AddWithValue("@vuurvergunning_vuurvergunning_id", id);
                        command.Parameters.AddWithValue("@werken_werken_id", Get_werken_Id(lbxBrand.Items[i].ToString(), 'B'));
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }

                for (int i = 0; i < lbxInstallatie.Items.Count; i++)
                {
                    using (var connection = new MySqlConnection(Globaal.user))
                    {
                        connection.Open();
                        var command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@extra", lbxInstallatieP.Items[i].ToString());
                        command.Parameters.AddWithValue("@vuurvergunning_vuurvergunning_id", id);
                        command.Parameters.AddWithValue("@werken_werken_id", Get_werken_Id(lbxInstallatie.Items[i].ToString(), 'I'));
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
                this.Close();
            //}
            //catch { }
            
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            lbxAard.Items.Add(cbAard.Text);
            lbxAardP.Items.Add(tbAard.Text);
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            lbxInstallatie.Items.Add(cbInstallatie.Text);
            lbxInstallatieP.Items.Add(tbIstallatie.Text);
        }

        private void brnO_Click(object sender, EventArgs e)
        {
            lbxOmpgeving.Items.Add(cbOmgeving.Text);
            lbxOmpgevingP.Items.Add(tbOmgeving.Text);
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            lbxBrand.Items.Add(cbBrand.Text);
            lbxBrandP.Items.Add(tbBrand.Text);
        }
    }
}
