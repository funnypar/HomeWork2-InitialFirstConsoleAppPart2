using System.Text.RegularExpressions;

namespace Homework1.Task3
{
    public class ThirdTask
    {
        public void Run()
        {
            Random random = new Random();
            int answer = random.Next(1, 11); 
            bool guessedCorrectly = false;

            for (int attempt = 1; attempt <= 5; attempt++)
            {
                int userInputInt = -1;

                while (true)
                {
                    Console.WriteLine($"Attempt {attempt}/5 — Guess a number between 1 and 10:");
                    string userInput = Console.ReadLine()?.Trim() ?? "";

                    if (!Regex.IsMatch(userInput, @"^\d+$"))
                    {
                        Console.WriteLine("Invalid input. Please enter numbers only.");
                        continue; 
                    }

                    userInputInt = int.Parse(userInput);

                    if (userInputInt < 1 || userInputInt > 10)
                    {
                        Console.WriteLine("The number must be between 1 and 10.");
                        continue; 
                    }

                    break; 
                }

                if (userInputInt == answer)
                {
                    Console.WriteLine($"Congratulations! You guessed it in {attempt} attempt(s)!");
                    guessedCorrectly = true;
                    break; 
                }
                else
                {
                    Console.WriteLine(userInputInt < answer ? "Too low! Try higher." : "Too high! Try lower.");
                }
            }

            if (!guessedCorrectly)
            {
                Console.WriteLine($"Out of attempts! The correct answer was: {answer}");
            }
        }
    }
}