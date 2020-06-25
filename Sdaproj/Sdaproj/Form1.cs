using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using BLL;

namespace Sdaproj
{
    public partial class Form1 : Form
    {
        public string conString = "Data Source=DESKTOP-8T7D12T;Initial Catalog=HappyMart;Integrated Security=True ";

        bal bb = new bal();
        public Form1()
        {
            InitializeComponent();
        }

        public void GridBind()
        {
            dataGridView1.DataSource = bb.Bl_Bind();
            dataGridView1.DataBind();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bb.Product_Id = Convert.ToInt16(textBox1.Text);
            bb.Product_Name = textBox2.Text;
            bb.Category_Id = Convert.ToInt16(textBox3.Text);
            bb.UnitPrice = Convert.ToInt16(textBox4.Text);
            bb.UnitInstock = Convert.ToInt16(textBox5);
            bb.insert_record();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bb.Product_Id = Convert.ToInt16(textBox1.Text);
            bb.Product_Name = textBox2.Text;
            bb.Category_Id = Convert.ToInt16(textBox3.Text);
            bb.UnitPrice = Convert.ToInt16(textBox4.Text);
            bb.UnitInstock=Convert.ToInt16(textBox5);
            bb.Update_record(bb.Product_Id);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bb.Product_Id = Convert.ToInt16(textBox1.Text);
            bb.Product_Name = textBox2.Text;
            bb.Category_Id = Convert.ToInt16(textBox3.Text);
            bb.UnitPrice = Convert.ToInt16(textBox4.Text);
            bb.UnitInstock = Convert.ToInt16(textBox5);
            bb.delete_record(bb.Product_Id);
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
            cmd.CommandText = "select * from Products";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

    }
}
