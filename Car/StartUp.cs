
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var tires = new List<Tire[]>();

            string tiresInfo;

            while ((tiresInfo = Console.ReadLine()) != "No more tires")
            {
                var tokens = tiresInfo.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();
               
                
                var currentPairOfTires = new Tire[4]
                {
               new Tire((int)tokens[0], tokens[1]),
                    new Tire((int)tokens[2], tokens[3]),
                    new Tire((int)tokens[4], tokens[5]),
                    new Tire((int)tokens[6], tokens[7]),
                };
                tires.Add(currentPairOfTires);

            }

            var engines = new List<Engine>();

            string enginesInfo;
            while ((enginesInfo = Console.ReadLine()) !="Engines done")
            {
                var tokens = enginesInfo.Split();
                int horsePower = int.Parse(tokens[0]);
                double cubicCapacity = double.Parse(tokens[1]);

                var engine = new Engine(horsePower, cubicCapacity);
                engines.Add(engine);
            }

            var cars = new List<Car>();

            string carInfo;
            while ((carInfo = Console.ReadLine()) != "Show special")
            {
                var tokens = carInfo.Split();
                string make = tokens[0];
                string model = tokens[1];
                int year = int.Parse(tokens[2]);
                double fuelQuantity = double.Parse(tokens[3]);
                double fuelConsumption = double.Parse(tokens[4]);
                int engineIndex = int.Parse(tokens[5]);
                int tireIndex = int.Parse(tokens[6]);

                var car = new Car
                 (make, model, year, fuelQuantity, fuelConsumption, engines[engineIndex],
                 tires.ElementAt(tireIndex));
                cars.Add(car);
                
            }

            
                 
                 

            foreach (var car in cars)
            {
                var pressureOfTheTiresPair = 0.00;

                foreach (var tire in car.Tires)
                {
                    pressureOfTheTiresPair += tire.Pressure;

                }

                if (car.Year >= 2017 && car.Engine.HorsePower > 330 && (pressureOfTheTiresPair > 9 && pressureOfTheTiresPair < 10))
                {
                    car.Drive(20);
                    Console.WriteLine(car.WhoAmI()); 
                }


            }
        }
    }
}
