using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace NoSinchro
{
    class Program
    {
        static int x = 0;
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Thread myThread = new Thread(Count);
                myThread.Name = "Поток " + i.ToString();
                myThread.Start();
            }

            Console.ReadLine();
        }
        public static void Count()
        {
            x++;
            Thread.Sleep(100 + x * x);
            x--;
            Console.WriteLine($"{Thread.CurrentThread.Name}: {x}");

            Thread.Sleep(100 + x * x);
        }
    }
}


