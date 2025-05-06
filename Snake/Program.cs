using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(width: 80, height: 25);
            Menu.ShowMenu();
        }

        public static void StartGame((bool musicOn, int difficultyIndex, int speed) settingsTuple)
        {
            bool musicOn = settingsTuple.musicOn;
            int level = settingsTuple.difficultyIndex;
            int speed = settingsTuple.speed;

            if (musicOn)
            {
                Music.PlayStartSound();
            }

            // Создаём экземпляр класса Walls
            Walls walls = new Walls(80, 25);

            // Вызываем метод DrawObstacles на объекте walls
            if (level == 2 || level == 3)
            {
                walls.DrawObstacles(level);
            }

            walls.Draw();
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();
            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }
                if (snake.Eat(food))
                {
                    if (musicOn)
                    {
                        Music.PlayEatSound();
                    }
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }
            WriteGameOver();
            Console.ReadLine();
        }


        static void WriteGameOver()
        {
            Console.Clear();
            Music.PlayGameOverSound();
            int xOffset = 25;
            int yOffset = 8;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(xOffset, yOffset++);
            WriteText("============================", xOffset, yOffset++);
            WriteText("G A M E  O V E R", xOffset + 1, yOffset++);
            yOffset++;
            WriteText("Author: Zhan :) Have a wounderfull day", xOffset + 2, yOffset++);
            WriteText("Made Special for Marina", xOffset + 1, yOffset++);
            WriteText("============================", xOffset, yOffset++);
            string name;
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter your name:");
                    name = Console.ReadLine();

                    if (name.Length < 3)
                    {
                        throw new Exception("Name has to inclute 3 or more symbols.");
                    }
                    Console.WriteLine($"Thank you for your's time {name}!");
                    // Если всё ок — выходим из цикла
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Try again.\n");
                }
            }
        }

        static void WriteText(string text, int xOffset, int yOffset)
        {
            Console.SetCursorPosition(xOffset, yOffset);
            Console.WriteLine(text);
        }
    }
}
