using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Snake//Название проекта
{
    class Program//Название класса
    {
        static void Main( string[] args)// void - ничего не возвращиает (нету return)
        {
            Point p1 = new Point(1,3,'*');//Создание структуры с помощью вызова пустого конструктора
            p1.Draw();//Вызавает класс Point функцию Draw

            Point p2 = new Point(4, 5, '#');//Создание структуры с помощью вызова пустого конструктора
            p2.Draw();//Вызавает класс Point функцию Draw
            
            HorizontalLine line = new HorizontalLine(5, 10, 8, '+');
            line.Drow();

            Console.ReadLine();
        }
    }
} 