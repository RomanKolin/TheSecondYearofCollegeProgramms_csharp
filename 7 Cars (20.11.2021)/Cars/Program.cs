using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Cars";
            Console.ForegroundColor = ConsoleColor.Red;
            
            double t, s1, s2, t1, t2, s, v1, v2, a1, a2, d, gas1, gas2, pr1, pr2, cons1, cons2, pr;

            Console.WriteLine("Print the characteristics of the cars");
            do
            {
                try
                {
                    Console.WriteLine("The distance between the 1st and the 2nd cars (in meters)");
                    s = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("The speed of the 1st and the 2nd cars (in meters per second)");
                    v1 = Convert.ToDouble(Console.ReadLine());
                    v2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("The acceleration of the 1st and the 2nd cars (in meters per second squared)");
                    a1 = Convert.ToDouble(Console.ReadLine());
                    a2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("The gasoline consumption of the 1st and the 2nd cars (in liters)");
                    cons1 = Convert.ToDouble(Console.ReadLine());
                    cons2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("The price of gasoline");
                    pr = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine();

                    while (s <= 0 || v1 <= 0 || v2 <= 0 || a1 <= 0 || a2 <= 0 || cons1 <= 0 || cons2 <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Print the correct characteristics of the cars (the distance, the speed, the acceleration and the gasoline consumption are positive values)");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("The distance between the 1st and the 2nd cars (in meters)");
                        s = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("The speed of the 1st and the 2nd cars (in meters per second)");
                        v1 = Convert.ToDouble(Console.ReadLine());
                        v2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("The acceleration of the 1st and the 2nd cars (in meters per second squared)");
                        a1 = Convert.ToDouble(Console.ReadLine());
                        a2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("The gasoline consumption of the 1st and the 2nd cars (in liters)");
                        cons1 = Convert.ToDouble(Console.ReadLine());
                        cons2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("The price of gasoline");
                        pr = Convert.ToDouble(Console.ReadLine());
                    }

                    if (a1 == 0 && a2 == 0)
                    {
                        t = s / (v1 + v2);
                        Console.WriteLine("Time of meet = {0} h", Math.Round(t, 1));
                        s1 = v1 * t;
                        Console.WriteLine("Distance of the first car = {0} km", Math.Round(s1, 2));
                        s2 = v2 * t;
                        Console.WriteLine("Distance of the second car = {0} km", Math.Round(s2, 2));
                        gas1 = (s1 / 100) * cons1;
                        Console.WriteLine("Used gasoline for the first car = {0} l", Math.Round(gas1, 3));
                        gas2 = (s2 / 100) * cons2;
                        Console.WriteLine("Used gasoline for the second car = {0} l", Math.Round(gas2, 3));
                        pr1 = pr * gas1;
                        Console.WriteLine("Price of gasoline for the first car = {0}", Math.Round(pr1));
                        pr2 = pr * gas1;
                        Console.WriteLine("Price of gasoline for the second car = {0}", Math.Round(pr2));
                    }
                    else
                    {
                        d = (v1 * v1 + 2 * v1 * v2 + v2 * v2) - (4 * (((a1 + a2) / 2) * -s));
                        if (d < 0)
                        {
                            Console.WriteLine("Print the correct characteristic");
                        }
                        else if (d == 0)
                        {
                            t = (-(v1 + v2) + Math.Sqrt(d)) / (2 * ((a1 + a2) / 2));
                            Console.WriteLine("Time of meet = {0} h", Math.Round(t, 1));
                            s1 = v1 * t + ((a1 * Math.Pow(t, 2)) / 2);
                            Console.WriteLine("Distance of the first car = {0} km", Math.Round(s1, 2));
                            s2 = v2 * t + ((a2 * Math.Pow(t, 2)) / 2);
                            Console.WriteLine("Distance of the second car = {0} km", Math.Round(s2, 2));
                            gas1 = (s1 / 100) * cons1;
                            Console.WriteLine("Used gasoline for the first car = {0} l", Math.Round(gas1, 3));
                            gas2 = (s2 / 100) * cons2;
                            Console.WriteLine("Used gasoline for the second car = {0} l", Math.Round(gas2, 3));
                            pr1 = pr * gas1;
                            Console.WriteLine("Price of gasoline for the first car = {0}", Math.Round(pr1));
                            pr2 = pr * gas2;
                            Console.WriteLine("Price of gasoline for the second car = {0}", Math.Round(pr2));
                        }
                        else
                        {
                            t1 = (- (v1 + v2) + Math.Sqrt(d)) / (2 * ((a1 + a2) / 2));
                            t2 = (- (v1 + v2) - Math.Sqrt(d)) / (2 * ((a1 + a2) / 2));
                            Console.WriteLine("Time of meet = {0} h", Math.Round(t1, 1));
                            if (t1 > 0 || t2 > 0)
                            {
                                s1 = v1 * t1 + ((a1 * Math.Pow(t1, 2)) / 2);
                                Console.WriteLine("Distance of the first car = {0} km", Math.Round(s1, 2));
                                s2 = s - s1;
                                Console.WriteLine("Distance of the second car = {0} km", Math.Round(Math.Abs(s2), 2));
                                gas1 = (s1 / 100) * cons1;
                                Console.WriteLine("Used gasoline for the first car = {0} l", Math.Round(gas1, 3));
                                gas2 = (s2 / 100) * cons2;
                                Console.WriteLine("Used gasoline for the second car = {0} l", Math.Round(gas2, 3));
                                pr1 = pr * gas1;
                                Console.WriteLine("Price of gasoline for the first car = {0}", Math.Round(pr1));
                                pr2 = pr * gas2;
                                Console.WriteLine("Price of gasoline for the second car = {0}", Math.Round(pr2));
                            }
                        }
                    }

                    Console.ReadKey();
                }
                catch
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Print the correct characteristics of the cars (the distance, the speed, the acceleration and the gasoline consumption are positive values)");
                    Console.ForegroundColor = ConsoleColor.Red;
                }

                Console.WriteLine();
            }
            while (true);
        }
    }
}
