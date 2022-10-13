using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array__basic_operations_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Basic operations with an array";

        Start:
            int numb, siz;
            double from, to;
            double[] dnumarr;

            try
            {
                do
                {
                NewMassive:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Print the array size");
                    Console.ForegroundColor = ConsoleColor.White;
                    siz = Convert.ToInt32(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Print the range of numbers (from min to max) in the array");
                    Console.Write("from: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    from = Convert.ToDouble(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("to: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    to = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();
                    if (from > to)
                        goto NewMassive;
                    dnumarr = DoubleNumArray(siz: siz, from: from, to: to);
                    Console.WriteLine();
                Operations:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("What do you wanna do?\n" +
                                      "1) sum of the array elements\n" +
                                      "2) sum of the array elements in the borders (the borders aren't taken into account)\n" +
                                      "3) arithmetic mean of the array elements\n" +
                                      "4) new array, in which each value is a deviation from the arithmetic mean\n" +
                                      "5) increase each element of the array by the input value\n" +
                                      "6) swap the array elements\n" +
                                      "7) max array element\n" +
                                      "8) max array element in the borders\n" +
                                      "9) min array element\n" +
                                      "10) min array element in the borders\n" +
                                      "11) the first position of the input element (the elements in the array are numbered from zero)\n" +
                                      "12) the final position of the input element (the elements in the array are numbered from zero)\n" +
                                      "13) all positions of the input element (the elements in the array are numbered from zero)");
                    Console.ForegroundColor = ConsoleColor.White;
                    numb = Convert.ToInt32(Console.ReadLine());
                    if (numb < 1 || numb > 13)
                        goto Operations;
                    switch (numb)
                    {
                        case 1:
                            Console.WriteLine(ArraySum(arr: dnumarr));
                            break;
                        case 2:
                            int fb, sb;

                        ArraySum:
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Print the borders (the elements in the array are numbered from zero)");
                            Console.Write("The first border: ");
                            Console.ForegroundColor = ConsoleColor.White;
                            fb = Convert.ToInt32(Console.ReadLine());
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write("The second border: ");
                            Console.ForegroundColor = ConsoleColor.White;
                            sb = Convert.ToInt32(Console.ReadLine());
                            if (fb > sb || fb == sb || fb < -1 || sb > siz)
                                goto ArraySum;
                            Console.WriteLine(ArrayBordersSum(arr: dnumarr, fb: fb, sb: sb));
                            break;
                        case 3:
                            Console.WriteLine(midlearr(arr: dnumarr, siz: siz));
                            break;
                        case 4:
                            NewDoubleNumArray(arr: dnumarr, siz: siz);
                            break;
                        case 5:
                            double incrval;

                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Print the value (the elements in the array are numbered from zero)");
                            Console.ForegroundColor = ConsoleColor.White;
                            incrval = Convert.ToDouble(Console.ReadLine());
                            ArrayIncrease(arr: dnumarr, incrval: incrval);
                            break;
                        case 6:
                            int fp, sp;

                        ArraySwap:
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Print the positions of elements (the elements in the array are numbered from zero)");
                            Console.Write("The first position: ");
                            Console.ForegroundColor = ConsoleColor.White;
                            fp = Convert.ToInt32(Console.ReadLine());
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write("The second position: ");
                            Console.ForegroundColor = ConsoleColor.White;
                            sp = Convert.ToInt32(Console.ReadLine());
                            if (fp > sp || fp == sp || fp < 0 || sp > siz - 1)
                                goto ArraySwap;
                            ArraySwap(arr: dnumarr, fp: fp, sp: sp);
                            break;
                        case 7:
                            double max;

                            max = dnumarr.Max();
                            Console.WriteLine("Max element = " + Math.Round(max, 2) + " in position = " + ArrayMax(arr: dnumarr, max: max));
                            break;
                        case 8:
                        ArrayMax:
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Print the borders (the elements in the array are numbered from zero)");
                            Console.Write("The first border: ");
                            Console.ForegroundColor = ConsoleColor.White;
                            fb = Convert.ToInt32(Console.ReadLine());
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write("The second border: ");
                            Console.ForegroundColor = ConsoleColor.White;
                            sb = Convert.ToInt32(Console.ReadLine());
                            if (fb > sb || fb == sb || fb < -1 || sb > siz)
                                goto ArrayMax;
                            Console.WriteLine(ArrayBordersMax(arr: dnumarr, fb: fb, sb: sb)); 
                            break;
                        case 9:
                            double min;

                            min = dnumarr.Min();
                            Console.WriteLine("Min element = " + Math.Round(min, 2) + " in position = " + ArrayMin(arr: dnumarr, min: min));
                            break;
                        case 10:
                        ArrayMin:
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Print the borders (the elements in the array are numbered from zero)");
                            Console.Write("The first border: ");
                            Console.ForegroundColor = ConsoleColor.White;
                            fb = Convert.ToInt32(Console.ReadLine());
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write("The second border: ");
                            Console.ForegroundColor = ConsoleColor.White;
                            sb = Convert.ToInt32(Console.ReadLine());
                            if (fb > sb || fb == sb || fb < -1 || sb > siz)
                                goto ArrayMin;
                            Console.WriteLine(ArrayBordersMin(arr: dnumarr, fb: fb, sb: sb));
                            break;
                        case 11:
                            double val;

                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Print the element");
                            Console.ForegroundColor = ConsoleColor.White;
                            val = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine(ArrayFirstPosition(arr: dnumarr, val: val));
                            break;
                        case 12:
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Print the element");
                            Console.ForegroundColor = ConsoleColor.White;
                            val = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine(ArrayFinalPosition(arr: dnumarr, val: val));
                            break;
                        case 13:
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Print the element");
                            Console.ForegroundColor = ConsoleColor.White;
                            val = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine(ArrayAllPosition(arr: dnumarr, val: val));
                            break;
                    }
                    Console.WriteLine();

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Create a new massive (1), continue work with this massive (2)");
                    Console.ForegroundColor = ConsoleColor.White;
                    numb = Convert.ToInt32(Console.ReadLine());
                    if (numb == 1)
                    {
                        Console.WriteLine();
                        goto NewMassive;
                    }
                    else if (numb == 2)
                    {
                        Console.WriteLine();
                        goto Operations;
                    }
                        
                    Console.ReadKey();
                }
                while (true);
            }
            catch
            {
                goto Start;
            }
        }

        public static double[] DoubleNumArray(int siz, double from, double to)
        {
            string spac = "";

            Random arrrand = new Random();
            double[] dnumarray = new double[siz];
            Console.Write("{");
            for (int arr = 0; arr < siz; arr++)
            {
                dnumarray[arr] = arrrand.NextDouble() * (to - from) + from;
                spac += Math.Round(dnumarray[arr], 2) + "; ";
            }
            spac = spac.Remove(spac.Length - 2).Insert(spac.Length - 2, "");
            Console.WriteLine(spac + "}");
            return dnumarray;
        }

        public static double ArraySum(double[] arr)
        {
            double arrsum = 0;

            foreach(double arrval in arr)
                arrsum += arrval;
            return Math.Round(arrsum, 2);
        }

        public static double ArrayBordersSum(double[] arr, int fb, int sb)
        {
            int num = 0, nfb;
            double arrsum = 0;

            double[] bordarr = new double[sb - fb - 1];
            nfb = fb + 1;
            for (int nnum = fb; nnum < sb - 1; nnum++)
            {
                bordarr[num] = arr[nfb];
                num += 1;
                nfb += 1;
            }

            foreach (double arrval in bordarr)
                arrsum += arrval;
            return Math.Round(arrsum, 2);
        }

        public static double midlearr(double[] arr, int siz)
        {
            double midle;
            midle = ArraySum(arr: arr) / siz;
            return Math.Round(midle, 2);
        }

        public static double[] NewDoubleNumArray(double[] arr, int siz)
        {
            double middlval;
            string spac = "";

            double[] ndnumarr = new double[arr.Length];
            middlval = midlearr(arr: arr, siz: siz);
            Console.Write("{");
            for (int num = 0; num < arr.Length; num++)
            {
                ndnumarr[num] = middlval - arr[num];
                spac += Math.Round(ndnumarr[num], 2) + "; ";
            }
            spac = spac.Remove(spac.Length - 2).Insert(spac.Length - 2, "");
            Console.WriteLine(spac + "}");
            return ndnumarr;
        }

        public static double[] ArrayIncrease(double[] arr, double incrval)
        {
            string spac = "";

            double[] arrincr = new double[arr.Length];
            Console.Write("{");
            for (int num = 0; num < arr.Length; num++)
            {
                arrincr[num] = arr[num] + incrval;
                spac += Math.Round(arrincr[num], 2) + "; ";
            }
            spac = spac.Remove(spac.Length - 2).Insert(spac.Length - 2, "");
            Console.WriteLine(spac + "}");
            return arrincr;
        }

        public static double[] ArraySwap(double[] arr, int fp, int sp)
        {
            double vfp = 0;
            string spac = "";

            Console.Write("{");
            for (int num = 0; num < arr.Length; num++)
            {
                if (num == fp)
                {
                    vfp = arr[num];
                    arr[num] = arr[sp];
                }
                if (num == sp)
                    arr[num] = vfp;
                spac += Math.Round(arr[num], 2) + "; ";
            }
            spac = spac.Remove(spac.Length - 2).Insert(spac.Length - 2, "");
            Console.WriteLine(spac + "}");
            return arr;
        }

        public static double ArrayMax(double[] arr, double max)
        {
            int pos = 0;

            for (int num = 0; num < arr.Length; num++)
            {
                if (arr[num] == max)
                    pos = num;
            }
            return pos;
        }

        public static string ArrayBordersMax(double[] arr, int fb, int sb)
        {
            int num = 0, nfb, pos = 0;
            double max = 0;
            string maxpos;

            double[] bordarr = new double[sb - fb - 1];
            nfb = fb + 1;
            for (int nnum = fb; nnum < sb - 1; nnum++)
            {
                bordarr[num] = arr[nfb];
                num += 1;
                nfb += 1;
            }

            for (num = 0; num < bordarr.Length; num++)
                max = bordarr.Max();
            for (num = 0; num < bordarr.Length; num++)
                if (bordarr[num] == max)
                    pos = num;
            maxpos = "Max element = " + Math.Round(max, 2) + " in position = " + pos;
            return maxpos;
        }

        public static double ArrayMin(double[] arr, double min)
        {
            int pos = 0;

            for (int num = 0; num < arr.Length; num++)
            {
                if (arr[num] == min)
                    pos = num;
            }
            return pos;
        }

        public static string ArrayBordersMin(double[] arr, int fb, int sb)
        {
            int num = 0, nfb, pos = 0;
            double min = 0;
            string minpos;

            double[] bordarr = new double[sb - fb - 1];
            nfb = fb + 1;
            for (int nnum = fb; nnum < sb - 1; nnum++)
            {
                bordarr[num] = arr[nfb];
                num += 1;
                nfb += 1;
            }

            for (num = 0; num < bordarr.Length; num++)
                min = bordarr.Min();
            for (num = 0; num < bordarr.Length; num++)
                if (bordarr[num] == min)
                    pos = num;
            minpos = "Min element = " + Math.Round(min, 2) + " in position = " + pos;
            return minpos;
        }

        public static string ArrayFirstPosition(double[] arr, double val)
        {
            int pos = -1;

            for (int num = 0; num < arr.Length; num++)
            {
                if (Math.Round(arr[num], 2) == val)
                {
                    pos = num;
                    return pos.ToString();
                }
                else if (num == arr.Length - 1)
                    return "There isn't this element";
            }
            return pos.ToString();
        }

        public static string ArrayFinalPosition(double[] arr, double val)
        {
            int pos = -1;

            for (int num = 0; num < arr.Length; num++)
            {
                if (Math.Round(arr[num], 2) == val)
                    pos = num;
                else if (num == arr.Length - 1 && pos == -1)
                    return "There isn't this element";
            }
            return pos.ToString();
        }

        public static string ArrayAllPosition(double[] arr, double val)
        {
            int count = 0;
            string pos = "";

            for (int num = 0; num < arr.Length; num++)
            {
                if (Math.Round(arr[num], 2) == val)
                    count += 1;
            }

            double[] arrallpos = new double[count];
            for (int num = 0; num < arr.Length; num++)
            {
                if (Math.Round(arr[num], 2) == val)
                {
                    pos += num.ToString() + ", ";
                }
                else if (num == arr.Length - 1 && arrallpos.Length == 0)
                    return "There isn't this element";
            }
            pos = pos.Remove(pos.Length - 2).Insert(pos.Length - 2, "");
            return pos;
        }
    }
}
