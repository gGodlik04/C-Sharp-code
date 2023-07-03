	using System;
	
	namespace Symbols16
	{
	    class CH
	    {
	        public static void program(string s, out char[] c) //ВВОД СТРОКИ В СИМВОЛЬНЫЙ
	        {                                                // МАССИВ
	            c = s.ToCharArray();
	        }
	        public static void print(char[] ch,string t)     // ввод строки и символа в метод
	        {
	            string q ="";
	            Array.Reverse(ch);
	            for (int i=0;i<ch.Length;i++) //переворачиваем массив
	            {
	                q = q + ch[i];  // создаем строку из массива
	
	            }
	            if (q == t) // сравниваем строки
	                Console.WriteLine("строка одинакова");
	            else Console.WriteLine("строка не одинакова");
	
	        }
	        class Program
	        {
	            static void Main()
	            {
	                char[] c;
	                Console.WriteLine("введите строку ");
	                string t = Console.ReadLine();
	                CH.program(t, out c);
	                CH.print(c, t);
	            }
	        }
	    }
	}
