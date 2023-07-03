using System;
using System.IO;

namespace ICKLUCHENIYA
{
    class krug
    {
        private int xtochka11 { get; set; } = 0;
        private int xtochka12 { get; set; } = 0;
        private int xtochka21 { get; set; } =0;
        private int xtochka22 { get; set; } = 0;
        private int ytochka11 { get; set; } = 0;
        private int ytochka12 { get; set; } = 0;
        private int ytochka21 { get; set; } = 0;
        private int ytochka22 { get; set; } = 0;

        public void vvod()
        {
            StreamReader d = new StreamReader("input.txt");
            int tochka1 = Convert.ToInt32(d.ReadLine());
            int tochka2 = Convert.ToInt32(d.ReadLine());
            int tochka3 = Convert.ToInt32(d.ReadLine());
            int tochka4 = Convert.ToInt32(d.ReadLine());
            xtochka21 = tochka1/10;
            xtochka22 = tochka2/10;
            xtochka11 = tochka3/10;
            xtochka12 = tochka4/10;
            ytochka21 = tochka1 % 10;
            ytochka22 = tochka2 % 10;
            ytochka11 = tochka3 % 10;
            ytochka12 = tochka4 % 10;
            d.Close();
        }
        public void storona()
        {
            int x11 = xtochka11;
            int x12 = xtochka12;
            int y11 = ytochka11;
            int y12 = ytochka12;
            int pstoron = y12 - y11;
            int vstoron = x12 - x11;
            Console.WriteLine($"Стороны 1-го прямоугольника= {pstoron} , {vstoron}");
        }
        public void storona2()
        {
            int x21 = xtochka21;
            int x22 = xtochka22;
            int y21 = ytochka21;
            int y22 = ytochka22;
            int pstoron = y22 - y21;
            int vstoron = x22 - x21;
            Console.WriteLine($"Стороны 1-го прямоугольника= {pstoron} , {vstoron}");
        }
        public bool Izmena()
        {
            
            Console.WriteLine("Выберите у какого прямоуг-а изм. размеры 1-ый или 2-ой?");
                int p = Convert.ToInt32(Console.ReadLine());
                if (p == 1)
                {
                    Console.WriteLine("Введите новвую координату");
                    xtochka11 = Convert.ToInt32(Console.ReadLine());
                return true;
                }
                else
                {
                    Console.WriteLine("Введите новвую координату");
                    xtochka21 = Convert.ToInt32(Console.ReadLine());
                return false;
                }            
        }
    }

    class Program
    {
        static void Main()
        {
            krug krug22 = new krug();
            krug22.vvod();
            krug22.storona();
            krug22.storona2();
            bool q=krug22.Izmena();
            if (q)
                krug22.storona();
            else krug22.storona2();
        }
    }
}
