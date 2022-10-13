using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cash_Machine
{
    public partial class Form1CashMachine : Form
    {
        public Form1CashMachine()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int sum, f, nf, oh, oh1, ohsum, th, th1, thsum, fh, fh1, fhsum, ot, ot1, otsum, tt, tt1,  ttsum, ft, ft1, ftsum, nft, ntt, not, nfh, nth, noh;

                sum = Convert.ToInt32(textBox1Sum.Text);
                if (sum <= 0)
                {
                    textBox9Correct.Visible = true;

                    textBox2Fifty.Text = "0";
                    textBox3Onehundred.Text = "0";
                    textBox4Twohundred.Text = "0";
                    textBox5Fivehundred.Text = "0";
                    textBox6Onethousand.Text = "0";
                    textBox7Twothousand.Text = "0";
                    textBox8Fivethousand.Text = "0";
                }
                
                if (sum > 0 && (sum % 50 == 0 || sum % 100 == 0))
                {
                    textBox9Correct.Visible = false;

                    nft = Convert.ToInt32(numericUpDown7Fivethousand.Value);
                    ntt = Convert.ToInt32(numericUpDown6Twothousand.Value);
                    not = Convert.ToInt32(numericUpDown5Onethousand.Value);
                    nfh = Convert.ToInt32(numericUpDown4Fivehundred.Value);
                    nth = Convert.ToInt32(numericUpDown3Twohundred.Value);
                    noh = Convert.ToInt32(numericUpDown2Onehundred.Value);
                    nf = Convert.ToInt32(numericUpDown1Fifty.Value);

                    ftsum = Convert.ToInt32(textBox8Fivethousand.Text) * 5000;
                    ttsum = Convert.ToInt32(textBox7Twothousand.Text) * 2000;
                    otsum = Convert.ToInt32(textBox6Onethousand.Text) * 1000;
                    fhsum = Convert.ToInt32(textBox5Fivehundred.Text) * 500;
                    thsum = Convert.ToInt32(textBox4Twohundred.Text) * 200;
                    ohsum = Convert.ToInt32(textBox3Onehundred.Text) * 100;

                    ft1 = sum / 5000;

                    if (nft * 5000 <= sum && nft > 0 && sum % nft == 0)
                    {
                        ft = ft1;
                        textBox8Fivethousand.Text = ft.ToString();
                        numericUpDown7Fivethousand.Value -= ft;
                        tt1 = sum % 5000;
                        tt = tt1 / 2000;
                        textBox7Twothousand.Text = tt.ToString();
                        numericUpDown6Twothousand.Value -= tt;
                        ot1 = tt1 % 2000;
                        ot = ot1 / 1000;
                        textBox6Onethousand.Text = ot.ToString();
                        numericUpDown5Onethousand.Value -= ot;
                        fh1 = sum % 1000;
                        fh = fh1 / 500;
                        textBox5Fivehundred.Text = fh.ToString();
                        numericUpDown4Fivehundred.Value -= fh;
                        th1 = fh1 % 500;
                        th = th1 / 200;
                        textBox4Twohundred.Text = th.ToString();
                        numericUpDown3Twohundred.Value -= th;
                        oh1 = th1 % 200;
                        oh = oh1 / 100;
                        textBox3Onehundred.Text = oh.ToString();
                        numericUpDown2Onehundred.Value -= oh;
                        f = sum % 100;
                        f = f / 50;
                        textBox2Fifty.Text = f.ToString();
                        numericUpDown1Fifty.Value -= f;
                    }
                    else if (nft == 0 && ntt == 0 && not == 0 && nfh == 0 && nth == 0 && noh == 0)
                    {
                        ohsum = Convert.ToInt32(textBox3Onehundred.Text) * 100;
                        f = (sum - ftsum - ttsum - otsum - fhsum - thsum - ohsum) / 50;
                        textBox2Fifty.Text = f.ToString();
                        numericUpDown1Fifty.Value -= f;
                    }
                    else if (ntt * 2000 <= sum && ntt > 0 && sum % ntt == 0)
                    {
                        ft = ft1;
                        textBox8Fivethousand.Text = ft.ToString();
                        numericUpDown7Fivethousand.Value -= ft;
                        tt1 = sum % 5000;
                        tt = tt1 / 2000;
                        textBox7Twothousand.Text = tt.ToString();
                        numericUpDown6Twothousand.Value -= tt;
                        ot1 = tt1 % 2000;
                        ot = ot1 / 1000;
                        textBox6Onethousand.Text = ot.ToString();
                        numericUpDown5Onethousand.Value -= ot;
                        fh1 = sum % 1000;
                        fh = fh1 / 500;
                        textBox5Fivehundred.Text = fh.ToString();
                        numericUpDown4Fivehundred.Value -= fh;
                        th1 = fh1 % 500;
                        th = th1 / 200;
                        textBox4Twohundred.Text = th.ToString();
                        numericUpDown3Twohundred.Value -= th;
                        oh1 = th1 % 200;
                        oh = oh1 / 100;
                        textBox3Onehundred.Text = oh.ToString();
                        numericUpDown2Onehundred.Value -= oh;
                        f = sum % 100;
                        f = f / 50;
                        textBox2Fifty.Text = f.ToString();
                        numericUpDown1Fifty.Value -= f;
                    }
                    else if (nft == 0 && ntt == 0 && not == 0 && nfh == 0 && nth == 0)
                    {
                        thsum = Convert.ToInt32(textBox4Twohundred.Text) * 200;
                        oh = (sum - ftsum - ttsum - otsum - fhsum - thsum) / 100;
                        textBox3Onehundred.Text = oh.ToString();
                        numericUpDown2Onehundred.Value -= oh;
                        ohsum = Convert.ToInt32(textBox3Onehundred.Text) * 100;
                        f = (sum - ftsum - ttsum - otsum - fhsum - thsum - ohsum) / 50;
                        textBox2Fifty.Text = f.ToString();
                        numericUpDown1Fifty.Value -= f;
                    }
                    else if (not * 1000 <= sum && not > 0 && sum % not == 0)
                    {
                        ft = ft1;
                        textBox8Fivethousand.Text = ft.ToString();
                        numericUpDown7Fivethousand.Value -= ft;
                        tt1 = sum % 5000;
                        tt = tt1 / 2000;
                        textBox7Twothousand.Text = tt.ToString();
                        numericUpDown6Twothousand.Value -= tt;
                        ot1 = tt1 % 2000;
                        ot = ot1 / 1000;
                        textBox6Onethousand.Text = ot.ToString();
                        numericUpDown5Onethousand.Value -= ot;
                        fh1 = sum % 1000;
                        fh = fh1 / 500;
                        textBox5Fivehundred.Text = fh.ToString();
                        numericUpDown4Fivehundred.Value -= fh;
                        th1 = fh1 % 500;
                        th = th1 / 200;
                        textBox4Twohundred.Text = th.ToString();
                        numericUpDown3Twohundred.Value -= th;
                        oh1 = th1 % 200;
                        oh = oh1 / 100;
                        textBox3Onehundred.Text = oh.ToString();
                        numericUpDown2Onehundred.Value -= oh;
                        f = sum % 100;
                        f = f / 50;
                        textBox2Fifty.Text = f.ToString();
                        numericUpDown1Fifty.Value -= f;
                    }
                    else if (nft == 0 && ntt == 0 && not == 0 && nfh == 0)
                    {
                        fhsum = Convert.ToInt32(textBox5Fivehundred.Text) * 500;
                        th = (sum - ftsum - ttsum - otsum - fhsum) / 200;
                        textBox4Twohundred.Text = th.ToString();
                        numericUpDown3Twohundred.Value -= th;
                        thsum = Convert.ToInt32(textBox4Twohundred.Text) * 200;
                        oh = (sum - ftsum - ttsum - otsum - fhsum - thsum) / 100;
                        textBox3Onehundred.Text = oh.ToString();
                        numericUpDown2Onehundred.Value -= oh;
                        ohsum = Convert.ToInt32(textBox3Onehundred.Text) * 100;
                        f = (sum - ftsum - ttsum - otsum - fhsum - thsum - ohsum) / 50;
                        textBox2Fifty.Text = f.ToString();
                        numericUpDown1Fifty.Value -= f;
                    }
                    else if (nfh * 500 <= sum && nfh > 0 && sum % nfh == 0)
                    {
                        ft = ft1;
                        textBox8Fivethousand.Text = ft.ToString();
                        numericUpDown7Fivethousand.Value -= ft;
                        tt1 = sum % 5000;
                        tt = tt1 / 2000;
                        textBox7Twothousand.Text = tt.ToString();
                        numericUpDown6Twothousand.Value -= tt;
                        ot1 = tt1 % 2000;
                        ot = ot1 / 1000;
                        textBox6Onethousand.Text = ot.ToString();
                        numericUpDown5Onethousand.Value -= ot;
                        fh1 = sum % 1000;
                        fh = fh1 / 500;
                        textBox5Fivehundred.Text = fh.ToString();
                        numericUpDown4Fivehundred.Value -= fh;
                        th1 = fh1 % 500;
                        th = th1 / 200;
                        textBox4Twohundred.Text = th.ToString();
                        numericUpDown3Twohundred.Value -= th;
                        oh1 = th1 % 200;
                        oh = oh1 / 100;
                        textBox3Onehundred.Text = oh.ToString();
                        numericUpDown2Onehundred.Value -= oh;
                        f = sum % 100;
                        f = f / 50;
                        textBox2Fifty.Text = f.ToString();
                        numericUpDown1Fifty.Value -= f;
                    }
                    else if (nft == 0 && ntt == 0 && not == 0)
                    {
                        otsum = Convert.ToInt32(textBox6Onethousand.Text) * 1000;
                        fh = (sum - ftsum - ttsum - otsum) / 500;
                        textBox5Fivehundred.Text = fh.ToString();
                        numericUpDown4Fivehundred.Value -= fh;
                        fhsum = Convert.ToInt32(textBox5Fivehundred.Text) * 500;
                        th = (sum - ftsum - ttsum - otsum - fhsum) / 200;
                        textBox4Twohundred.Text = th.ToString();
                        numericUpDown3Twohundred.Value -= th;
                        thsum = Convert.ToInt32(textBox4Twohundred.Text) * 200;
                        oh = (sum - ftsum - ttsum - otsum - fhsum - thsum) / 100;
                        textBox3Onehundred.Text = oh.ToString();
                        numericUpDown2Onehundred.Value -= oh;
                        ohsum = Convert.ToInt32(textBox3Onehundred.Text) * 100;
                        f = (sum - ftsum - ttsum - otsum - fhsum - thsum - ohsum) / 50;
                        textBox2Fifty.Text = f.ToString();
                        numericUpDown1Fifty.Value -= f;
                    }
                    else if (nth * 200 <= sum && nth > 0 && sum % nth == 0)
                    {
                        ft = ft1;
                        textBox8Fivethousand.Text = ft.ToString();
                        numericUpDown7Fivethousand.Value -= ft;
                        tt1 = sum % 5000;
                        tt = tt1 / 2000;
                        textBox7Twothousand.Text = tt.ToString();
                        numericUpDown6Twothousand.Value -= tt;
                        ot1 = tt1 % 2000;
                        ot = ot1 / 1000;
                        textBox6Onethousand.Text = ot.ToString();
                        numericUpDown5Onethousand.Value -= ot;
                        fh1 = sum % 1000;
                        fh = fh1 / 500;
                        textBox5Fivehundred.Text = fh.ToString();
                        numericUpDown4Fivehundred.Value -= fh;
                        th1 = fh1 % 500;
                        th = th1 / 200;
                        textBox4Twohundred.Text = th.ToString();
                        numericUpDown3Twohundred.Value -= th;
                        oh1 = th1 % 200;
                        oh = oh1 / 100;
                        textBox3Onehundred.Text = oh.ToString();
                        numericUpDown2Onehundred.Value -= oh;
                        f = sum % 100;
                        f = f / 50;
                        textBox2Fifty.Text = f.ToString();
                        numericUpDown1Fifty.Value -= f;
                    }
                    else if (nft == 0 && ntt == 0)
                    {
                        ttsum = Convert.ToInt32(textBox7Twothousand.Text) * 2000;
                        ot = (sum - ftsum - ttsum) / 1000;
                        textBox6Onethousand.Text = ot.ToString();
                        numericUpDown5Onethousand.Value -= ot;
                        otsum = Convert.ToInt32(textBox6Onethousand.Text) * 1000;
                        fh = (sum - ftsum - ttsum - otsum) / 500;
                        textBox5Fivehundred.Text = fh.ToString();
                        numericUpDown4Fivehundred.Value -= fh;
                        fhsum = Convert.ToInt32(textBox5Fivehundred.Text) * 500;
                        th = (sum - ftsum - ttsum - otsum - fhsum) / 200;
                        textBox4Twohundred.Text = th.ToString();
                        numericUpDown3Twohundred.Value -= th;
                        thsum = Convert.ToInt32(textBox4Twohundred.Text) * 200;
                        oh = (sum - ftsum - ttsum - otsum - fhsum - thsum) / 100;
                        textBox3Onehundred.Text = oh.ToString();
                        numericUpDown2Onehundred.Value -= oh;
                        ohsum = Convert.ToInt32(textBox3Onehundred.Text) * 100;
                        f = (sum - ftsum - ttsum - otsum - fhsum - thsum - ohsum) / 50;
                        textBox2Fifty.Text = f.ToString();
                        numericUpDown1Fifty.Value -= f;
                    }
                    else if (noh * 100 <= sum && noh > 0 && sum % noh == 0)
                    {
                        ft = ft1;
                        textBox8Fivethousand.Text = ft.ToString();
                        numericUpDown7Fivethousand.Value -= ft;
                        tt1 = sum % 5000;
                        tt = tt1 / 2000;
                        textBox7Twothousand.Text = tt.ToString();
                        numericUpDown6Twothousand.Value -= tt;
                        ot1 = tt1 % 2000;
                        ot = ot1 / 1000;
                        textBox6Onethousand.Text = ot.ToString();
                        numericUpDown5Onethousand.Value -= ot;
                        fh1 = sum % 1000;
                        fh = fh1 / 500;
                        textBox5Fivehundred.Text = fh.ToString();
                        numericUpDown4Fivehundred.Value -= fh;
                        th1 = fh1 % 500;
                        th = th1 / 200;
                        textBox4Twohundred.Text = th.ToString();
                        numericUpDown3Twohundred.Value -= th;
                        oh1 = th1 % 200;
                        oh = oh1 / 100;
                        textBox3Onehundred.Text = oh.ToString();
                        numericUpDown2Onehundred.Value -= oh;
                        f = sum % 100;
                        f = f / 50;
                        textBox2Fifty.Text = f.ToString();
                        numericUpDown1Fifty.Value -= f;
                    }
                    else if (nft == 0)
                    {
                        ftsum = Convert.ToInt32(textBox8Fivethousand.Text) * 5000;
                        tt = (sum - ftsum) / 2000;
                        textBox7Twothousand.Text = tt.ToString();
                        numericUpDown6Twothousand.Value -= tt;
                        ttsum = Convert.ToInt32(textBox7Twothousand.Text) * 2000;
                        ot = (sum - ftsum - ttsum) / 1000;
                        textBox6Onethousand.Text = ot.ToString();
                        numericUpDown5Onethousand.Value -= ot;
                        otsum = Convert.ToInt32(textBox6Onethousand.Text) * 1000;
                        fh = (sum - ftsum - ttsum - otsum) / 500;
                        textBox5Fivehundred.Text = fh.ToString();
                        numericUpDown4Fivehundred.Value -= fh;
                        fhsum = Convert.ToInt32(textBox5Fivehundred.Text) * 500;
                        th = (sum - ftsum - ttsum - otsum - fhsum) / 200;
                        textBox4Twohundred.Text = th.ToString();
                        numericUpDown3Twohundred.Value -= th;
                        thsum = Convert.ToInt32(textBox4Twohundred.Text) * 200;
                        oh = (sum - ftsum - ttsum - otsum - fhsum - thsum) / 100;
                        textBox3Onehundred.Text = oh.ToString();
                        numericUpDown2Onehundred.Value -= oh;
                        ohsum = Convert.ToInt32(textBox3Onehundred.Text) * 100;
                        f = (sum - ftsum - ttsum - otsum - fhsum - thsum - ohsum) / 50;
                        textBox2Fifty.Text = f.ToString();
                        numericUpDown1Fifty.Value -= f;
                    }
                }
            }
            catch
            {
                textBox9Correct.Visible = true;
                textBox2Fifty.Text = "0";
                textBox3Onehundred.Text = "0";
                textBox4Twohundred.Text = "0";
                textBox5Fivehundred.Text = "0";
                textBox6Onethousand.Text = "0";
                textBox7Twothousand.Text = "0";
                textBox8Fivethousand.Text = "0";
            }
        }

        private void button3PIN_Click(object sender, EventArgs e)
        {
            textBox10PIN.UseSystemPasswordChar = true;
            if (textBox10PIN.Text == "1111")
            {
                panel1PIN.Visible = false;
            }
            else
            {
                MessageBox.Show("Incorrect PIN", "Print the correct PIN", MessageBoxButtons.OK);
            }
        }
    }
}
