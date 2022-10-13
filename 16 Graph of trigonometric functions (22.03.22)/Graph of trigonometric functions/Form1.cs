using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graph_of_trigonometric_functions
{
    public partial class Form1graphoftrigonometricfunctions : Form
    {
        public Form1graphoftrigonometricfunctions()
        {
            InitializeComponent();

            this.Size = new Size(1000, 400);
        }

        private void button1buildagraph_Click(object sender, EventArgs e)
        {
            double lb, rb, st, x, y1, y2, y3, y4;

            try
            {
                textBox1values.Clear();

                if (textBox2leftborder.Text.Contains(".") || textBox3rightborder.Text.Contains(".") || textBox4step.Text.Contains("."))
                {
                    if (textBox2leftborder.Text.Contains("."))
                        textBox2leftborder.Text = textBox2leftborder.Text.Replace('.', ',');
                    if (textBox3rightborder.Text.Contains("."))
                        textBox3rightborder.Text = textBox3rightborder.Text.Replace('.', ',');
                    if (textBox4step.Text.Contains("."))
                        textBox4step.Text = textBox4step.Text.Replace('.', ',');
                    lb = Convert.ToDouble(textBox2leftborder.Text);
                    rb = Convert.ToDouble(textBox3rightborder.Text);
                    st = Convert.ToDouble(textBox4step.Text);
                    if (textBox2leftborder.Text.Contains(","))
                        textBox2leftborder.Text = textBox2leftborder.Text.Replace(',', '.');
                    if (textBox3rightborder.Text.Contains(","))
                        textBox3rightborder.Text = textBox3rightborder.Text.Replace(',', '.');
                    if (textBox4step.Text.Contains(","))
                        textBox4step.Text = textBox4step.Text.Replace(',', '.');
                }
                else
                {
                    lb = Convert.ToDouble(textBox2leftborder.Text);
                    rb = Convert.ToDouble(textBox3rightborder.Text);
                    st = Convert.ToDouble(textBox4step.Text);
                }

                if (lb > rb)
                    MessageBox.Show("The left border should be less than the right border", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (lb + st > rb)
                    MessageBox.Show("The left border with a step should be less than the right border", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (st <= 0) 
                    MessageBox.Show("The step should be more than zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (checkBox1sinx.Checked == false && checkBox2cosx.Checked == false && checkBox3tanx.Checked == false && checkBox4cotx.Checked == false)
                    MessageBox.Show("Please, mark the necessary function", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    chart1graphoftrigonometricfunctions.Series[0].IsVisibleInLegend = false;
                    chart1graphoftrigonometricfunctions.Series[1].IsVisibleInLegend = false;
                    chart1graphoftrigonometricfunctions.Series[2].IsVisibleInLegend = false;
                    chart1graphoftrigonometricfunctions.Series[3].IsVisibleInLegend = false;
                    chart1graphoftrigonometricfunctions.Series[0].Points.Clear();
                    chart1graphoftrigonometricfunctions.Series[1].Points.Clear();
                    chart1graphoftrigonometricfunctions.Series[2].Points.Clear();
                    chart1graphoftrigonometricfunctions.Series[3].Points.Clear();

                    x = lb;
                    while (x <= rb)
                    {
                        textBox1values.Text += " " + x.ToString() + "        ";
                        if (checkBox1sinx.Checked)
                        {
                            chart1graphoftrigonometricfunctions.Series[0].IsVisibleInLegend = true;
                            y1 = Math.Sin(x);
                            chart1graphoftrigonometricfunctions.Series[0].Points.AddXY(x, y1);
                            textBox1values.Text += Math.Round(y1, 2).ToString();
                        }
                        if (checkBox1sinx.Checked)
                            textBox1values.Text += "     ";
                        else
                            textBox1values.Text += "            ";

                        if (checkBox2cosx.Checked)
                        {
                            chart1graphoftrigonometricfunctions.Series[1].IsVisibleInLegend = true;
                            y2 = Math.Cos(x);
                            chart1graphoftrigonometricfunctions.Series[1].Points.AddXY(x, y2);
                            textBox1values.Text += Math.Round(y2, 2).ToString();
                        }
                        if (checkBox2cosx.Checked)
                            textBox1values.Text += "     ";
                        else
                            textBox1values.Text += "            ";

                        if (checkBox3tanx.Checked)
                        {
                            chart1graphoftrigonometricfunctions.Series[2].IsVisibleInLegend = true;
                            y3 = Math.Tan(x);
                            chart1graphoftrigonometricfunctions.Series[2].Points.AddXY(x, y3);
                            textBox1values.Text += Math.Round(y3, 2).ToString();
                        }
                        if (checkBox3tanx.Checked)
                            textBox1values.Text += "     ";
                        else
                            textBox1values.Text += "\t            ";

                        if (checkBox4cotx.Checked)
                        {
                            chart1graphoftrigonometricfunctions.Series[3].IsVisibleInLegend = true;
                            y4 = 1 / Math.Tan(x);
                            chart1graphoftrigonometricfunctions.Series[3].Points.AddXY(x, y4);
                            textBox1values.Text += Math.Round(y4, 2).ToString();
                        }
                        textBox1values.Text += Environment.NewLine;

                        x += st;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Print the correct values (non-empty, numbers)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2clear_Click(object sender, EventArgs e)
        {
            textBox1values.Clear();
            textBox2leftborder.Clear();
            textBox3rightborder.Clear();
            textBox4step.Clear();
            checkBox1sinx.Checked = false;
            checkBox2cosx.Checked = false;
            checkBox3tanx.Checked = false;
            checkBox4cotx.Checked = false;
            chart1graphoftrigonometricfunctions.Series[0].IsVisibleInLegend = false;
            chart1graphoftrigonometricfunctions.Series[1].IsVisibleInLegend = false;
            chart1graphoftrigonometricfunctions.Series[2].IsVisibleInLegend = false;
            chart1graphoftrigonometricfunctions.Series[3].IsVisibleInLegend = false;
            chart1graphoftrigonometricfunctions.Series[0].Points.Clear();
            chart1graphoftrigonometricfunctions.Series[1].Points.Clear();
            chart1graphoftrigonometricfunctions.Series[2].Points.Clear();
            chart1graphoftrigonometricfunctions.Series[3].Points.Clear();
        }

        private void textBox2leftborder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                e.SuppressKeyPress = true;
                textBox3rightborder.Focus();
            }
               
        }

        private void textBox3rightborder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                e.SuppressKeyPress = true;
                textBox4step.Focus();
            }
        }
    }
}
