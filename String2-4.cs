	using System;
	
	namespace ConsoleAppgk
	
	{
	    class Program
	    {
	       static void Main()
	        {
	            string k = ("`саша паша даша маша каша` вася петя вова вива кока нона`грета врита фрита мита кота сата бита`люба саня таня маня`");
	            string[] str = k.Split('`');
	            for (int i = 1; i < str.Length; i++)
	            {
	                Console.WriteLine(str[i]);
	            }
	            int d = 0;
	            int z = 0;
	            Console.WriteLine();
	            for (int i =1; i < str.Length; i++) // заносим строки в массив
	            { 
	                if (str[i].Length > d)           // через цикл находим необх.знач
	                {
	                    d = str[i].Length;
	                    z= i;
	                }
	            }
	            Console.WriteLine($"самая длинная строка под номером {z}\nдлина строки {d}\nсама строка:  {str[z]}");  
	
	        }
	    }
	}
