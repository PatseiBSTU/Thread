using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadLoc
{
    public class Slot
    {
        private static readonly Random rnd = new Random();
        private static int Shared = 25;
        private static ThreadLocal<int> NonShared =
               new ThreadLocal<int>(() => rnd.Next(1, 20));

        public static void PrintData()
        {
            Console.WriteLine($"Thread: {Thread.CurrentThread.Name} " +
                $"Shared: {Shared} NonShared: {NonShared.Value}");
        }
        public class MainClass
        {
            public static void Main()
            {         // для тестирования запускаем три потока      
                new Thread(Slot.PrintData) { Name = "First" }.Start();
                new Thread(Slot.PrintData) { Name = "Second" }.Start();
                new Thread(Slot.PrintData) { Name = "Third" }.Start();

                Console.ReadLine();
            }
        }
    }
}

