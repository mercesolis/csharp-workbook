using System;

namespace FizzBuzz
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // numbers 1-100
            for (int i = 1; i <= 100; i++)
            {

                // if number is divisible by 3 AND 5, "fizzbuzz"
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }

                // if number is divisible by 3, "fizz"
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }

                // if number is divisible by 5, "buzz"
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }

                // all other numbers print

                else
                {
                    Console.WriteLine(i);
                }
            }
            
        }
    }
}