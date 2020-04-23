using System;
using System.Collections.Generic;

namespace Mastermind
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] colors = new string[] { "red", "yellow", "blue" };
            List<string> computerColors = new List<string>();
            List<string> userColors = new List<string>();
            Random random = new Random();
            computerColors.Add(colors[random.Next(0, 2)]);
            computerColors.Add(colors[random.Next(0, 2)]);

            bool isPlaying = true;
            while (isPlaying)
            {
                Console.Clear();
                userColors.Clear();

                Console.WriteLine($"{computerColors[0]} - {computerColors[1]}");

                Console.WriteLine("Welcome to Mastermind");
                Console.WriteLine("Guess two colors in the correct position");
                Console.WriteLine("Enter your first color");
                userColors.Add(Console.ReadLine().ToLower().Trim());

                Console.WriteLine("Enter your second color");
                userColors.Add(Console.ReadLine().ToLower().Trim());

                if (userColors.Contains("exit"))
                {
                    break;
                }

                if (userColors[0].Equals(computerColors[0]) && userColors[1].Equals(computerColors[1]))
                {
                    Console.WriteLine("Correct!");
                    break;
                }

                else if (userColors[0].Equals(computerColors[0]) || userColors[1].Equals(computerColors[1]))
                {
                    Console.WriteLine("\n0 - 1. You guessed one of the colors in the correct position.");
                    Console.WriteLine();
                }

                else if (userColors.Contains(computerColors[1]) || userColors.Contains(computerColors[0]))
                {
                    if (userColors[0].Equals(computerColors[1]) && userColors[1].Equals(computerColors[0]))
                    {

                        Console.WriteLine("\n2 - 0. You guessed both of the colors but in the wrong positions. ");
                        Console.WriteLine();
                    }
                    else if (userColors[0].Equals(computerColors[1]) || userColors[1].Equals(computerColors[0]))
                    {
                        Console.WriteLine("\n1 - 0. You guessed one of the colors correctly but not in the correct position.");
                        Console.WriteLine();

                    }
                    else
                    {
                        Console.WriteLine("\n0 - 0. You did not guess either color.");
                    }

                    
                }

                Console.WriteLine("\nWould you like to try again? Y/N");
                isPlaying = Console.ReadLine().ToUpper().Contains("Y") ? true : false;

                
            }

            Console.WriteLine("\nGoodbye!");
            Console.ReadKey();

        }
                
            
                

                
            



        
    }
}