using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Reflection;
using System.Configuration;

namespace SafeContractorApp
{
    public partial class Print : Form
    {
        string pdfPath = @"C:\Users\praas\Bureaublad\test_doc\open_vergunning_21.pdf";

        public Print()
        {
            InitializeComponent();
            Load_printer();
        }

        private void Load_printer()
        {
            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                cbPrinter.Items.Add(printer);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                int numCopies = (int)nudVergunning.Value;

                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = pdfPath,
                    Verb = "printto",
                    Arguments = String.Format("/t \"{0}\" \"{1}\"", pdfPath, cbPrinter.Text),
                    CreateNoWindow = true,
                    WindowStyle = ProcessWindowStyle.Hidden
                };

                for (int i = 0; i < numCopies; i++)
                {
                    Process.Start(psi)?.WaitForExit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fout bij het afdrukken: {ex.Message}", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
