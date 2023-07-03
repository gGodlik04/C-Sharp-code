using System;

namespace Symbols
{
    class CH
    {
        public static void program(string s, out char[] c) //ВВОД СТРОКИ В СИМВОЛЬНЫЙ
        {                                                // МАССИВ
            c = s.ToCharArray();
            int l = s.Length;
        }
        public static void print(char[] ch)     // Проверка каждого символа в массиве на пробел
        {                                      // в массиве на пробел
            char g = ' ';
            Console.WriteLine();
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] == g)
                {
                    Console.WriteLine((int)ch[i]);
                }
            }
        }
        class Program
        {
            static void Main()
            {
                char[] c;
                string t = Console.ReadLine();
                CH.program(t, out c);
                CH.print(c);
            }
        }
    }
}
