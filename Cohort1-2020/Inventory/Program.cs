using System;
using System.Collections.Generic;

namespace Inventory
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<IRentable> rentals = new List<IRentable>();
            rentals.Add(new Boat("Yacht", 100));
            rentals.Add(new House("Yurt", 250, 5));
            rentals.Add(new Car("BMW XB7", 400, 2));
            

            foreach (var item in rentals)
            {
                Console.WriteLine($"{item.GetDescription()} {item.GetRate()}");
            }
            Console.ReadKey();
        }

        interface IRentable
        {
            string GetRate();
            string GetDescription();

        }

        class Boat : IRentable
        {
            private decimal chargePerHour;
            private string desc;
            private int hours;

            public Boat(string desc, decimal chargePerHour)
            {
                this.chargePerHour = chargePerHour;
                this.desc = desc;
                

            }

            public string GetDescription()
            {
                return desc;
            }

            public string GetRate()
            {
                
                return $"Costs ${chargePerHour} per hour";
            }

            
        }

        class House : IRentable
        {
            private decimal chargePerWeek;
            private string desc;
            private int weeks;

            public House(string desc, decimal chargePerWeek, int weeks)
            {
                this.desc = desc;
                this.chargePerWeek = chargePerWeek;
            }

            public string GetDescription()
            {
                return desc;
            }

            public string GetRate()
            {
                return $"Costs ${chargePerWeek} per week";
            }

            
        }

        class Car : IRentable
        {
            private decimal chargePerDay;
            private string desc;
            private int days;

            public Car(string desc, decimal chargePerDay, int days)
            {
                this.desc = desc;
                this.chargePerDay = chargePerDay;
            }

            public string GetDescription()
            {
                return desc;
            }

            public string GetRate()
            {
                return $"Costs ${chargePerDay} per day";
            }
        }
    }
    

    
    
}
