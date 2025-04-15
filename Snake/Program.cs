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
            int desiredWidth = 80;
            int desiredHeight = 25;

            // Получаем текущий размер окна консоли
            int windowWidth = Console.WindowWidth;
            int windowHeight = Console.WindowHeigh;

            // Убедимся, что буфер не меньше окна
            int bufferWidth = Math.Max(desiredWidth, windowWidth);
            int bufferHeight = Math.Max(desiredHeight, windowHeight);

            // Проверим, что значения не превышают short.MaxValue
            bufferWidth = Math.Min(bufferWidth, short.MaxValue - 1);
            bufferHeight = Math.Min(bufferHeight, short.MaxValue - 1);

            // Установим безопасно размер буфера
            Console.SetBufferSize(bufferWidth, bufferHeight);


            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            rightLine.Drow();

            Point p = new Point(4, 5, '*');
            p.Draw();
        }
    }
}  