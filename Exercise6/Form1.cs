using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                textBox1.Text = "Choosen Colour: Red";

            if (radioButton2.Checked)
                textBox1.Text = "Choosen Colour: Blue";

            if (radioButton3.Checked)
                textBox1.Text = "Choosen Colour: White";
        }
    }
}
