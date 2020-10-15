using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = "+";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = "-";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            textBox2.ResetText();
            textBox4.ResetText();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox3.Text == "+")
                {
                    int res = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text);
                    textBox4.Text = res.ToString();
                } else if (textBox3.Text == "-")
                {
                    int res = Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text);
                    textBox4.Text = res.ToString();
                } 
            }
            catch
            {

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox3.Text = comboBox1.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
