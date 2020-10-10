using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;

namespace CarSalesman
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Engine> engines = new List<Engine>();
            for (int i = 0; i < n; i++)
            {
                string[] inputEngine = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

                

                var engine = new Engine (inputEngine[0],int.Parse(inputEngine[1]));

                if (inputEngine.Length==3)
                {
                    if (char.IsDigit(inputEngine[2][0]))
                    {
                        engine.Displacement = inputEngine[2];
                    }
                    else
                    {
                        engine.Efficiency = inputEngine[2];
                    }
                    
                }

                if (inputEngine.Length==4)
                {
                    engine.Displacement = inputEngine[2];
                    engine.Efficiency = inputEngine[3];
                }
                engines.Add(engine);
            }

            int m = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < m; i++)
            {
                string[] inputCar =Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string model = inputCar[0];

               

                var selectedEngine = engines.Where(x => x.Model == inputCar[1]).FirstOrDefault();
           
              
                var car = new Car(model,selectedEngine);

                if (inputCar.Length == 3)
                {
                    if (char.IsDigit(inputCar[2][0]))
                    {
                        car.Weight = inputCar[2];
                    }
                    else
                    {
                        car.Color = inputCar[2];
                    }
                    
                }

                if (inputCar.Length == 4)
                {
                    car.Weight = inputCar[2];
                    car.Color = inputCar[3];
                }
                cars.Add(car);
            }
            foreach (var car in cars)
            {
                Console.Write(car);
            }
        }
    }
}
