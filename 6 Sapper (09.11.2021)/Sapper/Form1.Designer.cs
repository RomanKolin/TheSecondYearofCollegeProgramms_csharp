
namespace Sapper
{
    partial class Form1Minefield
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel2Menu = new System.Windows.Forms.Panel();
            this.textBox4Warning = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button1Start = new System.Windows.Forms.Button();
            this.textBox3Mine = new System.Windows.Forms.TextBox();
            this.label5Mine = new System.Windows.Forms.Label();
            this.textBox2Mine = new System.Windows.Forms.TextBox();
            this.textBox1Mine = new System.Windows.Forms.TextBox();
            this.label4Mine = new System.Windows.Forms.Label();
            this.label3Mine = new System.Windows.Forms.Label();
            this.label2Mine = new System.Windows.Forms.Label();
            this.label1Mine = new System.Windows.Forms.Label();
            this.numericUpDown1Mine = new System.Windows.Forms.NumericUpDown();
            this.timer1Bang = new System.Windows.Forms.Timer(this.components);
            this.panel1Grass = new System.Windows.Forms.Panel();
            this.label6Win = new System.Windows.Forms.Label();
            this.pictureBox1MineBang = new System.Windows.Forms.PictureBox();
            this.timer2Bang = new System.Windows.Forms.Timer(this.components);
            this.panel2Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1Mine)).BeginInit();
            this.panel1Grass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1MineBang)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2Menu
            // 
            this.panel2Menu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2Menu.BackColor = System.Drawing.Color.Maroon;
            this.panel2Menu.Controls.Add(this.textBox4Warning);
            this.panel2Menu.Controls.Add(this.button1);
            this.panel2Menu.Controls.Add(this.button1Start);
            this.panel2Menu.Controls.Add(this.textBox3Mine);
            this.panel2Menu.Controls.Add(this.label5Mine);
            this.panel2Menu.Controls.Add(this.textBox2Mine);
            this.panel2Menu.Controls.Add(this.textBox1Mine);
            this.panel2Menu.Controls.Add(this.label4Mine);
            this.panel2Menu.Controls.Add(this.label3Mine);
            this.panel2Menu.Controls.Add(this.label2Mine);
            this.panel2Menu.Controls.Add(this.label1Mine);
            this.panel2Menu.Controls.Add(this.numericUpDown1Mine);
            this.panel2Menu.Location = new System.Drawing.Point(0, 0);
            this.panel2Menu.Name = "panel2Menu";
            this.panel2Menu.Size = new System.Drawing.Size(200, 361);
            this.panel2Menu.TabIndex = 1;
            // 
            // textBox4Warning
            // 
            this.textBox4Warning.BackColor = System.Drawing.Color.Maroon;
            this.textBox4Warning.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4Warning.ForeColor = System.Drawing.Color.Maroon;
            this.textBox4Warning.Location = new System.Drawing.Point(0, 31);
            this.textBox4Warning.Multiline = true;
            this.textBox4Warning.Name = "textBox4Warning";
            this.textBox4Warning.Size = new System.Drawing.Size(200, 25);
            this.textBox4Warning.TabIndex = 4;
            this.textBox4Warning.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 11;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1Start
            // 
            this.button1Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Start.ForeColor = System.Drawing.Color.Black;
            this.button1Start.Location = new System.Drawing.Point(112, 314);
            this.button1Start.Name = "button1Start";
            this.button1Start.Size = new System.Drawing.Size(75, 35);
            this.button1Start.TabIndex = 10;
            this.button1Start.Text = "Start";
            this.button1Start.UseVisualStyleBackColor = true;
            this.button1Start.Click += new System.EventHandler(this.button1Start_Click);
            // 
            // textBox3Mine
            // 
            this.textBox3Mine.BackColor = System.Drawing.Color.Maroon;
            this.textBox3Mine.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3Mine.ForeColor = System.Drawing.Color.Maroon;
            this.textBox3Mine.Location = new System.Drawing.Point(0, 262);
            this.textBox3Mine.Multiline = true;
            this.textBox3Mine.Name = "textBox3Mine";
            this.textBox3Mine.ReadOnly = true;
            this.textBox3Mine.Size = new System.Drawing.Size(75, 25);
            this.textBox3Mine.TabIndex = 9;
            this.textBox3Mine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5Mine
            // 
            this.label5Mine.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5Mine.ForeColor = System.Drawing.Color.Black;
            this.label5Mine.Location = new System.Drawing.Point(0, 239);
            this.label5Mine.Name = "label5Mine";
            this.label5Mine.Size = new System.Drawing.Size(180, 20);
            this.label5Mine.TabIndex = 8;
            this.label5Mine.Text = "Distance to the Mine";
            this.label5Mine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox2Mine
            // 
            this.textBox2Mine.BackColor = System.Drawing.Color.Maroon;
            this.textBox2Mine.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2Mine.ForeColor = System.Drawing.Color.Maroon;
            this.textBox2Mine.Location = new System.Drawing.Point(90, 196);
            this.textBox2Mine.Multiline = true;
            this.textBox2Mine.Name = "textBox2Mine";
            this.textBox2Mine.ReadOnly = true;
            this.textBox2Mine.Size = new System.Drawing.Size(75, 25);
            this.textBox2Mine.TabIndex = 7;
            this.textBox2Mine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1Mine
            // 
            this.textBox1Mine.BackColor = System.Drawing.Color.Maroon;
            this.textBox1Mine.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1Mine.ForeColor = System.Drawing.Color.Maroon;
            this.textBox1Mine.Location = new System.Drawing.Point(0, 196);
            this.textBox1Mine.Multiline = true;
            this.textBox1Mine.Name = "textBox1Mine";
            this.textBox1Mine.ReadOnly = true;
            this.textBox1Mine.Size = new System.Drawing.Size(75, 25);
            this.textBox1Mine.TabIndex = 6;
            this.textBox1Mine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4Mine
            // 
            this.label4Mine.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4Mine.ForeColor = System.Drawing.Color.Black;
            this.label4Mine.Location = new System.Drawing.Point(90, 166);
            this.label4Mine.Name = "label4Mine";
            this.label4Mine.Size = new System.Drawing.Size(110, 20);
            this.label4Mine.TabIndex = 5;
            this.label4Mine.Text = "Horizontally";
            this.label4Mine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3Mine
            // 
            this.label3Mine.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3Mine.ForeColor = System.Drawing.Color.Black;
            this.label3Mine.Location = new System.Drawing.Point(0, 166);
            this.label3Mine.Name = "label3Mine";
            this.label3Mine.Size = new System.Drawing.Size(90, 20);
            this.label3Mine.TabIndex = 4;
            this.label3Mine.Text = "Vertically";
            this.label3Mine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2Mine
            // 
            this.label2Mine.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2Mine.ForeColor = System.Drawing.Color.Black;
            this.label2Mine.Location = new System.Drawing.Point(0, 137);
            this.label2Mine.Name = "label2Mine";
            this.label2Mine.Size = new System.Drawing.Size(200, 20);
            this.label2Mine.TabIndex = 3;
            this.label2Mine.Text = "Your Location";
            this.label2Mine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1Mine
            // 
            this.label1Mine.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1Mine.ForeColor = System.Drawing.Color.Black;
            this.label1Mine.Location = new System.Drawing.Point(0, 69);
            this.label1Mine.Name = "label1Mine";
            this.label1Mine.Size = new System.Drawing.Size(150, 20);
            this.label1Mine.TabIndex = 2;
            this.label1Mine.Text = "Number of Mines";
            this.label1Mine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1Mine.Click += new System.EventHandler(this.label1Mine_Click);
            // 
            // numericUpDown1Mine
            // 
            this.numericUpDown1Mine.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1Mine.Location = new System.Drawing.Point(157, 69);
            this.numericUpDown1Mine.Name = "numericUpDown1Mine";
            this.numericUpDown1Mine.Size = new System.Drawing.Size(40, 20);
            this.numericUpDown1Mine.TabIndex = 0;
            this.numericUpDown1Mine.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // timer1Bang
            // 
            this.timer1Bang.Interval = 1000;
            this.timer1Bang.Tick += new System.EventHandler(this.timer1Bang_Tick);
            // 
            // panel1Grass
            // 
            this.panel1Grass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1Grass.BackgroundImage = global::Sapper.Properties.Resources.Grass;
            this.panel1Grass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1Grass.Controls.Add(this.label6Win);
            this.panel1Grass.Controls.Add(this.pictureBox1MineBang);
            this.panel1Grass.Location = new System.Drawing.Point(200, 0);
            this.panel1Grass.Name = "panel1Grass";
            this.panel1Grass.Size = new System.Drawing.Size(584, 361);
            this.panel1Grass.TabIndex = 0;
            this.panel1Grass.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1Grass.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1Grass_MouseMove);
            // 
            // label6Win
            // 
            this.label6Win.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6Win.Font = new System.Drawing.Font("Times New Roman", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6Win.ForeColor = System.Drawing.Color.Maroon;
            this.label6Win.Location = new System.Drawing.Point(6, 9);
            this.label6Win.Name = "label6Win";
            this.label6Win.Size = new System.Drawing.Size(566, 340);
            this.label6Win.TabIndex = 3;
            this.label6Win.Text = "You\'re Winner!";
            this.label6Win.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6Win.Visible = false;
            // 
            // pictureBox1MineBang
            // 
            this.pictureBox1MineBang.BackgroundImage = global::Sapper.Properties.Resources.Mine;
            this.pictureBox1MineBang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1MineBang.Location = new System.Drawing.Point(267, 156);
            this.pictureBox1MineBang.Name = "pictureBox1MineBang";
            this.pictureBox1MineBang.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1MineBang.TabIndex = 0;
            this.pictureBox1MineBang.TabStop = false;
            this.pictureBox1MineBang.Visible = false;
            this.pictureBox1MineBang.Click += new System.EventHandler(this.pictureBox1BombBang_Click);
            // 
            // timer2Bang
            // 
            this.timer2Bang.Interval = 1000;
            this.timer2Bang.Tick += new System.EventHandler(this.timer2Bang_Tick);
            // 
            // Form1Minefield
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.panel1Grass);
            this.Controls.Add(this.panel2Menu);
            this.Name = "Form1Minefield";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel2Menu.ResumeLayout(false);
            this.panel2Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1Mine)).EndInit();
            this.panel1Grass.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1MineBang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1Grass;
        private System.Windows.Forms.PictureBox pictureBox1MineBang;
        private System.Windows.Forms.Panel panel2Menu;
        private System.Windows.Forms.NumericUpDown numericUpDown1Mine;
        private System.Windows.Forms.Label label1Mine;
        private System.Windows.Forms.TextBox textBox1Mine;
        private System.Windows.Forms.Label label4Mine;
        private System.Windows.Forms.Label label3Mine;
        private System.Windows.Forms.Label label2Mine;
        private System.Windows.Forms.Button button1Start;
        private System.Windows.Forms.TextBox textBox3Mine;
        private System.Windows.Forms.Label label5Mine;
        private System.Windows.Forms.TextBox textBox2Mine;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1Bang;
        private System.Windows.Forms.Label label6Win;
        private System.Windows.Forms.TextBox textBox4Warning;
        private System.Windows.Forms.Timer timer2Bang;
    }
}

