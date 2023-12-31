﻿using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections;
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
            string query = "SELECT * FROM vergunning ORDER BY vegunning_id DESC;";

            using (var connection = new MySqlConnection(Globaal.user))
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

        private void btnPDF_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvVergunning.SelectedRows[0];
            Globaal.printId = int.Parse(selectedRow.Cells[0].Value.ToString());
            PdfVergunning.GenDoc(Globaal.printId);
            try
            {
                PdfVuurvergunning.GenDoc(Globaal.printId);
            }
            catch { }
            try
            {
                PdfOpenvergunning.GenDoc(Globaal.printId);
            }
            catch { }
            try
            {
                PdfBeslotenvergunning.GenDoc(Globaal.printId);
            }catch { }
            Print ss= new Print();
            ss.Show();
        }

        private void dgvVergunning_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgvVergunning.SelectedRows[0];
            Globaal.printId = int.Parse(selectedRow.Cells[0].Value.ToString());
            PdfVergunning.GenDoc(Globaal.printId);
            try { PdfVuurvergunning.GenDoc(Globaal.printId); } catch { }
            try { PdfOpenvergunning.GenDoc(Globaal.printId); } catch { }
            try { PdfBeslotenvergunning.GenDoc(Globaal.printId); } catch { }
            Print ss = new Print();
            ss.Show();
        }
    }
}
