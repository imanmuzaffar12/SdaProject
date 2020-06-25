using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SDA_project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f1 = new Form3();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f1 = new Form4();
            f1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f1 = new Form5();
            f1.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form6 f1 = new Form6();
            f1.Show();
        }

        //private void button2_Click_1(object sender, EventArgs e)
        //{

        //}

    }
}
