// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.Data;

#region TASK1
Worker worker = new Worker("Сергеев Сергей Сергеевич", DateTime.Now, "+79289282828", "sergey@mail.ru", "Охранник", "Бдительность!", 19500);
Console.WriteLine($"Зарплата {worker.FIO} на должности {worker.Job} {worker.Salary}");
worker += 3000;
Console.WriteLine($"Зарплата {worker.FIO} на должности {worker.Job} {worker.Salary}");
worker -= 7000;
Console.WriteLine($"Зарплата {worker.FIO} на должности {worker.Job} {worker.Salary}");
Worker worker1 = new Worker("Сергеев Антон Сергеевич", DateTime.Now, "+79185822828", "anton@mail.ru", "Менеджер", "8 часов созвона!", 25500);
Console.WriteLine($"Зарплата братьев равна {worker == worker1} ");
Console.WriteLine($"Зарплата братьев не равна {worker != worker1} ");
Console.WriteLine($"Зарплата Сергей больше Антон {worker > worker1} ");
Console.WriteLine($"Зарплата Сергей меньше Антон{worker < worker1} ");
worker += 10000;
Console.WriteLine($"Зарплата братьев равна {worker == worker1} ");
Console.WriteLine($"Зарплата братьев не равна {worker != worker1} ");
Console.WriteLine($"Зарплата Сергей больше Антон {worker > worker1} ");
Console.WriteLine($"Зарплата Сергей меньше Антон{worker < worker1} ");
Console.WriteLine($"братья равны {worker.Equals (worker1)}") ;
Console.WriteLine($"Хэш код1: {worker.GetHashCode ()}" + $"Хэш код 2: {worker1.GetHashCode()}");


class Worker
{
    public string FIO { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Job { get; set; }
    public string JobDescription { get; set; }
    public int Salary { get; set; }
    public Worker(string fio, DateTime dateofbirth, string phone, string email, string job, string jobdescription, int salary)
    {
        FIO = fio;
        DateOfBirth = dateofbirth;
        Phone = phone;
        Email = email;
        Job = job;
        JobDescription = jobdescription;
        Salary = salary;
 
    }

    public static Worker operator + (Worker a, int b)
    {
        a.Salary += b;
        return a;
    }
    public static int operator +(int b, Worker a)
    {
        return b + a.Salary;
    }

    public static Worker operator -(Worker a, int b)
    {
        a.Salary -= b;
        return a;
    }
    public static int operator -(int b, Worker a)
    {
        return b - a.Salary;
    }
    public static bool operator == (Worker a, Worker b)
    {
        return a.Salary == b.Salary ? true : false;
    }
    public static bool operator !=(Worker a, Worker b)
    {
        return a.Salary == b.Salary ? true : false;
    }
    public static bool operator >(Worker a, Worker b)
    {
        return a.Salary > b.Salary ? true : false;
    }
    public static bool operator <(Worker a, Worker b)
    {
        return a.Salary < b.Salary ? true : false;
    }
    public override string ToString()
    {
        return  FIO + DateOfBirth.ToString() + Phone + Email + Job + JobDescription + Salary.ToString();
    }
    public override bool Equals(object obj)
    {
        return this.ToString() == obj.ToString();
    }
    public override int GetHashCode ()
    {
        return this.ToString().GetHashCode();
    }
    
}
#endregion TASK1

class City
{

}

class CreditCard
{

}

class Matrix
{

}