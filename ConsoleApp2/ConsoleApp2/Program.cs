using System;

namespace ConsoleApp2
{
    class Program
    {
        struct Book
        {
            public string Name { get; set; }
            public string ISBN { get; set; }
            public void Read()
            {
                Console.WriteLine("This is book {0},ISBN:{1}", Name, ISBN);
            }

        }
        static void Main(string[] args)
        {
            Book thebook = new Book();
            thebook.Name = "小甲鱼书";
            thebook.ISBN = "XXXX";
            thebook.Read();
            Console.Read();
        }
    }
}
