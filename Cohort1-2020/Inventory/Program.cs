using System;
using System.Collections.Generic;

namespace Inventory
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<IRentable> rentals = new List<IRentable>();
            rentals.Add(new Boat("", 100));

            foreach (var item in rentals)
            {
                Console.WriteLine(item.GetRate());
            }
        }

        interface IRentable
        {
            decimal GetRate();
            string GetDescription();

        }

        class Boat : IRentable
        {
            private decimal chargePerHour;
            private string desc;
            private int hours;

            public Boat(string desc, decimal chargePerHour)
            {
                this.chargePerHour = hours;
                this.desc = desc;
                

            }

            public string GetDescription()
            {
                return desc;
            }

            public decimal GetRate()
            {
                
                return chargePerHour;
            }


        }

        class House : IRentable
        {

            public string GetDescription()
            {
                throw new NotImplementedException();
            }

            public decimal GetRate()
            {
                throw new NotImplementedException();
            }
        }

        /*class Car : IRentable
        {
            private decimal rate;
            private string desc;

            public Car(decimal rate, string desc)
            {
                rate 
            }
            public string GetDescription()
            {
                throw new NotImplementedException();
            }

            public decimal GetRate()
            {
                throw new NotImplementedException();
            }
        }*/
    }
    

    
    
}
