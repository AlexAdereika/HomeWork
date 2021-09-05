using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi_company
{
    abstract class ConsumptionCar : CarInCompany
    {
        public int FuelConsumption
        {
            get; set;
        }
        public ConsumptionCar(string Model, int Cost, int Speed, int Consumption, Fuel fuelType) : base(Model, Cost, Speed, fuelType)
        {
            FuelConsumption = Consumption;
        }
        public override string ToString()
        {
            return base.ToString() + $"\t {FuelConsumption} l/km";
            
        }
    }
    
}

