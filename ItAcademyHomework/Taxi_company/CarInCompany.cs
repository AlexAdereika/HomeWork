using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi_company
{
    class CarInCompany
    {
        public string CarModel { get; set; }
        public int CarCost { get; set; }
        public int MaxSpeed { get; set; }

    }
    public enum Fuel
    {
        Gasoline,
        Diesel,
        Electric,
        Hybrid
    }

   


}
