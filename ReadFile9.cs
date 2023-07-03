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
				for (int j = 0; j < n2; j++)
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
				for (int j = 0; j < n2; j++)
				{
					sw.Write($"{a[i, j]} ");
				}
				sw.WriteLine();
			}
			sw.WriteLine();
			sw.Close();
		}
		public void vtorvnom() // основной метод 
		{
			int[] ostr = new int[n2];
			int c = 0;
			int q = 10000;
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n2; j++)
				{
					if (a[i,j] < q)
					{
						ostr[j] = a[i,j];
						q = a[i, j];
					}
					q = 10000;
				}
			}
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n2; j++)
				{
					a[i,j] += ostr[j];
				}
			} 
		}
	}
	class Program
	{
		static void Main()
		{
			int n = 5;
			int n2 = 7;
			string pathIN = "input.txt";
			Matr ob = new Matr(n, n2);
			ob.StrR(pathIN);
			string pathOUT = "output.txt";
			string s = "Исходная матрица";
			ob.StrW(pathOUT, s);
			ob.vtorvnom();
			ob.StrW(pathOUT, s);
			Console.WriteLine("Результат записан в файл");
		}
	}
}
