using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Speed_Racing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = input[0];
                double fuelAmount = double.Parse(input[1]);
                double fuelConsumption = double.Parse(input[2]);

                Car car = new Car();

                car.Model = model;
                car.FuelAmount = fuelAmount;
                car.FuelConsumption = fuelConsumption;
                car.TravelledDistance = 0.0;

                cars.Add(car);
            }

            string command;
            while ((command=Console.ReadLine())!="End")
            {
                var tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var carModel = tokens[1];
                double distance = double.Parse(tokens[2]);
                foreach (var car in cars)
                {
                    if (car.Model==carModel)
                    {
                        car.Drive(distance);
                       
                    }
                }
               
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }

        }
    }
}
