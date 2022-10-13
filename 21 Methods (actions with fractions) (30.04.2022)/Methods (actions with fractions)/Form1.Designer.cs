
namespace Methods__actions_with_fractions_
{
    partial class Form1actionswithfractions
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
            this.textBox1firstnumerator = new System.Windows.Forms.TextBox();
            this.textBox2firstdenominator = new System.Windows.Forms.TextBox();
            this.textBox3secondnumerator = new System.Windows.Forms.TextBox();
            this.textBox4seconddenominator = new System.Windows.Forms.TextBox();
            this.textBox6resultnumerator = new System.Windows.Forms.TextBox();
            this.textBox7resultdenominator = new System.Windows.Forms.TextBox();
            this.comboBox1sign = new System.Windows.Forms.ComboBox();
            this.button1equal = new System.Windows.Forms.Button();
            this.button2clear = new System.Windows.Forms.Button();
            this.radioButton1fractionreduction = new System.Windows.Forms.RadioButton();
            this.radioButton2actionswithfractions = new System.Windows.Forms.RadioButton();
            this.textBox5greatestleastcommondivisormultiple = new System.Windows.Forms.TextBox();
            this.label1greatestleastcommondivisormultiple = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1firstnumerator
            // 
            this.textBox1firstnumerator.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1firstnumerator.Location = new System.Drawing.Point(12, 63);
            this.textBox1firstnumerator.Name = "textBox1firstnumerator";
            this.textBox1firstnumerator.Size = new System.Drawing.Size(175, 63);
            this.textBox1firstnumerator.TabIndex = 0;
            this.textBox1firstnumerator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1firstnumerator.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1firstnumerator_KeyDown);
            this.textBox1firstnumerator.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1firstnumerator_KeyPress);
            // 
            // textBox2firstdenominator
            // 
            this.textBox2firstdenominator.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2firstdenominator.Location = new System.Drawing.Point(12, 126);
            this.textBox2firstdenominator.Name = "textBox2firstdenominator";
            this.textBox2firstdenominator.Size = new System.Drawing.Size(175, 63);
            this.textBox2firstdenominator.TabIndex = 1;
            this.textBox2firstdenominator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2firstdenominator.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2firstdenominator_KeyDown);
            this.textBox2firstdenominator.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2firstdenominator_KeyPress);
            // 
            // textBox3secondnumerator
            // 
            this.textBox3secondnumerator.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3secondnumerator.Location = new System.Drawing.Point(262, 63);
            this.textBox3secondnumerator.Name = "textBox3secondnumerator";
            this.textBox3secondnumerator.Size = new System.Drawing.Size(175, 63);
            this.textBox3secondnumerator.TabIndex = 2;
            this.textBox3secondnumerator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3secondnumerator.Visible = false;
            this.textBox3secondnumerator.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox3secondnumerator_KeyDown);
            this.textBox3secondnumerator.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1firstnumerator_KeyPress);
            // 
            // textBox4seconddenominator
            // 
            this.textBox4seconddenominator.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4seconddenominator.Location = new System.Drawing.Point(262, 126);
            this.textBox4seconddenominator.Name = "textBox4seconddenominator";
            this.textBox4seconddenominator.Size = new System.Drawing.Size(175, 63);
            this.textBox4seconddenominator.TabIndex = 3;
            this.textBox4seconddenominator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox4seconddenominator.Visible = false;
            this.textBox4seconddenominator.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2firstdenominator_KeyPress);
            // 
            // textBox6resultnumerator
            // 
            this.textBox6resultnumerator.BackColor = System.Drawing.Color.White;
            this.textBox6resultnumerator.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox6resultnumerator.Location = new System.Drawing.Point(289, 45);
            this.textBox6resultnumerator.Name = "textBox6resultnumerator";
            this.textBox6resultnumerator.ReadOnly = true;
            this.textBox6resultnumerator.Size = new System.Drawing.Size(230, 81);
            this.textBox6resultnumerator.TabIndex = 4;
            this.textBox6resultnumerator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7resultdenominator
            // 
            this.textBox7resultdenominator.BackColor = System.Drawing.Color.White;
            this.textBox7resultdenominator.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox7resultdenominator.Location = new System.Drawing.Point(289, 126);
            this.textBox7resultdenominator.Name = "textBox7resultdenominator";
            this.textBox7resultdenominator.ReadOnly = true;
            this.textBox7resultdenominator.Size = new System.Drawing.Size(230, 81);
            this.textBox7resultdenominator.TabIndex = 5;
            this.textBox7resultdenominator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBox1sign
            // 
            this.comboBox1sign.BackColor = System.Drawing.Color.White;
            this.comboBox1sign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1sign.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1sign.FormattingEnabled = true;
            this.comboBox1sign.ItemHeight = 55;
            this.comboBox1sign.Items.AddRange(new object[] {
            "+",
            "−",
            "×",
            "÷"});
            this.comboBox1sign.Location = new System.Drawing.Point(193, 93);
            this.comboBox1sign.Name = "comboBox1sign";
            this.comboBox1sign.Size = new System.Drawing.Size(63, 63);
            this.comboBox1sign.TabIndex = 6;
            this.comboBox1sign.Visible = false;
            // 
            // button1equal
            // 
            this.button1equal.BackColor = System.Drawing.Color.White;
            this.button1equal.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1equal.Location = new System.Drawing.Point(193, 79);
            this.button1equal.Name = "button1equal";
            this.button1equal.Size = new System.Drawing.Size(90, 90);
            this.button1equal.TabIndex = 7;
            this.button1equal.Text = "=";
            this.button1equal.UseVisualStyleBackColor = false;
            this.button1equal.Click += new System.EventHandler(this.button1equal_Click);
            // 
            // button2clear
            // 
            this.button2clear.BackColor = System.Drawing.Color.Red;
            this.button2clear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2clear.Location = new System.Drawing.Point(464, 213);
            this.button2clear.Name = "button2clear";
            this.button2clear.Size = new System.Drawing.Size(55, 30);
            this.button2clear.TabIndex = 8;
            this.button2clear.Text = "Clear";
            this.button2clear.UseVisualStyleBackColor = false;
            this.button2clear.Click += new System.EventHandler(this.button2clear_Click);
            // 
            // radioButton1fractionreduction
            // 
            this.radioButton1fractionreduction.AutoSize = true;
            this.radioButton1fractionreduction.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1fractionreduction.Checked = true;
            this.radioButton1fractionreduction.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1fractionreduction.Location = new System.Drawing.Point(12, 12);
            this.radioButton1fractionreduction.Name = "radioButton1fractionreduction";
            this.radioButton1fractionreduction.Size = new System.Drawing.Size(182, 27);
            this.radioButton1fractionreduction.TabIndex = 9;
            this.radioButton1fractionreduction.TabStop = true;
            this.radioButton1fractionreduction.Text = "Fraction reduction";
            this.radioButton1fractionreduction.UseVisualStyleBackColor = false;
            this.radioButton1fractionreduction.CheckedChanged += new System.EventHandler(this.radioButton1fractionreduction_CheckedChanged);
            // 
            // radioButton2actionswithfractions
            // 
            this.radioButton2actionswithfractions.AutoSize = true;
            this.radioButton2actionswithfractions.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2actionswithfractions.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2actionswithfractions.Location = new System.Drawing.Point(200, 12);
            this.radioButton2actionswithfractions.Name = "radioButton2actionswithfractions";
            this.radioButton2actionswithfractions.Size = new System.Drawing.Size(212, 27);
            this.radioButton2actionswithfractions.TabIndex = 10;
            this.radioButton2actionswithfractions.Text = "Actions with fractions";
            this.radioButton2actionswithfractions.UseVisualStyleBackColor = false;
            this.radioButton2actionswithfractions.CheckedChanged += new System.EventHandler(this.radioButton2actionswithfractions_CheckedChanged);
            // 
            // textBox5greatestleastcommondivisormultiple
            // 
            this.textBox5greatestleastcommondivisormultiple.BackColor = System.Drawing.Color.White;
            this.textBox5greatestleastcommondivisormultiple.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox5greatestleastcommondivisormultiple.Location = new System.Drawing.Point(233, 213);
            this.textBox5greatestleastcommondivisormultiple.Name = "textBox5greatestleastcommondivisormultiple";
            this.textBox5greatestleastcommondivisormultiple.ReadOnly = true;
            this.textBox5greatestleastcommondivisormultiple.Size = new System.Drawing.Size(70, 35);
            this.textBox5greatestleastcommondivisormultiple.TabIndex = 11;
            this.textBox5greatestleastcommondivisormultiple.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox5greatestleastcommondivisormultiple.Visible = false;
            // 
            // label1greatestleastcommondivisormultiple
            // 
            this.label1greatestleastcommondivisormultiple.BackColor = System.Drawing.Color.Transparent;
            this.label1greatestleastcommondivisormultiple.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1greatestleastcommondivisormultiple.Location = new System.Drawing.Point(12, 218);
            this.label1greatestleastcommondivisormultiple.Name = "label1greatestleastcommondivisormultiple";
            this.label1greatestleastcommondivisormultiple.Size = new System.Drawing.Size(215, 25);
            this.label1greatestleastcommondivisormultiple.TabIndex = 12;
            this.label1greatestleastcommondivisormultiple.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1greatestleastcommondivisormultiple.Visible = false;
            // 
            // Form1actionswithfractions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Methods__actions_with_fractions_.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(534, 261);
            this.Controls.Add(this.label1greatestleastcommondivisormultiple);
            this.Controls.Add(this.textBox5greatestleastcommondivisormultiple);
            this.Controls.Add(this.radioButton2actionswithfractions);
            this.Controls.Add(this.radioButton1fractionreduction);
            this.Controls.Add(this.button2clear);
            this.Controls.Add(this.button1equal);
            this.Controls.Add(this.comboBox1sign);
            this.Controls.Add(this.textBox7resultdenominator);
            this.Controls.Add(this.textBox6resultnumerator);
            this.Controls.Add(this.textBox4seconddenominator);
            this.Controls.Add(this.textBox3secondnumerator);
            this.Controls.Add(this.textBox2firstdenominator);
            this.Controls.Add(this.textBox1firstnumerator);
            this.Name = "Form1actionswithfractions";
            this.Text = "Actions with fractions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1firstnumerator;
        private System.Windows.Forms.TextBox textBox2firstdenominator;
        private System.Windows.Forms.TextBox textBox3secondnumerator;
        private System.Windows.Forms.TextBox textBox4seconddenominator;
        private System.Windows.Forms.TextBox textBox6resultnumerator;
        private System.Windows.Forms.TextBox textBox7resultdenominator;
        private System.Windows.Forms.ComboBox comboBox1sign;
        private System.Windows.Forms.Button button1equal;
        private System.Windows.Forms.Button button2clear;
        private System.Windows.Forms.RadioButton radioButton1fractionreduction;
        private System.Windows.Forms.RadioButton radioButton2actionswithfractions;
        private System.Windows.Forms.TextBox textBox5greatestleastcommondivisormultiple;
        private System.Windows.Forms.Label label1greatestleastcommondivisormultiple;
    }
}

