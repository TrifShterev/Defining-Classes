using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace CarSalesman
{
    class Engine
    {
        public Engine()
        {

        }

        public Engine(string model, int power):this()
        {
            Model = model;
            Power = power;
            Displacement = "n/a";
            Efficiency = "n/a";
        }

        public Engine(string model, int power, string displacement):this(model,power)
        {
            Model = model;
            Power = power;
            Displacement = displacement;
            Efficiency = "n/a";
        }

        public Engine(string model, int power, string displacement, string efficiency)
            :this(model,power,displacement)
        {
            Model = model;
            Power = power;
            Displacement = displacement;
            Efficiency = efficiency;
        }

        public string Model { get; set; }
        public int Power { get; set; }
        public string Displacement { get; set; }
        public string Efficiency { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            
            sb.AppendLine($"  {Model}:");
            sb.AppendLine($"    Power: {Power}");
            sb.AppendLine($"    Displacement: {Displacement}");
            sb.AppendLine($"    Efficiency: {Efficiency}");
           

            return sb.ToString();


        }
    }

       
}



