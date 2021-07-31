using System;

namespace HW1_task3
{
    class Program
    {
        static void Main(string[] args)
        {
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
            Console.WriteLine((x * y) * z);
        }
    }
}
