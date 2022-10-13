
namespace Password
{
    partial class Form1password
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
            this.pictureBox1ilovecoding = new System.Windows.Forms.PictureBox();
            this.panel1hide = new System.Windows.Forms.Panel();
            this.panel2newattempt = new System.Windows.Forms.Panel();
            this.label1finalcountdown = new System.Windows.Forms.Label();
            this.textBox1entrance = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1ilovecoding)).BeginInit();
            this.panel1hide.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1ilovecoding
            // 
            this.pictureBox1ilovecoding.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1ilovecoding.BackgroundImage = global::Password.Properties.Resources.ILoveCoding;
            this.pictureBox1ilovecoding.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1ilovecoding.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1ilovecoding.Name = "pictureBox1ilovecoding";
            this.pictureBox1ilovecoding.Size = new System.Drawing.Size(760, 337);
            this.pictureBox1ilovecoding.TabIndex = 0;
            this.pictureBox1ilovecoding.TabStop = false;
            this.pictureBox1ilovecoding.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1ilovecoding_MouseClick);
            // 
            // panel1hide
            // 
            this.panel1hide.BackgroundImage = global::Password.Properties.Resources.Background;
            this.panel1hide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1hide.Controls.Add(this.panel2newattempt);
            this.panel1hide.Controls.Add(this.label1finalcountdown);
            this.panel1hide.Controls.Add(this.textBox1entrance);
            this.panel1hide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1hide.Location = new System.Drawing.Point(0, 0);
            this.panel1hide.Name = "panel1hide";
            this.panel1hide.Size = new System.Drawing.Size(784, 361);
            this.panel1hide.TabIndex = 1;
            // 
            // panel2newattempt
            // 
            this.panel2newattempt.BackgroundImage = global::Password.Properties.Resources.Background;
            this.panel2newattempt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2newattempt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2newattempt.Location = new System.Drawing.Point(0, 0);
            this.panel2newattempt.Name = "panel2newattempt";
            this.panel2newattempt.Size = new System.Drawing.Size(784, 361);
            this.panel2newattempt.TabIndex = 5;
            this.panel2newattempt.Visible = false;
            // 
            // label1finalcountdown
            // 
            this.label1finalcountdown.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1finalcountdown.Location = new System.Drawing.Point(734, 0);
            this.label1finalcountdown.Name = "label1finalcountdown";
            this.label1finalcountdown.Size = new System.Drawing.Size(50, 50);
            this.label1finalcountdown.TabIndex = 4;
            this.label1finalcountdown.Text = "3";
            this.label1finalcountdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1entrance
            // 
            this.textBox1entrance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1entrance.Location = new System.Drawing.Point(350, 187);
            this.textBox1entrance.Multiline = true;
            this.textBox1entrance.Name = "textBox1entrance";
            this.textBox1entrance.Size = new System.Drawing.Size(100, 25);
            this.textBox1entrance.TabIndex = 3;
            this.textBox1entrance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Password.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.panel1hide);
            this.Controls.Add(this.pictureBox1ilovecoding);
            this.Name = "Form1password";
            this.Text = "Password";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1password_FormClosing);
            this.Shown += new System.EventHandler(this.Form1password_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1ilovecoding)).EndInit();
            this.panel1hide.ResumeLayout(false);
            this.panel1hide.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1ilovecoding;
        private System.Windows.Forms.Panel panel1hide;
        private System.Windows.Forms.TextBox textBox1entrance;
        private System.Windows.Forms.Label label1finalcountdown;
        private System.Windows.Forms.Panel panel2newattempt;
    }
}

