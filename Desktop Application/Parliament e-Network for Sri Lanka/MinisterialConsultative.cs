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
    public partial class MinisterialConsultative : Form
    {
        public MinisterialConsultative()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void MinisterialConsultative_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.parliament.lk/en/component/committees/categories?id=2&Itemid=533&tmpl=component&format=pdf");
        }

        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
