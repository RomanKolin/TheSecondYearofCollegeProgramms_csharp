using System;

namespace Triangle_s_Characteristics
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Title = "Triangle's Characteristics";
            Console.ForegroundColor = ConsoleColor.Red;

            double X1, Y1, X2, Y2, X3, Y3, a, b, c, per, sper, sqH, r, R, ma, mb, mc, ba, bb, bc, ha, hb, hc, degab, degbc, degca, radab, radbc, radca;

            Console.WriteLine("Print coordinate of triangle's sides");
            Console.WriteLine("(X1, Y1)");
            X1 = Convert.ToDouble(Console.ReadLine());
            Y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("(X2, Y2)");
            X2 = Convert.ToDouble(Console.ReadLine());
            Y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("(X3, Y3)");
            X3 = Convert.ToDouble(Console.ReadLine());
            Y3 = Convert.ToDouble(Console.ReadLine());

            a = Math.Sqrt(Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2, 2));
            Console.WriteLine("a = {0}", Math.Round(a, 2));
            b = Math.Sqrt(Math.Pow(X2 - X3, 2) + Math.Pow(Y2 - Y3, 2));
            Console.WriteLine("b = {0}", Math.Round(b, 2));
            c = Math.Sqrt(Math.Pow(X3 - X1, 2) + Math.Pow(Y3 - Y1, 2));
            Console.WriteLine("c = {0}", Math.Round(c, 2));

            per = a + b + c;
            Console.WriteLine("Peremiter = {0}", Math.Round(per, 2));
            sper = per / 2;

            sqH = Math.Sqrt(sper * (sper - a) * (sper - b) * (sper - c));
            Console.WriteLine("Square = {0}", Math.Round(sqH, 2));

            r = Math.Sqrt(((sper - a) * (sper - b) * (sper - c)) / sper);
            Console.WriteLine("Radius of incircle = {0}", Math.Round(r, 2));
            R = (a * b * c) / (4 * sqH);
            Console.WriteLine("Radius of excircle = {0}", Math.Round(R, 2));

            ma = Math.Sqrt(Math.Pow(X3 - ((X1 + X2) / 2), 2) + Math.Pow(Y3 - ((Y1 + Y2) / 2), 2));
            Console.WriteLine("Median to a = {0}", Math.Round(ma, 2));
            mb = Math.Sqrt(Math.Pow(X1 - ((X2 + X3) / 2), 2) + Math.Pow(Y1 - ((Y2 + Y3) / 2), 2));
            Console.WriteLine("Median to b = {0}", Math.Round(mb, 2));
            mc = Math.Sqrt(Math.Pow(X2 - ((X3 + X1) / 2), 2) + Math.Pow(Y2 - ((Y3 + Y1) / 2), 2));
            Console.WriteLine("Median to c = {0}", Math.Round(mc, 2));

            ba = (Math.Sqrt((b * c) * (b + c + a) * (b + c - a))) / (b + c);
            Console.WriteLine("Bisector to a = {0}", Math.Round(ba, 2));
            bb = (Math.Sqrt((a * c) * (a + c + b) * (a + c - b))) / (a + c);
            Console.WriteLine("Bisectors to b = {0}", Math.Round(bb, 2));
            bc = (Math.Sqrt((a * b) * (a + b + c) * (a + b - c))) / (a + b);
            Console.WriteLine("Bisectors to c = {0}", Math.Round(bc, 2));

            ha = (2 * sqH) / a;
            Console.WriteLine("Height to a = {0}", Math.Round(ha, 2));
            hb = (2 * sqH) / b;
            Console.WriteLine("Height to b = {0}", Math.Round(hb, 2));
            hc = (2 * sqH) / c;
            Console.WriteLine("Height to c = {0}", Math.Round(hc, 2));

            radab = Math.Acos((Math.Pow(a, 2) + Math.Pow(b, 2) - Math.Pow(c, 2)) / (2 * a * b));
            degab = (radab * 180) / Math.PI;
            Console.WriteLine("Angle in degrees between a and b = {0}°", Math.Round(degab, 2));
            Console.WriteLine("Angle in radians between a and b = {0}", Math.Round(radab, 2));
            radbc = Math.Acos((Math.Pow(b, 2) + Math.Pow(c, 2) - Math.Pow(a, 2)) / (2 * b * c));
            degbc = (radbc * 180) / Math.PI;
            Console.WriteLine("Angle in degrees between b and c = {0}°", Math.Round(degbc, 2));
            Console.WriteLine("Angle in radians between b and c = {0}", Math.Round(radbc, 2));
            radca = Math.Acos((Math.Pow(c, 2) + Math.Pow(a, 2) - Math.Pow(b, 2)) / (2 * c * a));
            degca = (radca * 180) / Math.PI;
            Console.WriteLine("Angle in degrees between c and a = {0}°", Math.Round(degca, 2));
            Console.WriteLine("Angle in radians between c and a = {0}", Math.Round(radca, 2));

        }
    }
}
