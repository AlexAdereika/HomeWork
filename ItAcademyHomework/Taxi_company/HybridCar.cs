using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi_company
{
    class HybridCar : CarInCompany
    {
        
        public string FuelConsumption = "Depends on your driving style!";
        public HybridCar(string Model, int Cost, int Speed) : base(Model, Cost, Speed, Fuel.Hybrid)
        {

        }
        public override string ToString()
        {
            return base.ToString() + $"\t {FuelConsumption}";
        }

    }
}
