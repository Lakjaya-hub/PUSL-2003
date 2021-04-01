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
    public partial class Committees : Form
    {
        public Committees()
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

      

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            GetInvolved obj1 = new GetInvolved();
            obj1.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
          
            LegislativeStanding obj1 = new LegislativeStanding();
            obj1.ShowDialog();
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Business obj1 = new Business();
            obj1.ShowDialog();

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            VisitingParliament obj1 = new VisitingParliament();
            obj1.ShowDialog();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {

            SelectCommitee obj1 = new SelectCommitee();
            obj1.ShowDialog();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {

       
            SectoralOversight obj1 = new SectoralOversight();
            obj1.ShowDialog();
        }

       

        private void button9_Click_1(object sender, EventArgs e)
        {
            MinisterialConsultative obj1 = new MinisterialConsultative();
            obj1.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            LegislativeStanding obj1 = new LegislativeStanding();
            obj1.ShowDialog(); 
        }

        private void button12_Click(object sender, EventArgs e)
        {

            CommitteesforSpecial obj1 = new CommitteesforSpecial();
            obj1.ShowDialog();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Home obj1 = new Home();
            obj1.ShowDialog();
        }
    }
}
