using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi_company
{
    class GasolineCar : CarInCompany
    {
        public Fuel FuelType = Fuel.Gasoline;
        public int FuelConsumption { get; set; }
        public GasolineCar(string Model, int Cost, int Speed, int Consumption)
        {
            CarModel = Model;
            CarCost = Cost;
            MaxSpeed = Speed;
            FuelConsumption = Consumption;
        }
    }
}
