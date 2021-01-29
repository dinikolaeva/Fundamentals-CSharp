using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            CatalogVehicle catalog = new CatalogVehicle();

            while (command != "end")
            {
                var vehicleInfo = command.Split('/', StringSplitOptions.RemoveEmptyEntries);

                var type = vehicleInfo[0];
                var brand = vehicleInfo[1];
                var model = vehicleInfo[2];
                var typeInfo = vehicleInfo[3];

                if (type == "Truck")
                {
                    Truck newTruck = new Truck()
                    {
                        Brand = brand,
                        Model = model,
                        Weight = typeInfo
                    };

                    catalog.Trucks.Add(newTruck);
                }
                else
                {
                    Car newCar = new Car()
                    {
                        Brand = brand,
                        Model = model,
                        HorsePower = typeInfo
                    };

                    catalog.Cars.Add(newCar);
                }

                command = Console.ReadLine();
            }

            if (catalog.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");

                foreach (Car car in catalog.Cars.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
                Console.WriteLine("Trucks:");
            }

            if (catalog.Trucks.Count > 0)
            {
                foreach (Truck truck in catalog.Trucks.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }

    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Weight { get; set; }
    }
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string HorsePower { get; set; }
    }
    class CatalogVehicle
    {
        public CatalogVehicle()
        {
            this.Trucks = new List<Truck>();
            this.Cars = new List<Car>();
        }

        public List<Truck> Trucks { get; set; }
        public List<Car> Cars { get; set; }
    }
}
