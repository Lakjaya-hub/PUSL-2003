using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parliament_e_Network_for_Sri_Lanka
{
    public partial class ParliamentLive : Form
    {
        public ParliamentLive()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;

        }

        private void ParliamentLive_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://us05web.zoom.us/j/2776411503?pwd=c29XK0lxSEptUEVrclA1TWJPbEY4UT09");
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
