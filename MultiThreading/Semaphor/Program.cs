using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Semaphor
{
    public class ThePool
    {     // ёмкость семафора равна 3    
        private static SemaphoreSlim sema = new SemaphoreSlim(3);

        public static void Main()
        {
            for (var i = 1; i <= 10; i++)
                new Thread(Enter).Start(i);
        }
        private static void Enter(object id)
        {
            Console.WriteLine(id + " enter");
            sema.Wait();
            Console.WriteLine(id + " is sweeming");
            Thread.Sleep(1000 * (int)id);
            Console.WriteLine(id + " is leaving");

            sema.Release();
        }
    }

}
