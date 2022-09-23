// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");



//string[] shop = new string[10] { "Book1", "Book1", "Book1", "Book1", "Book1", "Book1", "Book1", "Book1", "Book1", "Book1", };
//Console.WriteLine("Книги в магазине:");
//foreach (string book in shop)
//{
//    Console.WriteLine(book);
//}
using Lesson7.Properties;
using System.Collections;
using System.Collections.Generic;

List<Book> list = new List<Book>();
list.Add(new Book("Оно", "America", "Horror", "Stephen King", 700, 1995, 1000));
list.Add(new Book("Оно2", "America", "Horror", "Stephen King", 700, 1995, 1000));
list.Add(new Book("Оно3", "America", "Horror", "Stephen King", 700, 1995, 1000));

Shop sh = new Shop(Resources.ShopName, "ТЦ \"Рассвет\"", list);
sh.GetShopName();
Command.HelpCommand();
while (true)
{
    Console.WriteLine("Введите новую команду: ");
    string command = Console.ReadLine();
    switch (command)
    {
        case "help": Command.HelpCommand(); break;
        case "addbook": sh.AddABook(Command.AddBookCommand()); break;
        case "removebook": sh.DeleteBookByIndex(Command.RemoveBookCommand()); break;
        case "removebookname": sh.DeleteBookByName(Command.RemoveBookCommandName()); break;
        case "getbooks": Command.GetAllBookCommand(); sh.GetAllBooks(); break;
        default: Console.WriteLine("Не удалось распознать команду. Наберите Help для списка комманд"); break;
    }


}
//sh.GetAllBooks();
//sh.AddABook(new Book("Оно4", "America", "Horror", "Stephen King", 700, 1995, 1000));
//sh.GetAllBooks();
//Console.WriteLine();
//sh.DeleteBookByIndex(0);
//sh.GetAllBooks();
//Console.WriteLine();


//foreach(Book book in list)
//{
//    Console.WriteLine(book);
//}
//Console.WriteLine("Добавьте книгу, написав ее название");
//list.Add(Console.ReadLine());
//Console.WriteLine("Добавьте книгу, написав ее название");
//list.Remove(Console.ReadLine());    
//foreach (string book in list)
//{
//    Console.WriteLine(book);
//}
class Book : IEnumerable, IComparable
{
    public string Name { get; set; }
    public int NumberPages { get; set; }
    public string Publishing { get; set; }
    public string Genre { get; set; }
    public string Author { get; set; }
    public int YearOfPublishing { get; set; }
    public int Price { get; set; }

    public Book (string name, string publishing, string genre, string author, int numberpages, int yearofpublishing, int price)

    {
        Name= name;
        Publishing= publishing;
        Genre= genre;
        Author= author;
        NumberPages = numberpages;
        YearOfPublishing = yearofpublishing;
        Price = price;
   }
    public override string ToString()
    {
        return Name + " " + Publishing + " " + Genre + " " +  Author  + " " + NumberPages.ToString() + " " + YearOfPublishing.ToString() + " " + Price.ToString();
    }
    public IEnumerator GetEnumerator()
    {
        return ((IEnumerable)Name).GetEnumerator();
    }
    public int CompareTo(object? obj)
    {
            return Name.CompareTo((string?)obj);
    }
    public int Compare(object? obj, object? obj2)
    {
        return ((Book)obj).Name.CompareTo((string?)obj2);
    }
    
}
class Shop
{
    List<Book> Books;

    string Name { get; set; }

    string Address { get; set; }

    public Shop (string name, string address, List<Book> books)
    {
        Name = name;
        Address = address;
        Books = books;
    }

    public  void GetShopName()
    {
        Console.WriteLine("Добро пожаловать в {0}", Name);
    }
    public void SetShopName()
    {
        Console.WriteLine();
    }
    public void GetAllBooks()
    {
        int index = 1;
        foreach (Book book in Books)
        {
            Console.WriteLine("Индекс:");
        }

    }
    public void AddABook (Book book)
    {
        Books.Add(book);
    }
    public void DeleteBookByName ( string name)
    {
        int index = -1;
    foreach (Book book in Books)
        {

            if (book.CompareTo(name) == 0) index = Books.IndexOf(book);
        }
    }
    public void DeleteBookByIndex(int index)
    {
        Books.RemoveAt(index);
    }

}

class Command

{
    public static void HelpCommand()
    {
        Console.WriteLine("Используйте addbook для добавления книги, removebook для удаления книги, getbook для списка книг, clear для очистки ");
    }
    public static Book AddBookCommand()
    {
        Book book;
        Console.WriteLine("Введите имя книги");
        string name= Console.ReadLine();
        Console.WriteLine("Введите издательство  книги");
        string publishing = Console.ReadLine();
        Console.WriteLine("Введите жанр книги");
        string genre = Console.ReadLine();
        Console.WriteLine("Введите автор книги");
        string author = Console.ReadLine();
        Console.WriteLine("Введите количество страниц книги");
        int numberpage = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Введите год издания книги");
        int yearofpublishing = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Введите цену книги");
        int price = Int32.Parse(Console.ReadLine());
        book = new Book(name, publishing, genre, author, numberpage, yearofpublishing, price);
        return book;
    }
    public static string RemoveBookCommandName()
        {
        Console.WriteLine("Укажите имя удаляемой книги:");
        return Console.ReadLine();
    }
    public static int RemoveBookCommand()
    {
        Console.WriteLine("Укажите индекс удаляемой книги:");
        return Int32.Parse(Console.ReadLine());
    }
    public static void GetAllBookCommand()
    {
        Console.WriteLine("Список книг в магазине: ");
    }
    public static void GetAllBookCommand()
    {
        Console.WriteLine("Список книг в магазине");
    }

}