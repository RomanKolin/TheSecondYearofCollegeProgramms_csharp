using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cycle_for__pictures_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Creating the pictures";
            Console.CursorVisible = false;

        start:

            int col;
            Random rcol = new Random();
            Console.WriteLine("\"The Snowflake\"");
            Console.WriteLine("(press the enter to see \"The Snowflake\" or press any key to choose other pictures)");
            if (Console.ReadKey(true).Key == ConsoleKey.Enter)
            {
                Console.SetWindowSize(25, 25);
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
            snowflake:
                int x, y;

                y = 12;
                for (x = 0; x < 25; x++)
                {
                    col = rcol.Next(1, 15);
                    Console.BackgroundColor = (ConsoleColor)col;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine(" ");
                }
                x = 12;
                for (y = 0; y < 25; y++)
                {
                    col = rcol.Next(1, 15);
                    Console.BackgroundColor = (ConsoleColor)col;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine(" ");
                }
                y = -1;
                for (x = -1; x < 25; x++)
                {
                    col = rcol.Next(1, 15);
                    Console.BackgroundColor = (ConsoleColor)col;
                    Console.SetCursorPosition(x + 1, y += 1);
                    Console.WriteLine(" ");
                }
                y = -1;
                for (x = 25; x > 0; x--)
                {
                    col = rcol.Next(1, 15);
                    Console.BackgroundColor = (ConsoleColor)col;
                    Console.SetCursorPosition(x - 1, y += 1);
                    Console.WriteLine(" ");
                }

                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine();
                Console.WriteLine("Press the enter");
                Console.WriteLine("to see new snowflake");
                Console.WriteLine("OR");
                Console.WriteLine("Press any key");
                Console.WriteLine("to choose new pictures");
                Console.SetCursorPosition(0, 0);
                Console.SetWindowSize(25, 31);
                if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                {
                    goto snowflake;
                }
                else
                {
                    Console.Clear();
                    Console.SetWindowSize(120, 30);
                }
            }
            
            Console.WriteLine("\"The Christmas Tree\"");
            Console.WriteLine("(press the enter to see \"The Christmas Tree\" or press any key to play the game)");
            if (Console.ReadKey(true).Key == ConsoleKey.Enter)
            {
            christmastree:
                Console.SetWindowSize(50, 25);
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();

                int x, xnl, xnr, y, deccol;

                xnr = 50;
                xnl = 1;
                for (y = 50; y >= 0; y--)
                {
                    for (x = xnl; x <= xnr + 1; x++)
                    {
                        col = 2;
                        Console.BackgroundColor = (ConsoleColor)col;
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine(" ");

                        Random rdec = new Random();
                        Random xdec1 = new Random();
                        deccol = rdec.Next(1, 15);
                        Console.BackgroundColor = (ConsoleColor)deccol;
                        if (xnl <= 25)
                        {
                            int xdec = xdec1.Next(xnl, xnr);
                            Console.SetCursorPosition(xdec, y);
                        }
                        else
                        {
                            int xdec = xdec1.Next(xnr, xnl);
                            Console.SetCursorPosition(xdec, y);
                        }
                        Console.WriteLine(" ");
                    }
                    xnl += 1;
                    xnr -= 1;
                }
                for (x = 24; x <= 28; x++)
                {
                    for (y = 51; y <= 53; y++)
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine(" ");
                    }
                }
                Console.BackgroundColor = ConsoleColor.White;
                Console.SetCursorPosition(25, 25);
                Console.WriteLine(" ");

                Console.SetWindowSize(53, 35);
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(0, 55);
                Console.WriteLine("Press the enter");
                Console.WriteLine("to see new christmas tree");
                Console.WriteLine("OR");
                Console.WriteLine("Press any key");
                Console.WriteLine("to play the game");
                Console.SetCursorPosition(0, 25);
                if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                {
                    goto christmastree;
                }
                else
                {
                    Console.ResetColor();
                    Console.Clear();
                    Console.SetWindowSize(120, 30);
                }
            }

            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("The \"♫ vs ♪\"");
            Console.WriteLine("(press the enter to start the game or press any key to return to \"The Snowflake\")");
            if (Console.ReadKey(true).Key == ConsoleKey.Enter)
            {
                Console.ResetColor();
                Console.Clear();
            game:
                Console.Clear();
                Console.SetWindowSize(125, 25);

                int fox, fon, sox, son, foy, soy, sit;

                Console.WriteLine("If these objects will collide, they'll: ");
                Console.WriteLine("1) fall");
                Console.WriteLine("2) return to start");
                Console.WriteLine("3) fly around each other");
                Console.WriteLine("(print the number)");
                Console.CursorVisible = true;
                try
                {
                    sit = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    goto game;
                }
                if (sit != 1 && sit != 2 && sit != 3)
                {
                    goto game;
                }
                Console.CursorVisible = false;

                fon = 1;
                son = Console.WindowWidth - 2;
                Random rfoy = new Random();
                foy = rfoy.Next(0, 25);
                Console.SetCursorPosition(0, foy);
                Console.WriteLine("♫");
                Random sfoy = new Random();
                soy = sfoy.Next(0, 25);
                Console.SetCursorPosition(Console.WindowWidth - 1, soy);
                Console.WriteLine("♪");
                Console.Clear();
            nfl:
                for (fox = fon; fox < Console.WindowWidth; fox++)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.SetCursorPosition(fox, foy);
                    Console.WriteLine("♫");
                    System.Threading.Thread.Sleep(50);
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.SetCursorPosition(fox, foy);
                    Console.WriteLine("♫");
                    System.Threading.Thread.Sleep(50);
                    fon += 1;
                    goto nsl;
                }
            nsl:
                for (sox = son; sox >= 0; sox--)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.SetCursorPosition(sox, soy);
                    Console.WriteLine("♪");
                    System.Threading.Thread.Sleep(50);
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.SetCursorPosition(sox, soy);
                    Console.WriteLine("♪");
                    System.Threading.Thread.Sleep(50);
                    son -= 1;

                    if (sox == 0)
                    {
                        goto end;
                    }
                    else if (fox == sox && foy == soy)
                    {
                        if (sit == 1)
                        {
                        nfl1:
                            for (foy = foy + 1; foy <= Console.WindowHeight; foy++)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.SetCursorPosition(fox - 1, foy);
                                Console.WriteLine("♫");
                                System.Threading.Thread.Sleep(25);
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.SetCursorPosition(fox - 1, foy);
                                Console.WriteLine("♫");
                                System.Threading.Thread.Sleep(25);

                                goto nsl1;
                            }
                        nsl1:
                            for (soy = soy + 1; soy <= Console.WindowHeight; soy++)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.SetCursorPosition(sox, soy + 1);
                                Console.WriteLine("♪");
                                System.Threading.Thread.Sleep(25);
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.SetCursorPosition(sox, soy + 1);
                                Console.WriteLine("♪");
                                System.Threading.Thread.Sleep(25);

                                goto nfl1;
                            }
                        }
                        else if (sit == 2)
                        {
                        nfl2:
                            for (fox = fox - 1; fox >= 0; fox++)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.SetCursorPosition(fox, foy);
                                Console.WriteLine("♫");
                                System.Threading.Thread.Sleep(50);
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.SetCursorPosition(fox, foy);
                                Console.WriteLine("♫");
                                System.Threading.Thread.Sleep(50);

                                goto nsl2;
                            }
                        nsl2:
                            for (sox = sox + 1; sox < Console.WindowWidth; sox++)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.SetCursorPosition(sox, soy);
                                Console.WriteLine("♪");
                                System.Threading.Thread.Sleep(50);
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.SetCursorPosition(sox, soy);
                                Console.WriteLine("♪");
                                System.Threading.Thread.Sleep(50);

                                goto nfl2;
                            }
                        }
                        else if (sit == 3)
                        {
                            for (soy = soy - 1; soy >= soy + 3; soy--)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.SetCursorPosition(sox, soy - 1);
                                Console.WriteLine("♪");
                                System.Threading.Thread.Sleep(300);
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.SetCursorPosition(sox, soy - 1);
                                Console.WriteLine("♪");
                                System.Threading.Thread.Sleep(300);
                            }
                        nfl3:
                            for (fox = fox + 1; fox < Console.WindowWidth; fox++)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.SetCursorPosition(fox, foy);
                                Console.WriteLine("♫");
                                System.Threading.Thread.Sleep(50);
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.SetCursorPosition(fox, foy);
                                Console.WriteLine("♫");
                                System.Threading.Thread.Sleep(50);

                                goto nsl3;
                            }
                        nsl3:
                            for (sox = sox - 1; sox >= 0; sox++)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.SetCursorPosition(sox, soy);
                                Console.WriteLine("♪");
                                System.Threading.Thread.Sleep(50);
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.SetCursorPosition(sox, soy);
                                Console.WriteLine("♪");
                                System.Threading.Thread.Sleep(50);

                                goto nfl3;
                            }
                        }
                        goto end;
                    }
                    goto nfl;
                }
            end:
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Press the enter to start new game or press any key to return to \"The Snowflake\"");
                if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                {
                    goto game;
                }
                else
                {
                    Console.Clear();
                    goto start;
                }
            }
            else
            {
                Console.Clear();
                goto start;
            }

            Console.ReadKey();
        }
    }
}
