using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mortgage_calculator
{
    public partial class Form1mortgagecalculator : Form
    {
        public Form1mortgagecalculator()
        {
            InitializeComponent();
        }

        private void button1calculate_Click(object sender, EventArgs e)
        {
            //очищение информации в таблицах, диаграмме и полях с результатами в зависимости от состояния чекбоксов
            dataGridView1annuity.Rows.Clear();
            dataGridView2differentiated.Rows.Clear();
            chart1mortgagedata.Series[0].IsVisibleInLegend = false;
            chart1mortgagedata.Series[1].IsVisibleInLegend = false;
            chart1mortgagedata.Series[0].Points.Clear();
            chart1mortgagedata.Series[1].Points.Clear();
            textBox7annuity.Clear();
            textBox8differentiated.Clear();
            textBox9moreprofitable.Clear();
            //

            //не заполнен какой-либо текстбокс с основными данными
            if (textBox1apartmentprice.Text == "" || textBox2creditperiod.Text == "" || textBox3interestrate.Text == "" || textBox4depositpercent.Text == "")
                MessageBox.Show("Please, fill in the empty fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //
            //не выбран ни один чекбокс
            else if (checkBox1annuity.Checked == false && checkBox2differentiated.Checked == false)
                MessageBox.Show("Please, select the necessary type of payment", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //
            else
            {
                double apartm, irat, dperc, dmon, mortg, annuit, k, mpay, mpaypa, mpayma, different, mpaypd, mpaymd, rpay, diff;
                int cper, dinm, dtny, dtnm, dcurr, diny, per, row, nd, mon;

                apartm = Convert.ToDouble(textBox1apartmentprice.Text); //цена недвижимости
                cper = Convert.ToInt32(textBox2creditperiod.Text); //период кредитования
                //возможность ввода пользователем как точки, так и запятой
                if (textBox3interestrate.Text.Contains(".") || textBox4depositpercent.Text.Contains("."))
                {
                    if (textBox3interestrate.Text.Contains("."))
                        textBox3interestrate.Text = textBox3interestrate.Text.Replace('.', ',');
                    if (textBox4depositpercent.Text.Contains("."))
                        textBox4depositpercent.Text = textBox4depositpercent.Text.Replace('.', ',');
                    irat = Convert.ToDouble(textBox3interestrate.Text) / 12 / 100; //процентная ставка
                    dperc = Convert.ToDouble(textBox4depositpercent.Text); //процент первоначального взноса
                    if (textBox3interestrate.Text.Contains(","))
                        textBox3interestrate.Text = textBox3interestrate.Text.Replace(',', '.');
                    if (textBox4depositpercent.Text.Contains(","))
                        textBox4depositpercent.Text = textBox4depositpercent.Text.Replace(',', '.');
                }
                else
                {
                    irat = Convert.ToDouble(textBox3interestrate.Text) / 12 / 100;
                    dperc = Convert.ToDouble(textBox4depositpercent.Text);
                }
                //

                string[] months = { "January",
                                    "February",
                                    "March",
                                    "April",
                                    "May",
                                    "June",
                                    "July",
                                    "August",
                                    "September",
                                    "October",
                                    "November",
                                    "December", };

                annuit = 0; //аннуитетная схема
                different = 0; //дифференцированная схема

                dmon = (apartm * dperc) / 100; //первоначальный взнос
                textBox5depositmoney.Text = dmon.ToString();
                mortg = apartm - dmon; //ипотека, которая должна быть выплачена
                textBox6mortgage.Text = mortg.ToString();
                
                row = 1; //описывающая номер строки таблицы переменная ([столбец, строка]), которая будет меняться при ее заполнении на +1 при каждой новой итерации для возможности заполнения ячеек данными
                nd = 1; //номер периода кредитования
                mon = DateTime.Now.Month - 1; //название текущиго месяца, берущееся далее из массива по своему номеру
                if (checkBox1annuity.Checked)
                {
                    dataGridView1annuity.Rows.Add();
                    dataGridView1annuity[3, 0].Value = mortg; //заполнение третьего столбца первой строки таблицы суммой ипотеки

                    dtny = DateTime.Now.Year; //год
                    dtnm = DateTime.Now.Month; //месяц
                    dinm = DateTime.DaysInMonth(dtny, dtnm); //количество дней в месяце
                    k = (irat * Math.Pow(1 + irat, cper)) / (Math.Pow(1 + irat, cper) - 1); //коэффициент кредитования
                    mpay = Math.Round(k * mortg, 2); //месячный платеж
                    rpay = mortg; //оставшийся платеж
                    dcurr = 0; //переменная, помогающая добиться "смены месяцев" в цикле на +1
                    while (rpay > 0)
                    {
                        if (mon == 12)
                        {
                            mon = 0;
                            dtny += 1; //"смена года на +1"
                        }
                        if (dcurr == dinm)
                        {
                            if (dtnm == 12)
                                dtnm = 0;
                            dtnm += 1; //"начало года"
                            dcurr = 0;
                        }
                        dinm = DateTime.DaysInMonth(dtny, dtnm);
                        //определение количества дней в зависимости от его високосности
                        if (DateTime.IsLeapYear(DateTime.Now.Year))
                            diny = 366;
                        else
                            diny = 365;
                        //
                        mpaypa = Math.Round(rpay * irat * 12 * dinm / diny, 2); //платеж по процентам 
                        mpayma = mpay - mpaypa; //основной долг
                        rpay = Math.Round(rpay - mpayma, 2);
                        annuit += mpaypa;

                        dataGridView1annuity.Rows.Add();
                        dataGridView1annuity[0, row].Value = nd + " (" + dinm + ")";
                        dataGridView1annuity[1, row].Value = months[mon] + ", " + dtny;
                        dataGridView1annuity[2, row].Value = mpay + " (" + mpayma + " + " + mpaypa + ")";
                        dataGridView1annuity[3, row].Value = rpay;

                        chart1mortgagedata.Series[0].IsVisibleInLegend = true;
                        chart1mortgagedata.Series[0].Points.AddXY(nd, rpay);

                        row += 1;
                        nd += 1;
                        mon += 1;
                        dcurr += dinm;
                    }
                    textBox7annuity.Text = Math.Round(annuit).ToString();
                }
                row = 0;
                nd = 1;
                mon = DateTime.Now.Month - 1;
                dtny = DateTime.Now.Year;
                if (checkBox2differentiated.Checked)
                {
                    mpaymd = mortg / cper;
                    rpay = mortg;
                    per = 0;
                    while (rpay > 0)
                    {
                        if (mon == 12)
                        {
                            mon = 0;
                            dtny += 1;
                        }
                        rpay = mortg - (mpaymd * per);
                        mpaypd = irat * rpay;
                        different += mpaypd;
                        mpay = mpaymd + mpaypd;

                        dataGridView2differentiated.Rows.Add();
                        dataGridView2differentiated[0, row].Value = nd;
                        dataGridView2differentiated[1, row].Value = months[mon] + ", " + dtny;
                        dataGridView2differentiated[2, row].Value = mpay + " (" + mpaymd + " + " + mpaypd + ")";
                        dataGridView2differentiated[3, row].Value = rpay;

                        chart1mortgagedata.Series[1].IsVisibleInLegend = true;
                        chart1mortgagedata.Series[1].Points.AddXY(nd, rpay);

                        per += 1;
                        row += 1;
                        nd += 1;
                        mon += 1;
                    }
                    textBox8differentiated.Text = Math.Round(different).ToString();
                }
                //определение наиболее выгодной схемы платежа, если пользователем выбраны обе схемы
                if (checkBox1annuity.Checked && checkBox2differentiated.Checked)
                {
                    diff = Math.Round(annuit - different);
                    if (diff > 0)
                        textBox9moreprofitable.Text = "Differentiated payment more profitable than annuity payment by " + diff.ToString();
                    else if (diff < 0)
                    {
                        diff = Math.Abs(diff);
                        textBox9moreprofitable.Text = "Annuity payment more profitable than differentiated payment by " + diff.ToString();
                    }
                }
                //
            }
        }

        private void button2clear_Click(object sender, EventArgs e)
        {
            textBox1apartmentprice.Clear();
            textBox2creditperiod.Clear();
            textBox3interestrate.Clear();
            textBox4depositpercent.Clear();
            textBox5depositmoney.Clear();
            textBox6mortgage.Clear();
            textBox7annuity.Clear();
            textBox8differentiated.Clear();
            textBox9moreprofitable.Clear();
            checkBox1annuity.Checked = false;
            checkBox2differentiated.Checked = false;
            dataGridView1annuity.Rows.Clear();
            dataGridView2differentiated.Rows.Clear();
            chart1mortgagedata.Series[0].IsVisibleInLegend = false;
            chart1mortgagedata.Series[1].IsVisibleInLegend = false;
            chart1mortgagedata.Series[0].Points.Clear();
            chart1mortgagedata.Series[1].Points.Clear();
        }
        //перемещение между текстбоксами при помощи "Enter"
        private void textBox1apartmentprice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox2creditperiod.Focus();
        }

        private void textBox2creditperiod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox3interestrate.Focus();
        }

        private void textBox3interestrate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox4depositpercent.Focus();
        }
        //

        //контроль над вводом
        private void textBox1apartmentprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox2creditperiod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox3interestrate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != '.' && e.KeyChar != ',') || ((e.KeyChar == '.' || e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1 || (sender as TextBox).Text.IndexOf(',') > -1)))
                e.Handled = true;
            else if (textBox3interestrate.Text == "" && (e.KeyChar == '.' || e.KeyChar == ','))
                e.Handled = true;
            else
                e.Handled = false;
        }

        private void textBox4deposit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != '.' && e.KeyChar != ',') || ((e.KeyChar == '.' || e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1 || (sender as TextBox).Text.IndexOf(',') > -1)) || (textBox4depositpercent.Text.StartsWith(".") || textBox4depositpercent.Text.StartsWith(",")))
                e.Handled = true;
            else if (textBox4depositpercent.Text == "" && (e.KeyChar == '.' || e.KeyChar == ','))
                e.Handled = true;
            else
                e.Handled = false;
        }
        //
    }
}
