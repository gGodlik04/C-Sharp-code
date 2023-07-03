using System;
namespace Abstract1
{
  abstract class Student
  {
    string family="";
    double visit;
        bool grade;
        public string Family
        {
            get {return family;}
            set{family=value;}
        }
        public double Visit 
        {
          get {return visit;}
          set{visit=value;}  
        }
        public bool Grade
        {
          get {return grade;}
          set{grade=value;}
        }
        public Student(string _family,double _visit,bool _grade)
        {
        Family=_family;
        Visit=_visit;
        Grade=_grade;
        }
        public abstract void Test();
        public abstract void Info();

  }
}
using System;
namespace Lab2
{
    class Clever:Student
    {
        public Clever(string family,double visit):base(family,visit,false){}
        public override void Test()
        {
              if (Visit<10) 
            {
                Grade=false;
            }
            else
            {
            Grade=true;
            }
        }
        public override void Info()
        {
            string show="";
            if (Grade)
            {
            show="Сдан";
            }
            else
            {
            show="Не сдан";
            }
            Console.WriteLine($"Умный студент, Имя студента: {Family}, Кол-во посещений: {Visit}, Тест {show}");
        }
    }
}
using System;
namespace Lab2
{
    class Genius:Student
    {
        public Genius(string family,double visit):base(family,visit,false){}
        public override void Test()
        {
             if (Visit<1) 
            {
                Grade=false;
            }
            else
            {
            Grade=true;
            }
        }
        public override void Info()
        {
            string show="";
            if (Grade)
            {
            show="Сдан";
            }
            else
            {
            show="Не сдан";
            }
            Console.WriteLine($"Гениальный студент, Имя студента: {Family}, Кол-во посещений: {Visit}, Тест {show}");
        }
    }
}
using System;
namespace Lab2
{
    class Program
    {
        public static void Main()
        {
            Student? student=null;
            Random r=new Random();
            for (int i=0;i<3;i++)
            {
                string family="";
                Console.WriteLine("Введите Фамилию");
                family=Console.ReadLine();
                int a_visit=r.Next(0,50);
                switch(i)
                {
                    case 0:
                    {
                        student=new Ordinary(family,a_visit);
                        break;
                    }
                    case 1:
                    {
                        student=new Clever(family,a_visit);
                        break;
                    }
                    case 2:
                    {
                        student=new Genius(family,a_visit);
                        break;
                    }
                }
                student.Test();
                student.Info();
            }
        }
    }
}
using System;
namespace Lab2
{
    class Ordinary:Student
    {
        public Ordinary(string family,double visit):base(family,visit,false){}
        public override void Test()
        {
            Console.WriteLine(Visit);
            if (Visit<20) 
            {
                Grade=false;
            }
            else
            {
            Grade=true;
            }
        }
        public override void Info()
        {
            string show;
            if (Grade)
            {
            show ="Сдан";
            }
            else
            {
            show ="Не сдан";
            }
            Console.WriteLine($"Простой студент, Имя студента: {Family}, Кол-во посещений: {Visit}, Тест {show}");
        }
    }
}
