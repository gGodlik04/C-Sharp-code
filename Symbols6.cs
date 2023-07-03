using System;

namespace Symbols6
{
    class CH
    {

        public static void program(string s, out char[] c) // метод создает символьный массив из строки
        {
            c = s.ToCharArray();

        }
        public static void printmas(char[] db)  // вывод массива через цикл 
        {
            Console.WriteLine(" Строка помещенна в символьный массив\n");
            for (int i = 0; i < db.Length; i++)
            {
                Convert.ToChar(db[i]);
                Console.Write(db[i]);
                Console.Write('\t');
            }
            Console.WriteLine(" \n");
        }
        class Program
        {
            static void Main()
            {
                char[] c;
                string t = Console.ReadLine(); // вводим строку 
                Console.WriteLine(" \n");
                CH.program(t, out c);
                CH.print(c);
            }
        }
    }
}
