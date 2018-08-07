using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncLocal变量
{
    class Program
    {
        static AsyncLocal<int> local = new AsyncLocal<int>();
        static async Task RunAsync()
        {
            local.Value = 100;
            Console.WriteLine("异步等待前local变量的值：{0},当前线程ID：{1}.", local.Value, Thread.CurrentThread.ManagedThreadId);
            await Task.Delay(60);
            Console.WriteLine("一部等待侯local变量的值{0},当前线程ID：{1}.", local.Value, Thread.CurrentThread.ManagedThreadId);
        }
        static void Main(string[] args)
        {
            Task t = RunAsync();
            t.Wait();
            Console.Read();
        }
    }
}
