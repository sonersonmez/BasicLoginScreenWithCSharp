using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KayitDefteri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="admin" && textBox2.Text=="admin")
            {
                label3.Text = "Login successful";
                label3.ForeColor = Color.Green;
            }
            else
            {
                label3.ForeColor = Color.Red;
                label3.Text = "Login failed.\nPlease check your username and password.";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
