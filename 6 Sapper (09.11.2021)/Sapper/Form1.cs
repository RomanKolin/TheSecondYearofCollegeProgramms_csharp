using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;




namespace Sapper
{
    public partial class Form1Minefield : Form
    {
        public Form1Minefield()
        {
            InitializeComponent();
            Size = new Size (1000, 600);
            pictureBox1MineBang.BackColor = Color.Transparent;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1BombBang_Click(object sender, EventArgs e)
        {
            pictureBox1MineBang.BackgroundImage = Properties.Resources.Bang;
            pictureBox1MineBang.BackColor = Color.Transparent;
            pictureBox1MineBang.BackgroundImageLayout = ImageLayout.Zoom;
            textBox4Warning.Text = "BANG!";

            System.IO.Stream str = Properties.Resources.BangBang;
            SoundPlayer bang;
            bang = new SoundPlayer(str);
            bang.Play();

            timer1Bang.Enabled = true;
            timer1Bang.Start();


        }

        private void label1Mine_Click(object sender, EventArgs e)
        {

        }

        private void panel1Grass_MouseMove(object sender, MouseEventArgs e)
        {
            textBox1Mine.Text = e.Y.ToString();
            textBox2Mine.Text = e.X.ToString();

            double y, x, dist;
            y = pictureBox1MineBang.Top + (pictureBox1MineBang.Height / 2);
            x = pictureBox1MineBang.Left + (pictureBox1MineBang.Width / 2);
            dist = (Math.Sqrt(Math.Pow(e.Y - y, 2) + Math.Pow(e.X - x, 2)));
            textBox3Mine.Text = Math.Round(dist).ToString();

            if (dist > 50)
            { pictureBox1MineBang.Size = new Size(50, 50); }
            if (dist <= 50)
            { textBox4Warning.Text = "The Mine Is So Close"; }
            if (dist <= 35)
            { textBox4Warning.Text = "Dangerous"; }
            if (dist <= 25 && numericUpDown1Mine.Value > 0)
            {
                pictureBox1MineBang.Visible = true;
                timer2Bang.Enabled = true;
                timer2Bang.Start();   
            }
            if (dist > 50)
            { textBox4Warning.Text = ""; }

        }

        private void button1Start_Click(object sender, EventArgs e)
        {
            if (numericUpDown1Mine.Value > 0)
            {
                textBox1Mine.ForeColor = Color.Black;
                textBox1Mine.Text = "";
                textBox2Mine.ForeColor = Color.Black;
                textBox2Mine.Text = "";
                textBox3Mine.ForeColor = Color.Black;
                textBox3Mine.Text = "";
                textBox4Warning.ForeColor = Color.Red;
                textBox4Warning.Text = "";

                int ghei, gwid, mhei, mwid;
                ghei = panel1Grass.Size.Height;
                gwid = panel1Grass.Size.Width;
                mhei = pictureBox1MineBang.Height;
                mwid = pictureBox1MineBang.Width;

                Random loc = new Random();
                pictureBox1MineBang.Location = new Point(loc.Next(ghei - mhei), loc.Next(gwid - mwid));
                while (pictureBox1MineBang.Bottom > panel1Grass.Bottom)
                { pictureBox1MineBang.Location = new Point(loc.Next(ghei - mhei), loc.Next(gwid - mwid)); }
                
            }
        
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1Bang_Tick(object sender, EventArgs e)
        {
            timer1Bang.Enabled = false;
            
            numericUpDown1Mine.Value = numericUpDown1Mine.Value - 1;
            if (numericUpDown1Mine.Value == 0)
            {
                label6Win.Visible = true;
                label6Win.BackColor = Color.Transparent;
                textBox1Mine.Text = "";
                textBox2Mine.Text = "";
                textBox3Mine.Text = "";
            }
            else
            {
                pictureBox1MineBang.BackgroundImage = Properties.Resources.Mine;
                pictureBox1MineBang.Size = new Size(50, 50);
                pictureBox1MineBang.Visible = false;
                textBox4Warning.Text = "";


                int ghei, gwid, mhei, mwid;
                ghei = panel1Grass.Size.Height;
                gwid = panel1Grass.Size.Width;
                mhei = pictureBox1MineBang.Height;
                mwid = pictureBox1MineBang.Width;

                Random loc = new Random();
                pictureBox1MineBang.Location = new Point(loc.Next(ghei - mhei), loc.Next(gwid - mwid));
                while (pictureBox1MineBang.Bottom > panel1Grass.Bottom)
                { pictureBox1MineBang.Location = new Point(loc.Next(ghei - mhei), loc.Next(gwid - mwid)); }
            }
            
        }

        private void timer2Bang_Tick(object sender, EventArgs e)
        {
            pictureBox1MineBang.Size = new Size(40, 40);
            textBox3Mine.Text = "";
            textBox4Warning.Text = "";
        }
    }
}
