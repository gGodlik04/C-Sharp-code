	using System;
	
	namespace ConsoleAppgk
	
	{
	    class Program
	    {
	        static void Main()
	        {
	            string k = ("`((x+3)*1`(x*3))/2`x+3`t-4*4`((q-7)*7)/2");
	            string[] str = k.Split('`');
	            for (int i = 1; i < str.Length; i++)
	            {
	                Console.WriteLine(str[i]);
	            }
	            Console.WriteLine();
	            Console.WriteLine("не сбалансированые строки");
	            Console.WriteLine();
	            int p = 0;
	            int l = 0;
	            for (int i = 1; i < str.Length; i++)
	            {
	                char []ch = str[i].ToCharArray();// во всех строках массива считается кол-во
	                for (int d=0; d<ch.Length;d++)  // знаков ')' и '(' далее сравнивается и выводится
	                {
	                    if (ch[d] == '(')
	                        l++;
	                    else if (ch[d] == ')')
	                        p++;
	                }
	                if (l != p)
	                {
	                    Console.WriteLine(str[i]);
	                }
	                p = 0;
	                l = 0;
	                
	
	            }
	        }
	    }
	}
