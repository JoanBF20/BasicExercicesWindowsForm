using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String text = "Choosen animals: ";

            if (checkBox1.Checked)
                text += "mouse ";

            if (checkBox2.Checked)
                text += "cat ";

            if (checkBox3.Checked)
                text += "dog ";

            textBox1.Text = text;
        }
    }
}
