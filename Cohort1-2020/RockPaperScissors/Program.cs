using System;

namespace RockPaperScissors
{
    class Program
    {
        public static void Main(string[] args)
        {
            string inputPlayer;
            int randomInt;

            Console.Write("Choose ROCK, PAPER, or SCISSORS: ");
                    inputPlayer = Console.ReadLine();
                    inputPlayer = inputPlayer.ToUpper();

                    Random random = new Random();

                    randomInt = random.Next(1, 4);

                    switch (randomInt)
                    {
                        case 1:
                    Console.WriteLine("Computer chose ROCK");
                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("PLAYER WINS!!\n\n");
                               
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("CPU WINS!!\n\n");
                               
                            }
                            break;
                        case 2:
                    Console.WriteLine("Computer chose PAPER");
                            if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("CPU WINS!!\n\n");
                       
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("PLAYER WINS!!\n\n");
                              
                            }
                            break;
                        case 3:
                    Console.WriteLine("Computer chose SCISSORS");
                            if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("PLAYER WINS!!\n\n");

                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("CPU WINS!!\n\n");
                              
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid entry!");
                            break;
                    }


                }

                

                

                

            }
        }
    
