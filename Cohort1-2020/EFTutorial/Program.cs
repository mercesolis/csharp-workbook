using System;
using Microsoft.EntityFrameworkCore;

namespace EFTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student name: ");
            String name = Console.ReadLine();
            Console.WriteLine("Student grade: ");
            int grade = Convert.ToInt32(Console.ReadLine());

            Student s = new Student(name, grade);


            StudentsContext context = new StudentsContext();
            context.Database.EnsureCreated();
            context.students.Add(s);
            context.SaveChanges();

            foreach(Student contextStudent in context.students)
            {
                Console.WriteLine("{0}: {1} has a grade of {2}", contextStudent.id, contextStudent.name, contextStudent.grade);

            }

            Console.WriteLine("Student id to delete: ");
            int idToDelete = Convert.ToInt32(Console.ReadLine());

            Student studentToDelete = context.students.Find(idToDelete);
            context.students.Remove(studentToDelete);
        }
    }

    class Student
    {
        public int id { get; private set; }
        public String name { get; private set; }
        public int grade { get; private set; }

        public Student(String name, int grade)
        {
            this.name = name;
            this.grade = grade;
        }
    }

    class StudentsContext : DbContext
    {
        public DbSet<Student> students { get; set; }

        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=/Users/Merc/Downloads/ef.db");
        }

    }
}
