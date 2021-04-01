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
    public partial class ParliamentWork : Form
    {
        public ParliamentWork()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home obj1 = new Home();
            obj1.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Business obj1 = new Business();
            obj1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ParliamentWork obj1 = new ParliamentWork();
            obj1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            VotingPortal obj1 = new VotingPortal();
            obj1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            VisitingParliament obj1 = new VisitingParliament();
            obj1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            GetInvolved obj1 = new GetInvolved();
            obj1.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click_1(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
          
            StandingOrder obj1 = new StandingOrder();
            obj1.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
           
            Prorogation obj1 = new Prorogation();
            obj1.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
            TheLeges obj1 = new TheLeges();
            obj1.ShowDialog();
        }

        private void ParliamentWork_Load(object sender, EventArgs e)
        {

        }
    }
}
