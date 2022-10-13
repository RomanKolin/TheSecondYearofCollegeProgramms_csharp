using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Events_with_a_Form
{
    public partial class Form1EventswithaForm : Form
    {
        public Form1EventswithaForm()
        {
            InitializeComponent();
            this.MouseWheel += Form1EventswithaForm_MouseWheel;
            pictureBox1ILoveCoding.MouseWheel += pictureBox1ILoveCoding_MouseWheel;
            this.MouseDoubleClick += Form1EventswithaForm_MouseDoubleClick;

            pictureBox1ILoveCoding.Top = this.Height / 2 - pictureBox1ILoveCoding.Height / 2;
            pictureBox1ILoveCoding.Left = this.Width / 2 - pictureBox1ILoveCoding.Width / 2;
        }
        private void Form1EventswithaForm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (MessageBox.Show("Do you wanna to close app?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }

        private void Form1EventswithaForm_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                this.Opacity += 0.01;
            }
            if (e.Delta < 0)
            {
                if (this.Opacity > 0.01)
                {
                    this.Opacity -= 0.01;
                }
            }
        }
        private void pictureBox1ILoveCoding_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                if (pictureBox1ILoveCoding.Location.Y > 0)
                {
                    pictureBox1ILoveCoding.Location = new Point(pictureBox1ILoveCoding.Location.X, pictureBox1ILoveCoding.Location.Y - 1);
                    this.Opacity -= 0.01;
                }
                
            }
            if (e.Delta < 0)
            {
                if (pictureBox1ILoveCoding.Bottom < this.Height)
                {
                    pictureBox1ILoveCoding.Location = new Point(pictureBox1ILoveCoding.Location.X, pictureBox1ILoveCoding.Location.Y + 1);
                    this.Opacity += 0.01;
                }
                else
                {
                    this.Opacity += 0.01;
                }
            }

        }
        private void Form1EventswithaForm_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("Enter - Help" + Environment.NewLine +
                            "Right-click - Time" + Environment.NewLine +
                            "Left-click - Date" + Environment.NewLine +
                            "Middle-click - Color change of app" + Environment.NewLine +
                            "Mouse wheel - Changing the transparency of the app, moving the picture (up-down)" + Environment.NewLine +
                            "Arrows - Moving the app" + Environment.NewLine +
                            "Ctrl + Arrows, Alt + Arrows - Changing the size of the app" + Environment.NewLine +
                            "Double right-click - Exit" + Environment.NewLine, 
                            "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1EventswithaForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Enter - Help" + Environment.NewLine +
                            "Right-click - Time" + Environment.NewLine +
                            "Left-click - Date" + Environment.NewLine +
                            "Middle-click - Color change of app" + Environment.NewLine +
                            "Mouse wheel - Changing the transparency of the app, moving the picture (up-down)" + Environment.NewLine +
                            "Arrows - Moving the app" + Environment.NewLine +
                            "Ctrl + Arrows, Alt + Arrows - Changing the size of the app" + Environment.NewLine +
                            "Double right-click - Exit" + Environment.NewLine,
                            "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (!e.Control && !e.Alt && !e.Shift)
                switch (e.KeyCode)
                {
                    case Keys.Up:
                        this.Top = this.Top - 1;
                        break;
                    case Keys.Right:
                        this.Left = this.Left + 1;
                        break;
                    case Keys.Down:
                        this.Top = this.Top + 1;
                        break;
                    case Keys.Left:
                        this.Left = this.Left - 1;
                        break;
                }
            if (e.Control && !e.Alt && !e.Shift)
                switch (e.KeyCode)
                {
                    case Keys.Up:
                        this.Top = this.Top - 1;
                        this.Height = this.Height + 1;
                        break;
                    case Keys.Right:
                        this.Width = this.Width + 1;
                        break;
                    case Keys.Down:
                        this.Height = this.Height + 1;
                        break;
                    case Keys.Left:
                        this.Left = this.Left - 1;
                        this.Width = this.Width + 1;
                        break;
                }
            if (!e.Control && e.Alt && !e.Shift)
                switch (e.KeyCode)
                {
                    case Keys.Up:
                        this.Height = this.Height - 1;
                        break;
                    case Keys.Right:
                        this.Left = this.Left + 1;
                        this.Width = this.Width - 1;
                        break;
                    case Keys.Down:
                        this.Top = this.Top + 1;
                        this.Height = this.Height - 1;
                        break;
                    case Keys.Left:
                        this.Width = this.Width - 1;
                        break;
                }
        }

        private void Form1EventswithaForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                string t;

                t = DateTime.Now.ToString("HH:mm:ss tt");
                label2Time.Text = t;
            }
            if (e.Button == MouseButtons.Left)
            {
                string d;

                d = DateTime.Now.ToString("MMM dd, yyyy");
                label1Date.Text = d;
            }
            if (e.Button == MouseButtons.Middle)
            {
                int r, g, b;

                Random c = new Random();
                this.BackColor = Color.FromArgb(c.Next(256), c.Next(256), c.Next(256));
                Color rgb = Color.FromArgb(c.Next(256), c.Next(256), c.Next(256));
                r = rgb.R;
                g = rgb.G;
                b = rgb.B;
                textBox3Properties.Text = "RGB: " + r.ToString() + ", " + g.ToString() + ", " + b.ToString();
            }
        }
    }
}
