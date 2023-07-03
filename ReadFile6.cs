using System;
using System.IO;

namespace ConsoleApp1
{
	class Matr
	{
		int[,] a;
		int n;  // размерность массива
		int n2;
		public Matr(int n, int n2)
		{
			a = new int[n, n2];
			this.n = n;
			this.n2 = n2;
		}
		public void StrR(string pathIN) // чтение массива из файла
		{
			StreamReader sr = new StreamReader(pathIN);
			string st = sr.ReadToEnd();
			sr.Close();
			st = st.Replace("\r\n", " ");
			string[] stm = st.Split(' ');
			int k = 0;
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					a[i, j] = Convert.ToInt32(stm[k++]);
				}
			}
		}
		public void StrW(string pathOUT, string s) // метод для вывода массива 
		{
			StreamWriter sw = new StreamWriter(pathOUT, true);
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					sw.Write($"{a[i, j]} ");
				}
				sw.WriteLine();
			}
			sw.WriteLine();
			sw.Close();
		}
		public void vtorvnom(string pathOUT, string s) // основной метод 
		{
			StreamWriter sw = new StreamWriter(pathOUT, true);
			int p = 10;
			int[] per = new int[p];
			int[] vtor = new int[p];
			int q = 0;
			int w = 0;
			int q2 = 3;
			int w2 = 0;
			for (int i = 0; i < n; i++) // в массивы сохр. элементы
			{                           // находящиеся под диагональю
				for (int j = 0; j < n; j++)
				{
					if (j <= q)
					{
						per[w] =a[i,j];
						w++;
					}
					if (j >= q2)
					{
						vtor[w2] = a[i,j];
						w2++;
					}
				}
				q++;
				q2--;
			}
			sw.WriteLine("Главная"); // вывод массивов эл-ов
			for (int i=0;i<per.Length;i++)
            {
				sw.Write($"{per[i]} ");
            }
			sw.WriteLine();
			sw.WriteLine("Побочная");
			for (int i = 0; i < per.Length; i++)
			{
				sw.Write($"{vtor[i]} ");
			}
			sw.Close();
		}
	}
	class Program
	{
		static void Main()
		{
			int n = 4;
			int n2 = 7;
			string pathIN = "input.txt";
			Matr ob = new Matr(n, n2);
			ob.StrR(pathIN);
			string pathOUT = "output.txt";
			string s = "Исходная матрица";
			ob.StrW(pathOUT, s);
			ob.vtorvnom(pathOUT, s);
			Console.WriteLine("Результат записан в файл");
		}
	}
}
