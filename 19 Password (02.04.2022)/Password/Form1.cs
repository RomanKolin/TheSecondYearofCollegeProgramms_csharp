using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;
using System.Threading;

namespace Password
{
    public partial class Form1password : Form
    {
        public Form1password()
        {
            InitializeComponent();
        }

        private void pictureBox1ilovecoding_MouseClick(object sender, MouseEventArgs e)
        {
            string colleg = "http://www.spbkit.edu.ru/";
            System.Diagnostics.Process.Start(colleg);
        }

        private void Form1password_Shown(object sender, EventArgs e)
        {
            string passw;

            if (MessageBox.Show("Do you know the password?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                passw = Interaction.InputBox("Print the password", "New password");
                if (File.Exists("Password.txt"))
                {
                    StreamReader currpassw1 = new StreamReader("Password.txt");
                    string currpassw = currpassw1.ReadLine();
                    if (passw == currpassw)
                        panel1hide.Visible = false;
                    else
                        System.Diagnostics.Process.GetCurrentProcess().Kill();
                }
                else
                    System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
            else
            {
                int a, b, fcount, attempt;
                double res;

                attempt = 2;
            NEWNUMBERS:
                Random first1 = new Random();
                a = first1.Next(-100, 100);
                if (a >= -100 && a <= 100)
                    Thread.Sleep(1);
                Random sec1 = new Random();
                b = sec1.Next(-100, 100);
                textBox1entrance.Text = a.ToString() + "+" + b.ToString();
                res = a + b;
                StreamWriter password = new StreamWriter(@"Password.txt");
                password.WriteLine(res);
                password.Close();

                fcount = Convert.ToInt32(label1finalcountdown.Text);
                attempt -= 1;
                do
                {
                    passw = Interaction.InputBox("Find a solution to see more", "Print the correst answer");
                    fcount -= 1;
                    label1finalcountdown.Text = fcount.ToString();
                    if (fcount == 1 || fcount == 2 || fcount == 3)
                    {
                        if (fcount == 1 && passw != res.ToString())
                            MessageBox.Show("You have only one attempt", "Exclamation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (passw != res.ToString())
                    {
                        if (fcount == 0 && attempt == 1)
                        {
                            MessageBox.Show("You can try in 10 seconds", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            panel2newattempt.Visible = true;
                            Thread.Sleep(10000);
                        }
                        else if (fcount == 0 && attempt == 0)
                        {
                            MessageBox.Show("You can try in 30 seconds. If you make a mistake, app will close", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            panel2newattempt.Visible = true;
                            Thread.Sleep(30000);
                        }
                        else if (fcount == 0 && attempt == -1)
                            goto CLOSE;
                        fcount = 3;
                        label1finalcountdown.Text = "3";
                        panel2newattempt.Visible = false;
                        goto NEWNUMBERS;
                    }
                }
                while (passw != res.ToString());
                if (passw == res.ToString())
                    goto CORRECT;
            CLOSE:
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            CORRECT:
                panel1hide.Visible = false;
            }
        }

        private void Form1password_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you wanna change the password?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string newpassw;

                newpassw = Interaction.InputBox("Print a new password", "New password");
                StreamWriter password = new StreamWriter(@"Password.txt");
                password.WriteLine(newpassw);
                password.Close();
            }
        }
    }
}
