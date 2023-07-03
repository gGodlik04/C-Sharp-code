using system;

namespace gaga1212
{
    class Program
    {
        public static string [][] ernmas()
        {
            string[][] stup = new string[3][]; // объявление ступенчатого массива
            stup[0] = new string[3];
            stup[1] = new string[2];
            stup[2] = new string[4];
            for (int i = 0; i < 3; i++)// цикл с вводом данных в массив
            {
                for (int q = 0; q < stup[i].Length; q++)
                {
                    stup[i][q] = Console.ReadLine();
                }
            }
            Console.WriteLine();
            return stup;
        }         
        public static void max(string[][]stup) //  создание строки с ,
        {
            string sum ="";
            for (int i = 0; i < 3; i++)// цикл с вводом данных в массив
            {
                for (int q = 0; q < stup[i].Length; q++) // создание строки и добавление запятой и пробела
                {
                    sum = sum + stup[i][q] + ", ";
                }
            }
            Console.WriteLine(sum);
        }
        public static void maxtwo(string[][] stup) // создание строки с ;
        {
            string sum = "";
            for (int i = 0; i < 3; i++)
            {
                for (int q = 0; q < stup[i].Length; q++) // создание строки и добавление запятой и пробела
                {
                    sum = sum + stup[i][q] + "; ";
                }
            }
            Console.WriteLine(sum);
        }
        static void Main()
        {
            string[][]stup= new string[3][];
            stup=Program.ernmas();
            Program.max(stup);
            Program.maxtwo(stup);
        }
    }
}
