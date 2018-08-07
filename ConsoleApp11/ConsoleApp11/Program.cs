using System;

namespace ConsoleApp11
{
    public class KeyPressedEventArgs : EventArgs //定义一个事件信息KeyPressedEventArgs，这是一个烦心参数,TEventArgs
    {
        public KeyPressedEventArgs(ConsoleKey key)
        {
            PressedKey = key;
        }
        public ConsoleKey PressedKey { get; private set; }
    }
    public class MyApp
    {
        public event EventHandler<KeyPressedEventArgs> KeyPressed;
        protected virtual void OnKeyPressed(KeyPressedEventArgs e)
        {
            if (this.KeyPressed != null)
            {
                this.KeyPressed(this, e);
            }
        }
        public void Start()
        {
            while (true)
            {
                ConsoleKeyInfo keyinfo = Console.ReadKey();
                if (keyinfo.Key == ConsoleKey.Escape)
                {
                    break;
                }
                OnKeyPressed(new KeyPressedEventArgs(keyinfo.Key));
            }
        }
    }
    class Program
    {
        static void app_KeyPressed(object sender, KeyPressedEventArgs e) // 事件，有两个参数，sender是实例，KeyPressedEventArgs 是指按键信息
        {
            Console.WriteLine("按下了{0}", e.PressedKey.ToString());
        }
        static void Main(string[] args)
        {
            MyApp app = new MyApp();
            app.KeyPressed += app_KeyPressed;
            app.Start();
        }
    }
}
