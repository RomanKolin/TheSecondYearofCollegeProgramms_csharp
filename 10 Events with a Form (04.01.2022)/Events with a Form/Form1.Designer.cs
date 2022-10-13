
namespace Events_with_a_Form
{
    partial class Form1EventswithaForm
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
            this.textBox3Properties = new System.Windows.Forms.TextBox();
            this.label1Date = new System.Windows.Forms.Label();
            this.label2Time = new System.Windows.Forms.Label();
            this.pictureBox1ILoveCoding = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1ILoveCoding)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox3Properties
            // 
            this.textBox3Properties.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3Properties.Enabled = false;
            this.textBox3Properties.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3Properties.Location = new System.Drawing.Point(647, 329);
            this.textBox3Properties.Multiline = true;
            this.textBox3Properties.Name = "textBox3Properties";
            this.textBox3Properties.ReadOnly = true;
            this.textBox3Properties.Size = new System.Drawing.Size(125, 20);
            this.textBox3Properties.TabIndex = 1;
            this.textBox3Properties.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1Date
            // 
            this.label1Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1Date.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1Date.Location = new System.Drawing.Point(532, 9);
            this.label1Date.Name = "label1Date";
            this.label1Date.Size = new System.Drawing.Size(120, 25);
            this.label1Date.TabIndex = 4;
            this.label1Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2Time
            // 
            this.label2Time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2Time.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2Time.Location = new System.Drawing.Point(652, 9);
            this.label2Time.Name = "label2Time";
            this.label2Time.Size = new System.Drawing.Size(120, 25);
            this.label2Time.TabIndex = 5;
            this.label2Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1ILoveCoding
            // 
            this.pictureBox1ILoveCoding.BackgroundImage = global::Events_with_a_Form.Properties.Resources.ILoveCoding;
            this.pictureBox1ILoveCoding.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1ILoveCoding.Location = new System.Drawing.Point(325, 125);
            this.pictureBox1ILoveCoding.Name = "pictureBox1ILoveCoding";
            this.pictureBox1ILoveCoding.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1ILoveCoding.TabIndex = 3;
            this.pictureBox1ILoveCoding.TabStop = false;
            // 
            // Form1EventswithaForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.label2Time);
            this.Controls.Add(this.label1Date);
            this.Controls.Add(this.pictureBox1ILoveCoding);
            this.Controls.Add(this.textBox3Properties);
            this.Name = "Form1EventswithaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Events with a Form";
            this.Shown += new System.EventHandler(this.Form1EventswithaForm_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1EventswithaForm_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1EventswithaForm_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1ILoveCoding)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox3Properties;
        private System.Windows.Forms.Label label1Date;
        private System.Windows.Forms.Label label2Time;
        private System.Windows.Forms.PictureBox pictureBox1ILoveCoding;
    }
}

