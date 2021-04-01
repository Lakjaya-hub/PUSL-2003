using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Parliament_e_Network_for_Sri_Lanka
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


           
        }

        private void button3_Click(object sender, EventArgs e)
        {
           Vote obj1 = new Vote ();
            obj1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            siva obj1 = new siva();
            obj1.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\User\OneDrive\Documents\Parliament e-Network.mdf';Integrated Security=True;Connect Timeout=30");

            string query = "Select * from Login Where Your_id = '" + textBox1.Text.Trim() + "' and Your_password = '" + textBox2.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {



                Home obj1 = new Home();
                this.Hide();
                obj1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Check your username and password");
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Register obj1 = new Register();
            obj1.ShowDialog();
        }
    }
}
