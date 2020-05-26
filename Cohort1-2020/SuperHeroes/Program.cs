using System;
using System.Collections.Generic;

namespace SuperHeroes
{
    class Program
    {
        public static void Main(string[] args)
        {


            Superhero batman = new Superhero("Bruce Wayne", "Batman", "Rich.");
            Console.WriteLine(batman.PrintGreeting());

            List<Person> people = new List<Person>();
            people.Add(new Villain("The Joker", "Smart", string.Empty));
            people.Add(new Superhero("Wade Turner", "Mr. Incredible", "super strength"));
            people.Add(new Person("William", "Bill"));
            people.Add(new Villain("Norman Osbourne", "Green Goblin", "Evil"));
            people.Add(new Superhero("Peter Parker", "Spiderman", "Webs"));
            foreach (var person in people)
            {
                Console.WriteLine(person.PrintGreeting());
                
                
            }

            Console.ReadKey();
        }
    }

    class Person
    {
        private string name;
        public string Name { get; set; }
        public string Nickname { get; set; }

        public Person(string name,string nickname)
        {
            Name = name;
            Nickname = nickname;
        }
        public override string ToString()
        {
            return Name;
        }

        public virtual string PrintGreeting()
        {
            return "Hi, my name is William, you can call me Bill.";
            


        }
    }

    class Superhero : Person
    {
        public string Superpower { get; set; }
        public Superhero(string name, string nickname, string superpower) : base(name,nickname)
        {
            Superpower = superpower;
        }

        public override string PrintGreeting()
        {
            return "I am Wade Turner. When I am Mr. Incredible, my super power is Super Strength!";
        }
    }

    class Villain : Person
    {

        public string Nemesis { get; set; }
        public string EvilPower { get; set; }
        public Villain(string name, string nickname, string superpower) : base(name, string.Empty)
       
        {
            EvilPower = superpower;
        }
        public override string PrintGreeting()
        {
            return $"I am {Name}, Have you seen {Name}?";
        }

    }
    
}

