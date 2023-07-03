using System;
using System.IO;

namespace Step-massiv
{
    class Program
    {
        static void chten()
        {
            string[] crg;     \\ открытие потока и объявл. Массива как и в др програмах
            string path = "test.txt";
            StreamReader sw = new StreamReader(path);
            crg = sw.ReadLine().Split(' ');
            sw.Close();
            double[] crgc = new double[crg.Length];
            int k = crg.Length;
            double sum = 0;
            double min = 100000;
            int miin = 0;   \\ конец объявления
            for (int i = 0; i < crg.Length; i++) \\ цикл для нахождения минимального знач
            {
                crgc[i] = Convert.ToDouble(crg[i]);
                sum = sum + crgc[i];
                if (crgc[i] < min)
                {
                    miin = i;
                    min = crgc[i];
                }
            }
            String gate = "OUTPUT.txt";
            StreamWriter db = new StreamWriter(gate);
            int kon = 0;
            kon = Convert.ToInt32(sum / k);
            crgc[Convert.ToInt32(miin)] = kon;
            for (int i = 0; i < crg.Length; i++)
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
