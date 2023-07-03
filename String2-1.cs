using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("кол-во строк");
            int k = Convert.ToInt32(Console.ReadLine()); // создание массива
            string[] wk = new string[k];
            for (int i = 0; i < k; i++)  // ввод в массив строк
            {
                string u = Console.ReadLine();
                wk[i] = u;
            }                            // конец ввода
            for (int i = 0; i < k; i++) // нахождение кол-ва символов через .length
            {
                string w = wk[i];
                wk[i] = Convert.ToString(w.Length);
                Console.WriteLine($"строка номер {i}= {wk[i]} кол-во символов"); // вывод
            }
        }
    }
}
