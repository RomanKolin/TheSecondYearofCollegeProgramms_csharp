using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1Calculator : Form
    {
        public Form1Calculator()
        {
            InitializeComponent();
            this.DoubleClick += button13MemoryClear_DoubleClick;
        }

        double a, b, mp, mp1, mm, mm1, sum, sub, mult, div, sqrt, nsqrt, perc, x2, x3, exp, log, ln, sin, cos, tan, cot, fac, fac1, dfac, dfac1;
        private void button13MemoryClear_DoubleClick(object sender, EventArgs e)
        {
            mp = 0;
            mm = 0;
            textBox3Memory1.Visible = false;
            textBox4Memory2.Visible = false;
        }

        private void button24Percent_Click(object sender, EventArgs e)
        {
            perc = a;
            perc = (perc * b) / 100;
            if (oper == "×")
            {
                textBox2SecondNum.Visible = false;
                textBox1FirstNumandResult.Visible = true;
                textBox1FirstNumandResult.Text = perc.ToString();
                a = Convert.ToDouble(textBox1FirstNumandResult.Text);
            } 
        }

        private void button16CleanEntry_Click(object sender, EventArgs e)
        {
            if (textBox1FirstNumandResult.Text != "")
            {
                textBox1FirstNumandResult.Text = "0";
            }
            else if (textBox2SecondNum.Text != "0")
            {
                textBox2SecondNum.Text = "0";
            }
        }

        private void button26e_Click(object sender, EventArgs e)
        {
            if (textBox1FirstNumandResult.Text == "0")
            {
                a = Math.E;
                textBox1FirstNumandResult.Text = a.ToString();
            }
            else
            {
                b = Math.E;
                textBox2SecondNum.Text = b.ToString();
            }
        }

        private void button27Intheseconddegree_Click(object sender, EventArgs e)
        {
            x2 = a;
            x2 = Math.Pow(x2, 2);
            textBox1FirstNumandResult.Text = x2.ToString();
            a = Convert.ToDouble(textBox1FirstNumandResult.Text);
        }

        private void button28Inthethirddegree_Click(object sender, EventArgs e)
        {
            x3 = a;
            x3 = Math.Pow(x3, 3);
            textBox1FirstNumandResult.Text = x3.ToString();
            a = Convert.ToDouble(textBox1FirstNumandResult.Text);
        }

        private void button29Exponentialfunction_Click(object sender, EventArgs e)
        {
            exp = Math.Pow(Math.E, Convert.ToDouble(textBox1FirstNumandResult.Text));
            textBox1FirstNumandResult.Text = exp.ToString();
        }

        private void button30Logarithm_Click(object sender, EventArgs e)
        {
            textBox2SecondNum.Visible = true;
            textBox2SecondNum.Text = textBox1FirstNumandResult.Text;
            oper = "log";
        }

        private void button31Naturallogarithm_Click(object sender, EventArgs e)
        {
            if (a < 0)
            {
                textBox1FirstNumandResult.Text = "0";
                textBox6Error.Visible = true;
            }
            else
            {
                ln = a;
                ln = Math.Log(ln);
                textBox1FirstNumandResult.Text = ln.ToString();
                a = Convert.ToDouble(textBox1FirstNumandResult.Text);
            }
        }

        private void button32Factorial_Click(object sender, EventArgs e)
        {
            if (a < 0)
            {
                textBox1FirstNumandResult.Text = "0";
                textBox6Error.Visible = true;
            }
            else if (a == 0)
            {
                textBox1FirstNumandResult.Text = "1";
            }
            else
            {
                fac = a;
                fac1 = fac - 1;
                while (fac1 > 1)
                {
                    fac = fac * fac1;
                    fac1 -= 1;
                }
                textBox1FirstNumandResult.Text = fac.ToString();
                a = Convert.ToDouble(textBox1FirstNumandResult.Text);
            }
        }

        private void button33Doublefactorial_Click(object sender, EventArgs e)
        {
            if (a < 0)
            {
                textBox1FirstNumandResult.Text = "0";
                textBox6Error.Visible = true;
            }
            if (a == 0)
            {
                textBox1FirstNumandResult.Text = "1";
            }
            if (a % 2 == 0)
            {
                dfac = a;
                dfac1 = a - 2;
                while (dfac1 > 1)
                {
                    dfac = dfac * dfac1;
                    dfac1 -= 2;
                }
                textBox1FirstNumandResult.Text = dfac.ToString();
                a = Convert.ToDouble(textBox1FirstNumandResult.Text);
            }
            if (a % 2 == 1)
            {
                dfac = a;
                dfac1 = a - 2;
                while (dfac1 > 1)
                {
                    dfac = dfac * dfac1;
                    dfac1 -= 2;
                }
                textBox1FirstNumandResult.Text = dfac.ToString();
                a = Convert.ToDouble(textBox1FirstNumandResult.Text);
            }
        }

        private void button34Sin_Click(object sender, EventArgs e)
        {
            sin = a;
            sin = Math.Sin(sin * (Math.PI / 180));
            textBox1FirstNumandResult.Text = sin.ToString();
            a = Convert.ToDouble(textBox1FirstNumandResult.Text);
        }

        private void button35Cos_Click(object sender, EventArgs e)
        {
            cos = a;
            cos = Math.Cos(cos * (Math.PI / 180));
            textBox1FirstNumandResult.Text = cos.ToString();
            a = Convert.ToDouble(textBox1FirstNumandResult.Text);
        }

        private void button36Tan_Click(object sender, EventArgs e)
        {
            tan = a;
            tan = Math.Tan(tan * (Math.PI / 180));
            textBox1FirstNumandResult.Text = tan.ToString();
            a = Convert.ToDouble(textBox1FirstNumandResult.Text);
        }

        private void button37Cot_Click(object sender, EventArgs e)
        {
            cot = a;
            cot = 1 / Math.Tan(cot * (Math.PI / 180));
            textBox1FirstNumandResult.Text = cot.ToString();
            a = Convert.ToDouble(textBox1FirstNumandResult.Text);
        }

        private void button38Equal_Click(object sender, EventArgs e)
        {
            switch (oper)
            {
                case "+":
                    sum = a;
                    sum += b;
                    textBox1FirstNumandResult.Text = sum.ToString();
                    a = Convert.ToDouble(textBox1FirstNumandResult.Text);
                    break;
                case "−":
                    sub = a;
                    sub -= b;
                    textBox1FirstNumandResult.Text = sub.ToString();
                    a = Convert.ToDouble(textBox1FirstNumandResult.Text);
                    break;
                case "×":
                    mult = a;
                    mult *= b;
                    textBox1FirstNumandResult.Text = mult.ToString();
                    a = Convert.ToDouble(textBox1FirstNumandResult.Text);
                    break;
                case "÷":
                    if (b == 0)
                    {
                        textBox1FirstNumandResult.Text = "0";
                        textBox6Error.Visible = true;
                    }
                    else
                    {
                        div = a;
                        div /= b;
                        textBox1FirstNumandResult.Text = div.ToString();
                        a = Convert.ToDouble(textBox1FirstNumandResult.Text);
                    }
                    break;
                case "nsqrt":
                    nsqrt = a;
                    nsqrt = Math.Pow(nsqrt, 1 / b);
                    textBox1FirstNumandResult.Text = nsqrt.ToString();
                    a = Convert.ToDouble(textBox1FirstNumandResult.Text);
                    break;
                case "log":
                    if (a < 0 || b <= 1)
                    {
                        textBox1FirstNumandResult.Text = "0";
                        textBox6Error.Visible = true;
                    }
                    else
                    {
                        log = a;
                        log = Math.Log(log, b);
                        textBox1FirstNumandResult.Text = log.ToString();
                        a = Convert.ToDouble(textBox1FirstNumandResult.Text);
                    }
                    break;
            }
            textBox2SecondNum.Visible = false;
            textBox1FirstNumandResult.Visible = true;
        }

        private void button39Calculator_Click(object sender, EventArgs e)
        {
            this.Size = new Size(289, 343);
        }

        private void button40EngineeringCalculator_Click(object sender, EventArgs e)
        {
            this.Size = new Size(614, 343);
        }

        private void button11Dot_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox2SecondNum.Text != "0" || textBox1FirstNumandResult.Text == "")
                {
                    if (textBox2SecondNum.Text == textBox1FirstNumandResult.Text || textBox2SecondNum.Text == "0")
                    {
                        textBox2SecondNum.Text = "0";
                    }
                    textBox2SecondNum.Text += ".";
                    b = Convert.ToDouble(textBox2SecondNum.Text);
                }
                else
                {
                    if (textBox1FirstNumandResult.Text != "")
                    {
                        textBox1FirstNumandResult.Text += ".";
                    }
                    a = Convert.ToDouble(textBox1FirstNumandResult.Text);
                }
            }
            catch
            {
                textBox1FirstNumandResult.Text = "0";
                textBox2SecondNum.Text = "0";
                textBox5Error.Visible = true;
                textBox5Error.Text = "0";
                textBox6Error.Visible = true;
            }
        }

        private void button12PlusMinus_Click(object sender, EventArgs e)
        {
            if (textBox1FirstNumandResult.Text != "")
            {
                a = a * -1;
                textBox1FirstNumandResult.Text = a.ToString();
            }
            if (textBox2SecondNum.Text != "0")
            {
                b = b * -1;
                textBox2SecondNum.Text = b.ToString();
            }
        }

        string oper;

        private void button21Division_Click(object sender, EventArgs e)
        {
            textBox2SecondNum.Visible = true;
            textBox2SecondNum.Text = textBox1FirstNumandResult.Text;
            oper = "÷";
        }

        private void button15MemoryMinus_Click(object sender, EventArgs e)
        {
            mm1 = -Convert.ToDouble(textBox1FirstNumandResult.Text);
            mm = mm + mm1;
            oper = "mm";
            textBox3Memory1.Visible = true;
            textBox4Memory2.Visible = true;
        }

        private void button23nSquareroot_Click(object sender, EventArgs e)
        {
            textBox2SecondNum.Visible = true;
            textBox2SecondNum.Text = textBox1FirstNumandResult.Text;
            oper = "nsqrt";
        }

        private void button25PI_Click(object sender, EventArgs e)
        {
            if (textBox1FirstNumandResult.Text == "0")
            {
                a = Math.PI;
                textBox1FirstNumandResult.Text = a.ToString();
            }
            else
            {
                b = Math.PI;
                textBox2SecondNum.Text = b.ToString();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox2SecondNum.Text != "0" || textBox1FirstNumandResult.Text == "")
                {
                    if (textBox2SecondNum.Text == textBox1FirstNumandResult.Text || textBox2SecondNum.Text == "0")
                    {
                        textBox1FirstNumandResult.Text = "";
                        textBox2SecondNum.Text = "";
                    }
                    textBox2SecondNum.Text += (sender as Button).Text;
                    b = Convert.ToDouble(textBox2SecondNum.Text);
                }
                else
                {
                    if (textBox1FirstNumandResult.Text == "0")
                    {
                        textBox1FirstNumandResult.Text = "";
                    }
                    textBox1FirstNumandResult.Text += (sender as Button).Text;
                    a = Convert.ToDouble(textBox1FirstNumandResult.Text);
                }
            }
            catch
            {
                textBox1FirstNumandResult.Text = "0";
                textBox6Error.Visible = true;
            }
        }

        private void button18Addition_Click(object sender, EventArgs e)
        {
            textBox2SecondNum.Visible = true;
            textBox2SecondNum.Text = textBox1FirstNumandResult.Text;
            oper = "+";
        }

        private void button19Subtraction_Click(object sender, EventArgs e)
        {
            textBox2SecondNum.Visible = true;
            textBox2SecondNum.Text = textBox1FirstNumandResult.Text;
            oper = "−";
        }

        private void button20Multiplication_Click(object sender, EventArgs e)
        {
            textBox2SecondNum.Visible = true;
            textBox2SecondNum.Text = textBox1FirstNumandResult.Text;
            oper = "×";
        }

        private void button14MemoryPlus_Click(object sender, EventArgs e)
        {
            mp1 = Convert.ToDouble(textBox1FirstNumandResult.Text);
            mp = mp + mp1;
            oper = "mp";
            textBox3Memory1.Visible = true;
            textBox4Memory2.Visible = true;
        }

        private void button17OnClear_Click(object sender, EventArgs e)
        {
            textBox1FirstNumandResult.Text = "0";
            textBox2SecondNum.Text = "0";
            textBox2SecondNum.Visible = false;
            textBox5Error.Visible = false;
            textBox5Error.Text = "0";
            textBox6Error.Visible = false;
        }

        private void button22Squareroot_Click(object sender, EventArgs e)
        {
            sqrt = a;
            sqrt = Math.Sqrt(sqrt);
            textBox1FirstNumandResult.Text = sqrt.ToString();
            a = Convert.ToDouble(textBox1FirstNumandResult.Text);
        }

        private void button13MemoryClear_Click(object sender, EventArgs e)
        {
            switch (oper)
            {
                case "mp":
                    textBox1FirstNumandResult.Text = mp.ToString();
                    break;
                case "mm":
                    textBox1FirstNumandResult.Text = mm.ToString();
                    break;
            }
        }
    }
}
