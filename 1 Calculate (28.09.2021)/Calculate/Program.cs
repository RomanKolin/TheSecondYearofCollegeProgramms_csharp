using System;

namespace Calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            // Local variable block
            double a, b, sum, min, mult, div; // variable, operations
            String str; 
            Console.WriteLine("Print two numbers");
            str = Console.ReadLine();
            a = Convert.ToDouble(str);
            str = Console.ReadLine();
            b = Convert.ToDouble(str);
            sum = a + b;
            Console.WriteLine("{0} + {1} = {2}", a, b, sum);
            min = a - b;
            Console.WriteLine("{0} - {1} = {2}", a, b, min);
            mult = a * b;
            Console.WriteLine("{0} * {1} = {2}", a, b, mult);
            div = a / b;
            Console.WriteLine("{0} / {1} = {2}", a, b, div);
            Console.ReadKey();

        }
    }
}
