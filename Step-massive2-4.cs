using system;
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
            double min = 100000;
            int miin = 0;  \\ конец объявления
            for (int i = 0; i < crg.Length; i++) \\  цикл для нахождения миним.элемента
            {
                crgc[i] = Convert.ToDouble(crg[i]);
                sum = sum + crgc[i];
                if (crgc[i] < min)
                {
                    min = crgc[i];
                }
            }
            String gate = "OUTPUT.txt";  \\ открытие потока на вывод
            StreamWriter db = new StreamWriter(gate);
            for (int i = 0; i < crg.Length; i++) \\ цикл для нахождения нечетных эл-ов и вычетание из них min, вывод массива
            {
                if (crgc[i] % 2 != 0)
                {
                    crgc[i] = crgc[i]-min;
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
