using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Context_Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1Back.BackColor = Color.Green;
        }

 private void backColorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1Back.BackColor = Color.Red;
        }


        private void panel1BackColor_Paint(object sender, PaintEventArgs e)
        {
            panel1Back.ContextMenuStrip = contextMenuStrip1;
        }

        private void formToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void blueToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            panel1Back.BackColor = Color.Blue;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Opacity = 0.75;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Opacity = 0.5;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Opacity = 0.25;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Opacity = 1.0;
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Opacity = 0.01;
        }

        private void button1Default_Click(object sender, EventArgs e)
        {
            panel1Back.BackgroundImage = null;
            panel1Back.BackColor = Color.Maroon;
            this.Size = new Size(800, 400);
            this.Left = wScreen / 2 - this.Width / 2;
            this.Top = hScreen / 2 - this.Height / 2;
            this.WindowState = FormWindowState.Normal;
            textBox1Size.Text = "800x400";
            Opacity = 1.0;
            Cursor = Cursors.Default;
        }

        private void rGBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1Back.BackgroundImage = Properties.Resources.RGB;
        }

        private void iLoveCodingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1Back.BackgroundImage = Properties.Resources.ILoveCoding;
        }

        private void crossToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Cross;
        }

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void x800ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1000, 600);
            textBox1Size.Text = "1000x600";
        }

        private void default800x400ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Size = new Size(800, 400);
            textBox1Size.Text = "800x400";
        }

        private void x1000ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Size = new Size(800, 600);
            textBox1Size.Text = "800x600";
        }

        private void x800ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Size = new Size(800, 800);
            textBox1Size.Text = "800x800";
        }

        private void centrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Left = wScreen / 2 - this.Width / 2;
            this.Top = hScreen / 2 - this.Height / 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
        int wScreen = Screen.PrimaryScreen.WorkingArea.Width;
        int hScreen = Screen.PrimaryScreen.WorkingArea.Height;

        private void rightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Left = wScreen - this.Width;
            this.Top = hScreen / 2 - this.Height / 2;
        }

        private void downToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Left = wScreen / 2 - this.Width / 2;
            this.Top = hScreen / 2 + this.Height / 2;
        }

        private void upToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Left = wScreen / 2 - this.Width / 2;
            this.Top = 0;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button5Increase_Click(object sender, EventArgs e)
        {
            this.Height = this.Height + 100;
            this.Width = this.Width + 100;
            textBox1Size.Text = Convert.ToString(this.Width) + "x" + Convert.ToString(this.Height);
        }

        private void button6Decrease_Click(object sender, EventArgs e)
        {
            if (panel1Back.Size.Width > 784 && panel1Back.Size.Height > 361)
            {
                this.Height = this.Height - 100;
                this.Width = this.Width - 100;
                textBox1Size.Text = Convert.ToString(this.Width) + "x" + Convert.ToString(this.Height);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1Size_TextChanged(object sender, EventArgs e)
        {

        }

        private void maroonDefaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1Back.BackColor = Color.Maroon;
        }

        private void leftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Left = 0;
            this.Top = hScreen / 2 - this.Height / 2;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void groupBox1Size_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
