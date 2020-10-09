using System;
using System.Collections.Generic;
using System.Text;

namespace Speed_Racing
{
    class Car
    {

        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumption { get; set; }
        public double TravelledDistance { get; set; }

        public void Drive(double distance)
        {
            bool isGoodToGo = FuelAmount - distance  * FuelConsumption >= 0;
            if (isGoodToGo)
            {
                FuelAmount -= (distance * FuelConsumption);
                this.TravelledDistance += distance;
                
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }


        }
    }
}
