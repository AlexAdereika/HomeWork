using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi_company
{
    class TaxiPark
    {
        public List<CarInCompany> Cars { get; private set; }

        public TaxiPark()
        {
            Cars = new List<CarInCompany>();

        }

        public TaxiPark(IEnumerable<CarInCompany> cars)
        {
            Cars = new List<CarInCompany>(cars);
        }

        public int CalculateCost()
        {
            return Cars.Select(c => c.CarCost).Sum();
        }

        public IEnumerable<CarInCompany> SortByConsumption()
        {
            Cars.Sort(new ConsumptionCarInCompanyComparer());

            return Cars;

        }

        class ConsumptionCarInCompanyComparer : IComparer<CarInCompany>
        {
            public int Compare(CarInCompany x, CarInCompany y)
            {

                var X = (x as ConsumptionCar)?.FuelConsumption;
                if (!X.HasValue)
                    return 1;

                var Y = (y as ConsumptionCar)?.FuelConsumption;
                if (!Y.HasValue)
                    return 1;

                return X.Value - Y.Value;
            }

        }
        public static void Print(IEnumerable<CarInCompany> Cars)
        {
            foreach (var Car in Cars)
            {
                Console.WriteLine(Car.ToString());

            }
            Console.WriteLine();
        }
        public static void Print2(IEnumerable<CarInCompany> Cars)
        {
            foreach (var Car in Cars)
            {

                Console.WriteLine($"{Car.CarModel} \t {Car.MaxSpeed} km/h");

            }

        }

        public IEnumerable<CarInCompany> GetBySpeed(int minSpeed, int maxSpeed)
        {
            return Cars.Where(c => minSpeed <= c.MaxSpeed && c.MaxSpeed <= maxSpeed);

        }

    }

}
