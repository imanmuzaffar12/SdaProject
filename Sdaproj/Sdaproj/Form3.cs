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
using BLL;
namespace Sdaproj
{
    public partial class Form3 : Form
    {

        public string conString = "Data Source=DESKTOP-8T7D12T;Initial Catalog=HappyMart;Integrated Security=True ";

        bal bb = new bal();

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();


            disp_data();

        }
        public void disp_data()
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Customer";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        public void GridBind()
        {
            dataGridView1.DataSource = bb.Bl_Bind();
            dataGridView1.DataBind();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            bb.Customer_Id= Convert.ToInt16(textBox1.Text);
            bb.Cus_Address = textBox2.Text;
            bb.Contact_No =textBox3.Text;
            bb.Gender=textBox4.Text;
            bb.City=textBox5.Text;
            bb.Country = textBox6.Text;
            bb.Region = textBox7.Text;
            bb.PostalCode = textBox8.Text;
            bb.Update_record2(bb.Customer_Id);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bb.Customer_Id = Convert.ToInt16(textBox1.Text);
            bb.Cus_Address = textBox2.Text;
            bb.Contact_No = textBox3.Text;
            bb.Gender = textBox4.Text;
            bb.City = textBox5.Text;
            bb.Country = textBox6.Text;
            bb.Region = textBox7.Text;
            bb.PostalCode = textBox8.Text;
            bb.insert_record2();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bb.Customer_Id = Convert.ToInt16(textBox1.Text);
            bb.Customer_Address = textBox2.Text;
            bb.Contact_No = textBox3.Text;
            bb.Gender = textBox4.Text;
            bb.City = textBox5.Text;
            bb.Country = textBox6.Text;
            bb.Region = textBox7.Text;
            bb.PostalCode = textBox8.Text;
            bb.Update_record2(bb.Customer_Id);
        }


    }
}
