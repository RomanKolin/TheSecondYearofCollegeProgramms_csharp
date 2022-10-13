
namespace Body_Calculator
{
    partial class Form1BodyCalculator
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
            this.textBox1Result = new System.Windows.Forms.TextBox();
            this.textBox2Weight = new System.Windows.Forms.TextBox();
            this.textBox3Height = new System.Windows.Forms.TextBox();
            this.label1Weight = new System.Windows.Forms.Label();
            this.label2Height = new System.Windows.Forms.Label();
            this.button1Calculate = new System.Windows.Forms.Button();
            this.radioButton1Wrist = new System.Windows.Forms.RadioButton();
            this.radioButton2Wrist = new System.Windows.Forms.RadioButton();
            this.radioButton3Wrist = new System.Windows.Forms.RadioButton();
            this.groupBox1Wrist = new System.Windows.Forms.GroupBox();
            this.label3Age = new System.Windows.Forms.Label();
            this.textBox4Age = new System.Windows.Forms.TextBox();
            this.groupBox2Sex = new System.Windows.Forms.GroupBox();
            this.radioButton5Sex = new System.Windows.Forms.RadioButton();
            this.radioButton4Sex = new System.Windows.Forms.RadioButton();
            this.groupBox3Lifestyle = new System.Windows.Forms.GroupBox();
            this.radioButton10Lifestyle = new System.Windows.Forms.RadioButton();
            this.radioButton9Lifestyle = new System.Windows.Forms.RadioButton();
            this.radioButton8Lifestyle = new System.Windows.Forms.RadioButton();
            this.radioButton7Lifestyle = new System.Windows.Forms.RadioButton();
            this.radioButton6Lifestyle = new System.Windows.Forms.RadioButton();
            this.label4Error = new System.Windows.Forms.Label();
            this.groupBox1Wrist.SuspendLayout();
            this.groupBox2Sex.SuspendLayout();
            this.groupBox3Lifestyle.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1Result
            // 
            this.textBox1Result.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1Result.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1Result.Location = new System.Drawing.Point(298, 12);
            this.textBox1Result.Multiline = true;
            this.textBox1Result.Name = "textBox1Result";
            this.textBox1Result.ReadOnly = true;
            this.textBox1Result.Size = new System.Drawing.Size(474, 476);
            this.textBox1Result.TabIndex = 0;
            this.textBox1Result.TabStop = false;
            // 
            // textBox2Weight
            // 
            this.textBox2Weight.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2Weight.Location = new System.Drawing.Point(123, 9);
            this.textBox2Weight.Name = "textBox2Weight";
            this.textBox2Weight.Size = new System.Drawing.Size(75, 29);
            this.textBox2Weight.TabIndex = 1;
            this.textBox2Weight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2Weight.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2Weight_KeyDown);
            // 
            // textBox3Height
            // 
            this.textBox3Height.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3Height.Location = new System.Drawing.Point(123, 40);
            this.textBox3Height.Name = "textBox3Height";
            this.textBox3Height.Size = new System.Drawing.Size(75, 29);
            this.textBox3Height.TabIndex = 2;
            this.textBox3Height.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3Height.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox3Height_KeyDown);
            // 
            // label1Weight
            // 
            this.label1Weight.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1Weight.Location = new System.Drawing.Point(12, 9);
            this.label1Weight.Name = "label1Weight";
            this.label1Weight.Size = new System.Drawing.Size(105, 30);
            this.label1Weight.TabIndex = 3;
            this.label1Weight.Text = "Weight (kg)";
            this.label1Weight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2Height
            // 
            this.label2Height.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2Height.Location = new System.Drawing.Point(12, 40);
            this.label2Height.Name = "label2Height";
            this.label2Height.Size = new System.Drawing.Size(105, 30);
            this.label2Height.TabIndex = 4;
            this.label2Height.Text = "Height (cm)";
            this.label2Height.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1Calculate
            // 
            this.button1Calculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1Calculate.BackColor = System.Drawing.Color.Lime;
            this.button1Calculate.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Calculate.Location = new System.Drawing.Point(672, 494);
            this.button1Calculate.Name = "button1Calculate";
            this.button1Calculate.Size = new System.Drawing.Size(100, 30);
            this.button1Calculate.TabIndex = 5;
            this.button1Calculate.Text = "Calculate";
            this.button1Calculate.UseVisualStyleBackColor = false;
            this.button1Calculate.Click += new System.EventHandler(this.button1Calculate_Click);
            // 
            // radioButton1Wrist
            // 
            this.radioButton1Wrist.AutoSize = true;
            this.radioButton1Wrist.Checked = true;
            this.radioButton1Wrist.Location = new System.Drawing.Point(6, 28);
            this.radioButton1Wrist.Name = "radioButton1Wrist";
            this.radioButton1Wrist.Size = new System.Drawing.Size(153, 25);
            this.radioButton1Wrist.TabIndex = 6;
            this.radioButton1Wrist.TabStop = true;
            this.radioButton1Wrist.Text = "Less than 15 cm";
            this.radioButton1Wrist.UseVisualStyleBackColor = true;
            // 
            // radioButton2Wrist
            // 
            this.radioButton2Wrist.AutoSize = true;
            this.radioButton2Wrist.Location = new System.Drawing.Point(6, 51);
            this.radioButton2Wrist.Name = "radioButton2Wrist";
            this.radioButton2Wrist.Size = new System.Drawing.Size(231, 25);
            this.radioButton2Wrist.TabIndex = 7;
            this.radioButton2Wrist.Text = "Between 15 cm and 17 cm";
            this.radioButton2Wrist.UseVisualStyleBackColor = true;
            // 
            // radioButton3Wrist
            // 
            this.radioButton3Wrist.AutoSize = true;
            this.radioButton3Wrist.Location = new System.Drawing.Point(6, 74);
            this.radioButton3Wrist.Name = "radioButton3Wrist";
            this.radioButton3Wrist.Size = new System.Drawing.Size(159, 25);
            this.radioButton3Wrist.TabIndex = 8;
            this.radioButton3Wrist.Text = "More than 17 cm";
            this.radioButton3Wrist.UseVisualStyleBackColor = true;
            // 
            // groupBox1Wrist
            // 
            this.groupBox1Wrist.Controls.Add(this.radioButton1Wrist);
            this.groupBox1Wrist.Controls.Add(this.radioButton3Wrist);
            this.groupBox1Wrist.Controls.Add(this.radioButton2Wrist);
            this.groupBox1Wrist.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1Wrist.Location = new System.Drawing.Point(12, 102);
            this.groupBox1Wrist.Name = "groupBox1Wrist";
            this.groupBox1Wrist.Size = new System.Drawing.Size(240, 105);
            this.groupBox1Wrist.TabIndex = 9;
            this.groupBox1Wrist.TabStop = false;
            this.groupBox1Wrist.Text = "Girth of Wrist";
            // 
            // label3Age
            // 
            this.label3Age.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3Age.Location = new System.Drawing.Point(12, 71);
            this.label3Age.Name = "label3Age";
            this.label3Age.Size = new System.Drawing.Size(105, 30);
            this.label3Age.TabIndex = 10;
            this.label3Age.Text = "Age";
            this.label3Age.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox4Age
            // 
            this.textBox4Age.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4Age.Location = new System.Drawing.Point(123, 71);
            this.textBox4Age.Name = "textBox4Age";
            this.textBox4Age.Size = new System.Drawing.Size(75, 29);
            this.textBox4Age.TabIndex = 11;
            this.textBox4Age.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2Sex
            // 
            this.groupBox2Sex.Controls.Add(this.radioButton5Sex);
            this.groupBox2Sex.Controls.Add(this.radioButton4Sex);
            this.groupBox2Sex.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2Sex.Location = new System.Drawing.Point(12, 213);
            this.groupBox2Sex.Name = "groupBox2Sex";
            this.groupBox2Sex.Size = new System.Drawing.Size(240, 80);
            this.groupBox2Sex.TabIndex = 12;
            this.groupBox2Sex.TabStop = false;
            this.groupBox2Sex.Text = "Sex";
            // 
            // radioButton5Sex
            // 
            this.radioButton5Sex.AutoSize = true;
            this.radioButton5Sex.Location = new System.Drawing.Point(6, 50);
            this.radioButton5Sex.Name = "radioButton5Sex";
            this.radioButton5Sex.Size = new System.Drawing.Size(85, 25);
            this.radioButton5Sex.TabIndex = 10;
            this.radioButton5Sex.Text = "Female";
            this.radioButton5Sex.UseVisualStyleBackColor = true;
            // 
            // radioButton4Sex
            // 
            this.radioButton4Sex.AutoSize = true;
            this.radioButton4Sex.Checked = true;
            this.radioButton4Sex.Location = new System.Drawing.Point(6, 28);
            this.radioButton4Sex.Name = "radioButton4Sex";
            this.radioButton4Sex.Size = new System.Drawing.Size(67, 25);
            this.radioButton4Sex.TabIndex = 9;
            this.radioButton4Sex.TabStop = true;
            this.radioButton4Sex.Text = "Male";
            this.radioButton4Sex.UseVisualStyleBackColor = true;
            // 
            // groupBox3Lifestyle
            // 
            this.groupBox3Lifestyle.Controls.Add(this.radioButton10Lifestyle);
            this.groupBox3Lifestyle.Controls.Add(this.radioButton9Lifestyle);
            this.groupBox3Lifestyle.Controls.Add(this.radioButton8Lifestyle);
            this.groupBox3Lifestyle.Controls.Add(this.radioButton7Lifestyle);
            this.groupBox3Lifestyle.Controls.Add(this.radioButton6Lifestyle);
            this.groupBox3Lifestyle.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3Lifestyle.Location = new System.Drawing.Point(12, 299);
            this.groupBox3Lifestyle.Name = "groupBox3Lifestyle";
            this.groupBox3Lifestyle.Size = new System.Drawing.Size(280, 190);
            this.groupBox3Lifestyle.TabIndex = 14;
            this.groupBox3Lifestyle.TabStop = false;
            this.groupBox3Lifestyle.Text = "Your Lifestile";
            // 
            // radioButton10Lifestyle
            // 
            this.radioButton10Lifestyle.AutoSize = true;
            this.radioButton10Lifestyle.Location = new System.Drawing.Point(6, 152);
            this.radioButton10Lifestyle.Name = "radioButton10Lifestyle";
            this.radioButton10Lifestyle.Size = new System.Drawing.Size(272, 25);
            this.radioButton10Lifestyle.TabIndex = 4;
            this.radioButton10Lifestyle.Text = "Maximum high physical activity";
            this.radioButton10Lifestyle.UseVisualStyleBackColor = true;
            // 
            // radioButton9Lifestyle
            // 
            this.radioButton9Lifestyle.AutoSize = true;
            this.radioButton9Lifestyle.Location = new System.Drawing.Point(6, 121);
            this.radioButton9Lifestyle.Name = "radioButton9Lifestyle";
            this.radioButton9Lifestyle.Size = new System.Drawing.Size(228, 25);
            this.radioButton9Lifestyle.TabIndex = 3;
            this.radioButton9Lifestyle.Text = "Very high physical activity";
            this.radioButton9Lifestyle.UseVisualStyleBackColor = true;
            // 
            // radioButton8Lifestyle
            // 
            this.radioButton8Lifestyle.AutoSize = true;
            this.radioButton8Lifestyle.Location = new System.Drawing.Point(6, 90);
            this.radioButton8Lifestyle.Name = "radioButton8Lifestyle";
            this.radioButton8Lifestyle.Size = new System.Drawing.Size(194, 25);
            this.radioButton8Lifestyle.TabIndex = 2;
            this.radioButton8Lifestyle.Text = "High physical activity";
            this.radioButton8Lifestyle.UseVisualStyleBackColor = true;
            // 
            // radioButton7Lifestyle
            // 
            this.radioButton7Lifestyle.AutoSize = true;
            this.radioButton7Lifestyle.Location = new System.Drawing.Point(6, 59);
            this.radioButton7Lifestyle.Name = "radioButton7Lifestyle";
            this.radioButton7Lifestyle.Size = new System.Drawing.Size(228, 25);
            this.radioButton7Lifestyle.TabIndex = 1;
            this.radioButton7Lifestyle.Text = "Moderate physical activity";
            this.radioButton7Lifestyle.UseVisualStyleBackColor = true;
            // 
            // radioButton6Lifestyle
            // 
            this.radioButton6Lifestyle.AutoSize = true;
            this.radioButton6Lifestyle.Checked = true;
            this.radioButton6Lifestyle.Location = new System.Drawing.Point(6, 28);
            this.radioButton6Lifestyle.Name = "radioButton6Lifestyle";
            this.radioButton6Lifestyle.Size = new System.Drawing.Size(165, 25);
            this.radioButton6Lifestyle.TabIndex = 0;
            this.radioButton6Lifestyle.TabStop = true;
            this.radioButton6Lifestyle.Text = "Sedentary lifestyle";
            this.radioButton6Lifestyle.UseVisualStyleBackColor = true;
            // 
            // label4Error
            // 
            this.label4Error.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4Error.BackColor = System.Drawing.SystemColors.Control;
            this.label4Error.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4Error.Location = new System.Drawing.Point(298, 12);
            this.label4Error.Name = "label4Error";
            this.label4Error.Size = new System.Drawing.Size(474, 476);
            this.label4Error.TabIndex = 15;
            this.label4Error.Text = "Print the correct characteristics of your body\r\n(Weight, height, and age are posi" +
    "tive values)";
            this.label4Error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4Error.Visible = false;
            // 
            // Form1BodyCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(784, 536);
            this.Controls.Add(this.label4Error);
            this.Controls.Add(this.groupBox3Lifestyle);
            this.Controls.Add(this.groupBox2Sex);
            this.Controls.Add(this.textBox4Age);
            this.Controls.Add(this.label3Age);
            this.Controls.Add(this.button1Calculate);
            this.Controls.Add(this.groupBox1Wrist);
            this.Controls.Add(this.label2Height);
            this.Controls.Add(this.label1Weight);
            this.Controls.Add(this.textBox3Height);
            this.Controls.Add(this.textBox2Weight);
            this.Controls.Add(this.textBox1Result);
            this.Name = "Form1BodyCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Body Calculator";
            this.groupBox1Wrist.ResumeLayout(false);
            this.groupBox1Wrist.PerformLayout();
            this.groupBox2Sex.ResumeLayout(false);
            this.groupBox2Sex.PerformLayout();
            this.groupBox3Lifestyle.ResumeLayout(false);
            this.groupBox3Lifestyle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1Result;
        private System.Windows.Forms.TextBox textBox2Weight;
        private System.Windows.Forms.TextBox textBox3Height;
        private System.Windows.Forms.Label label1Weight;
        private System.Windows.Forms.Label label2Height;
        private System.Windows.Forms.Button button1Calculate;
        private System.Windows.Forms.RadioButton radioButton1Wrist;
        private System.Windows.Forms.RadioButton radioButton2Wrist;
        private System.Windows.Forms.RadioButton radioButton3Wrist;
        private System.Windows.Forms.GroupBox groupBox1Wrist;
        private System.Windows.Forms.Label label3Age;
        private System.Windows.Forms.TextBox textBox4Age;
        private System.Windows.Forms.GroupBox groupBox2Sex;
        private System.Windows.Forms.RadioButton radioButton5Sex;
        private System.Windows.Forms.RadioButton radioButton4Sex;
        private System.Windows.Forms.GroupBox groupBox3Lifestyle;
        private System.Windows.Forms.RadioButton radioButton10Lifestyle;
        private System.Windows.Forms.RadioButton radioButton9Lifestyle;
        private System.Windows.Forms.RadioButton radioButton8Lifestyle;
        private System.Windows.Forms.RadioButton radioButton7Lifestyle;
        private System.Windows.Forms.RadioButton radioButton6Lifestyle;
        private System.Windows.Forms.Label label4Error;
    }
}

