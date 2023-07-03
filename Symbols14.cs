	using System;
	
	namespace Symbols14
	{
	    class CH
	    {
	        public static void program(string s, out char[] c) //ВВОД СТРОКИ В СИМВОЛЬНЫЙ
	        {                                                // МАССИВ
	            c = s.ToCharArray();
	            int l = s.Length;
	        }
	        public static void print(char[] ch)     
	        {
	            string q = ""; 
	            for (int i=0;i<ch.Length;i++)
	            {
	                if (ch[i]==' ')  // ищем пробел
	                {
	                    int r = i + 1; 
	                    while (ch[r]==' ') // через while ищем все остальные пробелы
	                    {
	                        ch[r] = '`'; // и присваемаем тильду
	                        r++;
	                    }
	                }
	            }
	            for (int i = 0; i < ch.Length; i++) // проверка на тильду 
	            {
	                if (ch[i] != '`')  // и формирование строки из массива
	                    q = q + ch[i];
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
