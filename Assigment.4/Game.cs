using System;

namespace Assigment._4
{
    class Game
    {
        enum Menustate { Newgame = 1, about = 2, Quit = 3 }
        static void Main(string[] args)
        {
            Display.SetGameColor();
            string input;
            int inputNumber = 0;
            int Tnumber = 0;

            Menustate state;
            Display.PrintWelcomeMessage();
            int i = 0;

            while (true)
            {
                Display.GameMenu();
                while (!Enum.TryParse<Menustate>(Console.ReadKey().KeyChar.ToString(), out state)) ;
                Console.Clear();
                //New Game
                if (state == Menustate.Newgame)
                {
                    string[] n = new string[10];
                    string T = "X";
                    for (int j = 1; j <= 9; j++)
                        n[j] = " ";
                    i = 0;
                    Tnumber = 0;

                    while (i < 9)
                    {
                        Display.GameTable(n);

                        if (n[1] == n[2] && n[1] == n[3] && n[1] != " " ||
                            n[4] == n[5] && n[4] == n[6] && n[4] != " " ||
                            n[7] == n[8] && n[7] == n[9] && n[9] != " " ||
                            n[1] == n[4] && n[1] == n[7] && n[1] != " " ||
                            n[2] == n[5] && n[2] == n[8] && n[2] != " " ||
                            n[3] == n[6] && n[3] == n[9] && n[3] != " " ||
                            n[1] == n[5] && n[1] == n[9] && n[1] != " " ||
                            n[3] == n[5] && n[3] == n[7] && n[3] != " ")

                        {
                            Console.WriteLine($"{T} has won the game **");
                            Console.WriteLine("Press enter to return menu ");

                            while (Console.ReadKey().Key != ConsoleKey.Enter)
                            {
                                Console.Clear();
                                break;
                            }
                            break;
                        }

                        if (Tnumber % 2 == 0) T = "X";
                        else T = "O";

                        while (Tnumber < 9)

                        {
                            Console.Write($"{T}'s move > ");
                            input = Console.ReadLine();
                            if (!int.TryParse(input, out inputNumber)) continue;
                            switch (inputNumber)
                            {
                                case 1:
                                    if (n[1] != " ")
                                    {
                                        Display.IllegalMove();
                                        continue;
                                    }
                                    n[1] = T;
                                    break;
                                case 2:
                                    if (n[2] != " ")
                                    {
                                        Display.IllegalMove();
                                        continue;

                                    }
                                    n[2] = T;
                                    break;
                                case 3:
                                    if (n[3] != " ")
                                    {
                                        Display.IllegalMove();
                                        continue;
                                    }
                                    n[3] = T;
                                    break;
                                case 4:
                                    if (n[4] != " ")
                                    {
                                        Display.IllegalMove();
                                        continue;
                                    }
                                    n[4] = T;
                                    break;
                                case 5:
                                    if (n[5] != " ")
                                    {
                                        Display.IllegalMove();
                                        continue;
                                    }
                                    n[5] = T;
                                    break;
                                case 6:
                                    if (n[6] != " ")
                                    {
                                        Display.IllegalMove();
                                        continue;
                                    }
                                    n[6] = T;
                                    break;
                                case 7:
                                    if (n[7] != " ")
                                    {
                                        Display.IllegalMove();
                                        continue;
                                    }
                                    n[7] = T;
                                    break;
                                case 8:
                                    if (n[8] != " ")
                                    {
                                        Display.IllegalMove();
                                        continue;
                                    }
                                    n[8] = T;
                                    break;
                                case 9:
                                    if (n[9] != " ")
                                    {
                                        Display.IllegalMove();
                                        continue;
                                    }
                                    n[9] = T;
                                    break;
                                default:
                                    Display.IllegalMove();
                                    continue;
                            }
                            i++;
                            Tnumber++;
                            break;
                        }
                    }
                }

                else if (state == Menustate.about)
                {
                    Display.AboutMenu();
                    if (Console.ReadKey().Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        continue;
                    }
                }
                //Exit Game
                else if (state == Menustate.Quit)
                {
                    Display.ExitGame();
                    if (Console.ReadKey().Key == ConsoleKey.Y)
                    {
                        return;
                    }
                }
            }
        }
    }
}
