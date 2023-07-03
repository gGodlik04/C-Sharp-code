using System;
using System.IO;

namespace Exception1
{
    class zdanie
    {
        private int k_etaz = 0;
        private int stoim_kv_m = 0;
        private int k_kv_etaz = 0;
        private int k_pod = 0;
        public int proverkaPod
        {
            get
            {
                return k_pod;
            }
            set
            {
                k_pod = value;
            }
        }
        public int proverkaEtaz
        {
            get
            {
                return k_etaz;
            }
            set
            {
                k_etaz = value;
            }
        }
        public int proverkaKV_Etaz
        {
            get
            {
                return k_kv_etaz;
            }
            set
            {
                k_kv_etaz = value;
            }
        }
        public int proverkaStoim_kv_m
        {
            get
            {
                return stoim_kv_m;
            }
            set
            {
                stoim_kv_m = value;
            }
        }
    }
    class osnova
    { 
        zdanie Zdanie = new zdanie();
        public void metod()
        {
            int[] q = new int[4];
            StreamReader d = new StreamReader("input.txt");
            try
            {
                int w = 0;
                string r = d.ReadToEnd();
                string[] n = r.Split(' ');
                w = n.Length;
                d.Close();
                for (int i = 0; i < w; i++)
                {
                    q[i] = Convert.ToInt32(n[i]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Перезапустите программу и исправьте входные данные");
            }
            Zdanie.proverkaPod = q[0];
            Zdanie.proverkaEtaz = q[1];
            Zdanie.proverkaKV_Etaz = q[2];
            Zdanie.proverkaStoim_kv_m = q[3];
            int gt = Zdanie.proverkaPod;
            int rt = Zdanie.proverkaKV_Etaz;
            d.Close();
        }
        public void vivdo()
        {
            int w = Zdanie.proverkaPod;
            int k = Zdanie.proverkaEtaz;
            int s = Zdanie.proverkaKV_Etaz;
            int j = Zdanie.proverkaStoim_kv_m;
            int cu = s * k;
            int su = cu * w;
            int kv = su * 45;
            int pu = kv * j;
            StreamWriter d = new StreamWriter("output.txt");
            d.WriteLine($"Кол-во квартир в подъезде = {cu} ");
            d.WriteLine($"Кол-во квартир в доме= {su}");
            d.WriteLine($"Cтоимость всех квратир в доме= {pu}");
            d.Close();
        }
    }
    class Program
    {
       static void Main()
        {
            osnova os = new osnova();
            os.metod();
            os.vivdo();
        }
    }
}
