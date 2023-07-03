using System;

namespace Stirngs1
{
    class ch
    {
        public static void probel(string s)
        {
            Console.WriteLine();
            Console.WriteLine(s);
            s = s.Replace(" ", "");
            Console.WriteLine(s);
        }
        public static void defis(string s)
        {
            Console.WriteLine();
            Console.WriteLine(s);
            s = s.Replace(" ", "-");
            Console.WriteLine(s);
        }
        public static void inversiya(string s, out char[] c)
        {
            Console.WriteLine();
            Console.WriteLine(s);
            c = s.ToCharArray();
            Array.Reverse(c);
            string output = new string(c);

            Console.WriteLine(output);
        }
        public static void chetAandT(string s, out char[] g)
        {
            Console.WriteLine();
            Console.WriteLine(s);
            g = s.ToCharArray();
            char a = 'а';
            char t = 'т';
            int p = 0;
            int r = 0;
            for (int i = 0; i < g.Length; i++)
            {
                if (g[i] == a)
                    p = p + 1;
                else if (g[i] == t)
                    r = r + 1;
            }
            Console.WriteLine($"кол-во 'a'= {p}         кол-во 'т'= {r}");
        }
        public static int ChetClov(string s)
        {
            Console.WriteLine();
            Console.WriteLine(s);
            string s2 = " ";
            bool b = true;
            int e = 1;
            while (b)
            {
                b = s.Contains(s2);
                if (b)
                {
                    int n = s.IndexOf(" ");
                    s = s.Remove(n, 1);
                    e = e + 1;
                }
            }
            Console.WriteLine(e);
            return e;
        }
        public static void MasIzClov(string s)
        {
            int r = ChetClov(s);
            string[] l = new string[r];
            Console.WriteLine();
            Console.WriteLine(s);
            string s2 = " ";
            for (int i = 0; i < r; i++)
            {
                int n = s.IndexOf(" ");
                l[i] = s.Substring(1, n - 1);
                s = s.Remove(1, n);
                Console.WriteLine(s);
            }
             l[r-2]=s;

        }
    }
    class Program
    {
        static void Main()
        {
            string test = "Это строка для теста";
            Console.WriteLine(test);
            ch.probel(test);
            ch.defis(test);
            char[] c;
            ch.inversiya(test, out c);
            char[] g;
            ch.chetAandT(test, out g);
            ch.ChetClov(test);
            string[] l;
            ch.MasIzClov(test);
        }
    }
}