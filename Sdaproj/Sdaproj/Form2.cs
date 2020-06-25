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
    public partial class Form2 : Form
    {
        public string conString = "Data Source=DESKTOP-8T7D12T;Initial Catalog=HappyMart;Integrated Security=True ";

        bal bb = new bal();

        public Form2()
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
            cmd.CommandText = "select * from Category";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             bb.Category_Id = Convert.ToInt16(textBox1.Text);
            bb.Category_Name = textBox2.Text;
            bb.Category_Desc = textBox3.Text;
            bb.Update_record1(bb.Category_Id);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bb.Category_Id = Convert.ToInt16(textBox1.Text);
            bb.Category_Name = textBox2.Text;
            bb.Category_Desc = textBox3.Text;
            bb.insert_record1();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bb.Category_Id = Convert.ToInt16(textBox1.Text);
            bb.Category_Name = textBox2.Text;
            bb.Category_Desc = textBox3.Text;
            bb.delete_record1(bb.Category_Id);
        }

        public void GridBind()
        {
            dataGridView1.DataSource = bb.Bl_Bind();
            dataGridView1.DataBind();

        }
    }
}
