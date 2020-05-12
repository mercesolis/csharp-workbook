using System;

namespace FizzBuzz
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // numbers 1-100
            // if number is divisible by 3 AND 5, "fizzbuzz"
            // if number is divisible by 3, "fizz"
            // if number is divisible by 5, "buzz"
            // all other numbers print

            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }




        }
    }
}