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

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Введите число для индекса {0}", i);
                massive[i] = Int32.Parse(Console.ReadLine());
            }

        }
    }
}
