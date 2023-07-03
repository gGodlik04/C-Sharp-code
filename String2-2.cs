using System;

namespace ConsoleAppgk

{
    class Program
    {
        static void Main()
        {
            string k = ("`Я помню чудное мгновенье:`Передо мной явилась ты?`Как мимолетное виденье,`Как гений чистой красоты.");
            string[] str = k.Split('`');
            for (int i = 1; i < str.Length; i++)
            {
                Console.WriteLine(str[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Введите номер строки");
            int q = Convert.ToInt32(Console.ReadLine()); // с помощью split создаем массив строк
            str[q] = "-";
            string s = "?";
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i].EndsWith("?"))
                    str[i] = "-";
                if (str[i]!="-") // обнуляем не обходимую строку и ищем вопрос.знак
                Console.WriteLine(str[i]);
            }
        }
    }
}
