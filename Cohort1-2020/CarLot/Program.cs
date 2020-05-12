using System;
using System.Collections.Generic;

namespace CarLot
{
    class Program
    {
        static void Main(string[] args)
        {
            CarLot carlot1 = new CarLot("My Dream Car Lot"); // creating my car lots
            CarLot carlot2 = new CarLot("My Actual Car Lot");

            carlot1.AddVehicle(new Car("1234ABC", "BMW", "M8 Competition", 100_000, false, "Coupe", 4)); // car lot 1 contains...
            carlot1.AddVehicle(new Truck("4321CBA", "Mercedes Benz", "G63 AMG", 1_000, "6x6"));

            carlot2.AddVehicle(new Car("0246XYZ", "Volkswagen", "Jetta", 11_000, false, "Sedan", 4)); // car lot 2 contains...
            carlot2.AddVehicle(new Truck("8747FJD", "Jeep", "Cherokee", 14_000, "SUV"));

            foreach (var item in carlot1.GetVehicle()) // print contents of car lot 1
            {
                item.PrintDetails();
            }

            foreach (var item in carlot2.GetVehicle()) // print contentd of car lot 2
            {
                item.PrintDetails();
            }

            Console.ReadKey();

            
        }
    }

    abstract class Vehicle // the "main" class?
    {
        public string LicenseNumber { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }

        public Vehicle(string license, string make, string model, decimal price)
        {
            LicenseNumber = license;
            Make = make;
            Model = model;
            Price = price;
        }   

            public virtual void PrintDetails()
            {
            Console.WriteLine($"{LicenseNumber}, Make {Make}, Model {Model},  and costs ${Price}");
            }
    }

    class Car : Vehicle // subclass extends from Vehicle class
    {
        public bool IsElectric { get; set; }
        public string CarType { get; set; }
        public int NumberDoors { get; set; }
        public Car(string license, string make, string model, decimal price, bool electric, string type, int doors) : base(license, make, model, price)
        {
            IsElectric = electric;
            CarType = type;
            NumberDoors = doors;
        }

        public override void PrintDetails()
        {
            Console.WriteLine($"{LicenseNumber}, Make {Make}, Model {Model}, {CarType}, {NumberDoors} door, costs ${Price}, and is electric? {IsElectric}");
        }
        
    }

    class Truck : Vehicle // subclass that extends from Vehicle class
    {
        public string BedSize { get; set; }
        public Truck(string license, string make, string model, decimal price, string size) : base(license, make, model, price)
        {
            BedSize = size;
        }

        public override void PrintDetails()
        {
            Console.WriteLine($"{LicenseNumber}, Make {Make}, Model {Model}, costs ${Price}, and has a {BedSize} bed");
        }


    }

    class CarLot // instantiating car lot 1 "dream car lot"
    {
        public string Name { get; set; }
        List<Vehicle> vehicles = new List<Vehicle>();
        public CarLot(string name)
        {
            Name = name;
        }

        public void AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }

        public List<Vehicle> GetVehicle()
        {
            return vehicles;
        }
    }

    class CarLot2 // instantiating car lot 2 "actual car lot"
    {
        public string Name { get; set; }
        List<Vehicle> vehicles = new List<Vehicle>();
        public CarLot2(string name)
        {
            Name = name;
        }
    }
}
