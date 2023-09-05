using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SafeContractorApp
{
    public partial class Home : Form
    {
        private Form activeForm;

        private void OpenSchildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelStart.Controls.Add(childForm);
            this.panelStart.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public Home()
        {
            InitializeComponent();
        }

        private void btnDashbord_Click(object sender, EventArgs e)
        {
            OpenSchildForm(new Dashbord(), sender);
            lbTitel.Text = "Dashbord";
            pnlNav.Height = btnDashbord.Height;
            pnlNav.Top = btnDashbord.Top;
            pnlNav.Left = btnDashbord.Left;
            btnDashbord.ForeColor = Color.White;
        }

        private void btnVergunnigen_Click(object sender, EventArgs e)
        {
            OpenSchildForm(new Vergunningen(), sender);
            lbTitel.Text = "Vergunningen lijst";
            pnlNav.Height = btnVergunnigen.Height;
            pnlNav.Top = btnVergunnigen.Top;
            pnlNav.Left = btnVergunnigen.Left;
            btnVergunnigen.ForeColor = Color.White;
        }

        private void btnAddvergunning_Click(object sender, EventArgs e)
        {
            OpenSchildForm(new AadVergunningen(), sender);
            lbTitel.Text = "Vergunningen lijst";
            pnlNav.Height = btnAddvergunning.Height;
            pnlNav.Top = btnAddvergunning.Top;
            pnlNav.Left = btnAddvergunning.Left;
            btnAddvergunning.ForeColor = Color.White;
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            OpenSchildForm(new Installingen(), sender);
            lbTitel.Text = "Installingen";
            pnlNav.Height = btnSetting.Height;
            pnlNav.Top = btnSetting.Top;
            pnlNav.Left = btnSetting.Left;
            btnSetting.ForeColor = Color.White;
        }

        private void btnAdminpage_Click(object sender, EventArgs e)
        {
            OpenSchildForm(new Admin(), sender);
            lbTitel.Text = "Admin pagina";
            pnlNav.Height = btnAdminpage.Height;
            pnlNav.Top = btnAdminpage.Top;
            pnlNav.Left = btnAdminpage.Left;
            btnAdminpage.ForeColor = Color.White;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            OpenSchildForm(new Dashbord(), sender);
            lbTitel.Text = "Dashbord";
            pnlNav.Height = btnDashbord.Height;
            pnlNav.Top = btnDashbord.Top;
            pnlNav.Left = btnDashbord.Left;
            btnDashbord.ForeColor = Color.White;
        }
    }
}
