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
            ToDoItem item = new ToDoItem(desc);
            context.Add(item);
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
            if(updated.IsPending == true)
            {
                updated.IsPending = false;

            }
            else
            {
                updated.IsPending = true;
            }

        
            context.Update(updated);
            context.SaveChanges();
        }

        public List<ToDoItem> displayList()
        {
            List<ToDoItem> newList = new List<ToDoItem>().ToList();
            newList = context.ToDoItems.ToList();
            return newList;

        }

        public List<ToDoItem> pendingList()
        {
            List<ToDoItem> newList = new List<ToDoItem>().ToList();
            newList = context.ToDoItems.Where(item => item.IsPending == false).ToList();
            return newList;
        }

        public List<ToDoItem> doneList()
        {
            List<ToDoItem> newList = new List<ToDoItem>().ToList();
            newList = context.ToDoItems.Where(item => item.IsPending == true).ToList();
            return newList;
            
        }



    }
}
