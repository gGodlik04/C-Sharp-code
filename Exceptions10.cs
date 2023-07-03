using System;
using System.IO;

namespace ICKLUCHENIYA
{
    class Vozrast
    {
        private int den1 { get; set; } =0;
        private int mec9c1 { get; set; } =0;
        private int god1 { get; set; } = 0;
        public void vvod()
        {
            try
            {
                StreamReader d = new StreamReader("input.txt");
                int den = Convert.ToInt32(d.ReadLine());
                int mec9c = Convert.ToInt32(d.ReadLine());
                int god = Convert.ToInt32(d.ReadLine());
                den1 = den;
                mec9c1 = mec9c;
                god1 = god;
                d.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
        }
        public void vozrast()
        {
            Console.WriteLine("Введите сегоднешнее число");
            Console.WriteLine("День");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Месяц");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Год");
            int g = Convert.ToInt32(Console.ReadLine());
            if (m > mec9c1)
            {
                g = g - god1;
                if (d > den1)
                {
                    m = m - mec9c1;
                    d = d - den1;
                }
                else
                {
                    m = m - mec9c1 + 1;
                    d = den1 - d;
                }
            }
            else
            {
                g = g - god1 + 1;
                m = mec9c1 - m;
                if (d>den1)
                {
                    d = d - den1;
                }
                else
                {
                    d = den1 - d;
                }
            }
            Console.WriteLine($"Возраст {g} лет, {m} месяцев ,{d} дней ");
        }
    }

   class Program
        {
        static void Main()
        {
            Vozrast vozrast22 = new Vozrast();
            vozrast22.vvod();
            vozrast22.vozrast();
        }
   }
    
}
