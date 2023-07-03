	using System;
	
	namespace Symbols18
	{
	    class CH
	    {
	        public static void program(string s, out char[] c) //ВВОД СТРОКИ В СИМВОЛЬНЫЙ
	        {                                                // МАССИВ
	            c = s.ToCharArray();
	        }
	        public static void print(char[] ch)     // ввод строки и символа в метод
	        {
	            string r = "";
	            r = r + ch[0]; // берется первый символ из массива преобразовывается
	            string k = "";  // в строку и делаем заглавным
	            string v = "";
	            r = r.ToUpper();
	            for (int i = 1; i < ch.Length;i++)
	            {
	                k = k + ch[i]; // делаем строку из массива и делаем ее строчной
	            }
	            k = k.ToLower(); // соединяем все части
	            v = v + r;
	            v = v + k;
	            Console.WriteLine(v);
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
