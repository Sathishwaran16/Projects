using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hotel_Management_project
{
    public partial class Food_New_Entry : Form
    {
        public Food_New_Entry()
        {
            InitializeComponent();
        }

        private void Food_New_Entry_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //connection
        SqlConnection con = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = hoteldb; Integrated Security = True");
        
        string Foodtype = string.Empty;
        //submit
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please fill food Name");
            }
            else if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                MessageBox.Show("Please Choose Food Type");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Please fill food Price");
            }
            else if (comboBox1.SelectedIndex == 0)
            {
                MessageBox.Show("Please Choose Availability");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into tblFood values('" + textBox1.Text.Trim().ToString() + "',@foodType," + textBox2.Text.Trim() + ",'" + comboBox1.SelectedItem.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@foodType", Foodtype);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Food Added Successfully");
                    con.Close();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        // veg radiobutton(radiobtn1) to change text
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Text = "V";
            Foodtype = radioButton1.Text.ToString();

            radioButton1.Text = "Veg";
        }
        // nonveg radiobutton(radiobtn2) to change text
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton2.Text = "N";
            Foodtype = radioButton2.Text.ToString();

            radioButton2.Text = "Non Veg";
        }

        //view
        private void button5_Click(object sender, EventArgs e)
        {
            populate();
        }
        //Delete
        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete from tblFood where fname='" +textBox1.Text.Trim().ToString()+"'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.SelectCommand = cmd;
            da.Fill(ds);
            con.Close();
            MessageBox.Show("Data Deleted sucessfully"); 
        }
        //Load
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Fill Food Load");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select * from tblFood where fname='" + textBox1.Text.Trim().ToString() + "' ", con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        string Ftype = dr["Ftype"].ToString();
                        if (Ftype == "V")
                        {
                            radioButton1.Checked = true;
                        }
                        else
                        {
                            radioButton2.Checked = true;
                        }
                        textBox2.Text = dr["Fprice"].ToString();
                        comboBox1.SelectedItem = dr["Favailable"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Food: " + textBox1.Text.ToString() + " Not Found ");
                        textBox1.Clear();
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        //Update
        private void button4_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please fill food Name");
            }
            else if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                MessageBox.Show("Please Choose Food Type");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Please fill food Price");
            }
            else if (comboBox1.SelectedIndex == 0)
            {
                MessageBox.Show("Please Choose Availability");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "update tblFood set Ftype = @foodType,Fprice = " + textBox2.Text.Trim() + ",Favailable = '" + comboBox1.SelectedItem.ToString() + "' where Fname = '" + textBox1.Text.Trim().ToString() + "'";
                    SqlCommand cmd1 = new SqlCommand(query, con);
                    cmd1.Parameters.AddWithValue("@foodType", Foodtype);
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Food Updated Successfully");
                    con.Close();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        //To Load all database data(tblFood) into Datagridview (write in fn to call anywhere)
        private void populate()
        {
            con.Open();
            string query = "select Fid as 'Food ID', Fname as 'Food Name',Ftype as 'Food Type',Fprice as 'Food Price',Favailable as 'Food Availability' from tblFood";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset);
            dataGridView1.DataSource = dataset.Tables[0];
            con.Close();
        }

        // fn load when the form is opened (It is write in form load)
        private void FoodEntry_Load(object sender, EventArgs e)
        {
            populate();
        }
        //Load the details into textbox when the datagridview cells clicked
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            comboBox1.SelectedItem = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            string ftype = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

            if (ftype == "V")
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }

        }
    }
}






