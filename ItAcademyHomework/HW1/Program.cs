using System;

namespace FirstHomeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Сумма товаров не целочисленное значение, максимальная точность не требуется

            double price1 = 2.3;

            double price2 = 3.0;

            double price3 = 4.45;

            Console.WriteLine($"The cost of a package of milk: {price1} BYN");
            Console.WriteLine($"The cost of a chocolate bar: {price2} BYN");
            Console.WriteLine($"The cost of coffe: {price3} BYN");



            //2.

            int a = 13;
            int b = a + 3;
            int c = b + a;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);



            //3.

            Console.WriteLine("Enter the first integer");
            string userInput1 = Console.ReadLine();
            double x = Convert.ToDouble(userInput1);

            Console.WriteLine("Enter the second integer");
            string userInput2 = Console.ReadLine();
            double y = Convert.ToDouble(userInput2);

            Console.WriteLine("Enter the third integer");
            string userInput3 = Console.ReadLine();
            int z = Convert.ToInt32(userInput2);

            Console.WriteLine("result of dividing the first by the second");
            Console.WriteLine(x / y);

            Console.WriteLine("result of multiplication");
            Console.WriteLine((x*y)*z);

        }
    }
}
