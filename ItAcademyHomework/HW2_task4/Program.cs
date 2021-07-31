using System;

namespace HW2_task4
{
    class Program
    {
        static void Main(string[] args)

        {
            double x = 0;
            double y = 0;


            Hello();
            var operation = ChooseOperation();
            if (operation == "End")
            {
                return;
            }
            else
            {


                if (operation == "!")
                {
                    x = EnterNumber();
                    var result = Factorial(x);
                    Console.WriteLine(Factorial(x));
                }
                else
                {
                    x = EnterNumber();
                    y = EnterNumber();

                    Console.ForegroundColor = ConsoleColor.Green;
                    switch (operation)
                    {
                        case "+":
                            Console.WriteLine($"{x}+{y}={x + y}");
                            break;
                        case "-":
                            Console.WriteLine($"{x}-{y}={x - y}");
                            break;
                        case "*":
                            Console.WriteLine($"{x}*{y}={x * y}");
                            break;
                        case "/":
                            Console.WriteLine($"{x}/{y}={x / y}");
                            break;
                        case "^":
                            Console.WriteLine($"{x}^{y}={Math.Pow(x, y)}");
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Incorrect operation!");
                            break;
                    }

                    Console.ForegroundColor = ConsoleColor.White;
                    
                }
                ChooseOperation();
            }


        }
        static void Hello()
        {
            Console.WriteLine("Hello, Calculator User!");
        }
        static string ChooseOperation()
        {
            Console.WriteLine("Please, choose operation: +, -, *, /, ^, ! or enter 'End' for exit ");
            return Console.ReadLine();
         }
        static double EnterNumber()
        {
            Console.WriteLine("Enter number:");
            var userInput = Console.ReadLine();
            var x = Convert.ToDouble(userInput);
            return x;
        }
        static double Factorial(double x)
        {
            if (x < 0)
            {
                return 0;
            }
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1);
            }
        }

    }
}
