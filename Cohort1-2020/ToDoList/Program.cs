using System;
using System.Collections.Generic;
using System.Linq;

namespace ToDoItems
{
    class Program
    {
        public static void Main(string[] args)
        {
            var toDoItem = new ToDoItem("","","");
            List<ToDoItem> list = new List<ToDoItem>();
            string addItem = "Y";

            while (addItem == "Y")
            {

                Console.WriteLine("Enter an item desciption:");
                string description = Console.ReadLine();
                Console.WriteLine("Enter the due date:");
                string due = Console.ReadLine();
                Console.WriteLine("Enter the priority:");
                string priority = Console.ReadLine();
                

                ToDoItem item1 = new ToDoItem(description, due, priority);
                list.Add(item1);
                ToDoItem.PrintList(list);
                Console.WriteLine();
                Console.Write("Add another item?: Y or N");
                addItem = Console.ReadLine();

            }
            Console.ReadKey();
            
        }

    }

    public class ToDoItem
    {

        private string Description { get; }

        private string DueDate { get; }

        private string Priority { get; }

        public ToDoItem(string desc, string dueDate, string priority)
        {
            Description = desc;
            DueDate = dueDate;
            Priority = priority;

        }

        public static void PrintList(List<ToDoItem> list)
        {
            Console.WriteLine(" Description | Due date | Priority");
            Console.WriteLine("----+-----------------+------------");
            foreach (var l in list)
            {
                Console.WriteLine($"{l.Description}, {l.DueDate}, {l.Priority}");
            }
        }




    }

    



}
