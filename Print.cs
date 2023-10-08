using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Reflection;
using System.Configuration;
using System.IO;
using Spire.Pdf;
using MySql.Data.MySqlClient;
using System.Data;
using Google.Protobuf.WellKnownTypes;

namespace SafeContractorApp
{
    public partial class Print : Form
    {
        int vuurId = 0;
        int openId = 0;
        int geslId = 0;

        private void PathChecker()
        {
            string query = "SELECT * FROM vergunning where vegunning_id=@vegunning_id;";
            using (var connection = new MySqlConnection(Globaal.user))
            {
                connection.Open();
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@vegunning_id", Globaal.printId);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    try { vuurId = int.Parse(reader["vuurvergunning_vuurvergunning_id"].ToString()); } catch { }
                    try { openId = int.Parse(reader["open_vergunning_open_vergunning_id"].ToString()); } catch { }
                    try { geslId = int.Parse(reader["besloten_vergunning_besloten_vergunning_id"].ToString()); } catch { }
                }
                connection.Close();
            }
            nudVuur.Enabled = File.Exists($@"{Properties.Settings.Default.Work}\vuurvergunning_{vuurId}.pdf") ? true : false;
            nudOpen.Enabled = File.Exists($@"{Properties.Settings.Default.Work}\open_vergunning_{openId}.pdf") ? true : false;
            nudGesl.Enabled = File.Exists($@"{Properties.Settings.Default.Work}\besloten_vergunning_{geslId}.pdf") ? true : false;
        }

        private void Load_printer()
        {
            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                cbPrinter.Items.Add(printer);
            }
        }

        public Print()
        {
            InitializeComponent();
            Load_printer();
            PathChecker();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PdfDocument doc = new PdfDocument($@"{Properties.Settings.Default.Work}\vergunning_{Globaal.printId}.pdf");
            doc.PrintSettings.PrinterName = cbPrinter.Text;
            short numCopies = (short)nudVergunning.Value;
            doc.PrintSettings.Copies = numCopies;
            doc.Print();

            if (nudVuur.Enabled)
            {
                PdfDocument docVuur = new PdfDocument($@"{Properties.Settings.Default.Work}\vuurvergunning_{vuurId}.pdf");
                doc.PrintSettings.PrinterName = cbPrinter.Text;
                short numVuur = (short)nudVuur.Value;
                docVuur.PrintSettings.Copies = numVuur;
                docVuur.Print();
            }

            if (nudOpen.Enabled)
            {
                PdfDocument docOpen = new PdfDocument($@"{Properties.Settings.Default.Work}\open_vergunning_{openId}.pdf");
                doc.PrintSettings.PrinterName = cbPrinter.Text;
                short numOpen = (short)nudOpen.Value;
                docOpen.PrintSettings.Copies = numOpen;
                docOpen.Print();
            }

            if (nudGesl.Enabled)
            {
                PdfDocument docGesl = new PdfDocument($@"{Properties.Settings.Default.Work}\besloten_vergunning_{geslId}.pdf");
                doc.PrintSettings.PrinterName = cbPrinter.Text;
                short numGesl = (short)nudGesl.Value;
                docGesl.PrintSettings.Copies = numGesl;
                docGesl.Print();
            }

            this.Close();
        }
    }
}
