	using System;
	
	namespace Symbols15
	{
	    class CH
	    {
	        public static void program(string s, out char[] c) //ВВОД СТРОКИ В СИМВОЛЬНЫЙ
	        {                                                // МАССИВ
	            c = s.ToCharArray();
	            int l = s.Length;
	        }
	        public static void print(char[] ch)     // ввод строки и символа в метод
	        {
	            string q = "";
	            Array.Reverse(ch);
	            for (int i = 0; i < ch.Length; i++) //  строка перевернута
	            {                                  // в массиве через метод 
	                q = q + ch[i];                // array.reverse
	            }
	            Console.WriteLine(q);
	
	        }
	        class Program
	        {
	            static void Main()
	            {
	                char[] c;
	                Console.WriteLine("введите строку ");
	                string t = Console.ReadLine();
	                CH.program(t, out c);
	                CH.print(c);
	            }
	        }
	    }
	}
