using System;
using System.Collections.Generic;
using System.Linq;

namespace ToDoItems
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<ToDoItem> list = new List<ToDoItem>();

            do
            {
                Console.WriteLine("Enter an item desciption:");
                string description = Console.ReadLine();
                Console.WriteLine("Enter the due date:");
                string due = Console.ReadLine();
                Console.WriteLine("Enter the priority:");
                string priority = Console.ReadLine();

                ToDoItem item1 = new ToDoItem(description, due, priority);

                Console.WriteLine("Add a to do item:");


            } while (true);
            

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

    
}
