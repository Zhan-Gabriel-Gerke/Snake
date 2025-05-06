using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Snake
{
    public class FileReader
    {
        // Сделаем метод статическим
        public static void ReadFileAndPrintTable()
        {
            try
            {
                var lines = File.ReadAllLines("scores.txt");

                if (lines.Length == 0)
                {
                    Console.WriteLine("Файл пуст.");
                    return;
                }

                string[] headers = lines[0].Split(',');
                PrintRow(headers);

                for (int i = 1; i < lines.Length; i++)
                {
                    string[] row = lines[i].Split(',');
                    PrintRow(row);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при чтении файла: {ex.Message}");
            }
        }

        private static void PrintRow(string[] row)
        {
            foreach (var column in row)
            {
                Console.Write($"{column.Trim()} \t");
            }
            Console.WriteLine();
        }
    }


}
