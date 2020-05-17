using System;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace BooksInventory
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Book title: ");
            String title = Console.ReadLine();
            Console.WriteLine("Book author: ");
            String author = Console.ReadLine();

            Book book = new Book(title, author);


            BookContext context = new BookContext();
            context.Database.EnsureCreated();
            context.book.Add(book);
            context.SaveChanges();

            foreach (Book contextBook in context.book)
            {
                Console.WriteLine("{0}, {1}, {2}", contextBook.id, contextBook.title, contextBook.author);

            }

            Console.WriteLine("Book id to delete: ");
            int idToDelete = Convert.ToInt32(Console.ReadLine());

            Book bookToDelete = context.book.Find(idToDelete);
            context.book.Remove(bookToDelete);
        }
    }

    class Book
    {
        public int id { get; private set; }
        public String title { get; private set; }
        public String author { get; private set; }

        public Book(String title, String author)
        {
            this.title = title;
            this.author = author;
        }
    }

    class BookContext : DbContext
    {
        public DbSet<Book> book { get; set; }

        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=/Users/Merc/Downloads/bi.db");
        }
    }
}
