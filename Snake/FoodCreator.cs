using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class FoodCreator // Класс предназначен для создания еды на игровом поле.
    {
        int mapWidht;//Размеры поля
        int mapHeight;
        char sym; //Символ для отображения еды

        Random random = new Random();

        public FoodCreator(int mapWidht, int mapHeight, char sym)
        {
            this.mapWidht = mapWidht;
            this.mapHeight = mapHeight;
            this.sym = sym;
        }
            public Point CreateFood()//Создаёт еду в рандомном месте                     
        {
            int x = random.Next(2, mapWidht - 2);
            int y = random.Next(2, mapHeight - 2);
            return new Point(x, y, sym);
        }
    }
} 
