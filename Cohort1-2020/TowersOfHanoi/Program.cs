using System;
using System.Collections.Generic;

namespace TowersOfHanoi
{

    class Program
    {
        private static Dictionary<string, Stack<int>> board = new Dictionary<string, Stack<int>>();


        static void Main(string[] args)
        {
            // creating the board
            Stack<int> stack = new Stack<int>(); // instantiating a new stack
            stack.Push(4); // pushing 4 on top of the stack
            stack.Push(3); // pushing 3 before 4
            stack.Push(2); // pushing 2 before 3
            stack.Push(1); // pushing 1 before 2
            board.Add("A", stack); // creating the 'A' peg, adding stacks 1-4 to the peg
            // B and C empty initially because all the disks will be on A
            board.Add("B", new Stack<int>()); //add 'B' peg, empty initially
            board.Add("C", new Stack<int>()); // add 'C' peg, empty initially



            do // loop 
            {
                Console.Clear(); // clear the console
                PrintBoard(); // show the board (pegs and stacks)
                Console.WriteLine("Enter the peg you want to move from:"); // console asks the player to move from
                string from = Console.ReadLine().ToUpper(); // convert player input to uppercase
                Console.WriteLine("Enter the peg you want to move to:"); // asks player to move to
                string to = Console.ReadLine().ToUpper(); // convert player input to uppercase


                // if move is valid, move the disk to the stack
                if (IsMoveValid(from, to)) // if player move is valid according to the 'IsMoveValid' statement:
                {
                    stack.Push(stack.Pop()); // "pop the move off the top"
                }

                else // if move is invalid:
                {
                    Console.WriteLine("Illegal move."); // tell player move is illegal
                    Console.WriteLine("Press any key to continue."); // tell player to press any key if they want to try again
                    Console.ReadKey(); // game continues if player pushes key
                }
            } while (!CheckWin()); // loop checking if game is won

            Console.Clear(); // clears console 
            PrintBoard(); // prints board
            Console.WriteLine("You Won!"); // tells player they won
            Console.ReadKey(); // game continues 


        }

        private static bool IsMoveValid(string from, string to) // valid moves from and to pegs
        {
            // cannot move from empty peg
            if (board[from].Count != 0 && (board[to].Count == 0 || board[from].Peek() < board[to].Peek())) // checking if any disks on peg
            {
                return true; // continue with move
            }
            

            return false; // if move does not meet the 'if' statement, will go through 'do' loop and tell player move is illegal



        }

        //check if C has all the disks
        private static bool CheckWin() // check for game win
        {
            if (board["C"].Count == 4) //if 'C' has all 4 disks, win
            {
                return true; // goes through 'while' loop and game is won
            }

            return false; // if 'C' does not have all 4 disks, game continues
        }
        

        private static void PrintBoard() // creating board
        {
            
            foreach (var item in board) // for each disk in board
            {
                Console.WriteLine($"{item.Key}: "); // prints pegs and disks
                var numbers = item.Value.ToArray(); // instantiates board
                for (int i = numbers.Length; i > 0; i--)  // sorts numbers in descending order
                {
                    Console.WriteLine(numbers[i - 1] + " "); // prints board plus player input
                }
                Console.WriteLine();
            }
        }
    }
}

