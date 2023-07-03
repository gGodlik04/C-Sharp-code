using System;
Apartment apart=new Apartment() 
class Apartment 
{
    public double sw
    {
    
        get  {return squareWall;}
    }
    public double plaster
    {
       get {return plaster;} 
    }
protected double dlina=5, shirina=14,visota=3;
protected double squareWall=0,plaster=0;
public Apartment(double a,double b,double c)
{
    dlina=a;
    shirina b;
    visota=c;
    squareWall=a*c*2+b*c*2;
    plaster=squareWall*5;
}
public virtual bool Work (double kolsht)
{
    double plaster=plaster-kolsht;
    if (plaster>0)
        return true;
        else return false;
}
}
class Room:Apartment
{
    public double ob
    {
    
        get  {return ob;}
    }
    public ob=0;
    public Room (double a, double b,double c):base(a,b,c)
    {
        dlina=a;
    shirina b;
    visota=c;
    squareWall=a*c*2+b*c*2;
    plaster=squareWall*5;
    if(squareWall%10 ==0)
    ob=squareWall/10;
    else ob=squareWall/10+1;
    }
    public override bool Work (double kolrul)
    {
        double plaster=plaster-kolrul;
        if (plaster>0)
        return true;
        else return false;
    }
}
class Kitchen:Apartment 
{
    public double plitka
    {
        get{return plitka;}
    }
    double plitka =0;
    public Kitchen(double a,double b,double c):base(a,b,c)
    {
      dlina=a;
    shirina b;
    visota=c;
    squareWall=a*c*2+b*c*2;
    plaster=squareWall*5;
    if(squareWall%0.12 ==0)
    plitka=squareWall/0.12;
    else plitka=squareWall/0.12+1;
    }
    public override bool Work(double kolplit)
    {
        double plitka=plitka-kolplit;
       if  (plitka>0)
       return true;
       else return false;
    }
}
  static void Main()
  {
    double shet=0,shet2=0,shet3,shet4;
    double dlin=5,shir=14,visot=3;
    Apartment rROOM=null;
    rROOM=new Apartment(dlin,shir,visot);
    double sw=Apartment.sw; 
    double plaster=Apartment.plaster;
    for (int i=0;;i++)
    {
        if(rROOM.Work(50))
        shet++;
        else {
            shet++
            break;
             }
    }
    Room r2Room=null;
    r2Room =new Room(6.8,3);
    double ob=Room.ob;  
    for (int i=0;;i++)
    {
        if(r2Room.Work(2))
        shet2++;
        else {
            shet2++
            break;
             }
    }
    // для кухни
    Kitchen rKitch=null;
    rKitch=new Apartment(6,3,3);
    double squareWall=Apartment.sw;
    double plaster2=Apartment.plaster;
    for (int i=0;;i++)
    {
        if(rKitch.Work(50))
        shet3++;
        else {
            shet3++
            break;
             }
    }
    Kitchen rKitch=null;
    rKitch=new Kitchen(4,5,3)
    double plitka=Kitchen.plitka; 
    for (int i=0;;i++)
    {
       if(rKitch.Work(20))
        shet4++;
        else {
            shet4++
            break;
             } 
    }
    int konec=shet+shet2+shet3+shet4;
    Console.WriteLine($"общее кол-во дней= {konec} ") // вывести значения полей (может переопределить rKitch ДЛЯ Apartment т.к его обнулил)
    }