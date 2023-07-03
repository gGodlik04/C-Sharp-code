using System;

namespace Symbols4
{
    class CH
    {
        public static void program(string s, out char[] c) //ВВОД СТРОКИ В СИМВОЛЬНЫЙ
        {                                                // МАССИВ
            c = s.ToCharArray();
            int l = s.Length;
        }
        public static void print(char[] ch)     // МЕТОД ВЫЗЫВАЮЩИЙ ВЫВОД МАССИВА
        {                                      // В 16 И 8 КОДЕ
            Console.WriteLine();
            for (int i = 0; i < ch.Length; i++)
            {
                Console.Write(ch[i] + "   в 8-ом и 16-ом коде=");
                Console.WriteLine((int)ch[i]);
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
