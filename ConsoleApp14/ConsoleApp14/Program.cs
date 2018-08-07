using System;

namespace ConsoleApp14
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property)]
    public class AppInfoAttribute : Attribute
    {
        public string Title { get; set; }
        public string VerNo { get; set; }
    }
    [AppInfo(Title = "draw", VerNo = "0.01")]
    public class Drawer
    {
        [AppInfo(Title = "color", VerNo = "1.0")]
        public int Color { get; set; }
        [AppInfo(Title = "color" VerNo = "1.0")]
        public void DrawRectangle() { }



    }
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
