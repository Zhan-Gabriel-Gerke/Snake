using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine
    {
        List<Point> pList;

        public VerticalLine(int xLowest, int xHiest, int y, char sym)
        {
            pList = new List<Point>();
            for (int x = xHiest; x <= xLowest; x--)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
        public void Drow()
        {
            foreach(Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
