using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Methods__length_and_square_
{
    public partial class Form1lengthandsquare : Form
    {
        public Form1lengthandsquare()
        {
            InitializeComponent();
        }

        private void button1calculate_Click(object sender, EventArgs e)
        {
            double res = 0;

            if (radioButton1linesegment.Checked == true)
            {
                if (textBox1x1.Text == "" || textBox2y1.Text == "" || textBox3x2.Text == "" || textBox4y2.Text == "")
                    MessageBox.Show("Please, fill in the empty fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    res = Convert.ToDouble(Linesegment(tBxf: textBox1x1.Text, tByf: textBox2y1.Text, tBxs: textBox3x2.Text, tBys: textBox4y2.Text));
            }
            else if (radioButton2triangle.Checked == true)
            {
                if (textBox1x1.Text == "" || textBox2y1.Text == "" || textBox3x2.Text == "" || textBox4y2.Text == "" || textBox5x3.Text == "" || textBox6y3.Text == "")
                    MessageBox.Show("Please, fill in the empty fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    res = Triangle(tBxft1: textBox1x1.Text, tByft1: textBox2y1.Text, tBxst2: textBox3x2.Text, tByst2: textBox4y2.Text, tBxst3: textBox5x3.Text, tByst3: textBox6y3.Text, tBxst4: "0", tByst4: "0");
            }
            else if (radioButton3quadrilateral.Checked == true)
            {
                if (textBox1x1.Text == "" || textBox2y1.Text == "" || textBox3x2.Text == "" || textBox4y2.Text == "" || textBox5x3.Text == "" || textBox6y3.Text == "" || textBox7x4.Text == "" || textBox8y4.Text == "")
                    MessageBox.Show("Please, fill in the empty fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    res = Quadrilateral();
            }
            textBox9result.Text = Math.Round(res, 2).ToString();
        }

        private void button2clear_Click(object sender, EventArgs e)
        {
            radioButton1linesegment.Checked = true;
            foreach (Control tBclear in Controls)
            {
                if (tBclear is TextBox)
                    tBclear.Text = "";
            }
        }

        //метод для вычисления длины отрезка с четырьмя параметрами: xf - начальная координата x, yf - начальная координата y, xs - конечная координата x, ys - конечная координата y 
        public double Linesegment(double xf, double yf, double xs, double ys)
        {
            double x, y, linsegm;

            x = Math.Pow(xs - xf, 2);
            y = Math.Pow(ys - yf, 2);
            linsegm = Math.Sqrt(x + y);

            return linsegm;
        }
        //

        //метод для перегрузки, берущий текстовые значения координат из textBox, с четырьмя параметрами: tBxf - начальная координата x, tByf - начальная координата y, ytBxs - конечная координата x, tBys - конечная координата y
        public string Linesegment(string tBxf, string tByf, string tBxs, string tBys)
        {
            string linsegm;

            linsegm = Linesegment(xf: Convert.ToDouble(tBxf), yf: Convert.ToDouble(tByf), xs: Convert.ToDouble(tBxs), ys: Convert.ToDouble(tBys)).ToString();
            
            return linsegm;
        }
        //

        //метод для вычисления площади треугольника с восьмью параметрами: tBxft1 - координата x, tByft1 - координата y, tBxst2 - координата x, tByst2 - координата y, tBxst3 - координата x, tByst3 - координата y, tBxst4 - координата x, tByst4 - координата y
        public double Triangle(string tBxft1, string tByft1, string tBxst2, string tByst2, string tBxst3, string tByst3, string tBxst4, string tByst4)
        {
            double fstsid, sndsid, trdsid, fthsid, semiper, sqtr;

            fstsid = Convert.ToDouble(Linesegment(tBxf: tBxft1, tByf: tByft1, tBxs: tBxst2, tBys: tByst2));
            sndsid = Convert.ToDouble(Linesegment(tBxf: tBxst2, tByf: tByst2, tBxs: tBxst3, tBys: tByst3));
            trdsid = Convert.ToDouble(Linesegment(tBxf: tBxst3, tByf: tByst3, tBxs: tBxft1, tBys: tByft1));

            textBox10firstsidelength.Text = Math.Round(fstsid, 2).ToString();
            textBox11secondsidelength.Text = Math.Round(sndsid, 2).ToString();
            textBox12thirdsidelength.Text = Math.Round(trdsid, 2).ToString();
            if (radioButton3quadrilateral.Checked == true)
            {
                fthsid = Convert.ToDouble(Linesegment(tBxf: tBxst4, tByf: tByst4, tBxs: tBxft1, tBys: tByft1));
                textBox13fourthsidelength.Text = Math.Round(fthsid, 2).ToString();
            }
            semiper = (fstsid + sndsid + trdsid) / 2;
            sqtr = Math.Sqrt(semiper * (semiper - fstsid) * (semiper - sndsid) * (semiper - trdsid));
          
            return sqtr;
        }

        //метод для вычисления площади четырехугольника
        public double Quadrilateral()
        {
            double sqquad;

            sqquad = Triangle(tBxft1: textBox1x1.Text, tByft1: textBox2y1.Text, tBxst2: textBox3x2.Text, tByst2: textBox4y2.Text, tBxst3: textBox7x4.Text, tByst3: textBox8y4.Text, tBxst4: "0", tByst4: "0") + Triangle(tBxft1: textBox3x2.Text, tByft1: textBox4y2.Text, tBxst2: textBox5x3.Text, tByst2: textBox6y3.Text, tBxst3: textBox7x4.Text, tByst3: textBox8y4.Text, tBxst4: "0", tByst4: "0");
            
            return sqquad;
        }
        //

        private void radioButton1linesegment_CheckedChanged(object sender, EventArgs e)
        {
            label5lengthsquare.Text = "Length";
        }

        private void radioButton2triangle_CheckedChanged(object sender, EventArgs e)
        {
            label3x3y3.Visible = radioButton2triangle.Checked;
            textBox5x3.Visible = radioButton2triangle.Checked;
            textBox6y3.Visible = radioButton2triangle.Checked;
            label5lengthsquare.Text = "Square";
            label6firstsidelength.Visible = radioButton2triangle.Checked;
            label7secondsidelength.Visible = radioButton2triangle.Checked;
            label8thirdsidelength.Visible = radioButton2triangle.Checked;
            textBox10firstsidelength.Visible = radioButton2triangle.Checked;
            textBox11secondsidelength.Visible = radioButton2triangle.Checked;
            textBox12thirdsidelength.Visible = radioButton2triangle.Checked;
        }

        private void radioButton3quadrilateral_CheckedChanged(object sender, EventArgs e)
        {
            label3x3y3.Visible = radioButton3quadrilateral.Checked;
            label4x4y4.Visible = radioButton3quadrilateral.Checked;
            textBox5x3.Visible = radioButton3quadrilateral.Checked;
            textBox6y3.Visible = radioButton3quadrilateral.Checked;
            textBox7x4.Visible = radioButton3quadrilateral.Checked;
            textBox8y4.Visible = radioButton3quadrilateral.Checked;
            label5lengthsquare.Text = "Square";
            label6firstsidelength.Visible = radioButton3quadrilateral.Checked;
            label7secondsidelength.Visible = radioButton3quadrilateral.Checked;
            label8thirdsidelength.Visible = radioButton3quadrilateral.Checked;
            label9fourthsidelength.Visible = radioButton3quadrilateral.Checked;
            textBox10firstsidelength.Visible = radioButton3quadrilateral.Checked;
            textBox11secondsidelength.Visible = radioButton3quadrilateral.Checked;
            textBox12thirdsidelength.Visible = radioButton3quadrilateral.Checked;
            textBox13fourthsidelength.Visible = radioButton3quadrilateral.Checked;
        }

        private void textBox1x1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
                textBox2y1.Focus();
        }

        private void textBox2y1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
                textBox3x2.Focus();
        }

        private void textBox3x2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
                textBox4y2.Focus();
        }

        private void textBox4y2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
                textBox5x3.Focus();
        }

        private void textBox5x3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
                textBox6y3.Focus();
        }
        private void textBox6y3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
                textBox7x4.Focus();
        }

        private void textBox7x4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
                textBox8y4.Focus();
        }

        private void textBox1x1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != '.' && e.KeyChar != ',') || ((e.KeyChar == '.' || e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1 || (sender as TextBox).Text.IndexOf(',') > -1)))
                e.Handled = true;
            else if ((sender as TextBox).Text == "" && (e.KeyChar == '.' || e.KeyChar == ','))
                e.Handled = true;
            else
                e.Handled = false;
        }
    }
}
