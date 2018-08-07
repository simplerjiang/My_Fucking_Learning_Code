using System;

namespace ConsoleApp6
{
    public abstract class Ball
    {
        public abstract string CateName { get; }
        public abstract void Play();

        private decimal _r;

        public decimal Radius
        {
            get { return _r; }
            set
            {
                if (value <=  0 )
                {
                    _r = 1;
                }
                if (value > 15)
                {
                    _r = 15;
                }
            }
        }
    }

    public class FootBall : Ball
    {
        public override string CateName
        {
            get { return "足球"; }
        }


        public override void Play()
        {
            Console.WriteLine("正在踢足球");
        }
    }

    public class BasketBall : Ball
    {
        public override string CateName
        {
            get { return "篮球"; }
        }

        public override void Play()
        {
            Console.WriteLine("正在打篮球");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            FootBall footBall = new FootBall();
            footBall.Play();
            footBall.Radius = 15;
            BasketBall basketBall = new BasketBall();
            basketBall.Play();
            basketBall.Radius = 14;
            Console.Read();
        }
    }
}
