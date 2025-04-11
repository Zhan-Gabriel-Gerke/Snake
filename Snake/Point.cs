using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;//Public - Доступно из других классов
        public int y;
        public char sym;
        public Point()//Пишем свой конструктор
        {
        }
        /*
         * Инкапсуляция — это сокрытие внутренней реализации объекта от внешнего мира 
         * и предоставление к нему доступа только через публичный интерфейс.
         */
        public Point(int _x, int _y, char _sym)//Инкапсулировали код
        {
            x = _x;
            y = _y;
            sym = _sym;
        }
        public void Draw()//Draw - Просто название
        {
            Console.SetCursorPosition(x, y);//Устанавливает курсов по x & y
            Console.Write(sym);//Печетает символ в месте курсора
        }
    }
}
 