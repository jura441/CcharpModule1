// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


//    int start, end;
//    start = Int32.Parse(Console.ReadLine());
//    end = Int32.Parse(Console.ReadLine());
//    Console.WriteLine(MyClass.MyMethod(start, end));
//    Console.ReadLine();


//class MyClass
//{
//    public static int MyMethod(int start, int end )
//    {
//        int result = 1;
//        for(int i = start; i <= end; i++)
//        {
//            result *= i;
//        }
//        return result;

//    }
//}

//задача 2 - числа Фиббоначи

//int firstFib = 0, secondFib=1;

//Fibbonacci(firstFib, secondFib, Int32.Parse(Console.ReadLine()));

//static void Fibbonacci(int a, int b, int endNumber)
//{
//    int result = a + b;
//    if(result != endNumber && result<endNumber)
//    {
//        Fibbonacci(b, result, endNumber);

//    }
//    else if (result == endNumber)
//    {
//        //Simple(result) ? Console.WriteLine("Число простое") : Console.WriteLine("Число не простое");
//        Console.WriteLine("Это число входит в числа Фиббоначи");
//        Console.WriteLine("Число простое: {0}", Simple(result));
//    }
//    else
//    {
//        Console.WriteLine("Это число не входит в числа Фиббоначи");
//        Console.WriteLine("Число простое: {0}", Simple(result));
//    }
//    static bool Simple(int a)
//    {
//        if (a % 2 == 0 || a%3==0||a%5==0||a%7==0||a%9==0)
//        {
//            return false;
//        }
//        else
//        {
//            return true;
//        }
//    }
//}

// задача 3 Самолет

Plane pl = new Plane("Лебедь") ;
Plane pl2 = new Plane("Рак", 2010);
Plane pl3 = new Plane("Щука", 2010, "Победа", "Грузовой");
Console.WriteLine(pl.NameAndType());
Console.WriteLine(pl.NameAndType(true));
Console.WriteLine(pl.NameAndType(false));
Console.WriteLine(pl2.NameAndType());
Console.WriteLine(pl2.NameAndType(true));
Console.WriteLine(pl2.NameAndType(false));
Console.WriteLine(pl3.NameAndType());
Console.WriteLine(pl3.NameAndType(true));
Console.WriteLine(pl3.NameAndType(false));
class Plane
{
    public string _name { get; set; }
    public string _manufacture { get; set; }
    public int _year { get; set; }
    public string _type { get; set; }

    public Plane(string name)
    {
        _name = name;
        _manufacture = "Аэрофлот";
        _year = 2005;
        _type = "Пассажирский";
    }
    public Plane(string name, int year)
    {
        _name = name;
        _manufacture = "Аэрофлот";
        _year = year;
        _type = "Пассажирский";
    }
    public Plane(string name, int year, string manufacture, string type)
    {
        _name = name;
        _manufacture = manufacture;
        _year = year;
        _type = type;
    }
    public string NameAndType()
    {
        return this._name + this._type;
    }
    public string NameAndType(bool manufacture)
    {
        if (manufacture) return this._name + this._type + this._manufacture;
        else { return this._name + this._type; }
    }
}