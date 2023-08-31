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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
            tbPath.Text = Properties.Settings.Default.Work;
        }

        private void btnPath_Click(object sender, EventArgs e)
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

        private void btnAdminpage_Click(object sender, EventArgs e)
        {
            AdminLogin ss = new AdminLogin();
            ss.Show();
        }

        private void User_Load(object sender, EventArgs e)
        {

        }
    }
}
