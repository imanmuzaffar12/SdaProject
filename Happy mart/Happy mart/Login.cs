using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Happy_mart
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8T7D12T;Initial Catalog=HappyMart;Integrated Security=True");  // making connection   
   SqlDataAdapter sda = new SqlDataAdapter("SELECT Ad_Name,Ad_Pass FROM [Admin] WHERE Ad_Name='"+ textBox1.Text +"' AND Ad_Pass='"+ textBox2.Text +"'",con);  
        /* in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. */  
   DataTable dt = new DataTable(); //this is creating a virtual table  
   sda.Fill(dt);  
   if (dt.Rows.Count == 1)   
   {  
      /* I have made a new page called home page. If the user is successfully authenticated then the form will be moved to the next form */   
      this.Hide();
     WindowsFormsApp1.Form1 aa = new WindowsFormsApp1.Form1();
            aa.Show();

   }  
    else  
   MessageBox.Show("Invalid username or password");  
  
}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }  

        }
    }
