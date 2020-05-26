using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TodoApp1
{
    public class ItemRepository
    {
        // ItemRepository class that acts as the interface between your application and the database that store the TodoItems. This class is responsible for managing the list of items and how it is saved and fetched from the database.
        public ItemContext context = new ItemContext();
        public ItemRepository()
        {
            context.Database.EnsureCreated();
        }

        public void addItem (string desc)
        {
            ToDoItem added = context.ToDoItems.Where(item => item.Description == desc).FirstOrDefault();
            context.Add(added);
            context.SaveChanges();
        }

        public void delete (int id)
        {
            ToDoItem deleted = context.ToDoItems.Where(item => item.Id == id).FirstOrDefault();             context.Remove(deleted);
            context.SaveChanges();
        }

        public void updateItem (int id)
        {
            ToDoItem updated = context.ToDoItems.Where(item => item.Id == id).FirstOrDefault();
            context.Update(updated);
            context.SaveChanges();
        }

        public 



    }
}
