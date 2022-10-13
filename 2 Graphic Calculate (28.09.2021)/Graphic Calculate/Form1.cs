using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphic_Calculate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a, b, sum, min, mult, div;
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            sum = a + b;
            label1.Text = "Sum = " + sum;
            min = a - b;
            label2.Text = "Min = " + min;
            mult = a * b;
            label3.Text = "Mult = " + mult;
            div = a / b;
            label4.Text = "Div = " + div;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label1.Text = "Sum";
            label2.Text = "Min";
            label3.Text = "Mult";
            label4.Text = "Div";
        }
    }
}
