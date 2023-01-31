using System;
using System.Diagnostics;
namespace CountOccurrence
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int counter = 0;
            sw.Start();
            for (int i = 1; i <= 99999999; i++)
            {
                int num = i;
                while (num > 0)
                {

                    if (num % 10 == 1)
                    {
                        counter++;
                    }

                    num = num / 10;
                }
            }
            sw.Stop();
            Console.WriteLine("1 is counter {0} times and the time is {1}", counter, sw.Elapsed.ToString());

            //Stopwatch sw = new Stopwatch();
            //sw.Start();
            //int counter = 0;
            //sw.Reset();
            //sw.Start();
            //int n = 8;

            //counter = (int)(n * Math.Pow(10, n - 1));
            //sw.Stop();
            //Console.WriteLine("1 is counter {0} times and the time is {1}", counter, sw.ElapsedMilliseconds.ToString());
        }
    }
}
