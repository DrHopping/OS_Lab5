using System;
using System.Diagnostics;

namespace OS_Lab5
{
    class Program
    {
        static void Main(string[] args)
        {

            var timer = new Stopwatch();
            timer.Reset();
            timer.Start();

            int[,,] b = new int[1000, 1000, 1000];
            int res = 0;

            for (int j = 0; j < 1000; j++)
            {
                for (int i = 0; i < 1000; i++)
                {
                    for (int k = 0; k < 1000; k++)
                    {
                        b[k, i, j]++;
                    }
                }
            }

            timer.Stop();
            Console.WriteLine($"Non-optimized code finished in: {timer.ElapsedMilliseconds}ms");

            //////////////////////////////////////////////////////////////
            timer.Reset();
            timer.Start();

            int[,,] b1 = new int[1000, 1000, 1000];
            int res1 = 0;

            for (int j = 0; j < 1000; j++)
            {
                for (int i = 0; i < 1000; i++)
                {
                    for (int k = 0; k < 1000; k++)
                    {
                        b1[j, i, k]++;
                    }
                }
            }

            timer.Stop();
            Console.WriteLine($"Optimized code finished in:     {timer.ElapsedMilliseconds}ms");


        }
    }
}
