using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figure
    {
        protected List<Point> pList; //protected — доступен в самом классе и его наследниках.


        public virtual void Draw()//virtual — метод можно переопределить в наследуемом классе.
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }

        internal bool IsHit(Figure figure)//Проверяет столкнулась ли одна фигура с другой
        {
            foreach (var p in pList)
            {
                if(figure.IsHit(p))
                    return true;
            }
            return false;
        }
        
        private bool IsHit(Point point)//Проверяет, попадает ли заданная точка внутрь фигуры.

        {
            foreach (var p in pList)
            {
                if (p.IsHit(point))
                    return true;
            }
            return false;
        }
    }
}
