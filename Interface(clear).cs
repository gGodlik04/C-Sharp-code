namespace LAB4
{

    class Genius:IStudent,IComparable
    {
         public string family{get;set;}
        public int visit{get;set;}
        public bool request{get;set;}
        public Genius (string isol_family, int isol_visit)
        {
            family=isol_family;
            visit=isol_visit;
        }
        public bool Test()
        {
            if (visit>=1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Info()
        {
            if (request)
            {
                Console.WriteLine($"Фамилия гения-студента: {family}, Кол-во посещенный занятий: {visit}, Зачет Сдан");
            }
            else
            {
                Console.WriteLine($"Фамилия гения-студента: {family}, Кол-во посещенный занятий: {visit}, Зачет не Сдан");
            }
        }
        public int CompareTo(object o)
        {
            if(o is Genius genius) 
            {
                return this.visit.CompareTo(genius.visit);
            }
            else 
            {
                throw new Exception("Неккоректно");
            }
        }
    }

    class Clever:IStudent
    {
         public string family{get;set;}
        public int visit{get;set;}
        public bool request{get;set;}
        public Clever (string isol_family, int isol_visit)
        {
            family=isol_family;
            visit=isol_visit;
        }
        public bool Test()
        {
            if (visit>=10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Info()
        {
            if (request)
            {
                Console.WriteLine($"Фамилия умного-студента: {family}, Кол-во посещенный занятий: {visit}, Зачет Сдан");
            }
            else
            {
                Console.WriteLine($"Фамилия умного-студента: {family}, Кол-во посещенный занятий: {visit}, Зачет не Сдан");
            }
        }
    }
    
    class Ordinary:IStudent,ICloneable
    {
         public string family{get;set;}
        public int visit{get;set;}
        public bool request{get;set;}
        public Ordinary (string isol_family, int isol_visit)
        {
            family=isol_family;
            visit=isol_visit;
        }
        public bool Test()
        {
            if (visit>=20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Info()
        {
            if (request)
            {
                Console.WriteLine($"Фамилия обычного-студента: {family}, Кол-во посещенный занятий: {visit}, Зачет Сдан");
            }
            else
            {
                Console.WriteLine($"Фамилия обычного-студента: {family}, Кол-во посещенный занятий: {visit}, Зачет не Сдан");
            }
        }
        public object Clone()
        {
            return MemberwiseClone();
        }
    }

    public interface ICloneable
    {
        object Clone();
    }
    public interface IStudent
    {
        public string family{get;set;}
        public int visit{get;set;}
        public bool request{get;set;}
        public bool Test();
        public void Info();
    }
    class Program
    {
        static void Main()
        {
            IStudent Petrov= new Ordinary("Petrov",19);
            IStudent Orlov= new Genius("Orlov",8);
            IStudent Volnov= new Clever("Volnov",19);
            IStudent [] people={Petrov,Orlov,Volnov};
            for (int i=0;i<people.Length;i++)
            {
                people[i].request=people[i].Test();
                people[i].Info();
            }
            Genius s1=new Genius("Sasha",24);
            Genius s2=new Genius("Pasha",19);
            Genius s3=new Genius("Dasha",6);
            Genius s4=new Genius("Kasha",35);
            Genius[]genius=new Genius[]{s1,s2,s3,s4};
            Console.WriteLine("Проверка на CompareTo сортировка по кол-во посещений (массив объектов до сортировки:)");
            foreach(Genius person in genius)
            {
                Console.WriteLine($"{person.family}--{person.visit}");
            }
            Console.WriteLine();
            Array.Sort(genius);
            Console.WriteLine();
            Console.WriteLine("Сортировка выполнена, Массив объектов после сортировки:");
            foreach(Genius person in genius)
            {
                Console.WriteLine($"{person.family}--{person.visit}");
            }
            Console.WriteLine();
            Console.WriteLine("Выполняется клонирование объекта с помощью ICloneable");
            var Pavlov=new Ordinary("Pavlov",999);
            var temporarily=(Ordinary)Pavlov.Clone();
            Console.WriteLine();
            Console.WriteLine("Информация о клонированном объекте:");
            temporarily.Info();
        }
    }


}
