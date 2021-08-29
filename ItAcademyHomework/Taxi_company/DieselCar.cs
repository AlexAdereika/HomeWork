using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi_company
{
    class DieselCar : CarInCompany
    {
        public Fuel FuelType = Fuel.Diesel;
        public int FuelConsumption { get; set; }
        public DieselCar(string Model, int Cost, int Speed, int Consumption)
        {
            CarModel = Model;
            CarCost = Cost;
            MaxSpeed = Speed;
            FuelConsumption = Consumption;
        }
    }
}
