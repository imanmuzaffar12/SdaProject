using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace SDA_project
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        public string conString = @"Data Source=DESKTOP-TMA6F62\MYSQLSERVER;Initial Catalog=HappyMart;Integrated Security=True";
        public void disp_data()
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Categories";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT into Categories values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";


                cmd.ExecuteNonQuery();

                con.Close();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";

                disp_data();
                MessageBox.Show("Record Add Succesfully....!");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Update Categories set CategoryName ='" + textBox2.Text + "' where Category_Id = '" + textBox1.Text + "'";

                cmd.ExecuteNonQuery();

                con.Close();
                disp_data();
                MessageBox.Show("Record Updated Succesfully....!");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Delete from Categories where Category_Id ='" + textBox1.Text + "'";


                cmd.ExecuteNonQuery();

                con.Close();
                disp_data();
                MessageBox.Show("Record Deleted Succesfully....!");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 f5 = new Form2();
            f5.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            disp_data();
        }

    }
}
