using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_project.Properties
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loginFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void registerFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Register_Form rr = new Register_Form();
            rr.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void foodEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Food_New_Entry fn=new Food_New_Entry();
            fn.Show();
        }

        private void billGenerationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sales_Billing sb=new Sales_Billing();
            sb.Show();
        }

        private void searchDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search_Sales ss=new Search_Sales();
            ss.Show();
        }
    }
}
