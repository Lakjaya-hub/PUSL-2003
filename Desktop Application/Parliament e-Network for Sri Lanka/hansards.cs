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
    public partial class hansards : Form
    {
        public hansards()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;

        }

        private void hansards_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.parliament.lk/uploads/documents/hansard/1615957347078474.pdf");


        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
