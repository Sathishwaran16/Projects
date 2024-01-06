using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_project
{
    public partial class Hotel_App : Form
    {
        public Hotel_App()
        {
            InitializeComponent();
        }

        private void Hotel_App_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Food_New_Entry fn=new Food_New_Entry();
            fn.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sales_Billing sb=new Sales_Billing();
            sb.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Search_Sales ss= new Search_Sales();
            ss.Show();
        }
    }
}
