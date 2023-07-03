	using System;
	
	namespace Symbols12
	{
	    class CH
	    {
	        public static void program(string s, out char[] c) //ВВОД СТРОКИ В СИМВОЛЬНЫЙ
	        {                                                // МАССИВ
	            c = s.ToCharArray();
	            int l = s.Length;
	        }
	        public static void print(char[] ch)     // Проверка каждого символа в массиве 
	        {                                      
	            Console.WriteLine("введите символы \n");
	            string y= Console.ReadLine(); 
	            string x = Console.ReadLine();
	            Console.WriteLine();
	            char f = y[0];
	            char t = x[0];
	            string q = "";
	            for (int i = 0; i < ch.Length; i++) // через цикл находится  символов
	            {                                  // и меняется местами с другим символом
	                if (ch[i] == f) 
	                    ch[i] = t;
	                else if (ch[i] == t)
	                    ch[i] = f;
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
	                string t = Console.ReadLine();
	                CH.program(t, out c);
	                CH.print(c);
	            }
	        }
	    }
	}
