using System;

namespace ConsoleApp13
{
    class Program
    {
        public enum Test : ushort
        {
            Value1 = 100,
            Value2 = 101,
            Value3 = 102
        }
        
        static void Main(string[] args)
        {
            var values = Enum.GetValues(typeof(Test));

            foreach (ushort v in values)
            {
                Console.Write(v + "\t");
                Console.Write(Enum.GetName(typeof(Test), v));
                Console.Write('\n');
            }
            Console.ReadLine();
        }
    }
}
