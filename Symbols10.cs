	using System;
	
	namespace Symbols10
	{
	    class CH
	    {
	        public static void program(string s, out char[] c) //ВВОД СТРОКИ В СИМВОЛЬНЫЙ
	        {                                                // МАССИВ
	            c = s.ToCharArray();
	            int l = s.Length;
	        }
	        public static void print(char[] ch)     // Проверка каждого символа в массиве на 
	        {                                      // букву или цифр через код символов
	            Console.WriteLine("введите символ для поиска\n");
	            string y= Console.ReadLine(); // в переменную присваивается символ для сравнения
	            Console.WriteLine();
	            int w = 0;
	            char f = y[0];
	            for (int i = 0; i < ch.Length; i++) // через цикл находится кол-во символов
	            {
	                if (ch[i]==f)
	                    w++;
	            }
	            Console.WriteLine($"кол-во символов={w} ");
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
