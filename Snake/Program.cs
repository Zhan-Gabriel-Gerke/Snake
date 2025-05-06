using System;
using System.IO;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(width: 80, height: 25);
            Menu.ShowMenu();
        }

        public static void StartGame((bool musicOn, int difficultyIndex, string color) settingsTuple)
        {
            bool musicOn = settingsTuple.musicOn;
            int level = settingsTuple.difficultyIndex;
            string colorz = settingsTuple.color;

            if (musicOn)
            {
                Music.PlayStartSound();
            }
            Console.BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), colorz); //chat
            for (int y = 0; y < 25; y++)
            {
                for (int x = 0; x < 80; x++)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write(' ');
                }
            }
            Console.ResetColor();

            Walls walls = new Walls(80, 25);
            //if (level == 2 || level == 3)
            //{
                walls.DrawObstacles(level);
            //}
            walls.Draw();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            Score score = new Score(0, 2, 0);
            score.ShowScore();  // Отображаем счёт на экране в начале игры

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

                    score.AddPoints(1);  // Добавляем 1 очко за съеденную еду
                    score.ShowScore();  // Обновляем отображение счёта
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

            int finalScore = score.CurrentScore;  // Используем правильное свойство для счёта
            WriteGameOver(finalScore);
            Console.ReadLine();
        }

        static void WriteGameOver(int score)
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
            WriteText("Author: Zhan :) Have a wonderful day", xOffset + 2, yOffset++);
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
                        throw new Exception("Name must include 3 or more characters.");
                    }
                    Console.WriteLine($"Thank you for your time, {name}!");
                    FileWrite fileWriter = new FileWrite();
                    fileWriter.SaveScore(name, score);
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
