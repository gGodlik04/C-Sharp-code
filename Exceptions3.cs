using System;
using System.IO;

namespace Exception3
{
    class zdanie
    {
        private int chlenOdin = 0; // св-ва 
        private int znamenatel = 0;
        private int znach_arumenta = 0;
        private int q = 0;
        public int chlenOdin1
        {
            get
            {
                return chlenOdin;
            }
            set
            {
                chlenOdin = value;
            }
        }
        public int znamenatel1
        {
            get
            {
                return znamenatel;
            }
            set
            {
                znamenatel = value;
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
        int n;
        int h;
        int[] a;
        zdanie Zdanie = new zdanie();
        public osnova()
        {
        }
        public int[] vvod()   // ввод из файла
        {
            StreamReader d = new StreamReader("input.txt");
            try
            {
                a = new int[2];
                string chlenOdin = d.ReadLine();
                string znamenatel = d.ReadLine();
                Console.WriteLine(chlenOdin); Console.WriteLine(znamenatel);
                Zdanie.chlenOdin1 = Convert.ToInt32(chlenOdin);
                Zdanie.znamenatel1 = Convert.ToInt32(znamenatel);
                a[0] = Zdanie.chlenOdin1;
                a[1] = Zdanie.znamenatel1;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
            d.Close();
            return a;
        }
        public osnova(int p, int g,int[]q)  // нахождение значения многочлена
        {
            a = new int[2];
            int w = q[0];
            int y = q[1];
            int n = 0;
            int h = 0;
            n = Convert.ToInt32(w * Math.Pow(y, p - 1)); // n-ый член прогрессииэ
            h = Convert.ToInt32(w * (Math.Pow(y, g - 1)) / (y - 1)); // сумма n-ых членов
            a[0] = n;
            a[1] = h;
        }
        public osnova(int []t)
        {
            a = new int[2];
            int u = t[0];
            int j = t[1];
            Random rnd = new Random();
            int w = rnd.Next(0, 10);
            int y = rnd.Next(0, 10);
            this.n = n;
            this.h = h;
            n = Convert.ToInt32(u * Math.Pow(j, w - 1)); // n-ый член прогрессииэ
            h = Convert.ToInt32((u * (Math.Pow(j, y) - 1)) / (j - 1)); // сумма n-ых членов
            a[0] = n;
            a[1] = h;
        }
        public void vivod() //вывод  многочлена в файл
        {
            StreamWriter d = new StreamWriter("output.txt", true);
                d.WriteLine($"n-ый член прогресси= {a[0]}, сумма n-ых членов прогресси={a[1]}");
            d.Close();
        }
    }
    class Program
    {
        static void Main()
        {
            int[] p;
            int b = 0;
            osnova db = new osnova();
            p = db.vvod();
            osnova os = new osnova(p);
            Console.WriteLine("Ведите 1-ый член и n=ый член суммы");
            int f = Convert.ToInt32(Console.ReadLine());
            int k = Convert.ToInt32(Console.ReadLine());
            osnova AR1 = new osnova(f, k,p);
            AR1.vivod();           
            os.vivod();
        }
    }
}
