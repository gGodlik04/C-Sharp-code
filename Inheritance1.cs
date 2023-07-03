using System;

namespace Inheritance
{
    class Hotel
    {
        protected int total; //кол-во мест в гостинице
        protected int reserved; //кол-во занятых мест
        protected int sv; //кол-во свободных мест

        public Hotel(int total)
        {
            this.total = total;
            reserved = 0;
            sv = total;

        }
        public bool Reserve()
        {
            if ((sv > 0) && (reserved < total))
            {
                sv--;
                reserved++;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Vacating()
        {
            if ((sv < total) && (reserved > 0))
            {
                sv++;
                reserved--;
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            return ("Свободных мест: " + sv + "\nЗанятых мест: " + reserved);
        }
    }
    class Sanatory : Hotel
    {
        protected int medics;
        public Sanatory(int total) : base(total)
        {
            medics = 0;
        }
        protected int Medics
        {
            get
            {
                return medics;
            }
        }

        public void KolMedics()
        {
            medics= reserved / 10 + 1;
        }

        public new string ToString()
        {
            return ("Врачей: " + Medics);
        }
    }

    class Cruise : Hotel
    {
        protected int stop;
        public Cruise(int total, int stop) : base(total)
        {
            this.stop = stop;
        }

        public int Stop
        {
            get
            {
                return stop;
            }
            set
            {
                stop = value;
            }
        }
        public new string ToString()
        {
            return ("Осталось проехать: " + stop);
        }
    }

    class Program
    {
        static void Main()
        {
            Random r = new Random();

            // САНАТОРИЙ

            int total = r.Next(100, 1001);
            int guest = r.Next(100, 1001);
            int guestout = r.Next(100, 501);
            Sanatory Relax = new Sanatory(total);
            Console.WriteLine("     САНАТОРИЙ     ");
            Console.WriteLine("--После заселения--");
            for (int i=0; i < guest; i++)
            {
                if (Relax.Reserve() != true)
                {
                    Console.WriteLine("В Санатории АНШЛАГ, места больше нет.");
                    break;
                }
            }
            Relax.KolMedics();
            Console.WriteLine(((Hotel)Relax).ToString());
            Console.WriteLine(Relax.ToString());

            Console.WriteLine("\n--После выселения--");
            for (int i = 0; i < guestout; i++)
            {
                if (Relax.Vacating() != true)
                {
                    Console.WriteLine("В санатории только ПЕРЕКАТИ-ПОЛЕ.");
                    break;
                }
            }
            Relax.KolMedics();
            Console.WriteLine(((Hotel)Relax).ToString());
            Console.WriteLine(Relax.ToString());

            // КРУИЗ
            total= r.Next(50, 201);
            int stop= r.Next(1, 6);
            guest = r.Next(50, 201);
            Cruise Sunrise = new Cruise(total, stop);

            Console.WriteLine("\n       КРУИЗ       ");
            Console.WriteLine("--После заселения--");
            for (int i = 0; i < guest; i++)
            {
                if (Sunrise.Reserve() != true)
                {
                    Console.WriteLine("ФУЛ ХАУС НА КОРАБЛЕ, СЕЙЧАС ПОТОНЕМ!!!");
                    break;
                }
            }
            Console.WriteLine(((Hotel)Sunrise).ToString());
            Console.WriteLine(Sunrise.ToString());

            int n = stop;
            while ( stop > 0)
            {
                for (int i = 0; i < 10; i++)
                {

                    if (Sunrise.Vacating() != true)
                    {
                        Console.WriteLine("Корабль пуст");
                        break;
                    } 
                }
                stop--;
                Console.WriteLine($"\nОстановка №{ n-stop }");
                Sunrise.Stop = stop;
                Console.WriteLine(((Hotel)Sunrise).ToString());
                Console.WriteLine(Sunrise.ToString());
            }
            Console.ReadKey();
        }
    }
}
