using System;

namespace teamcity
{
    public class Program
    {
        public static int Factorial(int n)
        {
            if (n == 1) return 1;

            return n * Factorial(n - 1);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(5));
        }
    }
}