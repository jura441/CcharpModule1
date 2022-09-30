// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System.Text;
using System.Windows;
//using System.Windows.Forms;


static void Main(string[] args)
{
    Dog dog = new Dog(0);
    dog.Calm();
    dog.Sad();
}
class Dog
{
    int _state = 0;
    int live = 3;
    bool death = false;

    public Dog(int state)
    {
        _state = state;
    }
    public string WannaEat()
    {
        string result = "";
        return result;
    }
    public void Calm()
    {
        Console.WriteLine("   /\\____/\\  ");
        Console.WriteLine(" (           ) ");
        Console.WriteLine("(  /\\  /\\   )");
        Console.WriteLine("(  \\/  \\/   )");
        Console.WriteLine("(             )");
        Console.WriteLine("(      ()     )");
        Console.WriteLine("(    ____     )");
        Console.WriteLine(" (   |__|     )");
        Console.WriteLine("   (______)   )");
    }

    public void Sad()
    {
        Console.WriteLine("   /\\____/\\  ");
        Console.WriteLine(" (           ) ");
        Console.WriteLine("(  /\\  /\\   )");
        Console.WriteLine("(  \\/  \\/   )");
        Console.WriteLine("(   ..  ..    )");
        Console.WriteLine("(      ()     )");
        Console.WriteLine("(    ____     )");
        Console.WriteLine(" (   |__|     )");
        Console.WriteLine("   (______)   )");
    }
}
