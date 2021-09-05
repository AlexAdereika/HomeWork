using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi_company
{
    class ElectricCar : CarInCompany
    {

        public string FuelConsumption = "This car don't use Fuel, it's electric!";
        public ElectricCar(string Model, int Cost, int Speed) : base(Model, Cost, Speed, Fuel.Electric)
        {

        }
        public override string ToString()
        {
            return base.ToString() + $"\t {FuelConsumption}";
        }
    }

}
