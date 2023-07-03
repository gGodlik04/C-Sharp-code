using System;
using System.IO;

namespace Step-massiv
{
    class Program
    {
        static int[] chtenmas(StreamReader sw)  \\  метод для создание одномерного массива и ввод данных из файла 
        { 
            string[] crg;
            string str=sw.ReadToEnd();
            str = str.Replace("\r\n"," ");
            crg = str.Split(' ');
            int[] arr = new int[crg.Length];
            for (int i=0;i<crg.Length;i++)
            {
                arr[i] = Convert.ToInt32(crg[i]);
            }
            sw.Close();
            return arr;

        }
        static int [,] chten(int[] arr) \\ метод для создания двумерного массива из 1-мерного
        { 
            int k = 0; ;
            int[,] a = new int[4, 4];
            for (int i = 0; i <a.GetLength(0); i++)
            {
                 for(int j=0;j<a.GetLength(1);j++)
                {
                    a[i, j] = arr[k++];
                }
            }          
            return a;
        }
        static void maxchs (StreamWriter db,int[,] arr) \\ метод для перемены местами строк и столбцов двумерного массива , нахождения максимального знач в столбце и вывода полученных результатов.
        { 
            int[] par = new int[arr.GetLength(1)];
            int cxron = 0;
            int j = 0;
            int k = 0; 
            for (int i = 0; i < 4; i++) \\ цикл меняет местами столбцы и строки массива
            {
                for (; j < 4; j++)
                {
                    cxron = arr[i, j];
                    arr[i, j] = arr[j, i];
                    arr[j, i] = cxron;
                }
                k++;
                j = k;
            }
            for (int i = 0; i < 4; i++) \\  цикл находит максимальный элемент столба и добавляет в новый массив
            {
                par[i] = 0;
                for (int p=0; p < 4; p++)
                {
                    if (par[i]<arr[i,p])
                    {
                        par[i] = arr[i, p];
                    }
                }

            }
            for (int i=0;i<par.Length;i++)  \\ вывод одномерного массива с максимальными элементами
            {
                db.Write($"{par[i]} ");
            }            db.Close();
        }
        static void Main()
        {
            int[] arr;
            int[,] par;
            string path = "test.txt";
            StreamReader sw = new StreamReader(path);
            arr=Program.chtenmas(sw);
            par=Program.chten(arr);
            String gate = "OUTPUT.txt";
            StreamWriter db = new StreamWriter(gate);
            Program.maxchs(db,par);
        }
    }
}
