using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
namespace SDA_project
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public string conString = @"Data Source=DESKTOP-TMA6F62\MYSQLSERVER;Initial Catalog=HappyMart;Integrated Security=True";
        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT into Products values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";


                cmd.ExecuteNonQuery();

                con.Close();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";

                disp_data();
                MessageBox.Show("record Add Succesfully....!");


            }
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

        private void button4_Click(object sender, EventArgs e)
        {
            disp_data();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Update Products set UnitPrice='" + textBox4.Text + "',UnitInStock='" + textBox5.Text + "'where Product_Id='" + textBox1.Text + "'";
                // cmd.CommandText = "Update Products set UnitPrice ='" + textBox2.Text + "' where  Product_Id  = '" + textBox1.Text + "'";

                // cmd.CommandText = "Update Products set UnitPrice'" +textBox4.Text + "'UnitInStock'" +textBox5.Text + "'where Product_Id='" +textBox1.Text + "',";

                cmd.ExecuteNonQuery();

                con.Close();
                disp_data();
                MessageBox.Show("record Updated Succesfully....!");

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Delete from Products where Product_Name = '" + textBox2.Text + "'";


                cmd.ExecuteNonQuery();

                con.Close();
                disp_data();
                MessageBox.Show("record Deleted Succesfully....!");

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 f2 = new Form2();
            f2.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Insert into Products values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";


                cmd.ExecuteNonQuery();

                con.Close();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";

                disp_data();
                MessageBox.Show("Record Saved Succesfully....!");


            }




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}