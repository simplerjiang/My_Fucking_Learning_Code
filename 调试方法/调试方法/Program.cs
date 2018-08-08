using System;
using System.Diagnostics;
namespace 调试方法
{
    public class Test
    {
        public Test()
        {
            Trace.WriteLine("构造函数");
        }
        ~Test()
        {
            Trace.WriteLine("析构函数");
        }
        public void DoTask()
        {
            Trace.WriteLine("DoTask函数");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DefaultTraceListener listener = null;
            listener = Trace.Listeners[0] as DefaultTraceListener;
            if (listener == null)
            {
                listener = new DefaultTraceListener();
                Trace.Listeners.Add(listener);
            }
            listener.LogFileName = "example.log";
            Test t = new Test();
            t.DoTask();
            Console.ReadKey();
        }
    }
}
