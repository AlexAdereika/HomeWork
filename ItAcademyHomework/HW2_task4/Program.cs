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

            Console.WriteLine("Please, choose operation: + - * / ^ !");
            Console.WriteLine("If you want to sum several numbers, enter 'Sum'");
            Console.WriteLine("Enter 'End' for exit");
            string operation = Convert.ToString(Console.ReadLine());

            bool Input = (operation == "+") || (operation == "-") || (operation == "*") ||
                (operation == "/") || (operation == "^") || (operation == "!") || (operation == "Sum") | (operation == "End");
            if (Input == true)
            {
                if (operation == "End") //выход из рекурсии
                {
                    return;
                }
                else if (operation == "!")
                {
                    x = EnterNumber();
                    var result = Factorial(x);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(Factorial(x));
                    Console.ForegroundColor = ConsoleColor.White;
                    ChooseOperation();
                }
                else if (operation == "Sum")
                {
                    Console.WriteLine("How many number do you want to sum?");
                    int Elements = Convert.ToInt32(Console.ReadLine());
                    double[] SumArray = new double[Elements];
                    for (int i = 0; i < SumArray.Length; i++)
                    { //Сразу было так:
                        //Console.WriteLine($"Enter {i + 1} number:");
                        //SumArray[i] = Convert.ToDouble(Console.ReadLine());
                        //Потом добавил проверку на ввод числа и заполняю массив через метод:
                        SumArray[i] = EnterNumber();
                    }
                    double SumNumbersOfArray = 0;
                    for (int i = 0; i < SumArray.Length; i++)
                    {
                        SumNumbersOfArray += SumArray[i];

                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Sum of all numbers = {SumNumbersOfArray}");
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
                    ;
                }


            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect operation!");
                Console.ForegroundColor = ConsoleColor.White;
                ChooseOperation();
            }

            static double EnterNumber() //ввод числа
            {
                double userInput = 0;
                Console.WriteLine("Enter number:");
                while (!Double.TryParse(Console.ReadLine(), out userInput))
                {
                    Console.WriteLine("This is not a number, repeat the input");

                }
                double x = userInput;
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

