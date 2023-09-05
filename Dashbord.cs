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
            lbWelcome.Text = Connection.foutcode;
            lbHost.Text = "Host: " + Connection.host;
            lbDatabse.Text = "Database: " + Connection.database;
            lbUser.Text = "User: " + Connection.username;
        }
    }
}
