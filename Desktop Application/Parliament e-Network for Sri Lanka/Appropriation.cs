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
    public partial class Appropriation : Form
    {
        public Appropriation()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;

        }

        private void Appropriation_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.parliament.lk/uploads/acts/gbills/english/6202.pdf");


        }
    }
}
