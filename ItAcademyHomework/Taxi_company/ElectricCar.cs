using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi_company
{
    class ElectricCar:CarInCompany
    {
        public Fuel FuelType = Fuel.Electric;
        public string FuelConsumption = "This car don't use Fuel, it's electric!";
        public ElectricCar(string Model, int Cost, int Speed)
        {
            CarModel = Model;
            CarCost = Cost;
            MaxSpeed = Speed;
           
        }
    }
}
