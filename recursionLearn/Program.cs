using System;

namespace recursionLearn
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine(Factorial(5));
            Console.WriteLine(Factorial(10));
            Console.WriteLine(Counting(40));
            Console.WriteLine(Counting(70));

        }

        static int Factorial(int n) // defining 'Factorial'
        {
            if (n == 0)
            {
                return 1; //just returns 1 if n == 0
            }

            // recursive solution (as opposed to iterative)
            return n * Factorial(n - 1); // takes n, multiplies it by n - 1, UNTIL n == 0.

            // e.g.
            // 5! = 5 * 4!
            //  4! = 4 * 3!
            //   3! = 3 * 2!
            //    2! = 2 * 1!
            //     1! = 1 * 0!
            //      0! = 1 (because math)
        }
        static int Counting(int c)
        {
            if (c == 0)
                return 0;
            Console.WriteLine(c);
            return Counting(c - 1);
        }
    }
}
