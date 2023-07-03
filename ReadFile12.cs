using System;
using System.IO;

namespace ConsoleApp1
{
	class Matr
	{
		double[,] a;
		int n;  // размерность массива
		int n2;
		public Matr(int n, int n2)
		{
			a = new double[n, n2];
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
					sw.Write("{0:0.##}", a[i, j]);
					sw.Write (" ");
				}
				sw.WriteLine();
			}
			sw.WriteLine();
			sw.Close();
		}
		public void vtorvnom() // основной метод 
		{
			int c = 0;
			for (int i = 0; i < 6; i++)
			{
				for (int j = 0; j < 6; j++)
				{
					if (j <= c)
					{
						a[i,j] = 0; ;
					}
				}
				c++;
			}
		}
	}
		class Program
		{
			static void Main()
			{
				int n = 6;
				int n2 = 6;
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