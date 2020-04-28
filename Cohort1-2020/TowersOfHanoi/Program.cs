using System;
using System.Collections.Generic;

namespace TowersOfHanoi
{

    class Program
    {
        private static Dictionary<String, Stack<int>> board = new Dictionary<string, Stack<int>>();


        static void Main(string[] args)
        {
            //todo creating the board
            Stack<int> stack = new Stack<int>();
            stack.Push(4);
            stack.Push(3);
            stack.Push(2);
            stack.Push(1);
            board.Add("A", stack);
            // B and C empty initially because all the disks will be on A
            board.Add("B", new Stack<int>());
            board.Add("C", new Stack<int>());



            do
            {
                Console.Clear();
                PrintBoard();
                Console.WriteLine("Enter the peg you want to move from:");
                string from = Console.ReadLine().ToUpper();
                Console.WriteLine("Enter the peg you want to move to:");
                string to = Console.ReadLine().ToUpper();


                // if move is valid, move the disk to the stack
                if (IsMoveValid(from, to))
                {
                    stack.Push(stack.Pop());
                }

                else
                {
                    Console.WriteLine("Illegal move.");
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                }
            } while (!CheckWin()); // loop

            Console.Clear();
            PrintBoard();
            Console.WriteLine("You Won!");
            Console.ReadKey();


        }

        private static bool IsMoveValid(string from, string to)
        {
            if (board[from].Count != 0 && (board[to].Count == 0 || board[from].Peek() < board[to].Peek()))
            {
                return true;
            }
            

            return false;



        }

        //check if C has all the disks
        private static bool CheckWin()
        {
            if (board["C"].Count == 4)
            {
                return true;
            }

            return false;
        }
        

        private static void PrintBoard()
        {
            foreach (var item in board)
            {
                Console.WriteLine($"\n{item.Key}: ");
                var numbers = item.Value.ToArray();
                for (int i = numbers.Length; i > 0; i--)
                {
                    Console.WriteLine(numbers[i - 1] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

