using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods__pictures_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Creating the pictures";

            do
            {
            Pictures:
                string num;

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("What do you want to see (flags (1) or cheaseboard (2))?");
                num = Console.ReadLine();

                if (num == "1")
                {
                    Console.SetWindowSize(150, 39);

                    Console.WriteLine("Whose flag do you want to see (Russian (1), American (2), British (3), French (4), German (5))?");
                    num = Console.ReadLine();

                    switch (num)
                    {
                        case "1":
                            Console.ResetColor();
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.White;
                            HorizontalVerticalLine(x: 0, xhorwidth: Console.WindowWidth, y: 0, yhorwidth: 13);
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            HorizontalVerticalLine(x: 0, xhorwidth: Console.WindowWidth, y: 13, yhorwidth: 13);
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            HorizontalVerticalLine(x: 0, xhorwidth: Console.WindowWidth, y: 26, yhorwidth: 13);
                            Console.BackgroundColor = ConsoleColor.Black;
                            break;
                        case "2":
                            Console.ResetColor();
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            for (int yred = 0; yred <= Console.WindowHeight; yred += 6)
                            {
                                HorizontalVerticalLine(x: 0, xhorwidth: Console.WindowWidth, y: yred, yhorwidth: 3);
                            }
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            HorizontalVerticalLine(x: 0, xhorwidth: 48, y: 0, yhorwidth: 21);
                            Console.BackgroundColor = ConsoleColor.White;
                            for (int ynew = 1; ynew <= 17; ynew += 2)
                            {
                                for (int xnew = 2; xnew <= 42; xnew += 8)
                                {
                                    HorizontalVerticalLine(x: xnew, xhorwidth: xnew + 4, y: ynew, yhorwidth: 2);
                                }
                                if (ynew == 17)
                                    break;
                                ynew += 2;
                                for (int xnew = 6; xnew <= 38; xnew += 8)
                                {
                                    HorizontalVerticalLine(x: xnew, xhorwidth: xnew + 4, y: ynew, yhorwidth: 2);
                                }
                            }
                            Console.BackgroundColor = ConsoleColor.White;
                            break;
                        case "3":
                            Console.ResetColor();
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.White;
                            DiagonalLeftLine(x: 0, y: 0, ydiag: Console.WindowHeight, spac: "                                ");
                            DiagonalRightLine(x: 0, y: Console.WindowHeight, ydiag: 0, spac: "                                ");
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            DiagonalLeftLine(x: 4, y: 0, ydiag: Console.WindowHeight /2, spac: "                ");
                            DiagonalRightLine(x: 12, y: Console.WindowHeight, ydiag: Console.WindowHeight / 2, spac: "                ");
                            DiagonalLeftLine(x: 57, y: Console.WindowHeight / 2, ydiag: Console.WindowHeight, spac: "                ");
                            DiagonalRightLine(x: 49, y: Console.WindowHeight / 2, ydiag: 0, spac: "                ");
                            Console.BackgroundColor = ConsoleColor.White;
                            HorizontalVerticalLine(x: 0, xhorwidth: Console.WindowWidth, y: Console.WindowHeight / 2 - 5, yhorwidth: 10);
                            HorizontalVerticalLine(x: Console.WindowWidth / 2 - 9, xhorwidth: 84, y: 0, yhorwidth: Console.WindowHeight);
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            HorizontalVerticalLine(x: 0, xhorwidth: Console.WindowWidth, y: Console.WindowHeight / 2 - 3, yhorwidth: 6);
                            HorizontalVerticalLine(x: Console.WindowWidth / 2 - 7, xhorwidth: 82, y: 0, yhorwidth: Console.WindowHeight);
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            break;
                        case "4":
                            Console.ResetColor();
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            HorizontalVerticalLine(x: 0, xhorwidth: 50, y: 0, yhorwidth: Console.WindowHeight);
                            Console.BackgroundColor = ConsoleColor.White;
                            HorizontalVerticalLine(x: 50, xhorwidth: 100, y: 0, yhorwidth: Console.WindowHeight);
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            HorizontalVerticalLine(x: 100, xhorwidth: 150, y: 0, yhorwidth: Console.WindowHeight);
                            Console.BackgroundColor = ConsoleColor.Black;
                            break;
                        case "5":
                            Console.ResetColor();
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.Black;
                            HorizontalVerticalLine(x: 0, xhorwidth: Console.WindowWidth, y: 0, yhorwidth: 13);
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            HorizontalVerticalLine(x: 0, xhorwidth: Console.WindowWidth, y: 13, yhorwidth: 13);
                            Console.BackgroundColor = ConsoleColor.DarkYellow;
                            HorizontalVerticalLine(x: 0, xhorwidth: Console.WindowWidth, y: 26, yhorwidth: 13);
                            Console.BackgroundColor = ConsoleColor.Black;
                            break;
                    }
                    Console.SetCursorPosition(0, 40);
                }
                else if (num == "2")
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                    Console.SetWindowSize(96, 48);

                    Console.BackgroundColor = ConsoleColor.White;
                    for (int ynew = 0; ynew < 48; ynew += 6)
                    {
                        for (int xnew = 0; xnew <= 84; xnew += 24)
                        {
                            HorizontalVerticalLine(x: xnew, xhorwidth: xnew + 12, y: ynew, yhorwidth: 6);
                        }
                        ynew += 6;
                        for (int xnew = 12; xnew <= 96; xnew += 24)
                        {
                            HorizontalVerticalLine(x: xnew, xhorwidth: xnew + 12, y: ynew, yhorwidth: 6);
                        }
                    }
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                goto Pictures;
            }
            while (true);
        }


        //метод для горизонтальных и вертикальных линий с пятью параметрами: x, y - координаты по осям X и Y; xhorwidth, yhorwidth - ширина и высота по осям; spac - закрашиваемое расстояние
        public static void HorizontalVerticalLine(int x, int xhorwidth, int y, int yhorwidth, string spac = " ")
        {
            //два цикла, первый из которых разукрашивает по оси Y по заданной высоте, а второй по X по всей ширине
            yhorwidth = y + yhorwidth;
            for (int yh = y; yh < yhorwidth; yh += 1)
            {
                for (int xh = x; xh < xhorwidth; xh += 1)
                {
                    Console.SetCursorPosition(xh, yh);
                    Console.WriteLine(spac);
                }
            }
            //
        }
        //

        //два метода для диагональных линий с четырьмя параметрами: x, y - координаты по осям X и Y; ydiag - ограничение для y при закрашивании; spac - закрашиваемое расстояние
        public static void DiagonalLeftLine(int x, int y, int ydiag, string spac)
        {
            //два цикла, строющих диагональные линии путем смещения координаты y вверх/вниз на 1 и координаты x вправо на 3
            for (int ydl = y; ydl <= ydiag; ydl += 1)
            {
                Console.SetCursorPosition(x, ydl);
                Console.WriteLine(spac);
                x += 3;
            }
        }

        public static void DiagonalRightLine(int x, int y, int ydiag, string spac)
        {
            for (int ydr = y; ydr >= ydiag; ydr -= 1)
            {
                Console.SetCursorPosition(x, ydr);
                Console.WriteLine(spac);
                x += 3;
            }
            //
        }
        //
    }
}
