using System;
using Microsoft.EntityFrameworkCore;

namespace EFTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task name: ");
            String name = Console.ReadLine();
            Console.WriteLine("Due date: ");
            int date = Convert.ToInt32(Console.ReadLine());

            Task t = new Task(name, date);


            StudentsContext context = new StudentsContext();
            context.Database.EnsureCreated();
            context.students.Add(t);
            context.SaveChanges();

            foreach(Task contextStudent in context.students)
            {
                Console.WriteLine("{0}: {1}", contextStudent.id, contextStudent.name, contextStudent.date);

            }

            Console.WriteLine("Task id to delete: ");
            int idToDelete = Convert.ToInt32(Console.ReadLine());

            Task studentToDelete = context.students.Find(idToDelete);
            context.students.Remove(studentToDelete);
        }
    }

    class Task
    {
        public int id { get; private set; }
        public String name { get; private set; }
        public int date { get; private set; }

        public Task(String name, int date)
        {
            this.name = name;
            this.date = date;
        }
    }

    class StudentsContext : DbContext
    {
        public DbSet<Task> students { get; set; }

        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=/Users/Merc/Downloads/ef.db");
        }

    }
}
