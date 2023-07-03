using System;
using System.IO;

namespace Exception2
{
    class zdanie
    {
        private int znach_mnogochlena = 0; // св-ва 
        private int clozhen_mnogochlena = 0;
        private int znach_arumenta = 0;
        private int q = 0;
        public int znach_mnogochlena1
        {
            get
            {
                return znach_mnogochlena;
            }
            set
            {
                znach_mnogochlena = value;
            }
        }
        public int clozhen_mnogochlena1
        {
            get
            {
                return clozhen_mnogochlena;
            }
            set
            {
                clozhen_mnogochlena = value;
            }
        }
        public int znach_arumenta1
        {
            get
            {
                return znach_arumenta;
            }
            set
            {
                znach_arumenta = value;
            }
        }
        public int q1
        {
            get
            {
                return q;
            }
            set
            {
                q = value;
            }
        }
    }
    class osnova
    {
        int res = 0;
        zdanie Zdanie = new zdanie();
        public int[] vvod()   // вврд из файла
        {
            int[] q = new int[5];
            StreamReader d = new StreamReader("input.txt");
            try
            {
                int w = 0;
                string r = d.ReadToEnd();
                string[] n = r.Split(' ');
                w = n.Length;
                d.Close();
                for (int i = 0; i < w; i++)
                {
                    q[i] = Convert.ToInt32(n[i]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Перезапустите программу и исправьте входные данные");
            }
            Zdanie.znach_arumenta1 = q[4];
            d.Close();
            return q;
        }
        public void vichesl(int[] q)  // нахождение значения многочлена
        {
            int st = 3;
            for (int i = 4; i >= 0; i--, st--)
            {
                res += q[i] * Convert.ToInt32(Math.Pow(q[i], st));
            }
            Zdanie.znach_mnogochlena1 = res;
        }
        public int[] clozhen(int[] q)  // ввод 2-го многочлена и сложение многочленов
        {
            int[] d = new int[4];
            Console.WriteLine("Введите 2-ой многочлен");
            string w = Console.ReadLine();
            string[] we = w.Split(' ');
            for (int i = 0; i < we.Length; i++)
            {
                d[i] = Convert.ToInt32(we[i]);
                q[i] = q[i] + d[i];
            }
            return q;
        }
        public void vivod(int[] ar) //вывод  многочлена в файл
        {
            StreamWriter d = new StreamWriter("output.txt", true);
            int x = 3;
            for (int i = 0; i < 3; i++, x--)
            {
                d.Write($"{ar[i]}x^{x} + ");
            }
            d.Write($"{ar[3]}x^{0}");
            d.WriteLine();
            d.Close();
        }
        public void ew() //вывод значение многочлена
        {
            StreamWriter d = new StreamWriter("output.txt", true);
            d.WriteLine();
            d.Write($"Значение многочлена={Zdanie.znach_mnogochlena1}");
            d.Close();
        }
    }
    class Program
    {
       static void Main()
        {
            osnova os = new osnova();
            int []p;
            p=os.vvod();
            os.vivod(p);
            os.vichesl(p);
            p=os.clozhen(p);
            os.vivod(p);
            os.ew();
        }
    }
}
