namespace Symbols1
{
    class CH
    {
        public static double program(char a, char b, char c)
        {
            double rez;
            double x = char.GetNumericValue(a); //присваиваем код (юникод) символов
            double y = char.GetNumericValue(b); // числа 4 и 9
            if (c == '+') //проверяем  знаки и производим операцию
            {
                rez = x + y;
            }
            else if (c == '-')
            {
                rez = x - y;
            }
            else if (c == '*')
            {
                rez = x * y;
            }
            else
            {
                rez = x / y;
            }
            return rez;
        }
    }
    class Program
    {
        static void Main()
        {
            char A = '4'; //4+9 = 13
            char B = '9';
            char C = '+';
            double Rez = CH.program(A, B, C);
            Console.WriteLine(Rez);
        }
    }
}
