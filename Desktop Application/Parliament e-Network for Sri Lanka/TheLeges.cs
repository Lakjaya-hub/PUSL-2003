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
    public partial class TheLeges : Form
    {
        public TheLeges()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;

        }

        private void TheLeges_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.news.lk/images/pdf/2020/Budget_speech_-_2021_English.pdf");

        }
    }
}
