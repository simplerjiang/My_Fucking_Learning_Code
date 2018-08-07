using System;

namespace ConsoleApp10
{
    public delegate void SpaceKeyPressedEventHandler();
    public class MyApp
    {
        ///<summary>
        ///声明事件
        /// </summary>
        public event SpaceKeyPressedEventHandler SpaceKeyPressed;
        ///<summary>
        ///通过该方法引发事件
        /// </summary>
        protected virtual void OnSpaceKeyPressed()
        {
            if (this.SpaceKeyPressed != null)
            {
                SpaceKeyPressed();
            }
        }
        public void StartRun()
        {
            while (true)
            {
                ConsoleKeyInfo keyinfo = Console.ReadKey();
                if (keyinfo.Key == ConsoleKey.Spacebar)
                {
                    OnSpaceKeyPressed();
                }
                else if (keyinfo.Key == ConsoleKey.Escape)
                {
                    break;
                }

            }
        }
    }
    class Program
    {
        static void app_SpaceKeyPressed()
        {
            Console.WriteLine("{0} 按下空格键", DateTime.Now.ToLongTimeString());
        }
        static void Main(string[] args)
        {
            MyApp app = new MyApp();
            app.SpaceKeyPressed += app_SpaceKeyPressed;
            app.StartRun();
            Console.ReadLine();
        }
    }
}
