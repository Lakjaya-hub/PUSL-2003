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
    public partial class Contackmp : Form
    {
        public Contackmp()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void Contackmp_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://video.parliament.lk/");

        }
    }
}
