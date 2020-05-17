using System;

namespace ToDoItems
{
    class Program
    {
        static void Main(string[] args)
        {
            // loop to enter items

            do
            {
                Console.WriteLine("Enter an item desciption, due date, and priority of Low, medium, or high");
                string description = Console.ReadLine();

            } while (true);

            // loop to print out the items entered

        }
    }


    class ToDoItem
    {

        private string description;

        private string due;

        private string prior;

        public ToDoItem(string desc, string dueDate, string priority)
        {
            description = desc;
            due = dueDate;
            prior = priority;
        }
    }

    
}
