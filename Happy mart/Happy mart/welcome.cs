using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Happy_mart
{
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            user u = new user();
            u.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
