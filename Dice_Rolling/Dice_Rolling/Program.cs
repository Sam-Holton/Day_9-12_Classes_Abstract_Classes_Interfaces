  using System;

namespace Dice_Rolling
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                RollTheBones(WhatSidedDice());
            } while (ContinueRolling());
            
        }

        static int WhatSidedDice()
        {
            Console.Write("How many sides are there on the dice you wanna roll? ");
            int diceSides = int.Parse(Console.ReadLine());
            return diceSides;
        }

        static void RollTheBones(int diceSides)
        {
            var roll = new Random();
            Console.WriteLine("Aight, hit enter to roll the dice.");
            Console.ReadLine();
            Console.WriteLine($"First Die: {roll.Next(1, diceSides + 1)}");
            Console.WriteLine($"Second Die: {roll.Next(1, diceSides + 1)}");
        }

        static bool ContinueRolling()
        {
            do
            {
                Console.Write("Would you like to continue (Y/N)? ");
                ConsoleKey inputKey = Console.ReadKey().Key;

                if (inputKey == ConsoleKey.Y)
                {
                    Console.Clear();
                    return true;
                }
                else if (inputKey == ConsoleKey.N)
                {
                    return false;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input. Please try again.");
                }
            } while (true);
        }
    }
}
