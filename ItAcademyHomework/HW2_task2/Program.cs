using System;

namespace HW2_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first value:");
            int firstValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second value:");
            int secondValue = Convert.ToInt32(Console.ReadLine());

            int sum =0;

            while (firstValue <= secondValue)
            {
                
                if (firstValue%2 !=0)
                {
                    sum += firstValue;
                }
                firstValue++;
            }
            Console.WriteLine($"Sum of odd numbers:{sum}");
        }
    }
}
