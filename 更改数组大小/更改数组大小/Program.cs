using System;

namespace 更改数组大小
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arra = new int[3];
            arra[0] = 1;
            Console.WriteLine("{0},{1}", arra.Length, arra.GetHashCode());
            Array.Resize(ref arra, 7);
            Console.WriteLine("{0},{1}", arra.Length, arra.GetHashCode());
            Console.Read();
        }
    }
}
