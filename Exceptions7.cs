using System;
using System.IO;

namespace ICKLUCHENIYA
{
    class squar
    {
        private int storona1s { get; set; } = 0;
        private int storona2s { get; set; } = 0;
        private int gradus1s { get; set; } = 0;
        private int gradus2s { get; set; } = 0;

        public void vvod()
        {
           StreamReader d = new StreamReader("input.txt");
            int storona1 = Convert.ToInt32(d.ReadLine());
            int storona2 = Convert.ToInt32(d.ReadLine());
            int gradus1= Convert.ToInt32(d.ReadLine());
            int gradus2= Convert.ToInt32(d.ReadLine());
            gradus1s = gradus1;
            gradus2s = gradus2;
            storona1s = storona1;
            storona2s = storona2;
            d.Close();
        }
        public void Paralelogr()
        {
            StreamWriter d = new StreamWriter("output.txt");
            if (storona1s==storona2s & gradus1s==gradus2s)
            {                
                d.WriteLine("прямоугольник является паралелогрмаом");
            }
            else
            {
                d.WriteLine("Прямоугольник не является паралелограмом");
            }
            d.Close();
        }
    }

        class Program
        {
            static void Main()
            {
                squar squar22 = new squar();
            squar22.vvod();
            squar22.Paralelogr();
            }
        }
    
}
