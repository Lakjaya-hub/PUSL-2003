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
using System.Net.Mail;


namespace Parliament_e_Network_for_Sri_Lanka
{
    public partial class Vote : Form
    {
        public Vote()
        {
            InitializeComponent();
        }

        

        private void Vote_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

            int A = 0;
            int B = 0;
            int C = 0;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\User\OneDrive\Documents\Parliament e-Network.mdf';Integrated Security=True;Connect Timeout=30");

            con.Open();



            if (radioButton1.Checked == true)
            {
                
                MessageBox.Show("You are selected Red !! ");

                try
                {
                    string getCust = "select Parliament_ID,Accept,Deaccept,Noanswer  from vote ;";

                    SqlCommand cmd = new SqlCommand(getCust, con);
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        A = (int)dr.GetValue(1);
                        A+=1;
                        


                    }
                    else
                    {
                        MessageBox.Show(" Sorry, This ID,  Staff is not Available.   ");

                    }
                }
                catch (SqlException excep)
                {
                    MessageBox.Show(excep.Message);
                }
            }
            else if (radioButton2.Checked == true)
            {
                
                MessageBox.Show("You are selected Blue !! ");
                try
                {
                    string getCust = "select Parliament_ID,Accept,Deaccept,Noanswer  from vote ;";

                    SqlCommand cmd = new SqlCommand(getCust, con);
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        
                         B = (int)dr.GetValue(2);
                         B+=1;
                        

                    }
                    else
                    {
                        MessageBox.Show(" Sorry, This ID,  Staff is not Available.   ");

                    }
                }
                catch (SqlException excep)
                {
                    MessageBox.Show(excep.Message);
                }
            }

        
             else if (radioButton3.Checked == true)
            {
                MessageBox.Show("You are selected Blue !! ");
                try
                {
                    string getCust = "select Parliament_ID,Accept,Deaccept,Noanswer  from vote ;";

                    SqlCommand cmd = new SqlCommand(getCust, con);
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                          
                         C = (int)dr.GetValue(3);
                         C+=1;

                    }
                    else
                    {
                        MessageBox.Show(" Sorry, This ID,  Staff is not Available.   ");

                    }
                }
                catch (SqlException excep)
                {
                    MessageBox.Show(excep.Message);
                }
 con.Close();
            }
            else
            {
                MessageBox.Show("Selected option !! ");
                return;
            }

           
            SqlConnection conco = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\User\OneDrive\Documents\Parliament e-Network.mdf';Integrated Security=True;Connect Timeout=30");

            conco.Open();




            try
            {
                

                string str = "INSERT INTO vote VALUES('" + textBox1.Text + "','" + A + "','" + B + "','" + C + "'); ";

                SqlCommand cmd = new SqlCommand(str, conco);
                cmd.ExecuteNonQuery();
               
                string str1 = "select Max(Parliament_ID) from vote;";

                SqlCommand cmd1 = new SqlCommand(str1, conco);
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Patient Information Saved Successfully..");
                   



                }

              
            }
            catch (SqlException excep)
            {
                MessageBox.Show(excep.Message);
            }

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
