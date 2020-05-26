using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using System.Collections.Generic;
using System.IO;
using System;


namespace TodoApp1 
{
    


    public class ItemContext : DbContext
    {

        public DbSet<ToDoItem> ToDoItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            DirectoryInfo ExecutionDirectory = new DirectoryInfo(AppContext.BaseDirectory);

            DirectoryInfo ProjectBase = ExecutionDirectory.Parent.Parent.Parent;

            String DatabaseFile = Path.Combine(ProjectBase.FullName, "todoitems.db");

            optionsBuilder.UseSqlite("Data Source=" + DatabaseFile);
        }

    }
}
