namespace Receipt
{
    partial class Form1Receipt
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button3NewBuy = new System.Windows.Forms.Button();
            this.textBox1Abouttheproducts = new System.Windows.Forms.TextBox();
            this.panel1Product = new System.Windows.Forms.Panel();
            this.textBox3Discount = new System.Windows.Forms.TextBox();
            this.button1Add = new System.Windows.Forms.Button();
            this.label1Product = new System.Windows.Forms.Label();
            this.label2Productname = new System.Windows.Forms.Label();
            this.comboBox1Productname = new System.Windows.Forms.ComboBox();
            this.label3Price = new System.Windows.Forms.Label();
            this.textBox2Price = new System.Windows.Forms.TextBox();
            this.Label5Discount = new System.Windows.Forms.Label();
            this.label4Numberof = new System.Windows.Forms.Label();
            this.numericUpDown1Numberof = new System.Windows.Forms.NumericUpDown();
            this.panel2Abouttheproduct = new System.Windows.Forms.Panel();
            this.textBox5Total = new System.Windows.Forms.TextBox();
            this.label8Total = new System.Windows.Forms.Label();
            this.label6Abouttheproduct = new System.Windows.Forms.Label();
            this.textBox4Amountofdiscount = new System.Windows.Forms.TextBox();
            this.label7Amountofdiscount = new System.Windows.Forms.Label();
            this.button2Buy = new System.Windows.Forms.Button();
            this.textBox8AbouttheproductsCover = new System.Windows.Forms.TextBox();
            this.label12Abouttheproducts = new System.Windows.Forms.Label();
            this.panel3Payment = new System.Windows.Forms.Panel();
            this.textBox6Forpayment = new System.Windows.Forms.TextBox();
            this.label10Forpayment = new System.Windows.Forms.Label();
            this.label9Payment = new System.Windows.Forms.Label();
            this.label11Tothecashdesk = new System.Windows.Forms.Label();
            this.textBox7Tothecashdesk = new System.Windows.Forms.TextBox();
            this.button4Exit = new System.Windows.Forms.Button();
            this.panel1Product.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1Numberof)).BeginInit();
            this.panel2Abouttheproduct.SuspendLayout();
            this.panel3Payment.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3NewBuy
            // 
            this.button3NewBuy.BackColor = System.Drawing.Color.Red;
            this.button3NewBuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3NewBuy.Location = new System.Drawing.Point(348, 342);
            this.button3NewBuy.Name = "button3NewBuy";
            this.button3NewBuy.Size = new System.Drawing.Size(200, 32);
            this.button3NewBuy.TabIndex = 0;
            this.button3NewBuy.Text = "New Buy";
            this.button3NewBuy.UseVisualStyleBackColor = false;
            this.button3NewBuy.Click += new System.EventHandler(this.button3NewBuy_Click);
            // 
            // textBox1Abouttheproducts
            // 
            this.textBox1Abouttheproducts.BackColor = System.Drawing.Color.White;
            this.textBox1Abouttheproducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1Abouttheproducts.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1Abouttheproducts.Location = new System.Drawing.Point(348, 35);
            this.textBox1Abouttheproducts.Multiline = true;
            this.textBox1Abouttheproducts.Name = "textBox1Abouttheproducts";
            this.textBox1Abouttheproducts.ReadOnly = true;
            this.textBox1Abouttheproducts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1Abouttheproducts.Size = new System.Drawing.Size(200, 300);
            this.textBox1Abouttheproducts.TabIndex = 2;
            // 
            // panel1Product
            // 
            this.panel1Product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1Product.Controls.Add(this.textBox3Discount);
            this.panel1Product.Controls.Add(this.button1Add);
            this.panel1Product.Controls.Add(this.label1Product);
            this.panel1Product.Controls.Add(this.label2Productname);
            this.panel1Product.Controls.Add(this.comboBox1Productname);
            this.panel1Product.Controls.Add(this.label3Price);
            this.panel1Product.Controls.Add(this.textBox2Price);
            this.panel1Product.Controls.Add(this.Label5Discount);
            this.panel1Product.Controls.Add(this.label4Numberof);
            this.panel1Product.Controls.Add(this.numericUpDown1Numberof);
            this.panel1Product.Location = new System.Drawing.Point(12, 12);
            this.panel1Product.Name = "panel1Product";
            this.panel1Product.Size = new System.Drawing.Size(300, 150);
            this.panel1Product.TabIndex = 3;
            // 
            // textBox3Discount
            // 
            this.textBox3Discount.BackColor = System.Drawing.Color.White;
            this.textBox3Discount.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3Discount.Location = new System.Drawing.Point(109, 115);
            this.textBox3Discount.MaxLength = 3;
            this.textBox3Discount.Multiline = true;
            this.textBox3Discount.Name = "textBox3Discount";
            this.textBox3Discount.Size = new System.Drawing.Size(35, 20);
            this.textBox3Discount.TabIndex = 12;
            this.textBox3Discount.Text = "0";
            this.textBox3Discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox3Discount.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox3Discount_MouseClick);
            this.textBox3Discount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2Price_KeyPress);
            // 
            // button1Add
            // 
            this.button1Add.BackColor = System.Drawing.Color.Yellow;
            this.button1Add.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Add.Location = new System.Drawing.Point(222, 117);
            this.button1Add.Name = "button1Add";
            this.button1Add.Size = new System.Drawing.Size(75, 30);
            this.button1Add.TabIndex = 4;
            this.button1Add.Text = "Choose";
            this.button1Add.UseVisualStyleBackColor = false;
            this.button1Add.Click += new System.EventHandler(this.button1Add_Click);
            // 
            // label1Product
            // 
            this.label1Product.AutoSize = true;
            this.label1Product.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1Product.Location = new System.Drawing.Point(3, 12);
            this.label1Product.Name = "label1Product";
            this.label1Product.Size = new System.Drawing.Size(79, 24);
            this.label1Product.TabIndex = 6;
            this.label1Product.Text = "Product";
            // 
            // label2Productname
            // 
            this.label2Productname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2Productname.Location = new System.Drawing.Point(3, 41);
            this.label2Productname.Name = "label2Productname";
            this.label2Productname.Size = new System.Drawing.Size(100, 23);
            this.label2Productname.TabIndex = 7;
            this.label2Productname.Text = "Product name:";
            // 
            // comboBox1Productname
            // 
            this.comboBox1Productname.BackColor = System.Drawing.Color.White;
            this.comboBox1Productname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1Productname.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1Productname.FormattingEnabled = true;
            this.comboBox1Productname.Items.AddRange(new object[] {
            "Fanta",
            "Chips",
            "Coffee",
            "Bread",
            "Loaf",
            "Milk",
            "Sour cream",
            "Cheese",
            "Batter",
            "Mayonnaise",
            "Eggs",
            "Pasta",
            "Sugar",
            "Ground meat",
            "Ice cream"});
            this.comboBox1Productname.Location = new System.Drawing.Point(109, 41);
            this.comboBox1Productname.Name = "comboBox1Productname";
            this.comboBox1Productname.Size = new System.Drawing.Size(100, 23);
            this.comboBox1Productname.TabIndex = 9;
            // 
            // label3Price
            // 
            this.label3Price.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3Price.Location = new System.Drawing.Point(3, 67);
            this.label3Price.Name = "label3Price";
            this.label3Price.Size = new System.Drawing.Size(45, 20);
            this.label3Price.TabIndex = 8;
            this.label3Price.Text = "Price:";
            // 
            // textBox2Price
            // 
            this.textBox2Price.BackColor = System.Drawing.Color.White;
            this.textBox2Price.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2Price.Location = new System.Drawing.Point(109, 67);
            this.textBox2Price.MaxLength = 6;
            this.textBox2Price.Multiline = true;
            this.textBox2Price.Name = "textBox2Price";
            this.textBox2Price.Size = new System.Drawing.Size(50, 20);
            this.textBox2Price.TabIndex = 11;
            this.textBox2Price.Text = "0";
            this.textBox2Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox2Price.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox2Price_MouseClick);
            this.textBox2Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2Price_KeyPress);
            // 
            // Label5Discount
            // 
            this.Label5Discount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label5Discount.Location = new System.Drawing.Point(3, 115);
            this.Label5Discount.Name = "Label5Discount";
            this.Label5Discount.Size = new System.Drawing.Size(95, 20);
            this.Label5Discount.TabIndex = 10;
            this.Label5Discount.Text = "Discount (%):";
            // 
            // label4Numberof
            // 
            this.label4Numberof.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4Numberof.Location = new System.Drawing.Point(3, 90);
            this.label4Numberof.Name = "label4Numberof";
            this.label4Numberof.Size = new System.Drawing.Size(80, 20);
            this.label4Numberof.TabIndex = 9;
            this.label4Numberof.Text = "Number of:";
            // 
            // numericUpDown1Numberof
            // 
            this.numericUpDown1Numberof.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1Numberof.Location = new System.Drawing.Point(109, 90);
            this.numericUpDown1Numberof.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1Numberof.Name = "numericUpDown1Numberof";
            this.numericUpDown1Numberof.Size = new System.Drawing.Size(50, 22);
            this.numericUpDown1Numberof.TabIndex = 8;
            this.numericUpDown1Numberof.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown1Numberof.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel2Abouttheproduct
            // 
            this.panel2Abouttheproduct.BackColor = System.Drawing.Color.Aqua;
            this.panel2Abouttheproduct.Controls.Add(this.textBox5Total);
            this.panel2Abouttheproduct.Controls.Add(this.label8Total);
            this.panel2Abouttheproduct.Controls.Add(this.label6Abouttheproduct);
            this.panel2Abouttheproduct.Controls.Add(this.textBox4Amountofdiscount);
            this.panel2Abouttheproduct.Controls.Add(this.label7Amountofdiscount);
            this.panel2Abouttheproduct.Location = new System.Drawing.Point(12, 168);
            this.panel2Abouttheproduct.Name = "panel2Abouttheproduct";
            this.panel2Abouttheproduct.Size = new System.Drawing.Size(300, 100);
            this.panel2Abouttheproduct.TabIndex = 5;
            // 
            // textBox5Total
            // 
            this.textBox5Total.BackColor = System.Drawing.Color.White;
            this.textBox5Total.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5Total.Location = new System.Drawing.Point(54, 64);
            this.textBox5Total.Multiline = true;
            this.textBox5Total.Name = "textBox5Total";
            this.textBox5Total.ReadOnly = true;
            this.textBox5Total.Size = new System.Drawing.Size(120, 20);
            this.textBox5Total.TabIndex = 14;
            this.textBox5Total.Text = "0";
            this.textBox5Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8Total
            // 
            this.label8Total.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8Total.Location = new System.Drawing.Point(3, 64);
            this.label8Total.Name = "label8Total";
            this.label8Total.Size = new System.Drawing.Size(45, 20);
            this.label8Total.TabIndex = 0;
            this.label8Total.Text = "Total:";
            // 
            // label6Abouttheproduct
            // 
            this.label6Abouttheproduct.AutoSize = true;
            this.label6Abouttheproduct.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6Abouttheproduct.Location = new System.Drawing.Point(3, 12);
            this.label6Abouttheproduct.Name = "label6Abouttheproduct";
            this.label6Abouttheproduct.Size = new System.Drawing.Size(167, 24);
            this.label6Abouttheproduct.TabIndex = 9;
            this.label6Abouttheproduct.Text = "About the product";
            // 
            // textBox4Amountofdiscount
            // 
            this.textBox4Amountofdiscount.BackColor = System.Drawing.Color.White;
            this.textBox4Amountofdiscount.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4Amountofdiscount.Location = new System.Drawing.Point(139, 41);
            this.textBox4Amountofdiscount.Multiline = true;
            this.textBox4Amountofdiscount.Name = "textBox4Amountofdiscount";
            this.textBox4Amountofdiscount.ReadOnly = true;
            this.textBox4Amountofdiscount.Size = new System.Drawing.Size(35, 20);
            this.textBox4Amountofdiscount.TabIndex = 13;
            this.textBox4Amountofdiscount.Text = "0";
            this.textBox4Amountofdiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7Amountofdiscount
            // 
            this.label7Amountofdiscount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7Amountofdiscount.Location = new System.Drawing.Point(3, 41);
            this.label7Amountofdiscount.Name = "label7Amountofdiscount";
            this.label7Amountofdiscount.Size = new System.Drawing.Size(130, 20);
            this.label7Amountofdiscount.TabIndex = 1;
            this.label7Amountofdiscount.Text = "Amount of discount:";
            // 
            // button2Buy
            // 
            this.button2Buy.BackColor = System.Drawing.Color.Lime;
            this.button2Buy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2Buy.Location = new System.Drawing.Point(247, 67);
            this.button2Buy.Name = "button2Buy";
            this.button2Buy.Size = new System.Drawing.Size(50, 30);
            this.button2Buy.TabIndex = 8;
            this.button2Buy.Text = "Buy";
            this.button2Buy.UseVisualStyleBackColor = false;
            this.button2Buy.Click += new System.EventHandler(this.button2Buy_Click);
            // 
            // textBox8AbouttheproductsCover
            // 
            this.textBox8AbouttheproductsCover.BackColor = System.Drawing.Color.White;
            this.textBox8AbouttheproductsCover.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8AbouttheproductsCover.Location = new System.Drawing.Point(348, 35);
            this.textBox8AbouttheproductsCover.Multiline = true;
            this.textBox8AbouttheproductsCover.Name = "textBox8AbouttheproductsCover";
            this.textBox8AbouttheproductsCover.ReadOnly = true;
            this.textBox8AbouttheproductsCover.Size = new System.Drawing.Size(200, 300);
            this.textBox8AbouttheproductsCover.TabIndex = 6;
            // 
            // label12Abouttheproducts
            // 
            this.label12Abouttheproducts.BackColor = System.Drawing.Color.White;
            this.label12Abouttheproducts.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12Abouttheproducts.Location = new System.Drawing.Point(348, 12);
            this.label12Abouttheproducts.Name = "label12Abouttheproducts";
            this.label12Abouttheproducts.Size = new System.Drawing.Size(200, 23);
            this.label12Abouttheproducts.TabIndex = 7;
            this.label12Abouttheproducts.Text = "About The Products";
            this.label12Abouttheproducts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3Payment
            // 
            this.panel3Payment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3Payment.Controls.Add(this.textBox7Tothecashdesk);
            this.panel3Payment.Controls.Add(this.label11Tothecashdesk);
            this.panel3Payment.Controls.Add(this.textBox6Forpayment);
            this.panel3Payment.Controls.Add(this.label10Forpayment);
            this.panel3Payment.Controls.Add(this.label9Payment);
            this.panel3Payment.Controls.Add(this.button2Buy);
            this.panel3Payment.Location = new System.Drawing.Point(12, 274);
            this.panel3Payment.Name = "panel3Payment";
            this.panel3Payment.Size = new System.Drawing.Size(300, 100);
            this.panel3Payment.TabIndex = 8;
            // 
            // textBox6Forpayment
            // 
            this.textBox6Forpayment.BackColor = System.Drawing.Color.White;
            this.textBox6Forpayment.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6Forpayment.Location = new System.Drawing.Point(124, 40);
            this.textBox6Forpayment.MaxLength = 6;
            this.textBox6Forpayment.Multiline = true;
            this.textBox6Forpayment.Name = "textBox6Forpayment";
            this.textBox6Forpayment.ReadOnly = true;
            this.textBox6Forpayment.Size = new System.Drawing.Size(85, 20);
            this.textBox6Forpayment.TabIndex = 12;
            this.textBox6Forpayment.Text = "0";
            this.textBox6Forpayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10Forpayment
            // 
            this.label10Forpayment.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10Forpayment.Location = new System.Drawing.Point(3, 40);
            this.label10Forpayment.Name = "label10Forpayment";
            this.label10Forpayment.Size = new System.Drawing.Size(90, 20);
            this.label10Forpayment.TabIndex = 11;
            this.label10Forpayment.Text = "For payment:";
            // 
            // label9Payment
            // 
            this.label9Payment.AutoSize = true;
            this.label9Payment.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9Payment.Location = new System.Drawing.Point(3, 11);
            this.label9Payment.Name = "label9Payment";
            this.label9Payment.Size = new System.Drawing.Size(86, 24);
            this.label9Payment.TabIndex = 10;
            this.label9Payment.Text = "Payment";
            // 
            // label11Tothecashdesk
            // 
            this.label11Tothecashdesk.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11Tothecashdesk.Location = new System.Drawing.Point(3, 63);
            this.label11Tothecashdesk.Name = "label11Tothecashdesk";
            this.label11Tothecashdesk.Size = new System.Drawing.Size(115, 20);
            this.label11Tothecashdesk.TabIndex = 13;
            this.label11Tothecashdesk.Text = "To the cash desk:";
            // 
            // textBox7Tothecashdesk
            // 
            this.textBox7Tothecashdesk.BackColor = System.Drawing.Color.White;
            this.textBox7Tothecashdesk.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7Tothecashdesk.Location = new System.Drawing.Point(124, 63);
            this.textBox7Tothecashdesk.MaxLength = 6;
            this.textBox7Tothecashdesk.Multiline = true;
            this.textBox7Tothecashdesk.Name = "textBox7Tothecashdesk";
            this.textBox7Tothecashdesk.Size = new System.Drawing.Size(85, 20);
            this.textBox7Tothecashdesk.TabIndex = 14;
            this.textBox7Tothecashdesk.Text = "0";
            this.textBox7Tothecashdesk.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox7Tothecashdesk.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox7Tothecashdesk_MouseClick);
            this.textBox7Tothecashdesk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2Price_KeyPress);
            // 
            // button4Exit
            // 
            this.button4Exit.BackColor = System.Drawing.Color.Red;
            this.button4Exit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4Exit.ForeColor = System.Drawing.Color.White;
            this.button4Exit.Location = new System.Drawing.Point(560, -1);
            this.button4Exit.Name = "button4Exit";
            this.button4Exit.Size = new System.Drawing.Size(25, 25);
            this.button4Exit.TabIndex = 15;
            this.button4Exit.Text = "X";
            this.button4Exit.UseVisualStyleBackColor = false;
            this.button4Exit.Click += new System.EventHandler(this.button4Exit_Click);
            // 
            // Form1Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(584, 386);
            this.Controls.Add(this.button4Exit);
            this.Controls.Add(this.panel3Payment);
            this.Controls.Add(this.label12Abouttheproducts);
            this.Controls.Add(this.textBox8AbouttheproductsCover);
            this.Controls.Add(this.panel2Abouttheproduct);
            this.Controls.Add(this.panel1Product);
            this.Controls.Add(this.textBox1Abouttheproducts);
            this.Controls.Add(this.button3NewBuy);
            this.Name = "Form1Receipt";
            this.panel1Product.ResumeLayout(false);
            this.panel1Product.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1Numberof)).EndInit();
            this.panel2Abouttheproduct.ResumeLayout(false);
            this.panel2Abouttheproduct.PerformLayout();
            this.panel3Payment.ResumeLayout(false);
            this.panel3Payment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3NewBuy;
        private System.Windows.Forms.TextBox textBox1Abouttheproducts;
        private System.Windows.Forms.Panel panel1Product;
        private System.Windows.Forms.Label label1Product;
        private System.Windows.Forms.Button button1Add;
        private System.Windows.Forms.Panel panel2Abouttheproduct;
        private System.Windows.Forms.Label label4Numberof;
        private System.Windows.Forms.Label label3Price;
        private System.Windows.Forms.Label label2Productname;
        private System.Windows.Forms.NumericUpDown numericUpDown1Numberof;
        private System.Windows.Forms.Label Label5Discount;
        private System.Windows.Forms.TextBox textBox2Price;
        private System.Windows.Forms.Label label7Amountofdiscount;
        private System.Windows.Forms.Label label8Total;
        private System.Windows.Forms.TextBox textBox3Discount;
        private System.Windows.Forms.Button button2Buy;
        private System.Windows.Forms.Label label6Abouttheproduct;
        private System.Windows.Forms.ComboBox comboBox1Productname;
        private System.Windows.Forms.TextBox textBox5Total;
        private System.Windows.Forms.TextBox textBox4Amountofdiscount;
        private System.Windows.Forms.TextBox textBox8AbouttheproductsCover;
        private System.Windows.Forms.Label label12Abouttheproducts;
        private System.Windows.Forms.Panel panel3Payment;
        private System.Windows.Forms.Label label9Payment;
        private System.Windows.Forms.TextBox textBox6Forpayment;
        private System.Windows.Forms.Label label10Forpayment;
        private System.Windows.Forms.Label label11Tothecashdesk;
        private System.Windows.Forms.TextBox textBox7Tothecashdesk;
        private System.Windows.Forms.Button button4Exit;
    }
}

