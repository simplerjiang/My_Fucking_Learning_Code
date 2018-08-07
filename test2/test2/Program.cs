using System;

namespace test2
{
    class Program
    {
        static void Main(string[] args)
        {
            Toy toy = new Toy();
        }
    }
    public class Toy
    {
        public Toy()
        {
            System.Diagnostics.Debug.WriteLine("正在构造");
 
        }

        ~Toy()
        {
            System.Diagnostics.Debug.WriteLine("正在拆解");
        }
    }
}
