using System;

namespace gaga1212
{
    class Program
    {
        public static string[] ernmas(string k)
        {
            string p = ", ";
            string[] cifra = k.Split(p);
            return cifra;
        }
        public static void max(string []cifra)
        {
         for (int i=0; i<cifra.Length;i++)
            {
                Console.WriteLine(cifra[i]);
            }
        }
        static void Main()
        {
            string k = "один, два, три, четыре, пять, шесть, семь, восемь, девять, ";
            Console.WriteLine(k);
            string[] cifra;
            cifra=Program.ernmas(k);
            Program.max(cifra);

        }
    }
}
