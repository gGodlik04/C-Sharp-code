	using System;
	
	namespace Symbols19
	{
	    class CH
	    {
	        public static void program(string s, out char[] c) //ВВОД СТРОКИ В СИМВОЛЬНЫЙ
	        {                                                // МАССИВ
	            c = s.ToCharArray();
	        }
	        public static void ChetClov(char[] ch)  // МЕТОД СЧИТАЮЩИЙ КОЛ-ВО СЛОВ В СТРОКЕ
	        {
	            string q = "";
	            string w = "";
	            for (int i=0;i<ch.Length;i++ ) // проверяем весь массив на наличие раздел.символов
	            {
	                if (ch[i] == ',' | ch[i] == '[' | ch[i] == ']' | ch[i] == ';'
	                        | ch[i] == ':' | ch[i] == '!' | ch[i] == '-' | ch[i] == '(' |
	                        ch[i] == ')' | ch[i] == '.' | ch[i] == '?')
	                    q = q + ch[i];
	            }
	            Console.WriteLine(q);
	        } // КОНЕЦ МЕТОДА --------
	
	        class Program
	        {
	            static void Main()
	            {
	                char[] c;
	                Console.WriteLine("введите строку ");
	                string t = Console.ReadLine();
	                CH.program(t, out c);
	                CH.ChetClov(c);
	            } }
	            }
	        }
