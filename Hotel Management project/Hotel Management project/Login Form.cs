using Hotel_Management_project.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        // Login Button Function
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con= new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=hoteldb;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select user ID,Password from login where userID='" + textBox1.Text + "'and Password = '" + textBox2.Text + "' ", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Form2 f2= new Form2();
                f2.Show();
            }
            else
            {
                MessageBox.Show("Invalid User or Password");
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=hoteldb;Integrated Security=True");
            con.Open();
            textBox1.Clear();
            textBox2.Clear();
            con.Close();

        }
        // register here move one form to another form
        private void button3_Click(object sender, EventArgs e)
        {
            Register_Form rr= new Register_Form();
            rr.Show();
        }
    }
}
