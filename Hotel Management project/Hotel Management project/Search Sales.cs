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
    public partial class Search_Sales : Form
    {
        public Search_Sales()
        {
            InitializeComponent();
        }
        //connection 
        SqlConnection con = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = hoteldb; Integrated Security = True");
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        // Load the food in Food Combo box from database (write in fn to call anywhere)
        private void FillFood()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select Fname from tblFood", con);
            SqlDataReader datareader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Fname", typeof(string));
            dataTable.Load(datareader);
            comboBox1.ValueMember = "Fname";
            comboBox1.DataSource = dataTable;
            con.Close();
        }
        //To Load all database data(tblBilling) into Datagridview (write in fn to call anywhere)
        private void populateData()
        {
            con.Open();
            string query = "select * from tblBilling";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset);
            dataGridView1.DataSource = dataset.Tables[0];
            con.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "select f.Fname as 'Food Name',b.BillNo,b.Price,b.Quantity,b.Amount from tblFood f INNER JOIN tblBilling b ON f.Fid = b.Fid where b.BillDate >= '" + dateTimePicker1.Text + "' AND b.BillDate <= '" + dateTimePicker2.Text + "' AND Fname = '" + comboBox1.SelectedValue.ToString() + "' ORDER BY f.Fname";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataset = new DataSet();
                dataAdapter.Fill(dataset);
                // Clear previous data in the DataGridView
                dataGridView1.DataSource = null;
                // Fill the DataGridView with new data
                dataGridView1.DataSource = dataset.Tables[0];
                // Refresh the DataGridView
                dataGridView1.Refresh();
                con.Close();
                // Check for no matching data
                if (dataset.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("No matching data found.");
                }
                else
                {
                    // Calculate total quantity and total amount
                    int totalQuantity = 0;
                    decimal totalAmount = 0;

                    foreach (DataRow row in dataset.Tables[0].Rows)
                    {
                        totalQuantity += Convert.ToInt32(row["Quantity"]);
                        totalAmount += Convert.ToDecimal(row["Amount"]);
                    }

                    // Display or use the totals as needed
                    textBox1.Text = totalQuantity.ToString();
                    textBox2.Text = totalAmount.ToString("C");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // fn load when the form is opened (It is write in form load)
         private void Search_Sales_Load(object sender, EventArgs e)
         {
            FillFood();
            populateData();
         }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
