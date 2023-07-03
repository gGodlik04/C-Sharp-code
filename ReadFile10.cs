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
		public void vtorvnom(string pathOUT, string s) // основной метод 
		{
			StreamWriter sw = new StreamWriter(pathOUT, true);
			int[] ostr = new int[n];
			int[] blya = new int[6] { 1, 1, 1, 1, 1, 1, };
			int c = 0;
			int t = 0;
			int q = 10000;
			for (int i = 0; i < 6; i++)
			{ 
				for (int j = 0; j < 6; j++)
				{
					if (a[i,t] < 0 & a[i, j] > 0)
					{
						ostr[i] = ostr[i]+ a[i, j];
					}
					else
                    {
						if (a[i, t] > 0 & a[i, j] < 0)
						{
							blya[i]= blya[i]*a[i, j];
						}
					}
				}
			 t++;
			}
			for (int i = 0; i < blya.Length; i++)
            {
		     if (ostr[i]==0)
				{
					ostr[i] = blya[i];
				}
            }
				for (int i = 0; i < ostr.Length; i++)
			{
				sw.Write($"{ostr[i]} ");
			}
			sw.Close();
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
				ob.vtorvnom(pathOUT, s);
				Console.WriteLine("Результат записан в файл");
			}
		}
	}