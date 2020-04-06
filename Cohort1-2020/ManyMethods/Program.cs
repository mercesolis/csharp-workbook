using System;

namespace ManyMethods
{
    public class Program
    {
        static void Main(string[] args)
        {
            Hello();
            Addition();
            catDog();


        }

        public static void Hello()
        {
            Console.WriteLine("Say Hello");
            Console.Write("Enter your name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Bye, {0}!", name);
        }

        public static void Addition()
        {
            Console.WriteLine("Enter your first number.");
            string answer = Console.ReadLine();
            Console.WriteLine("Enter your second number.");
            string secondAnswer = Console.ReadLine();

            int first = Convert.ToInt32(answer);
            int second = Convert.ToInt32(secondAnswer);
            Console.WriteLine("The sum is " + (first + second));

            Console.WriteLine("The sum is " + Convert.ToInt32(answer) + Convert.ToInt32(secondAnswer));


        
        }

        public static void catDog()
        {
            Console.WriteLine("Cats or dogs?");
            string answer = Console.ReadLine();
            Console.WriteLine("")
        }
    }
}