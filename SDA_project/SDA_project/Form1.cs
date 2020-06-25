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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-TMA6F62\MYSQLSERVER;Initial Catalog=HappyMart;Integrated Security=True");	//  making  connection
            SqlDataAdapter sda = new SqlDataAdapter("SELECT  Ad_Name,Ad_Pass  FROM  [Admin]  WHERE Ad_Name='" + textBox1.Text + "'  AND  Ad_Pass='" + textBox2.Text + "'", con);
            /*  in  above  line  the  program  is  selecting  the  whole  data  from  table  and  the matching  it  with  the  user  name  and  password  provided  by  user.  */
            Login SingletonObject = Login.GetObject();
            SingletonObject.User();

            DataTable dt = new DataTable();  //this  is  creating  a  virtual  table
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {

                /*  I  have  made  a  new  page  called  home  page.  If  the  user  is  successfully authenticated  then  the  form  will  be  moved  to  the  next  form  */
                this.Hide();
                SDA_project.Form2 aa = new SDA_project.Form2();

                aa.Show();

            }
            else
                MessageBox.Show("Invalid  username  or  password");

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
