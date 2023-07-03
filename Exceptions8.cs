using System;
using System.IO;

namespace ICKLUCHENIYA
{
    class auditoria
    {
        private int dlinas { get; set; } = 0;
        private int shirinas { get; set; } = 0;
        private int visotas { get; set; } = 0;
        private int komputers { get; set; } = 0;

        public void vvod()
        {
            try
            {
                StreamReader d = new StreamReader("input.txt");
                int storona1 = Convert.ToInt32(d.ReadLine());
                int storona2 = Convert.ToInt32(d.ReadLine());
                int gradus1 = Convert.ToInt32(d.ReadLine());
                int gradus2 = Convert.ToInt32(d.ReadLine());
                dlinas = gradus1;
                shirinas = gradus2;
                visotas = storona1;
                komputers = storona2;
                d.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
        }
        public void SanPin()
        {
            bool i;
            int S = dlinas * shirinas;
            int V = dlinas * shirinas * visotas;
            if (S / komputers>=6)
            {
                i = true;
            }
            else i = false;
            if (i)
                Console.WriteLine($"Площадь аудитории: {S} , Объем аудитории: {V} , Нормы Сан.Пин выполняются");
            else Console.WriteLine($"Площадь аудитории: {S} , Объем аудитории: {V} , Нормы Сан.Пин  не выполняются");
        }
    }

        class Program
        {
            static void Main()
            {
                auditoria auditoria22 = new auditoria();
            auditoria22.vvod();
            auditoria22.SanPin();
            }
        }
    
}
