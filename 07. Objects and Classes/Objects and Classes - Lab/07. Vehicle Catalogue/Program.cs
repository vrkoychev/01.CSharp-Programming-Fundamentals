using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Vehicle_Catalogue
{
    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Weigth { get; set; }
    }

    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string HorsePower { get; set; }
    }

    class Catalog
    {
        public Truck Trucks { get; set; }

        public Car Cars { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Truck> trucks = new List<Truck>();
            List<Car> cars = new List<Car>();

            while (input != "end")
            {
                string[] data = input.Split('/').ToArray();

                Truck truck = new Truck();
                Car car = new Car();

                string type = data[0];
                string brand = data[1];
                string model = data[2];

                if (type == "Truck")
                {
                    string weigth = data[3];
                    truck.Brand = brand;
                    truck.Model = model;
                    truck.Weigth = weigth;

                    trucks.Add(truck);

                }
                else if (type == "Car")
                {
                    string horsePower = data[3];
                    car.Brand = brand;
                    car.Model = model;
                    car.HorsePower = horsePower;

                    cars.Add(car);
                }

                input = Console.ReadLine();
            }

            trucks.Sort((a, b) => (a.Brand.CompareTo(b.Brand)));
            cars.Sort((a,b) => (a.Brand.CompareTo(b.Brand)));

            if (cars.Count != 0)
            {
                Console.WriteLine("Cars:");
                foreach (Car cr in cars)
                {
                    Console.WriteLine($"{cr.Brand}: {cr.Model} - {cr.HorsePower}hp");
                }
            }

            if (trucks.Count != 0)
            {
                Console.WriteLine("Trucks:");
                foreach (Truck tr in trucks)
                {
                    Console.WriteLine($"{tr.Brand}: {tr.Model} - {tr.Weigth}kg");
                }
            }
        }
    }
}
