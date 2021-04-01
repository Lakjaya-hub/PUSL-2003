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
using System.Net;
using System.Net.Mail;


namespace Parliament_e_Network_for_Sri_Lanka
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void Register_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\User\OneDrive\Documents\Parliament e-Network.mdf';Integrated Security=True;Connect Timeout=30");
            con.Open();
            string str1 = "select max(Your_id) from Register ;";

            SqlCommand cmd1 = new SqlCommand(str1, con);
            SqlDataReader dr = cmd1.ExecuteReader();
            if (dr.Read())
            {
                string val = dr[0].ToString();
                if (val == "")
                {
                    textBox1.Text = "1";
                }
                else
                {
                    int a;
                    a = Convert.ToInt32(dr[0].ToString());
                    a = a + 1;
                    textBox1.Text = a.ToString();
                }
            }


            con.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
            
            


        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((textBox2.Text.Trim() == string.Empty)|| (textBox2.Text.Trim() == string.Empty)||(textBox3.Text.Trim() == string.Empty) || (textBox4.Text.Trim() == string.Empty)||(textBox5.Text.Trim() == string.Empty)||(textBox6.Text.Trim() == string.Empty)||(textBox7.Text.Trim() == string.Empty)||(textBox8.Text.Trim() == string.Empty)||(textBox9.Text.Trim() == string.Empty))
            {
                MessageBox.Show("Please Fill All Text Fields");

            }
            if (textBox9.Text != textBox8.Text)
            {
                MessageBox.Show("Both  Password shoud be match");

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox9.Text != textBox8.Text)
            {
                MessageBox.Show("Please check");

                textBox8.Text = "";
                textBox9.Text = "";

            }
            if (textBox1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter something in the textbox");
                return; // return because we don't want to run normal code of buton click
            }

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\User\OneDrive\Documents\Parliament e-Network.mdf';Integrated Security=True;Connect Timeout=30");
            con.Open();


            try
            {
                string str = "INSERT INTO Register(Your_id,Fname,Lname,NIC,Tel,Address,Email,Password,CPassword) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "'); ";
                string var;
                var = textBox1.Text;
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                string str1 = "select Max(Your_id) from Register;";

                SqlCommand cmd1 = new SqlCommand(str1, con);
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Patient Information Saved Successfully..");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";

                    textBox6.Text = "";

                    textBox8.Text = "";
                    textBox9.Text = "";



                }
            }
            catch (SqlException excep)
            {
                MessageBox.Show(excep.Message);
            }



            var fromAddress = new MailAddress("lakjayasilva65@gmail.com");
            var toAddress = new MailAddress(textBox7.Text);
            const string fromPassword = "1998124Ls";
            string subject = "The Registration Is being processed";


            const string body = "Hi, The Registration Is being processed. Our admin will sent Your Login Id and Password withng Two days";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }



        }
    }
}
