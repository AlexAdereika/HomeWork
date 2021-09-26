using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi_company
{
    abstract class CarInCompany
    {
        public Fuel FuelType { get; private set; }
        public string CarModel { get; private set; }
        public int CarCost { get; private set; }
        public int MaxSpeed { get; private set; }

        public CarInCompany(string Model, int Cost, int Speed, Fuel fuelType)
        {
            CarModel = Model;
            CarCost = Cost;
            MaxSpeed = Speed;
            FuelType = fuelType;
        }
        public override string ToString()
        {
            return $"{CarModel} \t {FuelType}";
        }
    }
    public enum Fuel
    {
        Gasoline,
        Diesel,
        Electric,
        Hybrid
    }




}
