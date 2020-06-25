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
using System.Data;
using BLL;
namespace Sdaproj
{
    public partial class Form4 : Form
    {
        public string conString = "Data Source=DESKTOP-8T7D12T;Initial Catalog=HappyMart;Integrated Security=True ";

        bal bb = new bal();

        public Form4()
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
            cmd.CommandText = "select * from Employee";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bb.Employee_Id = Convert.ToInt16(textBox1.Text);
            bb.Emp_Name = textBox2.Text;
            bb.Email =textBox3.Text;
            bb.Birthdate =textBox4.Text;
            bb.Hiredate = textBox5.Text;
            bb.Salary=textBox6.Text;
            bb.Country=textBox7.Text;
            bb.City=textBox8.Text;
            bb.Region = textBox9.Text;
            bb.Update_record3(bb.Employee_Id);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bb.Employee_Id = Convert.ToInt16(textBox1.Text);
            bb.Emp_Name = textBox2.Text;
            bb.Email = textBox3.Text;
            bb.Birthdate = textBox4.Text;
            bb.Hiredate = textBox5.Text;
            bb.Salary = textBox6.Text;
            bb.Country = textBox7.Text;
            bb.City = textBox8.Text;
            bb.Region = textBox9.Text;
            bb.insert_record3();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bb.Employee_Id = Convert.ToInt16(textBox1.Text);
            bb.Emp_Name = textBox2.Text;
            bb.Email = textBox3.Text;
            bb.Birthdate = textBox4.Text;
            bb.Hiredate = textBox5.Text;
            bb.Salary = textBox6.Text;
            bb.Country = textBox7.Text;
            bb.City = textBox8.Text;
            bb.Region = textBox9.Text;
            bb.delete_record3(bb.Employee_Id);
        }

        public void GridBind()
        {
            dataGridView1.DataSource = bb.Bl_Bind();
            dataGridView1.DataBind();
        }

        

    }
}
