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

namespace Hotel_Management_project.Properties
{
    public partial class Register_Form : Form
    {
        public Register_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=hoteldb;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into login values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "'" +
                                            ",'" + textBox4.Text + "'," + textBox5.Text+ " )", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Registered Successfully");
            //Move to login form
            Form1 f1= new Form1();
            f1.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
