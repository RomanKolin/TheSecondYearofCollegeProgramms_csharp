using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Body_Calculator
{
    public partial class Form1BodyCalculator : Form
    {
        public Form1BodyCalculator() //Размер формы и подсказки (при наведении на пункты groupbox "Your Lifestyle")
        {
            InitializeComponent();

            Size = new Size(1150, 575);

            ToolTip m = new ToolTip();
            m.SetToolTip(radioButton7Lifestyle, "easy sports exercises about 1-3 times per week");
            ToolTip h = new ToolTip();
            h.SetToolTip(radioButton8Lifestyle, "training 3-5 times per week");
            ToolTip vh = new ToolTip();
            vh.SetToolTip(radioButton9Lifestyle, "active lifestyle, training 6-7 times per week");
            ToolTip mh = new ToolTip();
            mh.SetToolTip(radioButton10Lifestyle, "sporty lifestyle, everyday training, phisycal labor");
        }

        private void button1Calculate_Click(object sender, EventArgs e)
        {
            try //Обработка исключений (проверка на ввод пользователем числовых значений)
            {
                textBox1Result.Text = ""; //Возможность вывода новых результатов на "чистый" textbox (если посчитан результат со старыми данными)

                double weig, heig, ag, k, bmi, ibwkr, mibwkr, ibwc, mibwc, ibwl, mibwl, cal, ycal, calm, call, calb, calh, calk, calro;

                weig = Convert.ToDouble(textBox2Weight.Text);
                heig = Convert.ToDouble(textBox3Height.Text);
                ag = Convert.ToDouble(textBox4Age.Text);

                if ((weig < 30 || weig > 300) || (heig < 140 || heig > 250) || (ag < 14 || ag > 100)) //Проверка на неподходящие значения
                {
                    label4Error.Visible = true;
                }
                else //Расчеты
                {
                    label4Error.Visible = false;
                    
                    bmi = weig / Math.Pow(heig / 100, 2); //Индекс массы тела
                    if (bmi < 18.5)
                    {
                        textBox1Result.Text += "Body Mass Index: " + Math.Round(bmi, 2) + " - " + "Underweight " + Environment.NewLine;
                    }
                    else if (bmi >= 18.5 && bmi <= 24.9)
                    {
                        textBox1Result.Text += "Body Mass Index: " + Math.Round(bmi, 2) + " - " + "Normal weight" + Environment.NewLine;
                    }
                    else if (bmi >= 25 && bmi <= 29.9)
                    {
                        textBox1Result.Text += "Body Mass Index: " + Math.Round(bmi, 2) + " - " + "Overweight" + Environment.NewLine;
                    }
                    else if (bmi >= 30 && bmi <= 34.9)
                    {
                        textBox1Result.Text += "Body Mass Index: " + Math.Round(bmi, 2) + " - " + "Obese (Class I)" + Environment.NewLine;
                    }
                    else if (bmi >= 35 && bmi <= 39.9)
                    {
                        textBox1Result.Text += "Body Mass Index: " + Math.Round(bmi, 2) + " - " + "Obese (Class II)" + Environment.NewLine;
                    }
                    else
                    {
                        textBox1Result.Text += "Body Mass Index: " + Math.Round(bmi, 2) + " - " + "Obese (Class III)" + Environment.NewLine;
                    }

                    if (radioButton1Wrist.Checked) //Типы телосложения (< 15) и формула идеального веса Креффа
                    {
                        textBox1Result.Text += "You have an asthenic body type" + Environment.NewLine + Environment.NewLine;
                        k = 0.9;
                        if (heig < 155)
                        {
                            ibwkr = (heig - 95 + (ag / 10)) * 0.9 * k;
                            mibwkr = ibwkr - weig;
                            textBox1Result.Text += "Ideal Body Weight (Kreff): " + Math.Round(ibwkr, 2) + " kg (the difference is " + Math.Round(Math.Abs(mibwkr), 2) + " kg)" + Environment.NewLine;
                        }
                        else if (heig >= 155 && heig < 175)
                        {
                            ibwkr = (heig - 100 + (ag / 10)) * 0.9 * k;
                            mibwkr = ibwkr - weig;
                            textBox1Result.Text += "Ideal Body Weight (Kreff): " + Math.Round(ibwkr, 2) + " kg (the difference is " + Math.Round(Math.Abs(mibwkr), 2) + " kg)" + Environment.NewLine;
                        }
                        else
                        {
                            ibwkr = (heig - 110 + (ag / 10)) * 0.9 * k;
                            mibwkr = ibwkr - weig;
                            textBox1Result.Text += "Ideal Body Weight (Kreff): " + Math.Round(ibwkr, 2) + " kg (the difference is " + Math.Round(Math.Abs(mibwkr), 2) + " kg)" + Environment.NewLine;
                        }
                    }
                    else if (radioButton2Wrist.Checked) //Типы телосложения (> 15 и < 17) и формула идеального веса Креффа
                    {
                        textBox1Result.Text += "You have a normosthenic body type" + Environment.NewLine + Environment.NewLine;
                        k = 1;
                        if (heig < 155)
                        {
                            ibwkr = (heig - 95 + (ag / 10)) * 0.9 * k;
                            mibwkr = ibwkr - weig;
                            textBox1Result.Text += "Ideal Body Weight (Kreff): " + Math.Round(ibwkr, 2) + " kg (the difference is " + Math.Round(Math.Abs(mibwkr), 2) + " kg)" + Environment.NewLine;
                        }
                        else if (heig >= 155 && heig < 175)
                        {
                            ibwkr = (heig - 100 + (ag / 10)) * 0.9 * k;
                            mibwkr = ibwkr - weig;
                            textBox1Result.Text += "Ideal Body Weight (Kreff): " + Math.Round(ibwkr, 2) + " kg (the difference is " + Math.Round(Math.Abs(mibwkr), 2) + " kg)" + Environment.NewLine;
                        }
                        else
                        {
                            ibwkr = (heig - 110 + (ag / 10)) * 0.9 * k;
                            mibwkr = ibwkr - weig;
                            textBox1Result.Text += "Ideal Body Weight (Kreff): " + Math.Round(ibwkr, 2) + " kg (the difference is " + Math.Round(Math.Abs(mibwkr), 2) + " kg)" + Environment.NewLine;
                        }
                    }
                    else if (radioButton3Wrist.Checked) //Типы телосложения (> 17) и формула идеального веса Креффа
                    {
                        textBox1Result.Text += "You have an hypersthenic body type" + Environment.NewLine + Environment.NewLine;
                        k = 1.1;
                        if (heig < 155)
                        {
                            ibwkr = (heig - 95 + (ag / 10)) * 0.9 * k;
                            mibwkr = ibwkr - weig;
                            textBox1Result.Text += "Ideal Body Weight (Kreff): " + Math.Round(ibwkr, 2) + " kg (the difference is " + Math.Round(Math.Abs(mibwkr), 2) + " kg)" + Environment.NewLine;
                        }
                        else if (heig >= 155 && heig < 175)
                        {
                            ibwkr = (heig - 100 + (ag / 10)) * 0.9 * k;
                            mibwkr = ibwkr - weig;
                            textBox1Result.Text += "Ideal Body Weight (Kreff): " + Math.Round(ibwkr, 2) + " kg (the difference is " + Math.Round(Math.Abs(mibwkr), 2) + " kg)" + Environment.NewLine;
                        }
                        else
                        {
                            ibwkr = (heig - 110 + (ag / 10)) * 0.9 * k;
                            mibwkr = ibwkr - weig;
                            textBox1Result.Text += "Ideal Body Weight (Kreff): " + Math.Round(ibwkr, 2) + " kg (the difference is " + Math.Round(Math.Abs(mibwkr), 2) + " kg)" + Environment.NewLine;
                        }
                    }
                    if (radioButton4Sex.Checked) //Формула идеального веса Купера (для мужчин)
                    {
                        ibwc = ((heig * 4 / 2.54) - 128) * 0.453;
                        mibwc = ibwc - weig;
                        textBox1Result.Text += "Ideal Body Weight (Cooper): " + Math.Round(ibwc, 2) + " kg (the difference is " + Math.Round(Math.Abs(mibwc), 2) + " kg)" + Environment.NewLine;
                    }
                    else if (radioButton5Sex.Checked) //Формула идеального веса Купера (для женщин)
                    {
                        ibwc = ((heig * 3.5 / 2.54) - 108) * 0.453;
                        mibwc = ibwc - weig;
                        textBox1Result.Text += "Ideal Body Weight (Cooper): " + Math.Round(ibwc, 2) + " kg (the difference is " + Math.Round(Math.Abs(mibwc), 2) + " kg)" + Environment.NewLine;
                    }
                    if (radioButton4Sex.Checked) //Формула идеального веса Лоренца (для мужчин)
                    {
                        ibwl = heig - 100 - ((heig - 150) / 4);
                        mibwl = ibwl - weig;
                        textBox1Result.Text += "Ideal Body Weight (Lorenz): " + Math.Round(ibwl, 2) + " kg (the difference is " + Math.Round(Math.Abs(mibwl), 2) + " kg)" + Environment.NewLine + Environment.NewLine;
                    }
                    else if (radioButton5Sex.Checked) //Формула идеального веса Лоренца (для женщин)
                    {
                        ibwl = heig - 100 - ((heig - 150) / 2);
                        mibwl = ibwl - weig;
                        textBox1Result.Text += "Ideal Body Weight (Lorenz): " + Math.Round(ibwl, 2) + " kg (the difference is " + Math.Round(Math.Abs(mibwl), 2) + " kg)" + Environment.NewLine + Environment.NewLine;
                    }
                    //Расчет калорий (суточная потребность, суточная потребность при образе жизни человека и расход калорий на органы)
                    if (radioButton4Sex.Checked) //Для мужчин
                    {
                        cal = 66 + ((13.7 * weig) + (5 * heig) - (6.8 * ag));
                        textBox1Result.Text += "Daily calories needs: " + Math.Round(cal) + " cal" + Environment.NewLine;
                        if (radioButton6Lifestyle.Checked) //При малоподвижном образе жизни
                        {
                            ycal = cal * 1.2;
                            textBox1Result.Text += "Daily calories needs for your lifestyle: " + Math.Round(ycal) + " cal" + Environment.NewLine;
                            calm = ycal * 0.26;
                            textBox1Result.Text += "Calories needs for muscles: " + Math.Round(calm) + " cal" + Environment.NewLine;
                            call = ycal * 0.26;
                            textBox1Result.Text += "Calories needs for liver: " + Math.Round(call) + " cal" + Environment.NewLine;
                            calb = ycal * 0.18;
                            textBox1Result.Text += "Calories needs for brain: " + Math.Round(calb) + " cal" + Environment.NewLine;
                            calh = ycal * 0.09;
                            textBox1Result.Text += "Calories needs for heart: " + Math.Round(calh) + " cal" + Environment.NewLine;
                            calk = ycal * 0.07;
                            textBox1Result.Text += "Calories needs for kidneys: " + Math.Round(calk) + " cal" + Environment.NewLine;
                            calro = ycal * 0.14;
                            textBox1Result.Text += "Calories needs for the rest organs: " + Math.Round(calro) + " cal" + Environment.NewLine;
                        }
                        else if (radioButton7Lifestyle.Checked) //При умеренном образе жизни
                        {
                            ycal = cal * 1.38;
                            textBox1Result.Text += "Daily calories needs for your lifestyle: " + Math.Round(ycal) + " cal" + Environment.NewLine;
                            calm = ycal * 0.26;
                            textBox1Result.Text += "Calories needs for muscles: " + Math.Round(calm) + " cal" + Environment.NewLine;
                            call = ycal * 0.26;
                            textBox1Result.Text += "Calories needs for liver: " + Math.Round(call) + " cal" + Environment.NewLine;
                            calb = ycal * 0.18;
                            textBox1Result.Text += "Calories needs for brain: " + Math.Round(calb) + " cal" + Environment.NewLine;
                            calh = ycal * 0.09;
                            textBox1Result.Text += "Calories needs for heart: " + Math.Round(calh) + " cal" + Environment.NewLine;
                            calk = ycal * 0.07;
                            textBox1Result.Text += "Calories needs for kidneys: " + Math.Round(calk) + " cal" + Environment.NewLine;
                            calro = ycal * 0.14;
                            textBox1Result.Text += "Calories needs for the rest organs: " + Math.Round(calro) + " cal" + Environment.NewLine;
                        }
                        else if (radioButton8Lifestyle.Checked) //При высокой физической активности
                        {
                            ycal = cal * 1.56;
                            textBox1Result.Text += "Daily calories needs for your lifestyle: " + Math.Round(ycal) + " cal" + Environment.NewLine;
                            calm = ycal * 0.26;
                            textBox1Result.Text += "Calories needs for muscles: " + Math.Round(calm) + " cal" + Environment.NewLine;
                            call = ycal * 0.26;
                            textBox1Result.Text += "Calories needs for liver: " + Math.Round(call) + " cal" + Environment.NewLine;
                            calb = ycal * 0.18;
                            textBox1Result.Text += "Calories needs for brain: " + Math.Round(calb) + " cal" + Environment.NewLine;
                            calh = ycal * 0.09;
                            textBox1Result.Text += "Calories needs for heart: " + Math.Round(calh) + " cal" + Environment.NewLine;
                            calk = ycal * 0.07;
                            textBox1Result.Text += "Calories needs for kidneys: " + Math.Round(calk) + " cal" + Environment.NewLine;
                            calro = ycal * 0.14;
                            textBox1Result.Text += "Calories needs for the rest organs: " + Math.Round(calro) + " cal" + Environment.NewLine;
                        }
                        else if (radioButton9Lifestyle.Checked) //При очень высокой физической активности
                        {
                            ycal = cal * 1.73;
                            textBox1Result.Text += "Daily calories needs for your lifestyle: " + Math.Round(ycal) + " cal" + Environment.NewLine;
                            calm = ycal * 0.26;
                            textBox1Result.Text += "Calories needs for muscles: " + Math.Round(calm) + " cal" + Environment.NewLine;
                            call = ycal * 0.26;
                            textBox1Result.Text += "Calories needs for liver: " + Math.Round(call) + " cal" + Environment.NewLine;
                            calb = ycal * 0.18;
                            textBox1Result.Text += "Calories needs for brain: " + Math.Round(calb) + " cal" + Environment.NewLine;
                            calh = ycal * 0.09;
                            textBox1Result.Text += "Calories needs for heart: " + Math.Round(calh) + " cal" + Environment.NewLine;
                            calk = ycal * 0.07;
                            textBox1Result.Text += "Calories needs for kidneys: " + Math.Round(calk) + " cal" + Environment.NewLine;
                            calro = ycal * 0.14;
                            textBox1Result.Text += "Calories needs for the rest organs: " + Math.Round(calro) + " cal" + Environment.NewLine;
                        }
                        else if (radioButton10Lifestyle.Checked) //При максимально высокой физической активности
                        {
                            ycal = cal * 1.95;
                            textBox1Result.Text += "Daily calories needs for your lifestyle: " + Math.Round(ycal) + " cal" + Environment.NewLine;
                            calm = ycal * 0.26;
                            textBox1Result.Text += "Calories needs for muscles: " + Math.Round(calm) + " cal" + Environment.NewLine;
                            call = ycal * 0.26;
                            textBox1Result.Text += "Calories needs for liver: " + Math.Round(call) + " cal" + Environment.NewLine;
                            calb = ycal * 0.18;
                            textBox1Result.Text += "Calories needs for brain: " + Math.Round(calb) + " cal" + Environment.NewLine;
                            calh = ycal * 0.09;
                            textBox1Result.Text += "Calories needs for heart: " + Math.Round(calh) + " cal" + Environment.NewLine;
                            calk = ycal * 0.07;
                            textBox1Result.Text += "Calories needs for kidneys: " + Math.Round(calk) + " cal" + Environment.NewLine;
                            calro = ycal * 0.14;
                            textBox1Result.Text += "Calories needs for the rest organs: " + Math.Round(calro) + " cal" + Environment.NewLine;
                        }
                    }
                    else if (radioButton5Sex.Checked) //Для женщин
                    {
                        cal = 655 + ((9.6 * weig) + (1.8 * heig) - (4.7 * ag));
                        textBox1Result.Text += "Daily calories needs: " + Math.Round(cal).ToString() + " cal" + Environment.NewLine;
                        if (radioButton6Lifestyle.Checked) //При малоподвижном образе жизни
                        {
                            ycal = cal * 1.2;
                            textBox1Result.Text += "Daily calories needs for your lifestyle: " + Math.Round(ycal) + " cal" + Environment.NewLine;
                            calm = ycal * 0.26;
                            textBox1Result.Text += "Calories needs for muscles: " + Math.Round(calm) + " cal" + Environment.NewLine;
                            call = ycal * 0.26;
                            textBox1Result.Text += "Calories needs for liver: " + Math.Round(call) + " cal" + Environment.NewLine;
                            calb = ycal * 0.18;
                            textBox1Result.Text += "Calories needs for brain: " + Math.Round(calb) + " cal" + Environment.NewLine;
                            calh = ycal * 0.09;
                            textBox1Result.Text += "Calories needs for heart: " + Math.Round(calh) + " cal" + Environment.NewLine;
                            calk = ycal * 0.07;
                            textBox1Result.Text += "Calories needs for kidneys: " + Math.Round(calk) + " cal" + Environment.NewLine;
                            calro = ycal * 0.14;
                            textBox1Result.Text += "Calories needs for the rest organs: " + Math.Round(calro) + " cal" + Environment.NewLine;
                        }
                        else if (radioButton7Lifestyle.Checked) //При умеренном образе жизни
                        {
                            ycal = cal * 1.38;
                            textBox1Result.Text += "Daily calories needs for your lifestyle: " + Math.Round(ycal) + " cal" + Environment.NewLine;
                            calm = ycal * 0.26;
                            textBox1Result.Text += "Calories needs for muscles: " + Math.Round(calm) + " cal" + Environment.NewLine;
                            call = ycal * 0.26;
                            textBox1Result.Text += "Calories needs for liver: " + Math.Round(call) + " cal" + Environment.NewLine;
                            calb = ycal * 0.18;
                            textBox1Result.Text += "Calories needs for brain: " + Math.Round(calb) + " cal" + Environment.NewLine;
                            calh = ycal * 0.09;
                            textBox1Result.Text += "Calories needs for heart: " + Math.Round(calh) + " cal" + Environment.NewLine;
                            calk = ycal * 0.07;
                            textBox1Result.Text += "Calories needs for kidneys: " + Math.Round(calk) + " cal" + Environment.NewLine;
                            calro = ycal * 0.14;
                            textBox1Result.Text += "Calories needs for the rest organs: " + Math.Round(calro) + " cal" + Environment.NewLine;
                        }
                        else if (radioButton8Lifestyle.Checked) //При высокой физической активности
                        {
                            ycal = cal * 1.56;
                            textBox1Result.Text += "Daily calories needs for your lifestyle: " + Math.Round(ycal) + " cal" + Environment.NewLine;
                            calm = ycal * 0.26;
                            textBox1Result.Text += "Calories needs for muscles: " + Math.Round(calm) + " cal" + Environment.NewLine;
                            call = ycal * 0.26;
                            textBox1Result.Text += "Calories needs for liver: " + Math.Round(call) + " cal" + Environment.NewLine;
                            calb = ycal * 0.18;
                            textBox1Result.Text += "Calories needs for brain: " + Math.Round(calb) + " cal" + Environment.NewLine;
                            calh = ycal * 0.09;
                            textBox1Result.Text += "Calories needs for heart: " + Math.Round(calh) + " cal" + Environment.NewLine;
                            calk = ycal * 0.07;
                            textBox1Result.Text += "Calories needs for kidneys: " + Math.Round(calk) + " cal" + Environment.NewLine;
                            calro = ycal * 0.14;
                            textBox1Result.Text += "Calories needs for the rest organs: " + Math.Round(calro) + " cal" + Environment.NewLine;
                        }
                        else if (radioButton9Lifestyle.Checked) //При очень высокой физической активности
                        {
                            ycal = cal * 1.73;
                            textBox1Result.Text += "Daily calories needs for your lifestyle: " + Math.Round(ycal) + " cal" + Environment.NewLine;
                            calm = ycal * 0.26;
                            textBox1Result.Text += "Calories needs for muscles: " + Math.Round(calm) + " cal" + Environment.NewLine;
                            call = ycal * 0.26;
                            textBox1Result.Text += "Calories needs for liver: " + Math.Round(call) + " cal" + Environment.NewLine;
                            calb = ycal * 0.18;
                            textBox1Result.Text += "Calories needs for brain: " + Math.Round(calb) + " cal" + Environment.NewLine;
                            calh = ycal * 0.09;
                            textBox1Result.Text += "Calories needs for heart: " + Math.Round(calh) + " cal" + Environment.NewLine;
                            calk = ycal * 0.07;
                            textBox1Result.Text += "Calories needs for kidneys: " + Math.Round(calk) + " cal" + Environment.NewLine;
                            calro = ycal * 0.14;
                            textBox1Result.Text += "Calories needs for the rest organs: " + Math.Round(calro) + " cal" + Environment.NewLine;
                        }
                        else if (radioButton10Lifestyle.Checked) //При максимально высокой физической активности
                        {
                            ycal = cal * 1.95;
                            textBox1Result.Text += "Daily calories needs for your lifestyle: " + Math.Round(ycal) + " cal" + Environment.NewLine;
                            calm = ycal * 0.26;
                            textBox1Result.Text += "Calories needs for muscles: " + Math.Round(calm) + " cal" + Environment.NewLine;
                            call = ycal * 0.26;
                            textBox1Result.Text += "Calories needs for liver: " + Math.Round(call) + " cal" + Environment.NewLine;
                            calb = ycal * 0.18;
                            textBox1Result.Text += "Calories needs for brain: " + Math.Round(calb) + " cal" + Environment.NewLine;
                            calh = ycal * 0.09;
                            textBox1Result.Text += "Calories needs for heart: " + Math.Round(calh) + " cal" + Environment.NewLine;
                            calk = ycal * 0.07;
                            textBox1Result.Text += "Calories needs for kidneys: " + Math.Round(calk) + " cal" + Environment.NewLine;
                            calro = ycal * 0.14;
                            textBox1Result.Text += "Calories needs for the rest organs: " + Math.Round(calro) + " cal" + Environment.NewLine;
                        }
                    }
                }
            }
            catch //Обработка исключений (если не числовые значения)
            { 
                label4Error.Visible = true;
            }
        }

        private void textBox2Weight_KeyDown(object sender, KeyEventArgs e) //Enter для перехода между textbox (weight-height)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox3Height.Focus();
            }
        }
        private void textBox3Height_KeyDown(object sender, KeyEventArgs e) //Enter для перехода между textbox (height-age)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox4Age.Focus();
            }
        }
    }
}
