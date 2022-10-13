using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Methods__actions_with_fractions_
{
    public partial class Form1actionswithfractions : Form
    {
        public Form1actionswithfractions()
        {
            InitializeComponent();
        }

        private void button1equal_Click(object sender, EventArgs e)
        {
            label1greatestleastcommondivisormultiple.Visible = true;
            if (textBox7resultdenominator.Visible == false)
                textBox6resultnumerator.Location = new Point(289, 45);
            textBox7resultdenominator.Visible = true;
            
            if (radioButton1fractionreduction.Checked)
            {
                if (textBox1firstnumerator.Text == "" || textBox2firstdenominator.Text == "")
                    MessageBox.Show("Please, fill in the empty fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    FractionReduction(numer: Convert.ToInt32(textBox1firstnumerator.Text), denomin: Convert.ToInt32(textBox2firstdenominator.Text));

                    label1greatestleastcommondivisormultiple.Text = "Greatest common divisor =";
                    textBox5greatestleastcommondivisormultiple.Visible = true;
                }
            }
            if (radioButton2actionswithfractions.Checked)
            {
                if (textBox1firstnumerator.Text == "" || textBox2firstdenominator.Text == "" || textBox3secondnumerator.Text == "" || textBox4seconddenominator.Text == "")
                    MessageBox.Show("Please, fill in the empty fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    //значения для сложения/вычитания дробей
                    int fstnumeraddsub, fstnumermultdiv, fstdenommultdiv, secnumeraddsub, secnumermultdiv, secdenommultdiv, lcm, resnumer, resdenom;
                    //

                    //значения для умножения/деления дробей
                    fstnumermultdiv = Convert.ToInt32(textBox1firstnumerator.Text);
                    fstdenommultdiv = Convert.ToInt32(textBox2firstdenominator.Text);
                    secnumermultdiv = Convert.ToInt32(textBox3secondnumerator.Text);
                    secdenommultdiv = Convert.ToInt32(textBox4seconddenominator.Text);
                    //

                    //приведение дробей к наименьшему общему знаменателю для их сложения/вычитания
                    lcm = LeastCommonMultiple();
                    fstnumeraddsub = (lcm / fstdenommultdiv) * fstnumermultdiv;
                    secnumeraddsub = (lcm / secdenommultdiv) * secnumermultdiv;
                    //

                    resnumer = 0;
                    resdenom = 0;
                    switch (comboBox1sign.SelectedIndex)
                    {
                        case 0:
                            resnumer = fstnumeraddsub + secnumeraddsub;
                            resdenom = lcm;
                            break;
                        case 1:
                            resnumer = fstnumeraddsub - secnumeraddsub;
                            resdenom = lcm;
                            break;
                        case 2:
                            resnumer = fstnumermultdiv * secnumermultdiv;
                            resdenom = fstdenommultdiv * secdenommultdiv;
                            break;
                        case 3:
                            resnumer = fstnumermultdiv * secdenommultdiv;
                            resdenom = fstdenommultdiv * secnumermultdiv;
                            break;
                    }
                    FractionReduction(numer: resnumer, denomin: resdenom);

                    label1greatestleastcommondivisormultiple.Text = "Least common multiple =";
                    textBox5greatestleastcommondivisormultiple.Visible = true;
                    textBox5greatestleastcommondivisormultiple.Text = lcm.ToString();
                }
            }
        }

        private void button2clear_Click(object sender, EventArgs e)
        {
            FractionReductionClear();
            radioButton1fractionreduction.Checked = true;
            textBox1firstnumerator.Text = "";
            textBox2firstdenominator.Text = "";
            textBox6resultnumerator.Location = new Point(289, 45);
            textBox7resultdenominator.Location = new Point(289, 126);
            textBox7resultdenominator.Visible = true;
        }

        //метод для нахождения наибольшего общего делителя
        public int GreatestCommonDivisor(int numer, int denomin)
        {
            int largnum, smallnum, rem, gcd;

            numer = Convert.ToInt32(numer);
            denomin = Convert.ToInt32(denomin);

            //нахождение наибольшего числа среди числителя и знаменателя
            gcd = 0;
            if (numer > denomin)
            {
                largnum = numer;
                smallnum = denomin;
                rem = smallnum;
            }
            else
            {
                largnum = denomin;
                smallnum = numer;
                rem = smallnum;
            }
            //

            //поиск НОД делением большего числа на меньшее (из числителя и знаменателя) до того момента, пока остаток больше нуля. НОД равен последнему делителю в цикле 
            while (rem != 0)
            {
                rem = largnum % smallnum;

                if (rem == 0)
                    gcd = smallnum;
                largnum = smallnum;
                smallnum = rem;
            }
            //
           
            return gcd;
        }
        //

        //метод для нахождения наименьшего общего кратного через НОД
        public int LeastCommonMultiple()
        {
            int gcd, lcm, fstdenomin, snddenomin;

            fstdenomin = Convert.ToInt32(textBox2firstdenominator.Text);
            snddenomin = Convert.ToInt32(textBox4seconddenominator.Text);
            gcd = GreatestCommonDivisor(numer: fstdenomin, denomin: snddenomin);
            lcm = (fstdenomin * snddenomin) / gcd;

            return lcm;
        }
        //

        //метод для сокращения дроби
        public void FractionReduction(int numer, int denomin)
        {
            int gcd, rednumer, reddenomin;

            gcd = GreatestCommonDivisor(numer: numer, denomin: denomin);
            rednumer = numer / gcd;
            reddenomin = denomin / gcd;
            textBox6resultnumerator.Text = rednumer.ToString();
            textBox7resultdenominator.Text = reddenomin.ToString();

            if (radioButton1fractionreduction.Checked == true)
            {
                textBox5greatestleastcommondivisormultiple.Text = gcd.ToString();
                if (reddenomin == 1)
                    IfResultDenominatorEquals1FRACTION();
            }
            if (radioButton2actionswithfractions.Checked == true)
            {
                if (reddenomin == 1)
                    IfResultDenominatorEquals1ACTIONS();
            }
        }
        //

        private void radioButton1fractionreduction_CheckedChanged(object sender, EventArgs e)
        {
            FractionReductionClear();
        }

        private void radioButton2actionswithfractions_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1sign.Visible = true;
            textBox3secondnumerator.Visible = true;
            textBox4seconddenominator.Visible = true;
            textBox7resultdenominator.Visible = true;
            this.Size = new Size(800, 300);
            button1equal.Location = new Point(443, 79);
            button2clear.Location = new Point(714, 213);
            textBox6resultnumerator.Location = new Point(539, 45);
            textBox7resultdenominator.Location = new Point(539, 126);
        }

        private void textBox1firstnumerator_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox2firstdenominator.Focus();
        }

        private void textBox2firstdenominator_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox3secondnumerator.Focus();
        }

        private void textBox3secondnumerator_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox4seconddenominator.Focus();
        }

        private void textBox1firstnumerator_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void textBox2firstdenominator_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true;
            else if ((sender as TextBox).Text == "" && (e.KeyChar == 48))
                e.Handled = true;
        }

        public void FractionReductionClear()
        {
            comboBox1sign.Visible = false;
            textBox3secondnumerator.Visible = false;
            textBox4seconddenominator.Visible = false;
            label1greatestleastcommondivisormultiple.Visible = false;
            textBox5greatestleastcommondivisormultiple.Visible = false;
            comboBox1sign.SelectedIndex = 0;
            textBox3secondnumerator.Text = "";
            textBox4seconddenominator.Text = "";
            textBox6resultnumerator.Text = "";
            textBox7resultdenominator.Text = "";
            this.Size = new Size(550, 300);
            button1equal.Location = new Point(193, 79);
            button2clear.Location = new Point(464, 213);
            textBox3secondnumerator.Location = new Point(262, 63);
            textBox4seconddenominator.Location = new Point(262, 126);
            textBox6resultnumerator.Location = new Point(289, 45);
            textBox7resultdenominator.Location = new Point(289, 126);
        }

        public void IfResultDenominatorEquals1FRACTION()
        {
            textBox7resultdenominator.Text = "";
            textBox7resultdenominator.Visible = false;
            textBox6resultnumerator.Location = new Point(289, 84);
        }

        public void IfResultDenominatorEquals1ACTIONS()
        {
            textBox7resultdenominator.Text = "";
            textBox7resultdenominator.Visible = false;
            textBox6resultnumerator.Location = new Point(539, 84);
        }
    }
}
