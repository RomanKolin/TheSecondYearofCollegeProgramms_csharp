using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taxi_Robocop
{
    public partial class Form1 : Form
    {
        Taxi_Robocop robot; //Объект класса Taxi_Robobcop
        int w, h; //Размер игровой области
        int wr, hr; //Размер робота

        /// <summary>
        /// Запуск
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            w = pictureBox1TaxiRobocop.Width;
            h = pictureBox1TaxiRobocop.Height;
            wr = pictureBox1TaxiRobocop.Width;
            hr = pictureBox1TaxiRobocop.Height;
            robot = new Taxi_Robocop(); //Создание объекта
            robot.PercentEnergy = 0;
            textBox1PercentEnergy.Text = Convert.ToString(robot.PercentEnergy);
            robot.X = 0;
            robot.Y = 211;
            pictureBox1TaxiRobocop.Left = robot.X;
            pictureBox1TaxiRobocop.Top = robot.Y;
        }

        /// <summary>
        /// Движение робота
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button1Right_Click(object sender, EventArgs e)
        {

            if (robot.X < 368)
            {
                robot.Walking("Right");
                textBox1PercentEnergy.Text = Convert.ToString(robot.PercentEnergy);
                pictureBox1TaxiRobocop.Left = robot.X;
                pictureBox1TaxiRobocop.Top = robot.Y;
            }

        }

        private void button2Left_Click(object sender, EventArgs e)
        {
            if (robot.X > 0)
            {
                robot.Walking("Left");
                textBox1PercentEnergy.Text = Convert.ToString(robot.PercentEnergy);
                pictureBox1TaxiRobocop.Left = robot.X;
                pictureBox1TaxiRobocop.Top = robot.Y;
            }
        }

        private void button3Up_Click(object sender, EventArgs e)
        {
            if (robot.Y > 0)
            {
                robot.Walking("Up");
                textBox1PercentEnergy.Text = Convert.ToString(robot.PercentEnergy);
                pictureBox1TaxiRobocop.Left = robot.X;
                pictureBox1TaxiRobocop.Top = robot.Y;
            }
        }

        private void button4Down_Click(object sender, EventArgs e)
        {
            if (robot.Y < 211)
            {
                robot.Walking("Down");
                textBox1PercentEnergy.Text = Convert.ToString(robot.PercentEnergy);
                pictureBox1TaxiRobocop.Left = robot.X;
                pictureBox1TaxiRobocop.Top = robot.Y;
            }
        }

        /// <summary>
        /// Процент зарядки робота
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5ChargeUp_Click(object sender, EventArgs e)
        {
            robot.ChargeUp();
            textBox1PercentEnergy.Text = Convert.ToString(robot.PercentEnergy);
        }

        private void button6ChargeDown_Click(object sender, EventArgs e)
        {
            robot.ChargeDown();
            textBox1PercentEnergy.Text = Convert.ToString(robot.PercentEnergy);
        }

        private void pictureBox1TaxiRobocop_Click(object sender, EventArgs e)
        {

        }

        private void button_deogonal_Click(object sender, EventArgs e)
        {
            if (robot.X < 368 && robot.Y > 0)
            {
                robot.Walking("Up-Right");
                textBox1PercentEnergy.Text = Convert.ToString(robot.PercentEnergy);
                pictureBox1TaxiRobocop.Left = robot.X;
                pictureBox1TaxiRobocop.Top = robot.Y;
            }
        }

        private void button6UpLeft_Click(object sender, EventArgs e)
        {
            if (robot.X > 0 && robot.Y > 0)
            {
                robot.Walking("Up-Left");
                textBox1PercentEnergy.Text = Convert.ToString(robot.PercentEnergy);
                pictureBox1TaxiRobocop.Left = robot.X;
                pictureBox1TaxiRobocop.Top = robot.Y;
            }
        }

        private void button8DownRight_Click(object sender, EventArgs e)
        {
            if (robot.X < 368 && robot.Y < 211)
            {
                robot.Walking("Down-Right");
                textBox1PercentEnergy.Text = Convert.ToString(robot.PercentEnergy);
                pictureBox1TaxiRobocop.Left = robot.X;
                pictureBox1TaxiRobocop.Top = robot.Y;
            }
        }

        private void button7DownLeft_Click(object sender, EventArgs e)
        {
            if (robot.X > 0 && robot.Y < 211)
            {
                robot.Walking("Down-Left");
                textBox1PercentEnergy.Text = Convert.ToString(robot.PercentEnergy);
                pictureBox1TaxiRobocop.Left = robot.X;
                pictureBox1TaxiRobocop.Top = robot.Y;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
