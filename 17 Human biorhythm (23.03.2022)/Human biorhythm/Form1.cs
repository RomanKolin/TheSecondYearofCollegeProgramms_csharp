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
using System.Windows.Forms.DataVisualization.Charting;

namespace Human_biorhythm
{
    public partial class Form1humanbiorhythm : Form
    {
        public Form1humanbiorhythm()
        {
            InitializeComponent();

            this.Size = new Size(1000, 400); 
        }

        private void button1buildabiorhythm_Click(object sender, EventArgs e)
        {
            double xper, phys, emot, intell;

            if (dateTimePicker1dateofbirth.Value >= DateTime.Today)
                MessageBox.Show("The \"Date of birth\" should be less than the current date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (checkBox1physical.Checked == false && checkBox2emotional.Checked == false && checkBox3intellectual.Checked == false)
                MessageBox.Show("Please, mark the necessary biorhythm", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                xper = 0;

                DateTime xcurr = DateTime.Today;
                DateTime xdob = dateTimePicker1dateofbirth.Value;
                TimeSpan xday = xcurr - xdob;

                if (radioButton1week.Checked)
                    xper = 7;
                if (radioButton2month.Checked)
                    xper = 31;
                if (radioButton3year.Checked)
                    xper = 365;
                if (radioButton4period.Checked)
                {
                    if (dateTimePicker2fromdate.Value >= dateTimePicker3todate.Value)
                        MessageBox.Show("The \"from\" date should be less than \"to\" date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        DateTime fromd = dateTimePicker2fromdate.Value;
                        DateTime tod = dateTimePicker3todate.Value;
                        TimeSpan xper1 = tod - fromd;
                        xper = xper1.Days;
                    }
                }

                chart1humanbiorhythm.Series[0].IsVisibleInLegend = false;
                chart1humanbiorhythm.Series[1].IsVisibleInLegend = false;
                chart1humanbiorhythm.Series[2].IsVisibleInLegend = false;
                chart1humanbiorhythm.Series[0].Points.Clear();
                chart1humanbiorhythm.Series[1].Points.Clear();
                chart1humanbiorhythm.Series[2].Points.Clear();
                for (int ixper = 1; ixper <= xper; ixper++)
                {
                    if (checkBox1physical.Checked)
                    {
                        if (checkBox4legends.Checked)
                            chart1humanbiorhythm.Series[0].IsVisibleInLegend = true;
                        if (checkBox53d.Checked)
                            chart1humanbiorhythm.ChartAreas[0].Area3DStyle.Enable3D = true;
                        phys = Math.Sin((2 * Math.PI * (xday.Days + ixper)) / 23);
                        chart1humanbiorhythm.Series[0].Points.AddXY(ixper, phys);
                    }
                    if (checkBox2emotional.Checked)
                    {
                        if (checkBox4legends.Checked)
                            chart1humanbiorhythm.Series[1].IsVisibleInLegend = true;
                        if (checkBox53d.Checked)
                            chart1humanbiorhythm.ChartAreas[0].Area3DStyle.Enable3D = true;
                        emot = Math.Sin((2 * Math.PI * (xday.Days + ixper)) / 28);
                        chart1humanbiorhythm.Series[1].Points.AddXY(ixper, emot);
                    }
                    if (checkBox3intellectual.Checked)
                    {
                        if (checkBox4legends.Checked)
                            chart1humanbiorhythm.Series[2].IsVisibleInLegend = true;
                        if (checkBox53d.Checked)
                            chart1humanbiorhythm.ChartAreas[0].Area3DStyle.Enable3D = true;
                        intell = Math.Sin((2 * Math.PI * (xday.Days + ixper)) / 33);
                        chart1humanbiorhythm.Series[2].Points.AddXY(ixper, intell);
                    }
                }

                button2photo.Visible = true;
            }
        }

        private void button3clear_Click(object sender, EventArgs e)
        {
            chart1humanbiorhythm.ChartAreas[0].Area3DStyle.Enable3D = false;
            chart1humanbiorhythm.Series[0].IsVisibleInLegend = false;
            chart1humanbiorhythm.Series[1].IsVisibleInLegend = false;
            chart1humanbiorhythm.Series[2].IsVisibleInLegend = false;
            chart1humanbiorhythm.Series[0].Points.Clear();
            chart1humanbiorhythm.Series[1].Points.Clear();
            chart1humanbiorhythm.Series[2].Points.Clear();
            radioButton1week.Checked = true;
            radioButton2month.Checked = false;
            radioButton3year.Checked = false;
            checkBox1physical.Checked = false;
            checkBox2emotional.Checked = false;
            checkBox3intellectual.Checked = false;
            checkBox4legends.Checked = false;
            checkBox53d.Checked = false;
            dateTimePicker1dateofbirth.Value = DateTime.Today;
            dateTimePicker2fromdate.Value = DateTime.Today;
            dateTimePicker3todate.Value = DateTime.Today;
            button2photo.Visible = false;
        }

        private void radioButton4period_CheckedChanged(object sender, EventArgs e)
        {
            label2from.Visible = true;
            dateTimePicker2fromdate.Visible = true;
            label3to.Visible = true;
            dateTimePicker3todate.Visible = true;
        }

        private void radioButton1week_CheckedChanged(object sender, EventArgs e)
        {
            label2from.Visible = false;
            dateTimePicker2fromdate.Visible = false;
            label3to.Visible = false;
            dateTimePicker3todate.Visible = false;
        }

        private void radioButton2month_CheckedChanged(object sender, EventArgs e)
        {
            label2from.Visible = false;
            dateTimePicker2fromdate.Visible = false;
            label3to.Visible = false;
            dateTimePicker3todate.Visible = false;
        }

        private void radioButton3year_CheckedChanged(object sender, EventArgs e)
        {
            label2from.Visible = false;
            dateTimePicker2fromdate.Visible = false;
            label3to.Visible = false;
            dateTimePicker3todate.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1humanbiorhythm.SaveImage("Human biorhythm.png", ChartImageFormat.Png);
            System.Diagnostics.Process.Start("Human biorhythm.png");
        }
    }
}
