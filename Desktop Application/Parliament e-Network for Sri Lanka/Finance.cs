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
    public partial class Finance : Form
    {
        public Finance()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;

        }

        private void Finance_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.parliament.lk/uploads/acts/gbills/english/6179.pdf");


        }
    }
}
