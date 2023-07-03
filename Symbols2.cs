using System;

namespace Symbols2
{
    class CH
    {
        public static void program(string s, out char[] c)  // создаем массив из символов строки
        {
            c = s.ToCharArray();
            int l = s.Length;   
        }
        public static void print(char[] ch) // выводим массив
        {
            Console.WriteLine();
            for (int i = 0; i < ch.Length; i++)
            {
                Console.Write(ch[i] + " в 10-ом и 16-ом коде=");
                Console.Write("{1,3:D}", (int)ch[i], (int)ch[i]);
                Console.WriteLine("{1,3:X}", (int)ch[i], (int)ch[i]);

            }
        }
        class Program
        {
            static void Main()
            {
                char[] c;
                string t = Console.ReadLine(); // вводим строку
                CH.program(t, out c);
                CH.print(c);
            }
        }
    }
}
