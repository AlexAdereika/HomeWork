using System;

namespace Taxi_company
{
    class Program
    {
        static void Main(string[] args)
        {
            var Car1 = new GasolineCar("Toyota hilux", 45700, 153, 15);
            var Car2 = new GasolineCar("KIA Rio", 18100, 170, 8);
            var Car3 = new GasolineCar("LADA Vesta", 13550, 162, 7);

            var Car4 = new DieselCar("Renault Duster", 24050, 165, 10);
            var Car5 = new DieselCar("Audi A4", 36000, 210, 5);
            var Car6 = new DieselCar("Mazda CX-5", 19500, 170, 6);

            var Car7 = new ElectricCar("Tesla Model X", 171500, 250);
            var Car8 = new ElectricCar("Nissan Leaf", 22350, 195);
            var Car9 = new ElectricCar("Chevrolet Volt", 24300, 166);

            var Car10 = new HybridCar("Ford Fusion", 37900, 205);
            var Car11 = new HybridCar("Toyota Prius", 17450, 160);



            Console.WriteLine($"Машина: {Car2.CarModel} \t Топливо: {Car2.FuelType} \t Расход: {Car2.FuelConsumption}\n");
            Console.WriteLine($"Машина: {Car5.CarModel} \t Топливо: {Car5.FuelType} \t Расход: {Car5.FuelConsumption}\n");
            Console.WriteLine($"Машина: {Car7.CarModel} \t Топливо: {Car7.FuelType} \t Расход: {Car7.FuelConsumption}\n");
            Console.WriteLine($"Машина: {Car10.CarModel} \t Топливо: {Car10.FuelType} \t Расход: {Car10.FuelConsumption}\n");


        }
    }
}
