using System;

namespace HW2_task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the height of the pyramid:");
            int height = Convert.ToInt32(Console.ReadLine());

            for (int x = 0; x < height; x++)
            {
                for (int i = height; i > x; i--)
                {
                    Console.Write(" ");
                }
                for (int y = 0; y <= x; y++)
                {
                    Console.Write("^");
                }
                for (int y = 1; y <= x; y++)
                {
                    Console.Write("^");
                }

                Console.WriteLine();

                
            }
            
        }
    }
}
