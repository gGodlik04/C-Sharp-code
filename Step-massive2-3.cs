using System;
using System.IO;

namespace Step-massiv
{
    class Program
    {
        static void chten();     \\ открытие потока и объявл. Массива как и в др програмах
        {
            string[] crg;
            string path = "test.txt";
            StreamReader sw = new StreamReader(path);
            crg = sw.ReadLine().Split(' ');
            sw.Close();
            double[] crgc = new double[crg.Length];
            int k = crg.Length;
            double sum = 0;
            double min = 100000;
            int miin = 0;  \\ конец объявления 
            for (int i = 0; i < crg.Length; i++) \\ цикл для  замена ср.арефм массива на мин. Элемент массива 
            {
                crgc[i] = Convert.ToDouble(crg[i]);
                sum = sum + crgc[i];
                if (crgc[i] < min)
                {
                    min = crgc[i];
                }
            }
            String gate = "OUTPUT.txt";
            StreamWriter db = new StreamWriter(gate); \\ вывод массива с условием четности
            for (int i = 0; i < crg.Length; i++)
            {
                if (crgc[i] % 2 != 0)
                {
                    crgc[i] = min;
                }
                db.Write(crgc[i] + " ");
            }
            db.Close();
        }
            static void Main()
            {
                Program.chten();
            }
    }
}
