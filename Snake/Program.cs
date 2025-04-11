using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake//Название проекта
{
    class Program//Название класса
    {
        static void Main( string[] args)// void - ничего не возвращиает (нету return)
        {
            Point p1 = new Point(1,3,'*');//Создание структуры с помощью вызова пустого конструктора
            /*p1.x = 1;
            p1.y = 3;
            p1.sym = '*';*/
            p1.Draw();//Вызавает класс Point функцию Draw

            Point p2 = new Point(4, 5, '#');//Создание структуры с помощью вызова пустого конструктора
            /*p2.x = 4;
            p2.y = 5;
            p2.sym = '#';*/
            p2.Draw();//Вызавает класс Point функцию Draw

            List<int> numList = new List<int>();//Создание списка
            numList.Add(1);//Добавление значения в список
            numList.Add(2);
            numList.Add(3);
            
            int x = numList[0];//Присвоение значения из списка к переменной
            int y = numList[1];
            int z = numList[2];

            foreach(int i in numList)// Цикл как for x in (list)
            {
                Console.WriteLine(i);//print
            }

            numList.RemoveAt(0); // Удаление из списка по индексу

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);

            Console.ReadLine();
        }
    }
} 