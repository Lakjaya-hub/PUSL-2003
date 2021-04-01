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
    public partial class DiscussionForum : Form
    {
        public DiscussionForum()
        {
            InitializeComponent();
        }

        private void DiscussionForum_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://groups.google.com/g/srilankapar");

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
