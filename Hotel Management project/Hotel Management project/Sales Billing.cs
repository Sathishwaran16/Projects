using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_project
{
    public partial class Sales_Billing : Form
    {
        public Sales_Billing()
        {
            InitializeComponent();
        }

        //connection 
        SqlConnection con = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = hoteldb; Integrated Security = True");

        private void FillFood()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select Fname from tblFood", con);
            SqlDataReader datareader = cmd.ExecuteReader();
            DataTable da = new DataTable();
            da.Columns.Add("Fname", typeof(string));
            da.Load(datareader);
            comboBox1.ValueMember = "Fname";
            comboBox1.DataSource = da;
            con.Close();
        }
        //After fill the and fetch the food details using food into textboxes
        private void FetchFoodDetails()
        {
            con.Open();
            string query = "select * from tblFood where Fname = '" + comboBox1.SelectedValue + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataadapter = new SqlDataAdapter(cmd);
            dataadapter.Fill(dataTable);
            foreach (DataRow dr in dataTable.Rows)
            {
                textBox2.Text = dr["Fprice"].ToString();
            }

            con.Close();

            ClearForm();
        }
        //If we enter quantity,automatically amount has been calculated
        private void FillAmountWithQuantity()
        {
            if (!string.IsNullOrEmpty(textBox3.Text))
            {
                float price = float.Parse(textBox2.Text);
                if (int.TryParse(textBox3.Text, out int quantity))
                {
                    float total = quantity * price;
                    textBox4.Text = total.ToString();
                }
                else
                {
                    MessageBox.Show("Please Enter Valid Quantity");
                    textBox3.Text = string.Empty;
                }
            }
            else
            {
                textBox4.Text = string.Empty;
            }
        }

        // To clear textboxes (in function)
        private void ClearForm()
        {
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        // calculate total amount of foods in tblBilling table

        decimal totalamt = 0;
        private void CalculateTotalAmount()
        {
            con.Open();
            string query = "select SUM(Amount) from tblBilling";
            SqlCommand cmd = new SqlCommand(query, con);

            object result = cmd.ExecuteScalar();

            if (result != DBNull.Value)
            {
                totalamt = Convert.ToDecimal(result);
            }
            else
            {
                totalamt = 0;
            }
            textBox4.Text = totalamt.ToString("C");

            con.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please fill bill no");
            }
            else if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose food");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Please fill price");
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("Please fill amount");
            }
            else
            {
                try
                {
                    con.Open();
                    //insert details into tblBilling
                    string query = "insert into tblBilling(BillNo,Fid,Price,Quantity,Amount) values(" + textBox1.Text.Trim() + "," +
                                  "(select Fid from tblFood where Fname = '" + comboBox1.SelectedValue.ToString() + "')," + textBox2.Text.Trim() + "," +
                                  "" + textBox3.Text.Trim() + "," + textBox4.Text.Trim() + ")";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bill Details Added Successfully");
                    ClearForm();
                    CalculateTotalAmount();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally 
                {
                    con.Close(); 
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sales_Billing_Load(object sender, EventArgs e)
        {
            //Random Bill Id Genration
            Random rr = new Random();
            textBox1.Text = rr.Next(1000, 9999).ToString();
            //Calling Function
            FillFood();
            FetchFoodDetails();
            CalculateTotalAmount();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            FetchFoodDetails();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            FillAmountWithQuantity();
        }
    }
}
