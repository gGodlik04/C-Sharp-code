using System;

namespace VirtualMethods1
{
    class Triangle
    {
        protected double a;
        protected double b;
        protected double c;
        protected double rad;
        protected double p;
        public Triangle(double a1, double b1, double c1)
        {
            a = a1;
            b = b1;
            c = Math.Sqrt(Math.Pow(a1, 2) + Math.Pow(b1, 2) - 2 * a * b * Math.Cos(c1));
            rad = c1*3.14/180;
            p = a1 + b1 + c1 / 2;
        }
        public virtual void Print()
        {
             Console.WriteLine($"\nЭто не  прямоугольный треугольник а = {a} b = {b} угол c = {c}");
        }
        public virtual double Sqr()
        {
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine($"Нахождение площади по формуле Герона");
            return s;
        }
        public virtual double Radius()
        {
            double rokr = Math.Sqrt(((p - a) * (p - b) * (p - c)) / p);
            Console.WriteLine($"Нахождение радиуса вписанной окружности");
            return rokr;
        }
    }
    //производный класс
    class Rectangle : Triangle
    {
        //автоматический вызов конструктора базового класса
        public Rectangle(double a1, double b1, double c1) : base(a1, b1, c1)
        {
            a = a1;
            b = b1;
            c1 = 90;
            c = Math.Sqrt(Math.Pow(a1, 2) + Math.Pow(b1, 2) - 2 * a * b * Math.Cos(c1));
            rad = c1 * 3.14 / 180;
            p = a1 + b1 + c1 / 2;
        }
        public override void Print()
        {
            //в производном классе 
            //наследуются поля базового класса
            Console.WriteLine($"\nЭто прямоугольный треугольник a = {a} b = {b} c = {c}");
        }
        public override  double Sqr()
        {
           double S = a * b / 2;
            Console.WriteLine($"Нахождение площади треуг-ка (наслед)");
            return S;
        }
        public override double Radius()
        {
            double rokr = Math.Sqrt(((p - a) * (p - b) * (p - c)) / p);
            Console.WriteLine($"Нахождение радиуса вписанной окружности (наслед)");
            return rokr;
        }
    } 
    class Program
    {
        static void Main()
        {
            double per;
            double st;
            double a=0;
            double b=0;
            double c=0;
            Triangle t = null;//треугольник
            Random r = new Random();
            for (int i = 0; i < 5; i++)
            {
                a = r.Next(0, 20);
                b = r.Next(0, 15);
                c = r.Next(85, 96);
                if (c!=90)
                {
                    t = new Triangle(a,b,c);
                    t.Print();
                    st=t.Sqr();
                    per=t.Radius(); 
                    Console.WriteLine($"Радиус вписанной окружности = {per:0.000} площадь = {st:0.000}");
                }
                else
                {
                    t = new Rectangle(a, b, c);
                    t.Print();
                    st = t.Sqr();
                    per = t.Radius();
                    Console.WriteLine($"Радиус вписанной окружности = {per:0.000} площадь = {st:0.000}");
                }
            }
        }
    }
}
