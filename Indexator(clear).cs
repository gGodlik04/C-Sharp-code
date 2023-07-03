using System;
namespace indexator1
{

using System;
namespace Lab3
{
    class MassivClass
    {
        int[]intArray;
        int n=4;
        public int SizeOfMassiv
        {
            get{return n;}
        }
        public int Multiplication
        {
        set{
            for(int i=0;i<intArray.Length;i++)
            {
                intArray[i]=intArray[i]*10;
            }
            }
        }
        public int this[int index]
        {
            get=>intArray[index];
            set=>intArray[index]=value;
        }

        public MassivClass()
        {
             intArray= new int[n];
        }
        public static MassivClass operator ++(MassivClass Array)
        {
            MassivClass NewArray=new MassivClass();
            for(int i=0;i<4;i++)
            {
            NewArray.intArray[i]=Array.intArray[i];
            NewArray.intArray[i]=NewArray.intArray[i]+1;
            }
            return NewArray;
        }
        public static MassivClass operator --(MassivClass Array)
        {
            MassivClass NewArray=new MassivClass();
            for(int i=0;i<4;i++)
            {
            NewArray.intArray[i]=Array.intArray[i];
            NewArray.intArray[i]=NewArray.intArray[i]-1;
            }
            return NewArray;
        }
        public static bool operator !(MassivClass Array)
        {
            bool temp=false;
            MassivClass NewArray=new MassivClass();
            for (int i=0;i<4;i++)
            {
                for(int j=i+1;j<4;j++)
                {
                    if(Array.intArray[i]>Array.intArray[j])
                    {
                        temp=true;
                        break;                        
                    }
                }
            }
            if (temp)
            {
                Console.WriteLine("Массив не упорядочен по возрастанию");
            }
            else
            {
            Console.WriteLine("Массив упорядочен по возрастанию");
            }
            return true;
        }
        public static implicit operator int[](MassivClass Array)
        {
            return Array.intArray;
        }
        public void Input()
        {
            Console.WriteLine("Введите значения массива");
            for(int i=0;i<intArray.Length;i++)
            {
                intArray[i]=Convert.ToInt32(Console.ReadLine());
            }
        }
        public void Output()
        {
            Console.WriteLine("Вывод значения массива");
            for(int i=0;i<intArray.Length;i++)
            {
                Console.Write($" {intArray[i]}  ");
            }
            Console.WriteLine();
        }
        public  void Sort()
        {
            Console.WriteLine("Ссортировка Массива");
            int temp;
            for (int i = 0; i < intArray.Length; i++)
            {
                for (int j = i + 1; j < intArray.Length; j++)
                {
                    if (intArray[i] > intArray[j])
                    {
                        temp = intArray[i];
                        intArray[i] = intArray[j];
                        intArray[j] = temp;
                    }                   
                }            
            }
        }
    }
} 


    class Program
    {
        static public void Main()
        {
            MassivClass Array=new MassivClass();
            Array.Input();
            if(!Array);
            Array.Sort();
            if(!Array);
            Array.Output();
            Console.WriteLine("Используется св-во класса");
            Array.Multiplication=5;
            Array.Output();
            Console.ReadKey();
            Console.WriteLine("Присваивание через индексатор: Array[2]=666 ");
            Array[2]= 666;
            Array.Output();
            Console.WriteLine("Использование Определенного оператора ++");
            MassivClass Operator=++Array;
            Console.ReadKey();
            Operator.Output();
            Console.WriteLine("Преобразование из класса в массив и его вывод");
            int[] ArrayTrans=new int[4];
            ArrayTrans=Array;
            for(int i=0; i<4;i++)
            {
                Console.Write($" {ArrayTrans[i]}  ");
            }
            
        }
    }
} 
