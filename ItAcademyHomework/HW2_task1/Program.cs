using System;

namespace HW2_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var counter = 0;
            double sum = 0;
            double userInput;
            do
            {
                userInput = Convert.ToDouble(Console.ReadLine());
                counter++;
                sum += userInput;
            }
            while (userInput != 0);
            Console.WriteLine($"Number of numbers:{counter}");
            Console.WriteLine($"The sum of numbers:{sum}");
            Console.WriteLine($"The average numbers:{sum/counter}");


        }

    }
}

