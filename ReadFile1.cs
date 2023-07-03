using System;
using System.IO;

namespace ConsoleApp1
{
    class Matr
    {
        double[,] a;
        double n;  // размерность массива
        double n2;
        public Matr(int n, int n2)
        {
            a = new double[n, n2];
            this.n = n;
            this.n2 = n2;
        }
        public void StrR(string pathIN)
        {
            StreamReader sr = new StreamReader(pathIN);
            string st = sr.ReadToEnd();
            sr.Close();
            st = st.Replace("\r\n", " ");
            string[] stm = st.Split(' ');
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n2; j++)
                {
                    a[i, j] = Convert.ToInt32(stm[k++]);
                }
            }
        }
        public void StrW(string pathOUT, string s)
        {
            StreamWriter sw = new StreamWriter(pathOUT, false);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n2; j++)
                {
                    sw.Write("{0:0.##}",a[i,j]);
                    sw.Write(" ");
                }
                sw.WriteLine();
            }
            sw.Close();
        }
        public void pervnom()
            {
            double k = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (Math.Abs(a[i,j]) > k)
                        k = a[i,j];

                }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    a[i,j] /= k;
                }
            }
        }
    }
        class Program
        {
            static void Main()
            {
                int n = 5;
                int n2 = 4;
                string pathIN = "input.txt";
                Matr ob = new Matr(n,n2);
                ob.StrR(pathIN);
                string pathOUT = "output.txt";
                string s = "Исходная матрица";
                ob.pervnom();
                ob.StrW(pathOUT, s);
                Console.WriteLine("Результат записан в файл");
            }
        }
}
