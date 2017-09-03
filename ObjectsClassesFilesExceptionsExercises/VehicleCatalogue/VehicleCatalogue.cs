using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    class Vehicle
    {
        public string Type { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public int HorsePower { get; set; }

        public static void PrintInformation(Vehicle vehicle)
        {
            if (vehicle.Type == "car")
            {
                Console.WriteLine("Type: Car");
            }
            else if (vehicle.Type == "truck")
            {
                Console.WriteLine("Type: Truck");
            }
            Console.WriteLine("Model: {0}", vehicle.Model);
            Console.WriteLine("Color: {0}", vehicle.Color);
            Console.WriteLine("Horsepower: {0}", vehicle.HorsePower);
        }

        public static double CarsAverageHorsePower(List<Vehicle> vehicles)
        {
            var carHorsePowers = new List<int>();

            foreach (var vehicle in vehicles)
            {
                if (vehicle.Type == "car")
                {
                    carHorsePowers.Add(vehicle.HorsePower);
                }
            }

            if (carHorsePowers.Count != 0)
            {
                return carHorsePowers.Average();
            }
            else
            {
                return 0;
            }
        }

        public static double TrucksAverageHorsePower(List<Vehicle> vehicles)
        {
            var trucksHorsePowers = new List<int>();

            foreach (var vehicle in vehicles)
            {
                if (vehicle.Type == "truck")
                {
                    trucksHorsePowers.Add(vehicle.HorsePower);
                }
            }

            if (trucksHorsePowers.Count != 0)
            {
                return trucksHorsePowers.Average();
            }
            else
            {
                return 0;
            }
        }
    }

    public static void Main()
    {
        var currentVehicle = Console.ReadLine();

        var vehicles = new List<Vehicle>();

        while (currentVehicle != "End")
        {
            var tokens = currentVehicle
                .Split().ToArray();
            var type = tokens[0].ToLower();
            var model = tokens[1];
            var color = tokens[2];
            var horsePower = int.Parse(tokens[3]);

            var vehicle = new Vehicle()
            {
                Type = type,
                Model = model,
                Color = color,
                HorsePower = horsePower
            };

            vehicles.Add(vehicle);

            currentVehicle = Console.ReadLine();
        }

        var currentModel = Console.ReadLine();

        while (currentModel != "Close the Catalogue")
        {
            for (int i = 0; i < vehicles.Count; i++)
            {
                if (vehicles[i].Model == currentModel)
                {
                    Vehicle.PrintInformation(vehicles[i]);
                }
            }

            currentModel = Console.ReadLine();
        }

        Console.WriteLine("Cars have average horsepower of: {0:f2}.", Vehicle.CarsAverageHorsePower(vehicles));
        Console.WriteLine("Trucks have average horsepower of: {0:f2}.", Vehicle.TrucksAverageHorsePower(vehicles));
    }
}
