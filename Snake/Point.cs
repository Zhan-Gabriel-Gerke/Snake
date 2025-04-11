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

        public void Draw()//Draw - Просто название
        {
            Console.SetCursorPosition(x, y);//Устанавливает курсов по x & y
            Console.Write(sym);//Печетает символ в месте курсора
        }
    }
}
