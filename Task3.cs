using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace namespace_lab
{
    namespace GuessNumberGame
    {
        public class Task3
        {
            public static void num3()
            {
                Console.WriteLine("Number game");

                Random random = new Random();
                int minNumber = 1;
                int maxNumber = 50;
                int mystery = random.Next(minNumber, maxNumber + 1);

                Console.WriteLine($"Maybe number between {minNumber} and {maxNumber},  guess what it is?");

                int guess;
                int numberOfGuesses = 0;

                do
                {
                    Console.Write("Enter your guess: ");
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        continue;
                    }

                    numberOfGuesses++;

                    if (guess < mystery)
                    {
                        Console.WriteLine("Too low. Try again.");
                    }
                    else if (guess > mystery)
                    {
                        Console.WriteLine("Too high. Try again.");
                    }
                    else
                    {
                        Console.WriteLine($"Congratulations! You guessed the number in {numberOfGuesses} guesses.");
                    }

                } while (guess != mystery);



            }
        }
    }
}
