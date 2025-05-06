using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Menu
    {
        private static string[] menuItems = { "PLAY", "TABLE SCORE", "SETTINGS", "EXIT" };
        /*public static int musicvar { get; set; }
        public static int level { get; set; }
        public static int speed { get; set; }
        static Settings()
        {
            musicvar = 1;
            level = 1;
            speed = 1;  
        }*/
        public static void ShowMenu()
        {
            Console.Clear();
            int row = Console.CursorLeft;
            int col = Console.CursorTop;
            int index = 0;
            while (true)
            {
                DrawMenu(menuItems, row, col, index);
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.DownArrow:
                        if (index < menuItems.Length - 1)
                            index++;
                        break;
                    case ConsoleKey.UpArrow:
                        if (index > 0)
                            index--;
                        break;
                    case ConsoleKey.Enter:
                        switch (index)
                        {
                            case 0:
                                Console.Clear();
                                Program.StartGame();
                                break;
                            case 1:
                                //ScoreTable
                                break;
                            case 2:
                                Settings.SettingsStart();
                                break;
                            case 3:
                                Console.WriteLine("Bye");
                                return;
                            default:
                                Console.Clear();
                                break;
                        }
                        break;
                }
            }
        }
        private static void DrawMenu(string[] items, int row, int col, int index)
        {
            Console.SetCursorPosition(col, row);
            for (int i = 0; i < items.Length; i++)
            {
                if (i == index)
                {
                    Console.BackgroundColor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                Console.WriteLine(items[i]);
                Console.ResetColor();
            }
            Console.WriteLine();
        }
    }
}
//https://ru.stackoverflow.com/questions/1338657/%D0%9A%D0%BE%D0%BD%D1%81%D0%BE%D0%BB%D1%8C%D0%BD%D0%BE%D0%B5-%D0%BC%D0%B5%D0%BD%D1%8E-%D0%BD%D0%B0-c