using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Receipt
{
    public partial class Form1Receipt : Form
    {
        public Form1Receipt()
        {
            InitializeComponent();
        }

        double pr, disc, aodisc, aodisc1, tot, numof, nds, ttcd, fp, chan;

        private void button4Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();

            StreamWriter receipt = new StreamWriter(@"C:\Users\roman\Downloads\Receipt.txt");
            receipt.WriteLine(textBox1Abouttheproducts.Text);
            receipt.Close();

            System.Diagnostics.Process receipt1 = new System.Diagnostics.Process();
            receipt1.StartInfo.FileName = "notepad.exe";
            receipt1.StartInfo.Arguments = @"C:\Users\roman\Downloads\Receipt.txt";
            receipt1.Start();
        }

        private void textBox7Tothecashdesk_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox7Tothecashdesk.Text == "0")
            {
                textBox7Tothecashdesk.Text = "";
            }
        }

        private void textBox3Discount_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox3Discount.Text == "0")
            {
                textBox3Discount.Text = "";
            }
        }

        private void textBox2Price_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox2Price.Text == "0")
            {
                textBox2Price.Text = "";
            }
        }

        private void textBox2Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8 && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void button1Add_Click(object sender, EventArgs e)
        {
            pr = Convert.ToDouble(textBox2Price.Text);
            disc = Convert.ToDouble(textBox3Discount.Text);
            numof = Convert.ToDouble(numericUpDown1Numberof.Value);

            if (numof > 1)
            {
                pr = numof * pr;
                aodisc1 = (pr * disc) / 100;
                aodisc = aodisc1 / numof;
                textBox4Amountofdiscount.Text = aodisc.ToString();
                tot = pr - aodisc;
                textBox5Total.Text = tot.ToString();

                nds = Math.Round((Convert.ToDouble(textBox5Total.Text) * 20) / 120, 2);
            }
            else
            {
                aodisc = (pr * disc) / 100;
                textBox4Amountofdiscount.Text = aodisc.ToString();
                tot = pr - aodisc;
                textBox5Total.Text = tot.ToString();

                nds = Math.Round((Convert.ToDouble(textBox5Total.Text) * 20) / 120, 2);
            }

            fp += tot;
            textBox6Forpayment.Text = fp.ToString();
            textBox1Abouttheproducts.Text += numericUpDown1Numberof.Value + " " + comboBox1Productname.Text + " (discount: " + disc + " %)" + Environment.NewLine +
                                             "NDS: 20 % (" + nds + ")" + Environment.NewLine +
                                             "Amount of discount (for one product): " + aodisc + Environment.NewLine;
        }

        private void button3NewBuy_Click(object sender, EventArgs e)
        {
            textBox8AbouttheproductsCover.Visible = true;
            textBox1Abouttheproducts.Text = "";
            comboBox1Productname.SelectedIndex = -1;
            textBox2Price.Text = "0";
            numericUpDown1Numberof.Value = 0;
            textBox3Discount.Text = "0";
            textBox4Amountofdiscount.Text = "0";
            textBox5Total.Text = "0";
            textBox6Forpayment.Text = "0";
            textBox7Tothecashdesk.Text = "0";
        }

        private void button2Buy_Click(object sender, EventArgs e)
        {
            ttcd = Convert.ToDouble(textBox7Tothecashdesk.Text);
            chan = ttcd - fp;

            textBox8AbouttheproductsCover.Visible = false;

            textBox1Abouttheproducts.Text += Environment.NewLine + "FOR PAYMENT: " + fp + Environment.NewLine +
                                             "To the cash desk: " + ttcd + Environment.NewLine +
                                             "Change: " + chan + Environment.NewLine;
        }
    }
}
