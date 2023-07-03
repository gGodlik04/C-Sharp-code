using System;
using System.IO;

namespace ICKLUCHENIYA
{
    class krug
    {
        private int nach1 { get; set; } =0;
        private int radius1 { get; set; } = 0;
        private int y1 { get; set; } = 0;
        private int q { get; set; } = 0;
        private int z { get; set; }=0;
        public void vvod()
        {
            StreamReader d = new StreamReader("input.txt");
            int nach = Convert.ToInt32(d.ReadLine());
            int dlina = Convert.ToInt32(d.ReadLine());
            int y = Convert.ToInt32(d.ReadLine());
            radius1 = dlina;
            nach1 = nach;
            y1 = y;
            d.Close();
        }
        public double Ploshad ()
        {
            int R=radius1;
            double S = (3.14 * Math.Pow(R, 2)) / 2;
            return S;
        }
        public double Poluokr ()
        {
            int R = radius1;
            double L = (3.14 * R);
            return L;
        }
        public void VVOD2()
        {
            Console.WriteLine("Введите координаты точки: x и y");
            int s = Convert.ToInt32(Console.ReadLine());
            int f = Convert.ToInt32(Console.ReadLine());
            q = s;
            z = f;
        }
        public void Proverka()
        {
            double xv = q;
            double yv = z;
            double ys = y1;
            double nach2 = nach1;
            double radius2 = radius1;
            if (yv >= ys & yv < Math.Sqrt((Math.Pow(radius2, 2) - Math.Pow(xv, 2))))
            {
                if (xv >= nach2 & xv <= (nach2 + radius2 * 2)) 
                Console.WriteLine("Точка входит в полуокружность");
            }
            else Console.WriteLine("Точка не входит");
        }
    }

    class Program
    {
        static void Main()
        {
            krug krug22 = new krug();
            krug22.vvod();
            krug22.VVOD2();
            double q=krug22.Ploshad();
            Console.WriteLine($"Площадь полукруга= {q}");
            double c = krug22.Poluokr();
            Console.WriteLine($"Длина полуокр= {c}");
            krug22.Proverka();
        }
    }
}
