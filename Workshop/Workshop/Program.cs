using Microsoft.Win32.SafeHandles;
using System;

namespace Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            bool realInteger = false;
            int userNumberGuess = 0;
            int randomNumber;
            string playAgain;
            bool playAgainBool;

            do
            {
                Console.Write("Welcome to my guessing game! Guess a number between 1 and 20: ");
                string userInput = Console.ReadLine();
                userNumberGuess = int.Parse(userInput);
                Console.WriteLine();

                realInteger = int.TryParse(userInput, out userNumberGuess);

                Random rand = new Random();
                randomNumber = rand.Next(1, 21);

                if (userNumberGuess > randomNumber)
                {
                    Console.WriteLine($"Your guess was {userNumberGuess} and the correct number was {randomNumber}");
                    Console.WriteLine("Your guess is higher than the correct number");
                    Console.WriteLine();
                    Console.Write("Would you like to play again? (Y/N)");
                    playAgain = Console.ReadLine();
                    if (playAgain.ToLower() == "y")
                    {
                        playAgainBool = true;
                        Console.WriteLine();
                        Console.WriteLine();
                    }
                    else playAgainBool = false;
                }
                else if (userNumberGuess < randomNumber)
                {
                    Console.WriteLine($"Your guess was {userNumberGuess} and the correct number was {randomNumber}");
                    Console.WriteLine("Your guess is lower than the correct number");
                    Console.WriteLine();
                    Console.Write("Would you like to play again? (Y/N)");
                    playAgain = Console.ReadLine();
                    if (playAgain.ToLower() == "y")
                    {
                        playAgainBool = true;
                        Console.WriteLine();
                        Console.WriteLine();
                    }
                    else playAgainBool = false;
                }
                else
                {
                    Console.WriteLine($"Your guess was {userNumberGuess} and the correct number was {randomNumber}");
                    Console.WriteLine("Woot Woot! You got it! Now go play the Lottery!");
                    Console.WriteLine();
                    Console.Write("Would you like to play again? (Y/N)");
                    playAgain = Console.ReadLine();
                    if (playAgain.ToLower() == "y")
                    {
                        playAgainBool = true;
                        Console.WriteLine();
                        Console.WriteLine();
                    }
                    else playAgainBool = false;
                }
            } while (playAgainBool == true);

            Console.WriteLine();
            Console.WriteLine("Thanks for playing!");

        }
    }
}
