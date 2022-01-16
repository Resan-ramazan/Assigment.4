using System;
using System.Collections.Generic;
using System.Text;

namespace Assigment._4
{
    static class Display
    {
        static public void SetGameColor()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Black;
        }

        static public void GameTable(string[] n)
        {
            for (int j = 1; j <= 9; j++)
                Console.Write(n[j] + (j < 9 ? j % 3 == 0 ? "\n-----\n" : "|" : "\n\n"));
        }

        static public void IllegalMove()
        {
            Console.WriteLine("ILLEGAL MOVE ! TRY AGAİN");
        }

        static public void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to Tic-Tac-Toe!");
            Console.WriteLine("=======================");
            Console.WriteLine();
        }
        static public void GameMenu()
        {
            Console.Clear();
            Console.WriteLine("1. New Game");
            Console.WriteLine("2. About the author");
            Console.WriteLine("3. Exit");
        }

        static public void AboutMenu()
        {
            Console.Clear();
            Console.WriteLine("Coded by Ramazan, 2021. All rights reserved.");
            Console.WriteLine("Press enter to return menu ");
        }

        static public void ExitGame()
        {
            Console.WriteLine("Are you sure you want to exit? Press Y to exit, any key to return to main menu");
        }
    }
}

