using System;

namespace Day_9_12_Classes_Abstract_Classes_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueLoop = true;
            var point = new Point();

            do
            {
                do
                {
                    Console.Write("Enter an X coordinate: ");
                    string userInput = Console.ReadLine();
                    if (double.TryParse(userInput, out double num))
                    {
                        point.xCoordinate = num;
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Think yer a smart guy, huh? Try again punk!");
                    }
                } while (true);

                do
                {
                    Console.Write("Enter a Y coordinate: ");
                    string userInput = Console.ReadLine();
                    if (double.TryParse(userInput, out double num))
                    {
                        point.yCoordinate = num;
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Think yer a smart guy, huh? Try again punk!");
                    }
                } while (true);

                Console.WriteLine($"You have created a point object ({point.xCoordinate}, {point.yCoordinate}).");

                do
                {


                    Console.Write("Would you like to continue? (y/n) ");
                    string userInput = Console.ReadLine();
                    if (userInput == "y" || userInput == "Y")
                    {
                        Console.Clear();
                        break;
                    }
                    else if (userInput == "n" || userInput == "N")
                    {
                        continueLoop = false;
                        Console.WriteLine("Goodbye!");
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You really don't like following directions do you?");
                    }
                } while (true);
            } while (continueLoop);
        }
    }

    public class Point
    {
        public double xCoordinate { get; set; }

        public double yCoordinate { get; set; }

    }
}
