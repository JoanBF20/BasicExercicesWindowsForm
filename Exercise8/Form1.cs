using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = listBox1.Items.Count;
            for (int i = 0; i < count; i++)
                listBox1.Items.RemoveAt(0);

            listBox1.Items.Add("Pau");
            listBox1.Items.Add("Montse");
            listBox1.Items.Add("Jaume");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count = listBox1.Items.Count;
            for (int i = 0; i < count; i++)
                listBox1.Items.RemoveAt(0);

            listBox1.Items.Add("Cati");
            listBox1.Items.Add("Pau");
            listBox1.Items.Add("Maria");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int count = listBox1.Items.Count;
            for (int i = 0; i < count; i++)
                listBox1.Items.RemoveAt(0);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = listBox1.Text;
        }
    }
}
