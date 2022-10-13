using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods__recursion_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Recursion";

            do
            {
            Start:
                int numbm;

                try
                {
                    Console.WriteLine("What do you wanna see: Factorial (1), Fibonacci (2), Fibonacci by number (3)?");
                    numbm = Convert.ToInt32(Console.ReadLine());
                    if (numbm != 1 && numbm != 2 && numbm != 3)
                        goto Start;
                    if (numbm == 1)
                    {
                        int num;

                        Console.WriteLine("Print a non-negative and non-fractional number");
                        num = Convert.ToInt32(Console.ReadLine());
                        if (num < 0)
                            goto Start;
                        Console.WriteLine(Factorial(num: num));
                    }
                    else if (numbm == 2)
                    {
                        int lim;

                        Console.WriteLine("Print a non-zero, non-negative and non-fractional number in the range of which you wanna see the Fibonacci number");
                        lim = Convert.ToInt32(Console.ReadLine());
                        if (lim <= 0)
                            goto Start;
                        Fibonacci(fib: 0, nnum: 1, lim: lim, numb: 0, count: 0);
                    }
                    else if (numbm == 3)
                    {
                        int numb;

                        Console.WriteLine("Print a non-zero, non-negative and non-fractional number by which you wanna see the Fibonacci number");
                        numb = Convert.ToInt32(Console.ReadLine());
                        if (numb <= 0)
                            goto Start;
                        Fibonacci(fib: 0, nnum: 1, lim: 0, numb: numb, count: numb - 1);
                    }
                    Console.ReadKey();
                }
                catch
                {
                    goto Start;
                }
            }
            while (true);
        }

        public static int Factorial(int num)
        {
            int fact;

            if (num == 0)
                fact = 1;
            else
                fact = num * Factorial(num: num - 1);
            return fact;
        }

        public static int Fibonacci(int fib, int nnum, int lim, int numb, int count)
        {
            if (numb == 0)
            {
                if (fib <= lim)
                {
                    Console.WriteLine(fib);
                    fib = fib + nnum;
                    return Fibonacci(fib: nnum, nnum: fib, lim: lim, numb: 0, count: 0);
                }
                else
                    return fib;
            }
            else
            {
                fib = fib + nnum;
                count -= 1;
                if (count == 1)
                {
                    Console.WriteLine(fib);
                    return fib;
                }
                return Fibonacci(fib: nnum, nnum: fib, lim: lim, numb: numb, count: count);
            }
        }
    }
}
