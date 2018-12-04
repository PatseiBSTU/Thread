using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace Barr
{
    class Program
    {
       
            private static readonly Barrier _barrier = new Barrier(3);

            public static void Main()
            {
               new Thread(Print).Start();
               new Thread(Print).Start();
               new Thread(Print).Start();      
            // вывод: 0 0 0 1 1 1 2 2 2 3 3 3 4 4 4 

                Console.ReadLine();
            }

            private static void Print() {
               for (var i = 0; i < 5; i++) {
                  Console.Write(i + " ");
                _barrier.SignalAndWait();
            }
        }
        }
    }

