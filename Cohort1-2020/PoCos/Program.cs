using System;


namespace PoCos
{
    class DriversLicense
    {
        static void Main(string[] args)
        {
            /* Driver's License
            Create a class that represents a driver's License.

            Your class should include the following fields:
            FirstName
            LastName
            Gender
            LicenseNumber
            Your class should include a constructor to set the FirstName, LastName, Gender, and LicenseNumber
            Your class should include a method that returns the FullName by concatenating the first and last name */

            Person p = new Person();
            p.firstName = "Mercedes";
            p.lastName = "Solis";
            p.gender = "F";
            p.licenseNumber = 12345678;

            Console.WriteLine(p.firstName + "  " + p.lastName);
        }
    }


    class Person
    {
        public String firstName;
        public String lastName;
        public string gender;
        public int licenseNumber;
    }



    class Book
    {
        public String title;
        public string authors;
        public int numPages;
        public int sku;
        public String publisher;
        public double price;

        static void Program()
        {

            /* Book
            Create a class that represents a book.

            Your class should include the following fields:

            Title
            Authors; this should allow for multiple authors
            Pages; this should hold the number of pages
            SKU
            Publisher
            Price */

            Book book = new Book();
            book.title = "Harry Potter";
            book.authors = "RL";
            book.numPages = 50000;
            book.sku = 97639302;
            book.publisher = "";
            book.price = 60.99;


            Console.WriteLine(book.title, "is on sale for" + book.price);


        }

    }
    




    class Airplane
    {


        /* Airplane
        Create a class that represents different airplane models.

        Your class should include the following fields:

        Manufacturer
        Model
        Variant
        Capacity; this should hold the seating capacity
        Engines; this should hold the number of engines */


        public string mfg;
        public int model;
        public int variant;
        public int capacity;
        public int numEngines;




        
    }
}
