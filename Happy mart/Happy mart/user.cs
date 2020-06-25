using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Happy_mart
{
    public partial class user : Form
    {
        public user()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8T7D12T;Initial Catalog=HappyMart;Integrated Security=True");  //
           // SqlConnection con = new SqlConnection(cs);  // making connection   
            SqlDataAdapter sda = new SqlDataAdapter("SELECT Us_Name,Us_Pass FROM [User] WHERE Us_Name='" + textBox1.Text + "' AND Us_Pass='" + textBox2.Text + "'", con);
            /* in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. */
            DataTable dt = new DataTable(); //this is creating a virtual table  
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                /* I have made a new page called home page. If the user is successfully authenticated then the form will be moved to the next form */
                this.Hide();
            }
            else
                MessageBox.Show("Invalid username or password");  
  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
