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
    public partial class Form5 : Form
    {
        public Form5()
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
            cmd.CommandText = "select * from Employee";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();


            disp_data();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT into Emplyoee  values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "')";


                cmd.ExecuteNonQuery();

                con.Close();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                disp_data();
                MessageBox.Show("Record Saved Succesfully....!");

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Update  Employee  set Email ='" + textBox3.Text + "' where  Employee_Id  = '" + textBox1.Text + "'";

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
                cmd.CommandText = "Delete from Employee  where Employee_Name = '" + textBox2.Text + "'";


                cmd.ExecuteNonQuery();

                con.Close();
                disp_data();
                MessageBox.Show("record Deleted Succesfully....!");


            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 f5 = new Form2();
            f5.Show();

        }
    }
}
