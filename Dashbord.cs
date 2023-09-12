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
    public partial class Dashbord : Form
    {
        public Dashbord()
        {
            InitializeComponent();
            lbWelcome.Text = Globaal.foutcode;
            lbHost.Text = "Host: " + Globaal.host;
            lbDatabse.Text = "Database: " + Globaal.database;
            lbUser.Text = "User: " + Globaal.username;
        }
    }
}
