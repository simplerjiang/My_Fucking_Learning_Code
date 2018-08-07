using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadLocal变量
{
    class Program
    {
        static Random random = new Random();
        static ThreadLocal<int> local = new ThreadLocal<int>();

        static void Main(string[] args)
        {
            for (int i = 0;i<5;i++)
            {
                Thread t = new Thread(DoWork);
                t.Start();
            }
            Console.Read();
            local.Dispose();
        }
        static void DoWork()
        {
            local.Value = random.Next();
            Console.WriteLine($"当前线程ID:{Thread.CurrentThread.ManagedThreadId},{nameof(local)}的值:{local.Value}");
        }
    }
}
