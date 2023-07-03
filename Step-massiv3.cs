using System;

namespace gaga1212
{
    class Program
    {
        public static string [][] ernmas()
        {
            string[][] stup = new string[3][]; // объявление ступенчатого массива
            stup[0] = new string[3];
            stup[1] = new string[2];
            stup[2] = new string[4];
            for (int i = 0; i < 3; i++)// цикл с вводом данных в массив
            {
                for (int q = 0; q < stup[i].Length; q++)
                {
                    stup[i][q] = Console.ReadLine();
                }
            }
            Console.WriteLine();
            return stup;
        }         
        public static void max(string[][]stup) // метод с нахождением самой длинной строки массива
        {
            int f = 0;
            int r = 0;
            int x = 0;
            Console.WriteLine();
            for (int i = 0; i < 3; i++) // поиск макс. знач 
            {
                for (int q = 0; q < stup[i].Length; q++)
                {
                    if (stup[i][q].Length>f)
                    {
                        f++;
                        r = i;
                        x = q;
                    }
                }              
            }
            Console.WriteLine(); // вывод
            Console.WriteLine($"адрес массива {r};{x},  длина = {f}");
        }
        static void Main()
        {
            string[][]stup= new string[3][];
            stup=Program.ernmas();
            Program.max(stup);
        }
    }
}
