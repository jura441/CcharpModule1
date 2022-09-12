using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] massive = new int[5]; //создание массива на 5 элементов
            int summary=0;
            int multiply=1;
            int max;
            int min;
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Введите число для индекса {0}", i);
                massive[i] = Int32.Parse(Console.ReadLine());
            }
            min=massive[0];
            max=massive[0];
            for (int i = massive.Length-1; i>=0; i--)
            {
             summary+=massive[i];       //сумма всех элементов
             multiply*=massive[i];   //произведение всех элементов
                if (min < massive[i]) { min = massive[i]; }
                if (max > massive[i]) { max = massive[i]; }
            }
            Console.WriteLine("Сумма: {0}, Произведение: {1}, Max: {2}, Min: {3}", summary, multiply, max, min);
        }
    }
}
