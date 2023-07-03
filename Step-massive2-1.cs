using System;
using System.IO;

namespace Step-massive2
{
    class Program
    {
        static void chten()
        {
            string[] crg;   \\ объявление массива
            string path = "test.txt";
            StreamReader sw = new StreamReader(path); \\ создание потока
            crg = sw.ReadLine().Split(' ');  \\ создание массива из строки
            sw.Close();
            double[] crgc = new double[crg.Length]; 
            int k = crg.Length;
            double sum = 0;
            for (int i = 0; i < crg.Length; i++) \\ цикл для перебора массива
            {
                crgc[i] = Convert.ToDouble(crg[i]); \\ присваивание другому массива значений Double 
                sum = sum + crgc[i]; \\ сложение массива
            }
            String gate = "OUTPUT.txt";  \\ открытие потока на вывод
            StreamWriter db = new StreamWriter(gate);
            double kon = 0;
            kon = Math.Pow(sum, 1 / k);
            for (int i = 0; i < crg.Length; i++)  \\ вывод массива
            {
                crgc[i] = crgc[i] / kon;
                db.Write(crgc[i]+5 + " ");
            }
            db.Close();
        }
        static void Main()
        {
            Program.chten();
        }
    }
}
