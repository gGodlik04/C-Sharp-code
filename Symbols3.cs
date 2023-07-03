using System;

namespace Symbols3
{
    class CH
    {
        public static void print(char a, char b) //МЕТОД  ДЛЯ ВЫВОД ОТ ПЕРЕМЕННОЙ
        {                                       // А ДО ПЕРЕМЕННОЙ В ЧЕРЕЗ ЦИКЛ
            Console.WriteLine();
            for (char i = a; i <= b; i++)
            {
                int code1 = (int)i;
                Console.WriteLine("'{0}'\t{1,3:D}\t{2,3:X}", i, code1, code1);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

        }
        class Program
        {
            static void Main()
            {
                char a = 'А';  // НАЧАЛЬНЫЕ ЗАДАННЫЕ ПЕРЕМЕННЫЕ
                char b = 'Я';
                char a1 = 'A';
                char b1 = 'Z';
                char a2 = '0';
                char b2 = '9';

                Console.WriteLine("Русск.букв:А..Я"); // ВЫЗОВ МЕТОДА ВЫВОДА АЛФОВИТА
                CH.print(a, b);
            }
        }
    }
}
