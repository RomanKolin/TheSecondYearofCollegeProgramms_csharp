
namespace Human_biorhythm
{
    partial class Form1humanbiorhythm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.dateTimePicker1dateofbirth = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2fromdate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3todate = new System.Windows.Forms.DateTimePicker();
            this.chart1humanbiorhythm = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1period = new System.Windows.Forms.GroupBox();
            this.radioButton4period = new System.Windows.Forms.RadioButton();
            this.label2from = new System.Windows.Forms.Label();
            this.label3to = new System.Windows.Forms.Label();
            this.radioButton3year = new System.Windows.Forms.RadioButton();
            this.radioButton1week = new System.Windows.Forms.RadioButton();
            this.radioButton2month = new System.Windows.Forms.RadioButton();
            this.groupBox2show = new System.Windows.Forms.GroupBox();
            this.checkBox3intellectual = new System.Windows.Forms.CheckBox();
            this.checkBox2emotional = new System.Windows.Forms.CheckBox();
            this.checkBox1physical = new System.Windows.Forms.CheckBox();
            this.label1dateofbirth = new System.Windows.Forms.Label();
            this.button1buildabiorhythm = new System.Windows.Forms.Button();
            this.button3clear = new System.Windows.Forms.Button();
            this.checkBox4legends = new System.Windows.Forms.CheckBox();
            this.checkBox53d = new System.Windows.Forms.CheckBox();
            this.button2photo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1humanbiorhythm)).BeginInit();
            this.groupBox1period.SuspendLayout();
            this.groupBox2show.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1dateofbirth
            // 
            this.dateTimePicker1dateofbirth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1dateofbirth.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1dateofbirth.Location = new System.Drawing.Point(572, 32);
            this.dateTimePicker1dateofbirth.Name = "dateTimePicker1dateofbirth";
            this.dateTimePicker1dateofbirth.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1dateofbirth.TabIndex = 0;
            this.dateTimePicker1dateofbirth.Value = new System.DateTime(2022, 3, 16, 0, 0, 0, 0);
            // 
            // dateTimePicker2fromdate
            // 
            this.dateTimePicker2fromdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker2fromdate.Location = new System.Drawing.Point(57, 51);
            this.dateTimePicker2fromdate.Name = "dateTimePicker2fromdate";
            this.dateTimePicker2fromdate.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker2fromdate.TabIndex = 1;
            this.dateTimePicker2fromdate.Value = new System.DateTime(2022, 3, 16, 0, 0, 0, 0);
            this.dateTimePicker2fromdate.Visible = false;
            // 
            // dateTimePicker3todate
            // 
            this.dateTimePicker3todate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker3todate.Location = new System.Drawing.Point(57, 83);
            this.dateTimePicker3todate.Name = "dateTimePicker3todate";
            this.dateTimePicker3todate.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker3todate.TabIndex = 2;
            this.dateTimePicker3todate.Value = new System.DateTime(2022, 3, 16, 0, 0, 0, 0);
            this.dateTimePicker3todate.Visible = false;
            // 
            // chart1humanbiorhythm
            // 
            this.chart1humanbiorhythm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1humanbiorhythm.BackColor = System.Drawing.Color.Maroon;
            chartArea1.Name = "ChartArea3";
            this.chart1humanbiorhythm.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Maroon;
            legend1.Name = "Legend1";
            this.chart1humanbiorhythm.Legends.Add(legend1);
            this.chart1humanbiorhythm.Location = new System.Drawing.Point(12, 9);
            this.chart1humanbiorhythm.Name = "chart1humanbiorhythm";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea3";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Red;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Physical";
            series1.YValuesPerPoint = 2;
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea3";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Green;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Emotional";
            series2.YValuesPerPoint = 2;
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea3";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.Blue;
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Intellectual";
            series3.YValuesPerPoint = 2;
            this.chart1humanbiorhythm.Series.Add(series1);
            this.chart1humanbiorhythm.Series.Add(series2);
            this.chart1humanbiorhythm.Series.Add(series3);
            this.chart1humanbiorhythm.Size = new System.Drawing.Size(489, 304);
            this.chart1humanbiorhythm.TabIndex = 3;
            this.chart1humanbiorhythm.Text = "Human biorhythm";
            title1.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.Name = "Title1";
            title1.Text = "Human biorhythm";
            this.chart1humanbiorhythm.Titles.Add(title1);
            // 
            // groupBox1period
            // 
            this.groupBox1period.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1period.Controls.Add(this.radioButton4period);
            this.groupBox1period.Controls.Add(this.label2from);
            this.groupBox1period.Controls.Add(this.label3to);
            this.groupBox1period.Controls.Add(this.radioButton3year);
            this.groupBox1period.Controls.Add(this.dateTimePicker3todate);
            this.groupBox1period.Controls.Add(this.radioButton1week);
            this.groupBox1period.Controls.Add(this.radioButton2month);
            this.groupBox1period.Controls.Add(this.dateTimePicker2fromdate);
            this.groupBox1period.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1period.Location = new System.Drawing.Point(507, 64);
            this.groupBox1period.Name = "groupBox1period";
            this.groupBox1period.Size = new System.Drawing.Size(265, 115);
            this.groupBox1period.TabIndex = 4;
            this.groupBox1period.TabStop = false;
            this.groupBox1period.Text = "Period";
            // 
            // radioButton4period
            // 
            this.radioButton4period.AutoSize = true;
            this.radioButton4period.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton4period.Location = new System.Drawing.Point(194, 25);
            this.radioButton4period.Name = "radioButton4period";
            this.radioButton4period.Size = new System.Drawing.Size(67, 23);
            this.radioButton4period.TabIndex = 11;
            this.radioButton4period.Text = "Period";
            this.radioButton4period.UseVisualStyleBackColor = true;
            this.radioButton4period.CheckedChanged += new System.EventHandler(this.radioButton4period_CheckedChanged);
            // 
            // label2from
            // 
            this.label2from.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2from.Location = new System.Drawing.Point(6, 51);
            this.label2from.Name = "label2from";
            this.label2from.Size = new System.Drawing.Size(45, 25);
            this.label2from.TabIndex = 9;
            this.label2from.Text = "From";
            this.label2from.Visible = false;
            // 
            // label3to
            // 
            this.label3to.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3to.Location = new System.Drawing.Point(26, 83);
            this.label3to.Name = "label3to";
            this.label3to.Size = new System.Drawing.Size(25, 25);
            this.label3to.TabIndex = 10;
            this.label3to.Text = "to";
            this.label3to.Visible = false;
            // 
            // radioButton3year
            // 
            this.radioButton3year.AutoSize = true;
            this.radioButton3year.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton3year.Location = new System.Drawing.Point(138, 25);
            this.radioButton3year.Name = "radioButton3year";
            this.radioButton3year.Size = new System.Drawing.Size(55, 23);
            this.radioButton3year.TabIndex = 7;
            this.radioButton3year.Text = "Year";
            this.radioButton3year.UseVisualStyleBackColor = true;
            this.radioButton3year.CheckedChanged += new System.EventHandler(this.radioButton3year_CheckedChanged);
            // 
            // radioButton1week
            // 
            this.radioButton1week.AutoSize = true;
            this.radioButton1week.Checked = true;
            this.radioButton1week.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1week.Location = new System.Drawing.Point(6, 25);
            this.radioButton1week.Name = "radioButton1week";
            this.radioButton1week.Size = new System.Drawing.Size(63, 23);
            this.radioButton1week.TabIndex = 5;
            this.radioButton1week.TabStop = true;
            this.radioButton1week.Text = "Week";
            this.radioButton1week.UseVisualStyleBackColor = true;
            this.radioButton1week.CheckedChanged += new System.EventHandler(this.radioButton1week_CheckedChanged);
            // 
            // radioButton2month
            // 
            this.radioButton2month.AutoSize = true;
            this.radioButton2month.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2month.Location = new System.Drawing.Point(70, 25);
            this.radioButton2month.Name = "radioButton2month";
            this.radioButton2month.Size = new System.Drawing.Size(67, 23);
            this.radioButton2month.TabIndex = 6;
            this.radioButton2month.Text = "Month";
            this.radioButton2month.UseVisualStyleBackColor = true;
            this.radioButton2month.CheckedChanged += new System.EventHandler(this.radioButton2month_CheckedChanged);
            // 
            // groupBox2show
            // 
            this.groupBox2show.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2show.Controls.Add(this.checkBox3intellectual);
            this.groupBox2show.Controls.Add(this.checkBox2emotional);
            this.groupBox2show.Controls.Add(this.checkBox1physical);
            this.groupBox2show.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2show.Location = new System.Drawing.Point(507, 185);
            this.groupBox2show.Name = "groupBox2show";
            this.groupBox2show.Size = new System.Drawing.Size(265, 100);
            this.groupBox2show.TabIndex = 0;
            this.groupBox2show.TabStop = false;
            this.groupBox2show.Text = "Show";
            // 
            // checkBox3intellectual
            // 
            this.checkBox3intellectual.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox3intellectual.Location = new System.Drawing.Point(6, 69);
            this.checkBox3intellectual.Name = "checkBox3intellectual";
            this.checkBox3intellectual.Size = new System.Drawing.Size(95, 25);
            this.checkBox3intellectual.TabIndex = 2;
            this.checkBox3intellectual.Text = "Intellectual";
            this.checkBox3intellectual.UseVisualStyleBackColor = true;
            // 
            // checkBox2emotional
            // 
            this.checkBox2emotional.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox2emotional.Location = new System.Drawing.Point(6, 47);
            this.checkBox2emotional.Name = "checkBox2emotional";
            this.checkBox2emotional.Size = new System.Drawing.Size(95, 25);
            this.checkBox2emotional.TabIndex = 1;
            this.checkBox2emotional.Text = "Emotional";
            this.checkBox2emotional.UseVisualStyleBackColor = true;
            // 
            // checkBox1physical
            // 
            this.checkBox1physical.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1physical.Location = new System.Drawing.Point(6, 25);
            this.checkBox1physical.Name = "checkBox1physical";
            this.checkBox1physical.Size = new System.Drawing.Size(95, 25);
            this.checkBox1physical.TabIndex = 0;
            this.checkBox1physical.Text = "Physical";
            this.checkBox1physical.UseVisualStyleBackColor = true;
            // 
            // label1dateofbirth
            // 
            this.label1dateofbirth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1dateofbirth.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1dateofbirth.Location = new System.Drawing.Point(572, 9);
            this.label1dateofbirth.Name = "label1dateofbirth";
            this.label1dateofbirth.Size = new System.Drawing.Size(200, 20);
            this.label1dateofbirth.TabIndex = 5;
            this.label1dateofbirth.Text = "Date of birth";
            this.label1dateofbirth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1buildabiorhythm
            // 
            this.button1buildabiorhythm.BackColor = System.Drawing.Color.Lime;
            this.button1buildabiorhythm.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1buildabiorhythm.Location = new System.Drawing.Point(32, 319);
            this.button1buildabiorhythm.Name = "button1buildabiorhythm";
            this.button1buildabiorhythm.Size = new System.Drawing.Size(165, 30);
            this.button1buildabiorhythm.TabIndex = 6;
            this.button1buildabiorhythm.Text = "Build a biorhythm";
            this.button1buildabiorhythm.UseVisualStyleBackColor = false;
            this.button1buildabiorhythm.Click += new System.EventHandler(this.button1buildabiorhythm_Click);
            // 
            // button3clear
            // 
            this.button3clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3clear.BackColor = System.Drawing.Color.Red;
            this.button3clear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3clear.Location = new System.Drawing.Point(405, 319);
            this.button3clear.Name = "button3clear";
            this.button3clear.Size = new System.Drawing.Size(55, 30);
            this.button3clear.TabIndex = 8;
            this.button3clear.Text = "Clear";
            this.button3clear.UseVisualStyleBackColor = false;
            this.button3clear.Click += new System.EventHandler(this.button3clear_Click);
            // 
            // checkBox4legends
            // 
            this.checkBox4legends.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox4legends.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox4legends.Location = new System.Drawing.Point(566, 288);
            this.checkBox4legends.Name = "checkBox4legends";
            this.checkBox4legends.Size = new System.Drawing.Size(155, 25);
            this.checkBox4legends.TabIndex = 9;
            this.checkBox4legends.Text = "Description of lines";
            this.checkBox4legends.UseVisualStyleBackColor = true;
            // 
            // checkBox53d
            // 
            this.checkBox53d.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox53d.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox53d.Location = new System.Drawing.Point(722, 288);
            this.checkBox53d.Name = "checkBox53d";
            this.checkBox53d.Size = new System.Drawing.Size(50, 25);
            this.checkBox53d.TabIndex = 10;
            this.checkBox53d.Text = "3D";
            this.checkBox53d.UseVisualStyleBackColor = true;
            // 
            // button2photo
            // 
            this.button2photo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button2photo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2photo.Location = new System.Drawing.Point(203, 319);
            this.button2photo.Name = "button2photo";
            this.button2photo.Size = new System.Drawing.Size(55, 30);
            this.button2photo.TabIndex = 12;
            this.button2photo.Text = "Photo";
            this.button2photo.UseVisualStyleBackColor = false;
            this.button2photo.Visible = false;
            this.button2photo.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1humanbiorhythm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.button2photo);
            this.Controls.Add(this.button3clear);
            this.Controls.Add(this.checkBox53d);
            this.Controls.Add(this.checkBox4legends);
            this.Controls.Add(this.button1buildabiorhythm);
            this.Controls.Add(this.groupBox1period);
            this.Controls.Add(this.label1dateofbirth);
            this.Controls.Add(this.groupBox2show);
            this.Controls.Add(this.chart1humanbiorhythm);
            this.Controls.Add(this.dateTimePicker1dateofbirth);
            this.Name = "Form1humanbiorhythm";
            this.Text = "Human biorhythm";
            ((System.ComponentModel.ISupportInitialize)(this.chart1humanbiorhythm)).EndInit();
            this.groupBox1period.ResumeLayout(false);
            this.groupBox1period.PerformLayout();
            this.groupBox2show.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1dateofbirth;
        private System.Windows.Forms.DateTimePicker dateTimePicker2fromdate;
        private System.Windows.Forms.DateTimePicker dateTimePicker3todate;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1humanbiorhythm;
        private System.Windows.Forms.GroupBox groupBox1period;
        private System.Windows.Forms.RadioButton radioButton3year;
        private System.Windows.Forms.RadioButton radioButton2month;
        private System.Windows.Forms.RadioButton radioButton1week;
        private System.Windows.Forms.GroupBox groupBox2show;
        private System.Windows.Forms.CheckBox checkBox3intellectual;
        private System.Windows.Forms.CheckBox checkBox2emotional;
        private System.Windows.Forms.CheckBox checkBox1physical;
        private System.Windows.Forms.Label label1dateofbirth;
        private System.Windows.Forms.Button button1buildabiorhythm;
        private System.Windows.Forms.Button button3clear;
        private System.Windows.Forms.Label label2from;
        private System.Windows.Forms.Label label3to;
        private System.Windows.Forms.CheckBox checkBox4legends;
        private System.Windows.Forms.CheckBox checkBox53d;
        private System.Windows.Forms.RadioButton radioButton4period;
        private System.Windows.Forms.Button button2photo;
    }
}

