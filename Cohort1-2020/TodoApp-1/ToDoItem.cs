using System;
using System.Collections.Generic;

namespace TodoApp1
{
    public class ToDoItem
    {
        // ToDoItem class. This is your "POCO" class that represents the item we want to track in our to do app.a.The items should have at a minimum: a description, an id, and done flag or status.b.The user should be able to set the description and the done flag, but the id will be automatically set for us


        public int Id { get; private set; } 
        public string Description { get; set; }
        public bool IsPending { get; set; }
        public ToDoItem(string description)
        {
            Description = description;
            IsPending = true;
        }
    }
}