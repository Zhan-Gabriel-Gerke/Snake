using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Snake//Название проекта
{
    class Program//Название класса
    {
        static void Main(string[] args)// void - ничего не возвращиает (нету return)
        {
            Console.SetWindowSize(width: 80, height: 25);
            Menu.ShowMenu();
            /*Walls walls = new Walls(80, 25);
            walls.Draw();

            Point p = new Point(4, 5, '*');//Рисует змейкуv
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();
            
            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();
            while (true)

            {
                if (walls.IsHit(snake) || snake.IsHitTail())//Смерть
                {
                    break;
                }
                if(snake.Eat(food))//кушает еду
                {
                    Music.PlayEatSound();
                    food = foodCreator.CreateFood();
                    food.Draw();

                }
                else
                {
                    snake.Move();//Шевелится
                }
                Thread.Sleep(100);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                //Thread.Sleep(100);
                //snake.Move();
            }
            WriteGameOver();
            Console.ReadLine();*/
        }
        public static void StartGame()
        {
            Walls walls = new Walls(80, 25);
            walls.Draw();

            Point p = new Point(4, 5, '*');//Рисует змейку
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();
            while (true)

            {
            if (walls.IsHit(snake) || snake.IsHitTail())//Смерть
            {
            break;
            }
            if(snake.Eat(food))//кушает еду
            {
            Music.PlayEatSound();
            food = foodCreator.CreateFood();
            food.Draw();

            }
            else
            {
            snake.Move();//Шевелится
            }
            Thread.Sleep(100);
            if (Console.KeyAvailable)
            {
            ConsoleKeyInfo key = Console.ReadKey();
            snake.HandleKey(key.Key);
            }
            //Thread.Sleep(100);
            //snake.Move();
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

        static void WriteText(String text, int xOffset, int yOffset)
        {
            Console.SetCursorPosition(xOffset, yOffset);
            Console.WriteLine(text);
        }
    }
}