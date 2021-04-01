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
    public partial class order : Form
    {
        public order()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;

        }

        private void order_Load(object sender, EventArgs e)
        {

          webBrowser1.Navigate("https://www.parliament.lk/uploads/documents/orderpapers/1615288089054864.pdf");


        }
    }
}
