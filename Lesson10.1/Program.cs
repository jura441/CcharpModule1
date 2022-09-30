using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Timers;

using System.Windows.Forms;

namespace Lesson10._1
{
    internal class Program
    {
            static System.Timers.Timer timer = new System.Timers.Timer();
            static Random rnd = new Random();
            static Dog dog = new Dog(0);
        static void Main(string[] args)
        {
            //dog.Calm();
            //dog.Sad();
            //dog.Wanna();
        }
        private void Timer_Elapsed(object? sender, System.ElapsedEventArgs e)
        {
            Timer.Interval = rnd.Next(1000, 10000);
            int action = rnd.Next(1, 6);

        }
        class Dog
        {
            int _state = 0;
            int _live = 3;
            bool death = false;

            public Dog(int state)
            {
                _state = state;
            }
            public string Wanna(string wish)
            {
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("ГАВ!" + wish, wish, MessageBoxButtons.OKCancel);
                    if (DialogResult.OK == dr)
                {
                    if (_live < 3)
                    {
                        _live++;
                    }
                }
                if (DialogResult.Cancel == dr)
                {
                    Console.Clear();
                    Sad();
                    _live--;
                }
                if(_live==0)
                {
                    Console.WriteLine("Песик умрет");
                }
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
    }
}
