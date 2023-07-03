using System;

namespace Symbols17
{
    class CH
    {
        public static void program(string s, out char[] c) //ВВОД СТРОКИ В СИМВОЛЬНЫЙ
        {                                                // МАССИВ
            c = s.ToCharArray();
        }
        public static void ChetClov(string s)  // МЕТОД СЧИТАЮЩИЙ КОЛ-ВО СЛОВ В СТРОКЕ
        {
            string s2 = " ";
            bool b = true;
            int e = 1;
            while (b)
            {
                b = s.Contains(s2); // ПОИСК ПРОБЕЛА В СТРОКЕ
                if (b)
                {
                    int n = s.IndexOf(" ");// НАХОЖДЕНИЕ ИНДЕКСА ПРОБЕЛА
                    s = s.Remove(n, 1); // УДАЛЕНИЕ 1-ГО СЛОВА  С ПРОБЕЛОМ
                    e = e + 1;
                }
            }
            Console.WriteLine("Кол-во слов");
            Console.WriteLine(e);
        } // КОНЕЦ МЕТОДА --------

        public static void Chetpredl(string s)  // МЕТОД СЧИТАЮЩИЙ КОЛ-ВО прост.предл
        {
            string s2 = ".";
            bool b = true;
            int e = 1;
            while (b)
            {
                b = s.Contains(s2); // ПОИСК ПРОБЕЛА В СТРОКЕ
                if (b)
                {
                    int n = s.IndexOf(".");// НАХОЖДЕНИЕ ИНДЕКСА ТОЧКИ
                    s = s.Remove(n, 1); // УДАЛЕНИЕ ТОЧКИ
                    e = e + 1;
                }
            }
            Console.WriteLine("Кол-во простых предл.");
            Console.WriteLine(e-1);
        } // КОНЕЦ МЕТОДА --------
	        public static void print(char[] ch)     // ввод строки и символа в метод
        {
            string y = "!";
            string u = ".";
            string o = "?";
            char q = y[0];
            char a = u[0];
            char b = o[0];
            int j = 0;
	            for (int i = 0; i<ch.Length; i++) //  проверка каждого символа
	            {                                  //  == ! ? .  и подсчет
                if (ch[i] == q | ch[i] == a | ch[i] == b) 
                {
                    ch[i] = '`';
                    if (ch[i] == '`')
                        j++;
                }
	            }
            Console.WriteLine(" кол-во предложений");
	            Console.WriteLine(j);
	
	        }


class Program
        {
            static void Main()
            {
                char[] c;
                Console.WriteLine("введите строку ");
                string t = Console.ReadLine();
                CH.program(t, out c);
                CH.ChetClov(t);
                CH.Chetpredl(t);
                CH.print(c);
            }
        }
    }
}
