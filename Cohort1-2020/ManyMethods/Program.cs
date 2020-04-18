using System;

namespace ManyMethods
{
    public class Program
    {
        private static object dateOfBirth;

        static void Main(string[] args)
        {
            Hello();
            Addition();
            catDog();
            oddEvent();
            echo();
            killGrams();
            date();
            age();
            guess();

        }

        public static void Hello()
        {
            Console.WriteLine("Say Hello");
            Console.WriteLine("Enter your name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Bye, {0}!", name);
        }

        public static void Addition()
        {
            Console.WriteLine("Enter your first number:");
            string answer = Console.ReadLine();
            Console.WriteLine("Enter your second number:");
            string secondAnswer = Console.ReadLine();

            int first = Convert.ToInt32(answer);
            int second = Convert.ToInt32(secondAnswer);
            Console.WriteLine("The sum is " + (first + second));

            Console.WriteLine("The sum is " + Convert.ToInt32(answer) + Convert.ToInt32(secondAnswer));



        }

        public static void catDog()
        {
            Console.WriteLine("Cats or Dogs?");
            string cats = Console.ReadLine();
            Console.WriteLine("Meow");
            string dogs = Console.ReadLine();
            Console.WriteLine("Woof");


        }


        public static void oddEvent()
        {
            int i;
            Console.WriteLine("Type a Number: ");
            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.WriteLine("Even number");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Odd number");
                Console.ReadLine();

            }
        }






        // A method that ask the user for a word then prints it 3 times, first in all caps, then 2 more time in all lower case
        static void echo()
        {
            Console.WriteLine("Type a word: ");
            string echo = Console.ReadLine();
            string ucaseEcho = echo.ToUpper();
            string lcaseEcho = echo.ToLower();
            Console.WriteLine(ucaseEcho);
            Console.WriteLine(lcaseEcho);
            Console.WriteLine(lcaseEcho);



        }



        // A method that ask the user for a weight in pounds, then converts it to killograms
        static void killGrams()
        {
            Console.WriteLine("Enter a weight in pounds: ");
            double pounds = Convert.ToDouble(Console.ReadLine());
            double kilograms = pounds / 2.20462262185;
            Console.WriteLine(pounds + " pounds is " + kilograms + " kilograms");
            Console.ReadLine();
        }


        // A method that prints out the current date
        static void date()
        {
            string date = DateTime.UtcNow.GetDateTimeFormats('d')[0];
            Console.WriteLine("The current date is {0}", date);
        }


        // A method that asks the user their birth year, and print out their age
        static void age()
        {
            Console.WriteLine("Enter your birthday dd/mm/yyyy: ");
            string bday = Console.ReadLine().ToString();
            int age = DateTime.Today.Year - (DateTime.Parse(bday)).Year;
            Console.WriteLine("You are {0} years old", age);
        }




        // A method that ask the user to guess a word, and print out 'CORRECT!!' if the word is "chsarp", otherwise prints out 'WRONG!!'
        static void guess()
        {
            string Input = "";
            Console.WriteLine("Guess a word: ");
            Input = Console.ReadLine();

            if (Input == "csharp")
            {
                Console.WriteLine("CORRECT!!");
            }
            else
            {
                Console.WriteLine("WRONG!!");
            }
            
        }



    }
}