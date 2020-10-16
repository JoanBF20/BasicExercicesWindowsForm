using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = comboBox1.Items.Count;
            for (int i = 0; i < count; i++)
                comboBox1.Items.RemoveAt(0);

            comboBox1.Items.Add("2");
            comboBox1.Items.Add("4");
            comboBox1.Items.Add("6");
            comboBox1.Items.Add("8");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count = comboBox1.Items.Count;
            for (int i = 0; i < count; i++)
                comboBox1.Items.RemoveAt(0);

            comboBox1.Items.Add("1");
            comboBox1.Items.Add("3");
            comboBox1.Items.Add("5");
            comboBox1.Items.Add("7");
            comboBox1.Items.Add("9");
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.Text;
        }
    }
}
