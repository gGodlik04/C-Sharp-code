	using System;
	
	namespace Symbols13
	{
	    class CH
	    {
	        public static void program(string s, out char[] c) //ВВОД СТРОКИ В СИМВОЛЬНЫЙ
	        {                                                // МАССИВ
	            c = s.ToCharArray();
	            int l = s.Length;
	        }
	        public static void print(char[] ch, char r)     // ввод строки и символа в метод
	        {                                               // 
	            string q = "";
	            for (int i = 0; i < ch.Length; i++)  // в массиве происходит проверка на == символу
	            {                                    // далее если == присваивается 0 и не 
	                if (ch[i] ==r)                   //вводится в строку
	                    ch[i] = '0';
	                if (ch[i] != '0')
	                q = q + ch[i];
	            }
	            Console.WriteLine();
	            Console.WriteLine(q);
	        }
	        class Program
	        {
	            static void Main()
	            {
	                char[] c;
	                Console.WriteLine("введите строку и символ");
	                string t = Console.ReadLine();
	                string y = Console.ReadLine();
	                char r = y[0];
	                CH.program(t, out c);
	                CH.print(c, r);
	            }
	        }
	    }
	}
