using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls
    {
        List<Figure> wallList;

        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();

            HorizontalLine upLine = new HorizontalLine(0, mapWidth - 2, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, mapWidth - 2, mapHeight - 1, '+');
            VerticalLine leftLine = new VerticalLine(0, mapHeight - 1, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, mapHeight - 1, mapWidth - 2, '+');

            wallList.Add(upLine);
            wallList.Add(downLine);
            wallList.Add(leftLine);
            wallList.Add(rightLine);
        }
        internal bool IsHit(Figure figure)
        {
            foreach(var wall in wallList)
            {
                if(wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }
        public void Draw()
        {
            foreach (var wall in wallList)
            {
                wall.Draw();
            }
        }
        public void DrawObstacles(int difficultyIndex)
        {
            if (difficultyIndex == 2)
            {
                // Горизонтальная линия, разделяющая экран на две части
                HorizontalLine line1 = new HorizontalLine(5, 75, 8, '#');
                HorizontalLine line2 = new HorizontalLine(5, 75, 16, '#');
                wallList.Add(line1);
                wallList.Add(line2);

                // Вертикальные стены, создающие дорожки
                VerticalLine vertical1 = new VerticalLine(9, 15, 20, '#');
                VerticalLine vertical2 = new VerticalLine(9, 15, 60, '#');
                wallList.Add(vertical1);
                wallList.Add(vertical2);
                
                // Маленькие горизонтальные преграды
                HorizontalLine smallLine1 = new HorizontalLine(30, 40, 5, '#');
                HorizontalLine smallLine2 = new HorizontalLine(40, 50, 12, '#');
                wallList.Add(smallLine1);
                wallList.Add(smallLine2);

                // Ограничение по краям экрана (рамка)
                HorizontalLine edgeTop = new HorizontalLine(0, 79, 0, '#');
                HorizontalLine edgeBottom = new HorizontalLine(0, 79, 24, '#');
                wallList.Add(edgeTop);
                wallList.Add(edgeBottom);

                VerticalLine edgeLeft = new VerticalLine(0, 24, 0, '#');
                VerticalLine edgeRight = new VerticalLine(0, 24, 79, '#');
                wallList.Add(edgeLeft);
                wallList.Add(edgeRight);
            }

            Draw();
        }


    }
}
