using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cycle_for
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Operations with numbers";
            Console.ForegroundColor = ConsoleColor.Red;

            int div, count, armnum, dig, lim, deg, chn;
            double num, ndig, n, x, lran, hran, a, pol;

            do
            {
                try
                {
                    Console.WriteLine("Search of all divisors of a number");
                    Console.Write("Number: ");
                    num = Convert.ToDouble(Console.ReadLine());

                    if (num <= 0 || num == 1 || num.ToString().Contains("."))
                    {
                        Console.WriteLine("This number isn't prime or composite");
                    }
                    else
                    {
                        count = 0;

                        for (div = 1; div >= (div / 2); div++)
                        {
                            if (num % div == 0)
                            {
                                count += 1;

                                if (div == 1)
                                {
                                    Console.WriteLine("Divisors: ");
                                }
                                Console.WriteLine("{0}", div);
                                if (div >= num)
                                {
                                    Console.WriteLine("Quantity: {0}", count);
                                    break;
                                }
                            }
                        }
                        if (count == 2)
                        {
                            Console.Clear();

                            Console.WriteLine("Search of all divisors of a number");
                            Console.WriteLine("Number: {0}", num);
                            Console.WriteLine("The number is prime");
                        }
                    }
                    Console.WriteLine();

                    Console.WriteLine("The Armstrong numbers");
                    Console.Write("Quantity of digit in a number: ");
                    ndig = Convert.ToDouble(Console.ReadLine());
                    while (ndig > 9 || ndig.ToString().Contains(".") || ndig.ToString().Contains("-"))
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("The number is too large, or it's fractional, or the degree is negative");
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.Write("Quantity of digit in a number: ");
                        ndig = Convert.ToDouble(Console.ReadLine());
                    }
                    for (armnum = Convert.ToInt32(Math.Pow(10, ndig - 1)); armnum <= Convert.ToInt32(Math.Pow(10, ndig) - 1); armnum++)
                    {
                        deg = 0;

                        for (lim = Convert.ToInt32(Math.Pow(10, ndig - 1)); lim >= 1; lim /= 10)
                        {
                            dig = armnum / lim % 10;
                            deg += Convert.ToInt32(Math.Pow(dig, ndig));
                        }
                        if (deg == armnum)
                        {
                            Console.WriteLine("{0}", armnum);
                        }
                    }
                    Console.WriteLine();

                    Console.WriteLine("Polynomials");
                    Console.Write("Degree: ");
                    n = Convert.ToDouble(Console.ReadLine());
                    while (n < 0 || n.ToString().Contains("."))
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("The degree must be a non-negative and non-fractional number");
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.Write("Degree: ");
                        n = Convert.ToDouble(Console.ReadLine());
                    }
                    Console.Write("Variable (x): ");
                    x = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Range:");
                    Console.Write("from ");
                    lran = Convert.ToDouble(Console.ReadLine());
                    Console.Write("to ");
                    hran = Convert.ToDouble(Console.ReadLine());

                    pol = 0;

                    Random rand = new Random();
                    for (chn = Convert.ToInt32(n); chn >= 0; chn--)
                    {
                        a = lran + rand.NextDouble()*(hran - lran+1);

                        pol += a * Convert.ToDouble(Math.Pow(x, chn));
                        if (chn == n)
                        {
                            Console.Write("The polynomial: ");
                        }
                        if (chn > 0)
                        {
                            Console.Write($"{Math.Round(a, 2)}*x^{chn} + ");
                        }
                        if (chn == 0)
                        {
                            Console.Write($"{Math.Round(a, 2)} = ");
                        }
                    }
                    Console.WriteLine("{0}", Math.Round(pol, 2));

                    Console.ReadKey();
                }
                catch
                {
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            while (true);
        }
    }
}
