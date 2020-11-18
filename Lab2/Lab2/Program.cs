using System;
using System.Dynamic;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isLooping = true;
            do
            {
                Console.WriteLine("Welcome to the Grand Circus Room Detail Generator!");
                Console.WriteLine();

                Console.Write("Enter Length in Inches: ");
                double length = double.Parse(Console.ReadLine());

                Console.Write("Enter Width in Inches: ");
                double width = double.Parse(Console.ReadLine());

                Console.WriteLine($"Area: {width * length}");
                Console.WriteLine($"Perimeter: {width * 2 + length * 2}");

                do
                {
                    Console.Write("Continue (y/n) ");
                    string userContinueDecision = Console.ReadLine();
                    if (userContinueDecision == "y")
                    {
                        Console.Clear();
                        break;
                    }
                    else if (userContinueDecision == "n")
                    {
                        isLooping = false;
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Please keep response to y or n");
                    }
                } while(true);
            } while(isLooping);
        }
    }
}
