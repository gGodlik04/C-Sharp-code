using System;

namespace VirtualMethods2
{
    class Man
    {
        protected string name;
        public double god;
        public double vozr;
        public Man(string a, double b)
        {
            name = a;
            god = b;
        }
        public virtual double Print()
        {
            Console.WriteLine($"\nИмя: {name}, Год рождения {god} , Возраст {vozr}");
            return 0;
        }
        public void Age()
        {
            vozr = 2021 - god;
        }
    }
    class Entrant : Man
    {
        public double bal=0;
        public bool post = false;
        public Entrant(string a, double b,double c) : base(a,b)
        {
            bal =  c;
            vozr = 2021 - god;
        }
        public void Acted()
        {
            double prox = 240;
            if (bal >= prox)
            {
                post = true;
            }
        }
        public override double Print()
        {
            if (post == true)
            {
                Console.WriteLine($"\nИмя: {name}, Год рождения {god} , Возраст {vozr} , поступил(а)");
            }
            else
            {
                Console.WriteLine($"\nИмя: {name}, Год рождения {god} , Возраст {vozr}, не поступил(а)");
            }
            return 0;
        }
    }
    class Student : Man
    {
     public string Fac="";
     public double kurc;
     public double cr_bal;
     public bool stip = false;
        public Student(string a,double b,string e, double w,double c):base(a,b)
        {
            Fac = e;
            kurc = w;
            cr_bal = c;
            vozr = 2021 - god;
        }
        public void Grants()
        {
            double minst = 4.3;
            if(cr_bal>minst)
            {
                stip = true;
            }
        }
        public override double Print()
        {
            if(stip==true)
            {
                Console.WriteLine($"\nИмя: {name}, Факультет {Fac} , Курс {kurc} ,Год рождения {god} , Возраст {vozr} , стипендия=8000 руб. ");
            }
            else
            {
                Console.WriteLine($"\nИмя: {name}, Год рождения {god} , Возраст {vozr}, степендия не начисляется");
            }
            return 0;
        }
    }
    class Program
    {
        static void Main()
        {
            double v = 0;
            Man t = null;
            Console.WriteLine("Введите имя, год рождения.");
            string a = Console.ReadLine();
            double b = Convert.ToDouble(Console.ReadLine());
            t = new Man(a,b);
            t.Age();
            t.Print();
            //
            Entrant q = null;
            Console.WriteLine("\nВведите ваш бал");
            double bal233 = Convert.ToDouble(Console.ReadLine());
            q = new Entrant(a,b,bal233);
            q.Acted();
            q.Print();
            //
            Console.WriteLine("\nВведите Факультет, Курс, Ср.бал");
            string h = Console.ReadLine();
            double k = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            Student w = null;
            w = new Student(a,b,h,k,c);
            w.Grants();
            w.Print();
        }
    }
}
