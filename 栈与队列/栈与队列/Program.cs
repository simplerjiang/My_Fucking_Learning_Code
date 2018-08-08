using System;
using System.Collections;
namespace 栈与队列
{
    public class EmpInfo
    {
        public string EmpID { get; set; }
        public string EmpName { get; set; }
        public int EmpAge { get; set; }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Stack s = new Stack();

            s.Push(1);
            s.Push(2);
            int a = 1;
            string b = a.ToString();

            Queue myq = new Queue();
            myq.Enqueue("大家好");
            myq.Enqueue("立刻");
            myq.Enqueue("出来咯");

            while (myq.Count>0)
            {
                Console.Write(myq.Dequeue() as string);  
            }
            Hashtable hsth = new Hashtable();
            EmpInfo emp1 = new EmpInfo();
            emp1.EmpID = "C-1001";
            emp1.EmpName = "小明";
            emp1.EmpAge = 29;
            hsth.Add(emp1.EmpID, emp1);
            EmpInfo emp2 = new EmpInfo()
            {
                EmpID = "C-1002",
                EmpName = "老李",
                EmpAge = 28
            };
            Console.WriteLine(b);
            Console.Read();
        }
    }
}
