using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi_company
{
    class HybridCar : CarInCompany
    {
        public Fuel FuelType = Fuel.Hybrid;
        public string FuelConsumption = "Depends on your driving style!";
        public HybridCar(string Model, int Cost, int Speed)
        {
            CarModel = Model;
            CarCost = Cost;
            MaxSpeed = Speed;
            
        }
    }
}
