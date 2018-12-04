using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading;

namespace AboutThred
{
    class Program
    {
        static void Main(string[] args)
        {
            Context ctx = Thread.CurrentContext;


            var currt = Thread.CurrentThread;

            Console.WriteLine("  " + currt.Name);


            if (currt.IsAlive)
            {
                Console.WriteLine("Working");
            }

            if (!currt.IsBackground)
            {
                Console.WriteLine("not Background");
            }

            Console.WriteLine(currt.Priority);
        }
    }
}
