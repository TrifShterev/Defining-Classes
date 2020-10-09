using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    class Tire
    {
        public Tire(double tirePressure,int tireYear)
        {
            this.TirePressure = tirePressure;
            this.TireYear = tireYear;
        }
        public int TireYear { get; set; }
        public double TirePressure { get; set; }
    }
}
