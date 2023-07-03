using System;
class Entrant
{
    protected string name = "";
    protected double grade = 0;
    public double Mark
    {
        get { return grade; }
        set { grade = value; }
    }
    public string Name
    {
        get { return name; }
    }
    public Entrant(string nameE)
    {
        name = nameE;
    }
    public override string ToString()
    {
        string s = ($"имя: {Name}, Оценка: {Mark}\n");
        return s;
    }
}
class EntrantExaminatioin
{
    Random rnd = new Random();
    public int prbal = 0, mest = 0, i = 0;
    Entrant[] a;
    public EntrantExaminatioin(int w, int c)
    {
        prbal = w;
        mest = c;
        a = new Entrant[mest];
    }
    public void TakeEntrant(Entrant x)// нужно передать объект
    {
        a[i] = x;
        i++;
    }
    public void TakeExam(string st)
    {
        for (int i = 0; i< a.Length; i++) // сравнение объекта 
        {
            if (st == a[i].Name)
            {
                if (a[i].Mark == 0)
                    a[i].Mark = rnd.Next(200,300);
                break;
            }
        }
    }
    public bool HasPlaces()
    {
        bool pr = false;
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == null)
            {
                pr = true;
            }
        }
        return pr;
    }
    public bool IsExamPass(Entrant x)
    {
        if (x.Mark >= prbal)
            return true;
        else return false ;
    }
}
class Program
{
    static void Main()
    {
        int t = 240, m = 5;
        EntrantExaminatioin s = new EntrantExaminatioin(t, m);
        for (int i=0;i<6;i++)
        {
            if (s.HasPlaces())
            {
                Console.WriteLine("Введите имя");
                string z = Console.ReadLine();
                Entrant k = new Entrant(z);
                s.TakeEntrant(k);
                s.TakeExam(k.Name);
                if (s.IsExamPass(k))
                {
                    Console.WriteLine(k);
                    Console.WriteLine("Поступил\n");
                }
                else
                {
                    Console.WriteLine("Не поступил\n");
                    Console.WriteLine(k);
                }
            }
            else Console.WriteLine("нет мест");
        }
    }
}
