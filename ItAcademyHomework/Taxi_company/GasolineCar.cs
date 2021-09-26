using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi_company
{
    class GasolineCar : ConsumptionCar
    {

        public GasolineCar(string Model, int Cost, int Speed, int Consumption) : base(Model, Cost, Speed, Consumption, Fuel.Gasoline)
        {
        }
    }
}
