using System;
using System.IO;

namespace Step-massiv
{
    class Program
    {
        static void chten()
        {
            string[] crg; ;     \\ открытие потока и объявл. Массива как и в др програмах
            string path = "test.txt";
            StreamReader sw = new StreamReader(path);
            crg = sw.ReadLine().Split(' ');
            sw.Close();
            double[] crgc = new double[crg.Length];
            int k = crg.Length;
            double sum = 0;
            double max = 0;   \\ конец объявления
            for (int i = 0; i < crg.Length; i++) \\ ЦИКЛ с нахождением макс знач массива
            {
                crgc[i] = Convert.ToDouble(crg[i]);
                sum = sum + crgc[i];
                if (crgc[i] > max)
                {
                    max = crgc[i];
                }
            } 
            String gate = "OUTPUT.txt"; \\открытие потока на вывод
            StreamWriter db = new StreamWriter(gate);
            crgc[k-1] = max; \\ замена последнего эл-а массива
            for (int i = 0; i < crg.Length; i++) \\ цикл для  вывода массива
            { 
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
