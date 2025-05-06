using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class FileWrite
    {
        private string filename;

        // Конструктор с параметром для имени файла
        public FileWrite(string filename = "scores.txt")
        {
            this.filename = filename;
        }

        // Метод для записи счёта и имени в файл
        public void SaveScore(string name, int score)
        {
            try
            {
                // Открываем файл в режиме добавления, если файл не существует, он будет создан
                using (StreamWriter writer = new StreamWriter(filename, true))
                {
                    writer.WriteLine($"{name}: {score}");
                }
                Console.WriteLine($"Score {name} has been writen!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"error: {ex.Message}");
            }
        }
    }
}
