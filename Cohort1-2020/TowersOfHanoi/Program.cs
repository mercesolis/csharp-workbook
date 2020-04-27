using System;
using System.Collections.Generic;

namespace TowersOfHanoi
{ 

    class Program
    {
        private static Dictionary<string, Stack<int>> board = new Dictionary<string, Stack<int>>();
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(4);
            stack.Push(3);
            stack.Push(2);
            stack.Push(1);
            // board will contain the pegs 'ABC' and the disks 'stack'
            board.Add("A", stack);
            // empty stacks because 'A' will contain all the disks initially
            board.Add("B", new Stack<int>());
            board.Add("C", new Stack<int>());

        }
    }


}

