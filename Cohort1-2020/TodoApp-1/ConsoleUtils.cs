using System;
using System.Collections.Generic;
using System.Linq;

namespace TodoApp1
{
    public class ConsoleUtils
    {
        private bool IsPending;
        public bool validInput = false;
        public int GetUserOption()
        {
            // ConsoleUtils class to handle printing to the console, and reading from the console. Yes, this could be done in the App class, but we want to contain all code that handles user input and display to the ConsoleUtils class.

            return PrintMenu();
        }

        public int PrintMenu()
        {
            
            int number = 0;
            Console.WriteLine("0 - Exit the program");
            Console.WriteLine("1 - Add a new item");
            Console.WriteLine("2 - Delete an item");
            Console.WriteLine("3 - Mark item done");
            Console.WriteLine("4 - Display list");
            Console.WriteLine("5 - Print completed items.");
            Console.WriteLine("6 - Print pending items");
            Console.WriteLine("What would you like to do?");
            while (validInput == false)
            {


                string choice = Console.ReadLine();
                if (!int.TryParse(choice, out number))
                {
                    Console.WriteLine("Invalid option - enter a number: ");
                    validInput = false;
                }
                else
                {
                   validInput = true;
                }
                
            }
            return number;
        }
        public int Delete()
        {
            Console.WriteLine("Enter id to delete:");
            string id = Console.ReadLine();
            if (!int.TryParse(id, out int number))
            {
                Console.WriteLine("Invalid option");
            }
            return number;
        }

        public string AddItem()
        {
            Console.WriteLine("Add a task: ");
            string desc = Console.ReadLine();
            return desc;
        }

        public int UpdateItem()
        {
            Console.WriteLine("Enter ID to update: ");
            string id = Console.ReadLine();
            if (!int.TryParse(id, out int number))
            {
                Console.WriteLine("Invalid option");
            }
            return number;
        }


        public void PrintList(List<ToDoItem> list)
        {
            Console.WriteLine(" id | item            | Done   ");
            Console.WriteLine("----+-----------------+------------");
            foreach (var l in list)
            {
                Console.WriteLine($"{l.Id}, {l.Description}, {l.IsPending}");
            }
        }
    }
}
