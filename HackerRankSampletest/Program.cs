using System;

namespace HackerRankSampletest
{
    class Program
    {
        public static void fizzBuzz(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if ((i % 3 == 0) && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }

                else if (i % 3 == 0 && i % 5 != 0)
                {
                    Console.WriteLine("Fizz");
                }

                else if (i % 5 == 0 && i % 3 != 0)
                {
                    Console.WriteLine("Buzz");
                }

                else if (i % 5 != 0 || i % 3 != 0)
                {
                    Console.WriteLine(i);
                }
            }

         }
            static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
                fizzBuzz(1);
        }
    }
}
