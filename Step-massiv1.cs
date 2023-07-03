using System;

namespace gaga1212
{
    class Program
    {
        static void Main()
        {
            string[][] stup = new string[3][]; // объявление ступенчатого массива
            stup[0] = new string[3];
            stup[1] = new string[2];
            stup[2] = new string[4]; 
            for (int i = 0; i < 3; i++)// цикл с вводом данных в массив
            {
                for (int q = 0; q < stup[i].Length ; q++)
                {
                    stup[i][q] = Console.ReadLine();
                }
            }
            Console.WriteLine();  
            for (int i = 0; i < 3; i++) // вывод массива
            {
                for (int q = 0; q < stup[i].Length; q++)
                {
                    Console.Write($"{stup[i][q]} ") ;
                }
                Console.WriteLine();
            }
        }
    }
}
