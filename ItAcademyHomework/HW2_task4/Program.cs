using System;

namespace HW2_task4
{
    class Program
    {

        string operation;
        static void Main(string[] args)


        {
            Hello();
            ChooseOperation();

        }


        //методы

        static void Hello() //приветствие
        {
            Console.WriteLine("Hello, Calculator User!");
        }



        static void ChooseOperation() // меню выбора операции и сама операция
        {
            double x = 0;
            double y = 0;

            Console.WriteLine("Please, choose operation: +, -, *, /, ^, ! or enter 'End' for exit ");
            string operation = Convert.ToString(Console.ReadLine());
            if (operation == "End") //выход из рекурсии
            {
                return;
            }
            if (operation == "!")
            {
                x = EnterNumber();
                var result = Factorial(x);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(Factorial(x));
                Console.ForegroundColor = ConsoleColor.White;
                ChooseOperation();
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
                ChooseOperation();
            }

            static double EnterNumber() //ввод числа
            {
                Console.WriteLine("Enter number:");
                var userInput = Console.ReadLine();
                var x = Convert.ToDouble(userInput);
                return x;
            }

            static double Factorial(double x) // подсчёт факториала 
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


}

