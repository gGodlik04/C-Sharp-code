using System;

namespace StingMethods
{
    class ch
    {
        public static void probel(string s) // МЕТОД ДЛЯ УДАЛЕНИЯ ПРОБЕЛОВ 
        {
            Console.WriteLine(s);
            s = s.Replace(" ", "");
            Console.WriteLine(s);
        } // КОНЕЦ МЕТОДА
        public static void defis(string s) // МЕТОД ДЛЯ ЗАМЕНЫ ПРОБЕЛОВ ДЕФИСАМИ В СТРОКЕ
        {
            Console.WriteLine();
            Console.WriteLine(s);
            s = s.Replace(" ", "-");
            Console.WriteLine(s);
        }  // КОНЕЦ МЕТОДА 
        public static void inversiya(string s, out char[] c) // МЕТОД ВОЗВРАЩАЕТ СТРОКУ, ЗАПИСАННУЮ СПРАВА НАЛЕВО
        {
            Console.WriteLine();
            Console.WriteLine(s);
            c = s.ToCharArray(); // СТРОКА ПОМЕЩАЕТСЯ В МАССИВ
            Array.Reverse(c);  // МАССИВ ПЕРЕВОРАЧИВАЕТСЯ
            string output = new string(c);

            Console.WriteLine(output);
        } //КОНЕЦ МЕТОДА 
        public static void chetAandT(string s, out char[] g)  // МЕТОД ДЛЯ ПОДСЧЕТА БУКВ 'A' И 'T'
        {
            Console.WriteLine();
            Console.WriteLine(s);
            g = s.ToCharArray();
            char a = 'а';
            char t = 'т';
            int p = 0;   // СЧЕТЧИКИ БУКВ
            int r = 0;
            for (int i = 0; i < g.Length; i++) // ЦИКЛ ИЩУЩИЙ БУКВЫ А и Т
            {
                if (g[i] == a)
                    p = p + 1;
                else if (g[i] == t)
                    r = r + 1;
            }
            Console.WriteLine($"кол-во 'a'= {p}         кол-во 'т'= {r}");
            Console.WriteLine();
        } // КОНЕЦ МЕТОДА 
        public static int ChetClov(string s)  // МЕТОД СЧИТАЮЩИЙ КОЛ-ВО СЛОВ В СТРОКЕ
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
            return e;
        } // КОНЕЦ МЕТОДА --------
        public static string[] MasIzClov(string s) //  МЕТОД ДЛЯ ФОРМИРОВАНИЯ МАССИВА ИЗ СЛОВ СТРОКИ
        {
            int r = ChetClov(s); // ОбРАЩЕНИЕ К МЕТОДУ ПОДСЧЕТА СЛОВ
            string[] l = new string[r];
            Console.WriteLine();
            Console.WriteLine(s);
            string s2 = " ";
            for (int i = 0; i< r-1; i++) 
            {
                int n = s.IndexOf(" "); // НАХОДИТСЯ ИНДЕКС ПРОБЕЛА
                l[i] = s.Substring(0, n); // СЛОВО ПОМЕЩАЕТСЯ В МАССИВ
                s = s.Remove(0, n+1);  // УДАЛЕНИЕ СЛОВА С ПРОБЕЛОМ
            } 
            l[r - 1] = s;
            Console.WriteLine("Слова из строки помещенны в массив");
            Console.WriteLine();
            return l;
        } // КОНЕЦ МЕТОДА -------
        public static void VivodMasClov(string []s,string f) // МЕТОД ДЛЯ ВЫВОДА МАССИВА ИЗ СЛОВ
        {
            Console.WriteLine("Вывод массива из слов");
            int r = ChetClov(f); // ОБРАЩАЕМСЯ К МЕТОДУ ПОДСЧЕТА СЛОВ 
            for (int i=0;i<r;i++) // ВЫВОДИМ МАССИВ
            {
                Console.Write($"номер массива={i} ");
                Console.Write($" ' {s[i]} ' ");
                Console.Write('\t');
            }
            Console.WriteLine();

            
        } // КОНЕЦ МЕТОДА 
        public static void PerevorotStrokiMasiva(string []s,string f) // МЕТОД ПЕРЕВОРАЧИВАЕТ 
        {                                                  // МАССИВ СЛОВ И ВЫВОДИТ
            Console.WriteLine();
            Console.WriteLine("вывод массива слов в обратную сторону");
            int r = ChetClov(f); // ОБРАЩАЕМСЯ К МЕТОДУ ПОДСЧЕТА СЛОВ
            s[0] = s[0].ToLower();  // ПРЕОБРАЗОВЫВЕМ ЗАГЛАВНЫЕ В СТРОЧНЫЕ
            s[0]+=".";               // И ДОБАВЛЯЕМ ТОЧКУ
            string b = s[r - 1].Substring(0, 1); // ПЕРЕМ ПЕРВУЮ БУКВУ ИЗ СЛОВА
            s[r - 1] = s[r - 1].Remove(0, 1);  // УДАЛЯЕМ 1УЮ БУКВУ 
            b = b.ToUpper(); // ДЕЛАЕМ БУКВУ ЗАГЛАВНОЙ
            b += s[r - 1];
            s[r - 1] = b; // СОЕДИНЯЕМ ОБРАТНО
                for (int i=r-1;i>=0;i--)
            {
                Console.Write($" {s[i]}");
            }
            Console.WriteLine();

        }
    }
    class Program
    {
        static void Main()
        {
            string test = "Это строка для теста";
            ch.probel(test);
            ch.defis(test);
            char[] c;
            ch.inversiya(test, out c);
            char[] g;
            ch.chetAandT(test, out g);
            Console.WriteLine(test);
            int p=ch.ChetClov(test);
            Console.WriteLine(p);
            string [] q=ch.MasIzClov(test);
            ch.VivodMasClov(q, test);
            ch.PerevorotStrokiMasiva(q, test);
        }
    }
}
