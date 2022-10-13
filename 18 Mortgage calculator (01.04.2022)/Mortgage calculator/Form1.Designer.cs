
namespace Mortgage_calculator
{
    partial class Form1mortgagecalculator
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1annuity = new System.Windows.Forms.DataGridView();
            this.Numberofmonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monthlypayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remainingpayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chart1mortgagedata = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1calculate = new System.Windows.Forms.Button();
            this.groupBox1initialdata = new System.Windows.Forms.GroupBox();
            this.textBox4depositpercent = new System.Windows.Forms.TextBox();
            this.label1apartmentprice = new System.Windows.Forms.Label();
            this.textBox1apartmentprice = new System.Windows.Forms.TextBox();
            this.textBox3interestrate = new System.Windows.Forms.TextBox();
            this.label2creditperiod = new System.Windows.Forms.Label();
            this.textBox2creditperiod = new System.Windows.Forms.TextBox();
            this.label3interestrate = new System.Windows.Forms.Label();
            this.label4depositpercent = new System.Windows.Forms.Label();
            this.groupBox3total = new System.Windows.Forms.GroupBox();
            this.label6mortgage = new System.Windows.Forms.Label();
            this.textBox6mortgage = new System.Windows.Forms.TextBox();
            this.textBox9moreprofitable = new System.Windows.Forms.TextBox();
            this.label8differentiated = new System.Windows.Forms.Label();
            this.textBox8differentiated = new System.Windows.Forms.TextBox();
            this.textBox7annuity = new System.Windows.Forms.TextBox();
            this.label5depositmoney = new System.Windows.Forms.Label();
            this.textBox5depositmoney = new System.Windows.Forms.TextBox();
            this.label7annuity = new System.Windows.Forms.Label();
            this.button2clear = new System.Windows.Forms.Button();
            this.checkBox1annuity = new System.Windows.Forms.CheckBox();
            this.checkBox2differentiated = new System.Windows.Forms.CheckBox();
            this.groupBox2payment = new System.Windows.Forms.GroupBox();
            this.dataGridView2differentiated = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1annuity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1mortgagedata)).BeginInit();
            this.groupBox1initialdata.SuspendLayout();
            this.groupBox3total.SuspendLayout();
            this.groupBox2payment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2differentiated)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1annuity
            // 
            this.dataGridView1annuity.AllowUserToDeleteRows = false;
            this.dataGridView1annuity.AllowUserToResizeColumns = false;
            this.dataGridView1annuity.AllowUserToResizeRows = false;
            this.dataGridView1annuity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1annuity.BackgroundColor = System.Drawing.Color.Maroon;
            this.dataGridView1annuity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1annuity.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1annuity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1annuity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numberofmonth,
            this.Month,
            this.Monthlypayment,
            this.Remainingpayment});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1annuity.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1annuity.Location = new System.Drawing.Point(222, 12);
            this.dataGridView1annuity.Name = "dataGridView1annuity";
            this.dataGridView1annuity.ReadOnly = true;
            this.dataGridView1annuity.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1annuity.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1annuity.Size = new System.Drawing.Size(690, 150);
            this.dataGridView1annuity.TabIndex = 0;
            // 
            // Numberofmonth
            // 
            this.Numberofmonth.HeaderText = "№ (days)";
            this.Numberofmonth.Name = "Numberofmonth";
            this.Numberofmonth.ReadOnly = true;
            this.Numberofmonth.Width = 65;
            // 
            // Month
            // 
            this.Month.HeaderText = "Month, Year";
            this.Month.Name = "Month";
            this.Month.ReadOnly = true;
            this.Month.Width = 140;
            // 
            // Monthlypayment
            // 
            this.Monthlypayment.HeaderText = "Monthly payment (main + percent)";
            this.Monthlypayment.Name = "Monthlypayment";
            this.Monthlypayment.ReadOnly = true;
            this.Monthlypayment.Width = 225;
            // 
            // Remainingpayment
            // 
            this.Remainingpayment.HeaderText = "Remaining payment";
            this.Remainingpayment.Name = "Remainingpayment";
            this.Remainingpayment.ReadOnly = true;
            this.Remainingpayment.Width = 202;
            // 
            // chart1mortgagedata
            // 
            this.chart1mortgagedata.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1mortgagedata.BackColor = System.Drawing.Color.Maroon;
            chartArea1.Name = "ChartArea1";
            this.chart1mortgagedata.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Maroon;
            legend1.Name = "Legend1";
            this.chart1mortgagedata.Legends.Add(legend1);
            this.chart1mortgagedata.Location = new System.Drawing.Point(222, 324);
            this.chart1mortgagedata.Name = "chart1mortgagedata";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Green;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Annuity";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Red;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Differentiated";
            this.chart1mortgagedata.Series.Add(series1);
            this.chart1mortgagedata.Series.Add(series2);
            this.chart1mortgagedata.Size = new System.Drawing.Size(690, 215);
            this.chart1mortgagedata.TabIndex = 1;
            this.chart1mortgagedata.Text = "Mortgage data";
            title1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.Name = "Title1";
            title1.Text = "Mortgage data";
            this.chart1mortgagedata.Titles.Add(title1);
            // 
            // button1calculate
            // 
            this.button1calculate.BackColor = System.Drawing.Color.Lime;
            this.button1calculate.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1calculate.Location = new System.Drawing.Point(12, 247);
            this.button1calculate.Name = "button1calculate";
            this.button1calculate.Size = new System.Drawing.Size(204, 35);
            this.button1calculate.TabIndex = 2;
            this.button1calculate.Text = "Calculate";
            this.button1calculate.UseVisualStyleBackColor = false;
            this.button1calculate.Click += new System.EventHandler(this.button1calculate_Click);
            // 
            // groupBox1initialdata
            // 
            this.groupBox1initialdata.Controls.Add(this.textBox4depositpercent);
            this.groupBox1initialdata.Controls.Add(this.label1apartmentprice);
            this.groupBox1initialdata.Controls.Add(this.textBox1apartmentprice);
            this.groupBox1initialdata.Controls.Add(this.textBox3interestrate);
            this.groupBox1initialdata.Controls.Add(this.label2creditperiod);
            this.groupBox1initialdata.Controls.Add(this.textBox2creditperiod);
            this.groupBox1initialdata.Controls.Add(this.label3interestrate);
            this.groupBox1initialdata.Controls.Add(this.label4depositpercent);
            this.groupBox1initialdata.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1initialdata.Location = new System.Drawing.Point(12, 12);
            this.groupBox1initialdata.Name = "groupBox1initialdata";
            this.groupBox1initialdata.Size = new System.Drawing.Size(204, 140);
            this.groupBox1initialdata.TabIndex = 3;
            this.groupBox1initialdata.TabStop = false;
            this.groupBox1initialdata.Text = "Initial Data";
            // 
            // textBox4depositpercent
            // 
            this.textBox4depositpercent.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4depositpercent.Location = new System.Drawing.Point(157, 109);
            this.textBox4depositpercent.MaxLength = 5;
            this.textBox4depositpercent.Name = "textBox4depositpercent";
            this.textBox4depositpercent.Size = new System.Drawing.Size(41, 26);
            this.textBox4depositpercent.TabIndex = 11;
            this.textBox4depositpercent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4deposit_KeyPress);
            // 
            // label1apartmentprice
            // 
            this.label1apartmentprice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1apartmentprice.Location = new System.Drawing.Point(6, 22);
            this.label1apartmentprice.Name = "label1apartmentprice";
            this.label1apartmentprice.Size = new System.Drawing.Size(115, 26);
            this.label1apartmentprice.TabIndex = 4;
            this.label1apartmentprice.Text = "Apartment price";
            // 
            // textBox1apartmentprice
            // 
            this.textBox1apartmentprice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1apartmentprice.Location = new System.Drawing.Point(127, 22);
            this.textBox1apartmentprice.Name = "textBox1apartmentprice";
            this.textBox1apartmentprice.Size = new System.Drawing.Size(71, 26);
            this.textBox1apartmentprice.TabIndex = 8;
            this.textBox1apartmentprice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1apartmentprice_KeyDown);
            this.textBox1apartmentprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1apartmentprice_KeyPress);
            // 
            // textBox3interestrate
            // 
            this.textBox3interestrate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3interestrate.Location = new System.Drawing.Point(157, 80);
            this.textBox3interestrate.MaxLength = 5;
            this.textBox3interestrate.Name = "textBox3interestrate";
            this.textBox3interestrate.Size = new System.Drawing.Size(41, 26);
            this.textBox3interestrate.TabIndex = 10;
            this.textBox3interestrate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox3interestrate_KeyDown);
            this.textBox3interestrate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3interestrate_KeyPress);
            // 
            // label2creditperiod
            // 
            this.label2creditperiod.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2creditperiod.Location = new System.Drawing.Point(6, 51);
            this.label2creditperiod.Name = "label2creditperiod";
            this.label2creditperiod.Size = new System.Drawing.Size(155, 26);
            this.label2creditperiod.TabIndex = 5;
            this.label2creditperiod.Text = "Credit period (months)";
            // 
            // textBox2creditperiod
            // 
            this.textBox2creditperiod.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2creditperiod.Location = new System.Drawing.Point(167, 51);
            this.textBox2creditperiod.MaxLength = 3;
            this.textBox2creditperiod.Name = "textBox2creditperiod";
            this.textBox2creditperiod.Size = new System.Drawing.Size(31, 26);
            this.textBox2creditperiod.TabIndex = 9;
            this.textBox2creditperiod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2creditperiod_KeyDown);
            this.textBox2creditperiod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2creditperiod_KeyPress);
            // 
            // label3interestrate
            // 
            this.label3interestrate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3interestrate.Location = new System.Drawing.Point(6, 80);
            this.label3interestrate.Name = "label3interestrate";
            this.label3interestrate.Size = new System.Drawing.Size(145, 26);
            this.label3interestrate.TabIndex = 6;
            this.label3interestrate.Text = "Interest rate (%)";
            // 
            // label4depositpercent
            // 
            this.label4depositpercent.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4depositpercent.Location = new System.Drawing.Point(6, 109);
            this.label4depositpercent.Name = "label4depositpercent";
            this.label4depositpercent.Size = new System.Drawing.Size(145, 26);
            this.label4depositpercent.TabIndex = 7;
            this.label4depositpercent.Text = "Deposit (%)";
            // 
            // groupBox3total
            // 
            this.groupBox3total.Controls.Add(this.label6mortgage);
            this.groupBox3total.Controls.Add(this.textBox6mortgage);
            this.groupBox3total.Controls.Add(this.textBox9moreprofitable);
            this.groupBox3total.Controls.Add(this.label8differentiated);
            this.groupBox3total.Controls.Add(this.textBox8differentiated);
            this.groupBox3total.Controls.Add(this.textBox7annuity);
            this.groupBox3total.Controls.Add(this.label5depositmoney);
            this.groupBox3total.Controls.Add(this.textBox5depositmoney);
            this.groupBox3total.Controls.Add(this.label7annuity);
            this.groupBox3total.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3total.Location = new System.Drawing.Point(12, 324);
            this.groupBox3total.Name = "groupBox3total";
            this.groupBox3total.Size = new System.Drawing.Size(204, 215);
            this.groupBox3total.TabIndex = 4;
            this.groupBox3total.TabStop = false;
            this.groupBox3total.Text = "Total";
            // 
            // label6mortgage
            // 
            this.label6mortgage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6mortgage.Location = new System.Drawing.Point(6, 54);
            this.label6mortgage.Name = "label6mortgage";
            this.label6mortgage.Size = new System.Drawing.Size(100, 26);
            this.label6mortgage.TabIndex = 15;
            this.label6mortgage.Text = "Mortgage";
            // 
            // textBox6mortgage
            // 
            this.textBox6mortgage.BackColor = System.Drawing.Color.White;
            this.textBox6mortgage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox6mortgage.Location = new System.Drawing.Point(112, 54);
            this.textBox6mortgage.Name = "textBox6mortgage";
            this.textBox6mortgage.ReadOnly = true;
            this.textBox6mortgage.Size = new System.Drawing.Size(86, 26);
            this.textBox6mortgage.TabIndex = 16;
            // 
            // textBox9moreprofitable
            // 
            this.textBox9moreprofitable.BackColor = System.Drawing.Color.White;
            this.textBox9moreprofitable.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox9moreprofitable.Location = new System.Drawing.Point(6, 144);
            this.textBox9moreprofitable.Multiline = true;
            this.textBox9moreprofitable.Name = "textBox9moreprofitable";
            this.textBox9moreprofitable.ReadOnly = true;
            this.textBox9moreprofitable.Size = new System.Drawing.Size(192, 65);
            this.textBox9moreprofitable.TabIndex = 10;
            // 
            // label8differentiated
            // 
            this.label8differentiated.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8differentiated.Location = new System.Drawing.Point(6, 112);
            this.label8differentiated.Name = "label8differentiated";
            this.label8differentiated.Size = new System.Drawing.Size(100, 26);
            this.label8differentiated.TabIndex = 5;
            this.label8differentiated.Text = "Differentiated";
            // 
            // textBox8differentiated
            // 
            this.textBox8differentiated.BackColor = System.Drawing.Color.White;
            this.textBox8differentiated.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox8differentiated.Location = new System.Drawing.Point(112, 112);
            this.textBox8differentiated.Name = "textBox8differentiated";
            this.textBox8differentiated.ReadOnly = true;
            this.textBox8differentiated.Size = new System.Drawing.Size(86, 26);
            this.textBox8differentiated.TabIndex = 9;
            // 
            // textBox7annuity
            // 
            this.textBox7annuity.BackColor = System.Drawing.Color.White;
            this.textBox7annuity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox7annuity.Location = new System.Drawing.Point(112, 83);
            this.textBox7annuity.Name = "textBox7annuity";
            this.textBox7annuity.ReadOnly = true;
            this.textBox7annuity.Size = new System.Drawing.Size(86, 26);
            this.textBox7annuity.TabIndex = 8;
            // 
            // label5depositmoney
            // 
            this.label5depositmoney.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5depositmoney.Location = new System.Drawing.Point(6, 25);
            this.label5depositmoney.Name = "label5depositmoney";
            this.label5depositmoney.Size = new System.Drawing.Size(100, 26);
            this.label5depositmoney.TabIndex = 13;
            this.label5depositmoney.Text = "Deposit";
            // 
            // textBox5depositmoney
            // 
            this.textBox5depositmoney.BackColor = System.Drawing.Color.White;
            this.textBox5depositmoney.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox5depositmoney.Location = new System.Drawing.Point(112, 25);
            this.textBox5depositmoney.Name = "textBox5depositmoney";
            this.textBox5depositmoney.ReadOnly = true;
            this.textBox5depositmoney.Size = new System.Drawing.Size(86, 26);
            this.textBox5depositmoney.TabIndex = 14;
            // 
            // label7annuity
            // 
            this.label7annuity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7annuity.Location = new System.Drawing.Point(6, 83);
            this.label7annuity.Name = "label7annuity";
            this.label7annuity.Size = new System.Drawing.Size(100, 26);
            this.label7annuity.TabIndex = 4;
            this.label7annuity.Text = "Annuity";
            // 
            // button2clear
            // 
            this.button2clear.BackColor = System.Drawing.Color.Red;
            this.button2clear.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2clear.Location = new System.Drawing.Point(151, 288);
            this.button2clear.Name = "button2clear";
            this.button2clear.Size = new System.Drawing.Size(65, 30);
            this.button2clear.TabIndex = 5;
            this.button2clear.Text = "Clear";
            this.button2clear.UseVisualStyleBackColor = false;
            this.button2clear.Click += new System.EventHandler(this.button2clear_Click);
            // 
            // checkBox1annuity
            // 
            this.checkBox1annuity.AutoSize = true;
            this.checkBox1annuity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1annuity.Location = new System.Drawing.Point(6, 25);
            this.checkBox1annuity.Name = "checkBox1annuity";
            this.checkBox1annuity.Size = new System.Drawing.Size(74, 23);
            this.checkBox1annuity.TabIndex = 6;
            this.checkBox1annuity.Text = "Annuity";
            this.checkBox1annuity.UseVisualStyleBackColor = true;
            // 
            // checkBox2differentiated
            // 
            this.checkBox2differentiated.AutoSize = true;
            this.checkBox2differentiated.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox2differentiated.Location = new System.Drawing.Point(6, 47);
            this.checkBox2differentiated.Name = "checkBox2differentiated";
            this.checkBox2differentiated.Size = new System.Drawing.Size(109, 23);
            this.checkBox2differentiated.TabIndex = 7;
            this.checkBox2differentiated.Text = "Differentiated";
            this.checkBox2differentiated.UseVisualStyleBackColor = true;
            // 
            // groupBox2payment
            // 
            this.groupBox2payment.Controls.Add(this.checkBox1annuity);
            this.groupBox2payment.Controls.Add(this.checkBox2differentiated);
            this.groupBox2payment.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2payment.Location = new System.Drawing.Point(12, 158);
            this.groupBox2payment.Name = "groupBox2payment";
            this.groupBox2payment.Size = new System.Drawing.Size(204, 75);
            this.groupBox2payment.TabIndex = 12;
            this.groupBox2payment.TabStop = false;
            this.groupBox2payment.Text = "Payment";
            // 
            // dataGridView2differentiated
            // 
            this.dataGridView2differentiated.AllowUserToDeleteRows = false;
            this.dataGridView2differentiated.AllowUserToResizeColumns = false;
            this.dataGridView2differentiated.AllowUserToResizeRows = false;
            this.dataGridView2differentiated.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2differentiated.BackgroundColor = System.Drawing.Color.Maroon;
            this.dataGridView2differentiated.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2differentiated.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2differentiated.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2differentiated.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2differentiated.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2differentiated.Location = new System.Drawing.Point(222, 168);
            this.dataGridView2differentiated.Name = "dataGridView2differentiated";
            this.dataGridView2differentiated.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2differentiated.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView2differentiated.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView2differentiated.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView2differentiated.Size = new System.Drawing.Size(690, 150);
            this.dataGridView2differentiated.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "№ (days)";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 65;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Month, Year";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 140;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Monthly payment (main + percent)";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 225;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Remaining payment";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 202;
            // 
            // Form1mortgagecalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(924, 551);
            this.Controls.Add(this.dataGridView2differentiated);
            this.Controls.Add(this.groupBox2payment);
            this.Controls.Add(this.button2clear);
            this.Controls.Add(this.groupBox3total);
            this.Controls.Add(this.groupBox1initialdata);
            this.Controls.Add(this.button1calculate);
            this.Controls.Add(this.chart1mortgagedata);
            this.Controls.Add(this.dataGridView1annuity);
            this.Name = "Form1mortgagecalculator";
            this.Text = "Mortgage calculator";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1annuity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1mortgagedata)).EndInit();
            this.groupBox1initialdata.ResumeLayout(false);
            this.groupBox1initialdata.PerformLayout();
            this.groupBox3total.ResumeLayout(false);
            this.groupBox3total.PerformLayout();
            this.groupBox2payment.ResumeLayout(false);
            this.groupBox2payment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2differentiated)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1annuity;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1mortgagedata;
        private System.Windows.Forms.Button button1calculate;
        private System.Windows.Forms.GroupBox groupBox1initialdata;
        private System.Windows.Forms.TextBox textBox4depositpercent;
        private System.Windows.Forms.TextBox textBox3interestrate;
        private System.Windows.Forms.TextBox textBox1apartmentprice;
        private System.Windows.Forms.Label label4depositpercent;
        private System.Windows.Forms.Label label3interestrate;
        private System.Windows.Forms.Label label2creditperiod;
        private System.Windows.Forms.Label label1apartmentprice;
        private System.Windows.Forms.GroupBox groupBox3total;
        private System.Windows.Forms.Label label7annuity;
        private System.Windows.Forms.TextBox textBox7annuity;
        private System.Windows.Forms.Label label8differentiated;
        private System.Windows.Forms.TextBox textBox8differentiated;
        private System.Windows.Forms.Button button2clear;
        private System.Windows.Forms.CheckBox checkBox1annuity;
        private System.Windows.Forms.CheckBox checkBox2differentiated;
        private System.Windows.Forms.GroupBox groupBox2payment;
        private System.Windows.Forms.TextBox textBox2creditperiod;
        private System.Windows.Forms.TextBox textBox9moreprofitable;
        private System.Windows.Forms.Label label5depositmoney;
        private System.Windows.Forms.TextBox textBox5depositmoney;
        private System.Windows.Forms.DataGridView dataGridView2differentiated;
        private System.Windows.Forms.Label label6mortgage;
        private System.Windows.Forms.TextBox textBox6mortgage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numberofmonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monthlypayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remainingpayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}

