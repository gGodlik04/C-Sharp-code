using System;
using System.IO;

namespace ICKLUCHENIYA
{
    class Numbers
    {
        private int chislo { get; set; } = 0;
        public void vvod()
        {
            try
            {
                StreamReader d = new StreamReader("input.txt");
                int chisl = Convert.ToInt32(d.ReadLine());
                chislo = chisl;
                d.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
        }
        public double Perevod()
        {
            double x = 0 ;
            int q = chislo;
            for(int i=0;i<4;i++)
            {
                int w = q % 10;
                x = Math.Pow(2, i) * w + x;
            }
            return x;
        }
        public double Sdvig()
        {
            double x = 0;
            int q = chislo;
            int a=q;
            Console.WriteLine("На сколько разрядов сделать сдвиг?");
            int p = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < p; i++)
            {
               a = (a - 1000) * 10;
            }
            return a;
        }
    }

        class Program
        {
            static void Main()
            {
                Numbers numbers22 = new Numbers();
            numbers22.vvod();
            double t=numbers22.Perevod();
            StreamWriter d = new StreamWriter("output.txt");
            d.WriteLine($"в десятичном число = {t}");
            double l=numbers22.Sdvig();
            d.WriteLine($"cо сдвигом влево= {l}");
            d.Close();
            }
        }
    
}
