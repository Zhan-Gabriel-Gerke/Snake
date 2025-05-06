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
            // Ограничение по краям экрана (общая рамка для всех уровней)
            HorizontalLine edgeTop = new HorizontalLine(0, 79, 0, '#');
            //HorizontalLine edgeBottom = new HorizontalLine(0, 79, 24, '#');
            VerticalLine edgeLeft = new VerticalLine(0, 10, 0, '#');
            VerticalLine edgeRight = new VerticalLine(0, 6, 79, '#');

            wallList.Add(edgeTop);
            //wallList.Add(edgeBottom);
            wallList.Add(edgeLeft);
            wallList.Add(edgeRight);

            if (difficultyIndex == 1)
            {
                // Усложняем уровень с помощью нескольких линий
                // Одна горизонтальная линия по центру
                HorizontalLine midLine = new HorizontalLine(20, 59, 12, '#');
                wallList.Add(midLine);

                // Добавляем вертикальные линии, чтобы пересекались с горизонтальными
                VerticalLine midVertical1 = new VerticalLine(5, 20, 30, '#');
                wallList.Add(midVertical1);
            }
            else if (difficultyIndex == 2)
            {
                HorizontalLine midLine = new HorizontalLine(20, 59, 12, '#');
                VerticalLine midVertical = new VerticalLine(5, 20, 40, '#');
                wallList.Add(midLine);
                wallList.Add(midVertical);
            }

            Draw();
        }



    }
}
