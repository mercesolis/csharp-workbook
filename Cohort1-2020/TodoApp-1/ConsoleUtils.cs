using System;
using System.Collections.Generic;

namespace TodoApp1
{
    public class ConsoleUtils
    {
        public int GetUserOption()
        {
            // ConsoleUtils class to handle printing to the console, and reading from the console. Yes, this could be done in the App class, but we want to contain all code that handles user input and display to the ConsoleUtils class.

            PrintMenu();
            var result = Console.ReadLine();

            if (!int.TryParse(result, out int number))
            {
                Console.WriteLine("Invalid option");
            }
            return number;
        }

        static int PrintMenu()
        {
            int choice;
            Console.WriteLine("0 - Exit the program");
            Console.WriteLine("1 - Add a new item");
            Console.WriteLine("2 - Delete an item");
            Console.WriteLine("3 - Display pending items");
            Console.WriteLine("4 - Display list");
            Console.WriteLine("5 - Print completed items.");
            Console.WriteLine("What would you like to do?");
            choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }
        public int Delete()
        {
            Console.WriteLine("Enter id to delete:");
            int id = Convert.ToInt32(Console.ReadLine());
            return id;
        }

        public string AddItem()
        {
            Console.WriteLine("Add a task: ");
            string item = Console.ReadLine();
            return item;
        }


        public void PrintList(List<ToDoItem> list)
        {
            Console.WriteLine(" id | item            | status    ");
            Console.WriteLine("----+-----------------+------------");
            foreach (var l in list)
            {
                Console.WriteLine($"{l.Id}, {l.Description}, {l.IsPending}");
            }
        }
    }
}
