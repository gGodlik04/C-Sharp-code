using System;

namespace ConsoleAppgk

{
    class Program
    {
        static void Main()
        {
            string k = ("`саша паша даша маша каша`вася петя вова вива кока нона`грета врита фрита мита кота сата бита`люба саня таня маня`");
            string[] sl = k.Split('`');
            for (int i = 1; i < sl.Length; i++)
            {
                Console.WriteLine(sl[i]);
            }
            Console.WriteLine("задание номер 1");
            Console.WriteLine();
            for (int i = sl.Length - 1; i >= 1; i--) // из строки в массиве создается новый массив символов
            {
                char[] arr = sl[i].ToCharArray();   // которые переворачивается с помощью Reverse и ToCharArray
                Array.Reverse(arr);
                sl[i] = new string(arr);
                Console.WriteLine(sl[i]);
            }
            Console.WriteLine();
            Console.WriteLine("задание номер 2");
            Console.WriteLine();
            for (int i = 1; i < sl.Length; i++)  // тот же перевернутый массив выводится в обратную сторону
            {
                char[] arr = sl[i].ToCharArray();
                Array.Reverse(arr);
                sl[i] = new string(arr);
                Console.WriteLine(sl[i]);
            }
        }
    }
}