using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehilcle> vehicles = new List<Vehilcle>();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] information = command.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                              .ToArray();

                string type = information[0];
                if (type == "Car" || type == "car") { type = "Car"; }
                if (type == "Truck" || type == "truck") { type = "Truck"; }
                string model = information[1];
                string color = information[2];
                double horsepower = double.Parse(information[3]);
                Vehilcle currentVehicle = new Vehilcle(type, model, color, horsepower);
                vehicles.Add(currentVehicle);

                command = Console.ReadLine();
            }

            string modelOfVehicles = Console.ReadLine();

            while (modelOfVehicles != "Close the Catalogue")
            {
                foreach (Vehilcle vehicle in vehicles)
                {
                    if (vehicle.Model == modelOfVehicles)
                    {
                        Console.WriteLine($"Type: {vehicle.Type}\nModel: {vehicle.Model}\nColor: {vehicle.Color}\nHorsepower: {vehicle.Horsepower}");
                        break;
                    }
                }

                modelOfVehicles = Console.ReadLine();
            }

            int countCars = 0;
            int countTrucks = 0;
            double sumOfHoursepowerOfCas = 0;
            double sumOfHoursepowerOfTrucks = 0;

            foreach (Vehilcle vehilcle in vehicles)
            {
                if (vehilcle.Type == "Car")
                {
                    sumOfHoursepowerOfCas += vehilcle.Horsepower;
                    countCars++;
                }
                else
                {
                    sumOfHoursepowerOfTrucks += vehilcle.Horsepower;
                    countTrucks++;
                }
            }

            double averageHorsepowerForCars = 0;
            double averageHorspowerForTrucks = 0;

            if (countCars > 0)
            {
                averageHorsepowerForCars = sumOfHoursepowerOfCas / countCars;
            }
            
            if (countTrucks > 0)
            {
                averageHorspowerForTrucks = sumOfHoursepowerOfTrucks / countTrucks;
            }

            Console.WriteLine($"Cars have average horsepower of: {averageHorsepowerForCars:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {averageHorspowerForTrucks:f2}.");
        }
    }
    class Vehilcle
    {
        public Vehilcle(string type, string model, string color, double horsepower)
        {
            Type = type;
            Model = model;
            Color = color;
            Horsepower = horsepower;
        }

        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double Horsepower { get; set; }
    }
}
