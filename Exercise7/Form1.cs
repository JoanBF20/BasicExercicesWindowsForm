using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Red":
                    textBox1.Text = "The choosen colour is: Red";
                    break;
                case "Green":
                    textBox1.Text = "The choosen colour is: Green";
                    break;
                case "Blue":
                    textBox1.Text = "The choosen colour is: Blue";
                    break;
                case "Yellow":
                    textBox1.Text = "The choosen colour is: Yellow";
                    break;
                case "White":
                    textBox1.Text = "The choosen colour is: White";
                    break;
                default:
                    textBox1.Text = "";
                    break;
            }
        }
    }
}
