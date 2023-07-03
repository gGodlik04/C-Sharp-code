using System;
using System.IO;

namespace ICKLUCHENIYA
{
    class derevo
    {
        private int[] prirost = new int[10];
        public int[] Prirost { get { return prirost; } }
        private string nazvanieb { get; set; } = "";
        private int vozrastb { get; set; } = 0;
        private int visotab { get; set; } = 0;

        public void visota()
        {
            Console.WriteLine($"введите высоту");
            visotab = Convert.ToInt32(Console.ReadLine());
        }
        public void vozrast()
        {

            Console.WriteLine($"Возраст");
            vozrastb = Convert.ToInt32(Console.ReadLine());
        }
        public void nazvanie()
        {
            Console.WriteLine("Введите название дерева");
            nazvanieb = Console.ReadLine();
        }
        public void derevoa()
        {
            double q = 0;
            Console.WriteLine("Введите возраст дерева за 10 лет");
            for (int i=0;i<Prirost.Length;i++)
            {
                Prirost[i] = Convert.ToInt32(Console.ReadLine());
                q += Prirost[i];
            }
            q = q / Prirost.Length;
            Console.WriteLine($"Средний прирост дерева за год= {q}");
        }
        public void vivod()
        {
            Console.WriteLine($"высота дерева= {visotab}");
            Console.WriteLine($"Название дерева: {nazvanieb}");
            Console.WriteLine($"Возраст дерева= {vozrastb}");
        }
    }

        class Program
        {
            static void Main()
            {
                derevo derevo22 = new derevo();
            derevo22.visota();
            derevo22.vozrast();
            derevo22.nazvanie();
            derevo22.derevoa();
            derevo22.vivod();
            }
        }
    
}
