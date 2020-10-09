using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace RawData
{
    class Program
    {
        static void Main(string[] args)
        {
            int n =int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] data =Console.ReadLine().Split();
                string model = data[0];

                int engineSpeed = int.Parse(data[1]);
                int enginePower = int.Parse(data[2]);

                Engine engine = new Engine(engineSpeed, enginePower);

                int cargoWeight = int.Parse(data[3]);
                string cargoType = data[4];

                Cargo cargo = new Cargo(cargoWeight, cargoType);

                double tire1Pressure = double.Parse(data[5]);
                int tire1Age = int.Parse(data[6]);
                double tire2Pressure = double.Parse(data[7]);
                int tire2Age = int.Parse(data[8]);
                double tire3Pressure = double.Parse(data[9]);
                int tire3Age = int.Parse(data[10]);
                double tire4Pressure = double.Parse(data[11]);
                int tire4Age = int.Parse(data[12]);
            
                
                Tire[] tires = new Tire[4] {
            new Tire (tire1Pressure,tire1Age),
            new Tire (tire2Pressure,tire2Age),
            new Tire (tire3Pressure,tire3Age),
            new Tire (tire4Pressure,tire4Age),
            };

                Car car = new Car(model,engine,cargo,tires);
                cars.Add(car);


            }
            string command = Console.ReadLine();
            if (command=="fragile")
            {
                var fragileCargoCars = cars.Where(x => x.Cargo.CargoType == "fragile").ToList();
               
                    
                    foreach (var car in fragileCargoCars)
                {
                    foreach (var tire in car.Tires)
                    {
                        if (tire.TirePressure< 1)
                        {
                            Console.WriteLine(car.Model);
                            break;
                        }
                    }
                       
                    }
                
            }
            else if (command=="flamable")
            {
                var flamableCargo = cars.Where(x => x.Cargo.CargoType == "flamable").ToList();
               

                    foreach (var car in flamableCargo)
                    {
                        if (car.Engine.EnginePower>250)
                        {
                            Console.WriteLine(car.Model);
                        }
                    }
                
            }

        }
    }
}
