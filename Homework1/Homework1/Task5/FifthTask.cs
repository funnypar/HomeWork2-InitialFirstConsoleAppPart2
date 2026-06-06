using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Homework1.Task5
{
    public class FifthTask
    {
        public void Run()
        {
            bool isOk = true;
            int userInputInt = 1;
            int sum = 0;

            while (isOk)
            {
                Console.WriteLine("Please enter a positive number: ");
                string userInput = Console.ReadLine().Trim();

                if (!Regex.IsMatch(userInput, @"^\d+$"))
                {
                    Console.WriteLine("Invalid input. Please enter numbers only.\n");
                    continue;
                }

                userInputInt = int.Parse(userInput);

                if (userInputInt < 1)
                {
                    Console.WriteLine("Invalid input. Please enter positive numbers only.\n");
                    continue;
                }
                isOk = false;
            }

            for(int num = 1; num <= userInputInt; num++)
            {
                if (num % 2 != 0) {
                    sum += num;
                }
            }

            Console.WriteLine($"\nThe sum is {sum}");
        }
    }
}
