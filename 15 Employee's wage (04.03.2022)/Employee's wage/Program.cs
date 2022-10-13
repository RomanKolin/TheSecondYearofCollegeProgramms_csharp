using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_s_wage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Employee's wage";
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetWindowSize(140, 30);

            double lv, wag, wagi, wagd, pf, it, finw, totfw, totpf, totit, maxw, minw, hlw;
            int mon, maxm, minm;

            do
            {
            lv:
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("The living wage (in the range from $1000 to $5000): ");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                try
                {
                    lv = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    goto lv;
                }
                if (lv < 1000 || lv > 5000)
                {
                    goto lv;
                }
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Month\t\tWage\t\tTo the pension fund\tTo the income tax\tFinal wage\tLess(\"+\")/More(\"-\") than the living wage?");
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

                Random wag1 = new Random();
                Random wagd1 = new Random();
                mon = 0;
                totfw = 0;
                totpf = 0;
                totit = 0;
                maxw = 1000;
                maxm = 0;
                minw = 5000;
                minm = 0;
                hlw = 0;
                for (int m = 1; m <= 12; m++)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;

                    wagi = wag1.Next(1000, 5000);
                    wagd = wagd1.NextDouble();
                    wag = wagi + wagd;
                    pf = (wag * 22) / 100;
                    it = (wag * 13) / 100;
                    finw = wag - pf - it;
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write($"{months[mon]}     \t");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write($"{Math.Round(wag, 2)}\t\t");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"{Math.Round(pf, 2)}\t\t\t{Math.Round(it, 2)}\t\t\t");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"{Math.Round(finw, 2)}\t\t");
                    if (finw >= maxw)
                    {
                        maxw = finw;
                        maxm = mon;
                    }
                    else if (finw < minw)
                    {
                        minw = finw;
                        minm = mon;
                    }
                    if (finw >= lv)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("+");
                        hlw += 1;
                    }
                    else if (finw < lv)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("-");
                    }
                    totfw += finw;
                    totpf += pf;
                    totit += it;

                    mon += 1;
                }
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"Total final wage: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{Math.Round(totfw, 2)}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"Total money to the pension fund: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{Math.Round(totpf, 2)}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"Total money to the income tax: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{Math.Round(totit, 2)}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"Max wage: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{Math.Round(maxw, 2)} ");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine($"in {months[maxm]}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"Min wage: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{Math.Round(minw, 2) } ");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine($"in {months[minm]}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"Number of months with wage more than the living wage: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{Math.Round(hlw)}");
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.ReadKey();
            }
            while (true);
        }
    }
}
