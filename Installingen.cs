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
    public partial class Installingen : Form
    {
        public Installingen()
        {
            InitializeComponent();
            tbPath.Text = Properties.Settings.Default.Work;
            tbImages.Text = Properties.Settings.Default.Images;
        }

        private void btnPath_Click_1(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.SelectedPath))
                {
                    Properties.Settings.Default.Work = dialog.SelectedPath;
                    Properties.Settings.Default.Save(); // Opslaan van de instellingen
                    tbPath.Text = Properties.Settings.Default.Work; // Weergeven in het tekstvak
                }
            }
        }

        private void btnImages_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.SelectedPath))
                {
                    Properties.Settings.Default.Images = dialog.SelectedPath;
                    Properties.Settings.Default.Save(); // Opslaan van de instellingen
                    tbPath.Text = Properties.Settings.Default.Images; // Weergeven in het tekstvak
                }
            }
        }
    }
}
