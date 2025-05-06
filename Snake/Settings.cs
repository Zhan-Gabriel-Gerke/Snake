using System;

namespace Snake
{
    class Settings
    {
        public static (bool musicOn, int difficultyIndex, string color) SettingsStart()
        {
            string[] menuItems = new string[]
            {
                "Level: Easy",
                "Music: ON",
                "Path Color: Black",
                "Exit"
            };

            string[] difficulties = { "Easy", "Medium", "Hard" };
            string[] colors = { "Black", "Blue", "Green" };
            int difficultyIndex = 0;
            bool musicOn = true;
            int colorsIndex = 0;

            Console.WriteLine("Settings");
            Console.WriteLine();

            int row = Console.CursorTop;
            int col = Console.CursorLeft;
            int index = 0;
            while (true)
            {
                DrawMenu(menuItems, row, col, index);
                var key = Console.ReadKey(true).Key;

                switch (key)
                {
                    case ConsoleKey.DownArrow:
                        if (index < menuItems.Length - 1)
                            index++;
                        break;
                    case ConsoleKey.UpArrow:
                        if (index > 0)
                            index--;
                        break;
                    case ConsoleKey.LeftArrow:
                        switch (index)
                        {
                            case 0:
                                if (difficultyIndex > 0) difficultyIndex--;
                                menuItems[0] = $"Level: {difficulties[difficultyIndex]}";
                                break;
                            case 1:
                                musicOn = !musicOn;
                                menuItems[1] = $"Music: {(musicOn ? "ON" : "OFF")}";
                                break;
                            case 2:
                                if (colorsIndex > 0) colorsIndex--;
                                menuItems[2] = $"Path Color: {colors[colorsIndex]}";
                                break;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        switch (index)
                        {
                            case 0:
                                if (difficultyIndex < difficulties.Length - 1) difficultyIndex++;
                                menuItems[0] = $"Level: {difficulties[difficultyIndex]}";
                                break;
                            case 1:
                                musicOn = !musicOn;
                                menuItems[1] = $"Music: {(musicOn ? "ON" : "OFF")}";
                                break;
                            case 2:
                                if (colorsIndex < colors.Length-1) colorsIndex++;
                                menuItems[2] = $"Path Color: {colors[colorsIndex]}";
                                break;
                        }
                        break;
                    case ConsoleKey.Enter:
                        if (index == 3)
                        {
                            Console.Clear();
                            return (musicOn, difficultyIndex, colors[colorsIndex]);
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
                Console.WriteLine(items[i].PadRight(Console.WindowWidth - 1));
                Console.ResetColor();
            }
            Console.WriteLine();
        }
    }
}
