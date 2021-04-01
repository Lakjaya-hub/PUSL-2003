using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;

namespace Parliament_e_Network_for_Sri_Lanka
{
    public partial class siva : Form
    {
        public siva()
        {
            InitializeComponent();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\User\OneDrive\Documents\Parliament e-Network.mdf';Integrated Security=True;Connect Timeout=30");

            con.Open();

            try
            {

                string getCust = " select count(Accept) from vote where Accept=1; ";

                SqlCommand cmd = new SqlCommand(getCust, con);



                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    textBox1.Text = dr.GetValue(0).ToString();




                }
                else
                {
                    MessageBox.Show(" Sorry, This ID Staff is not Available.   ");
                    textBox1.Text = "";
                }


            }
            catch (SqlException excep)
            {
                MessageBox.Show(excep.Message);
            }



            con.Close();



            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\User\OneDrive\Documents\Parliament e-Network.mdf';Integrated Security=True;Connect Timeout=30");

            conn.Open();

            try
            {

                string getCust = " select count(Deaccept) from vote where Deaccept=1; ";

                SqlCommand cmd = new SqlCommand(getCust, conn);



                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    textBox2.Text = dr.GetValue(0).ToString();




                }
                else
                {
                    MessageBox.Show(" Sorry, This ID Staff is not Available.   ");
                    textBox1.Text = "";
                }


            }
            catch (SqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            conn.Close();


            SqlConnection conne = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\User\OneDrive\Documents\Parliament e-Network.mdf';Integrated Security=True;Connect Timeout=30");

            conne.Open();

            try
            {

                string getCust = " select count(Noanswer) from vote where Noanswer=1; ";

                SqlCommand cmd = new SqlCommand(getCust, conne);



                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    textBox3.Text = dr.GetValue(0).ToString();




                }
                else
                {
                    MessageBox.Show(" Sorry, This ID Staff is not Available.   ");
                    textBox1.Text = "";
                }


            }
            catch (SqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            conne.Close();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }


}