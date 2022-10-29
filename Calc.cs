using System;

namespace Calc2
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Clear();
                double firstValue, secondValue;
                string action;

                Console.WriteLine("Enter number one");
                firstValue = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter number two");
                secondValue = double.Parse(Console.ReadLine());

                Console.WriteLine("Choose an operation: '+' '-' '*' '/' '%' ");
                action = Console.ReadLine();

                if (action == "+")
                {
                    Console.WriteLine(firstValue + secondValue);
                }
                else if (action == "-")
                {
                    Console.WriteLine(firstValue - secondValue);
                }
                else if (action == "*")
                {
                    Console.WriteLine(firstValue * secondValue);
                }
                else if (action == "/")
                {
                    if (secondValue == 0)
                        Console.WriteLine(0);
                    else
                        Console.WriteLine(firstValue / secondValue);
                }
                else if (action == "%")
                {
                    Console.WriteLine(firstValue % secondValue);
                }
                else
                {
                    Console.WriteLine("ERRORR");
                }
                Console.ReadLine();
            }
        }

    }
}
