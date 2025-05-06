namespace Snake
{
    public class Menu
    {
        private static string[] menuItems = { "PLAY", "TABLE SCORE", "SETTINGS", "EXIT" };

        public static void ShowMenu()
        {
            (bool musicOn, int difficultyIndex, string color) settingsTuple = Settings.SettingsStart();
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
                                Program.StartGame(settingsTuple); // Передаем settingsTuple
                                break;
                            case 1:
                                FileReader.ReadFileAndPrintTable();
                                break;
                            case 2:
                                settingsTuple = Settings.SettingsStart(); // теперь возвращает такой же value tuple
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
