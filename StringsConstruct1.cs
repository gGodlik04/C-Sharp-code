using System;

namespace StringConstructors
{
    class Array // конструкторы 
    {
        private int size = 15;
        public int sizepr // свойства
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        }
        private int[] _arrpr = new int[15];
        public int[] arrpr // свойства
        {
            get
            {
                return _arrpr;
            }
        }
        public static Array operator *(Array ARR1, Array ARR2)  // перегрузка операторов 3шт
        {
            Array farray = new();
            for (int i = 0; i < ARR1.size; i++)
            {
                farray.arrpr[i] = ARR1.arrpr[i] * ARR2.arrpr[i];
            }
            return farray;
        }
        public static bool operator ==(Array ARR1, Array ARR2)// 2
        {
            if (ARR1.sizepr == ARR2.sizepr)
            {
                return true;
            }
            else return false;
        }
        public static bool operator !=(Array ARR1, Array ARR2)// 3
        {
            if (ARR1.sizepr == ARR2.sizepr)
            {
                return true;
            }
            else return false;
        }
        Random rnd = new Random();
        public Array () // конструкторы 
        {
            Random rnd = new Random();

            for (int i = 0; i < 15; i++)
            {
                arrpr[i] = rnd.Next(0, 99);
            }
        }
        public Array (int q)// конструкторы  
        {
            Random rnd = new Random();
 
            for (int i=0; i<15;i++)
            {
                arrpr[i] = rnd.Next(0,99);
            }              
        }
        public Array(int [] a, int q)// конструкторы 
        {
            for (int i=0;i<15;i++)
            {
                arrpr[i] = a[i];
            }
        }
        public static void conclusion (Array AR) // метод для вывода объекта-массива
        {
            Console.WriteLine();
            for (int i=0; i<AR.sizepr;i++)
            {
                Console.Write($" {AR.arrpr[i]}  ");
            }
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main()
        {
            Random rnd = new ();
             int[]a = new int[15];
            for (int i=0;i<15;i++)
            {
                a[i] = rnd.Next(0,99);
            }
            Array AR1 = new Array();
            Array AR2 = new Array(5);
            Array AR3 = new Array(a, 5);
            bool equality = AR1 == AR2;
            if (equality)
            {
                Console.WriteLine("Объект-массив AR1 равен AR2");
            }
            else Console.WriteLine("Объект-массив AR2 НЕ равен AR2");
            Console.WriteLine("Выполняется перемножение массивов, ВЫ ВИДИТЕ ИСХОДНЫЕ ОБЪЕКТ-МАССИВЫ");
            Array.conclusion(AR1);
            Array.conclusion(AR2);
            Array EndAr = AR1 * AR2;
            Console.WriteLine("Перемножение выполненно, итог:");
            Array.conclusion(EndAr);
            Console.WriteLine("Вы видите массив на основе которого был создан ОБЪЕКТ-МАССИВ");
            for (int i=0;i<15;i++)
            {
                Console.Write($" {a[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine("Сейчас вы витиде сам ОБЪЕКТ-МАССИВ");
            Array.conclusion(AR3);
        }
    }
}