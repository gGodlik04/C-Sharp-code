using System;
using System.IO;

namespace Step-massiv
{
    class Program
    {
        static void chten()
        {
            string[] crg;  ;     \\ открытие потока и объявл. Массива как и в др програмах
            string path = "test.txt";
            StreamReader sw = new StreamReader(path);
            crg = sw.ReadLine().Split(' ');
            sw.Close();
            int[] crgc = new int[crg.Length];
            int k = crg.Length;
            int sum = 0;
            int prvc = 1;
            int prot = 1;  \\ конец объявления
            for (int i = 0; i < crg.Length; i++) \\ цикл для  нахожд произведения всех эл-ов и отриц.эл-ов
            {
                crgc[i] = Convert.ToInt32(crg[i]);
                prvc = prvc * crgc[i];
                if (crgc[i] < 0)
                {
                    prot = prot * crgc[i];
                }
            }
            String gate = "OUTPUT.txt";
            StreamWriter db = new StreamWriter(gate);
            double chast = 0;
            chast = prvc / prot;               \\ нахождение частного
            db.WriteLine($"Произведение всех элементов массива= {prvc}");  \\ вывод найденных значений 
            db.WriteLine($"Произведение всех отрицательных эл-ом массива= {prot}");
            db.WriteLine($"Частное от произведение всех эл. на отриц.эл-ы= {chast}");
            db.Close();
        }
        static void Main()
        {
            Program.chten();
        }
    }
}
