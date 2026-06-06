using System.Text.RegularExpressions;

namespace Homework1.Task2
{
    public class SecondTask
    {
        public void Run()
        {
            Console.WriteLine("Please enter your name :");
            string name = Console.ReadLine().Trim();
            Console.WriteLine("Please enter your age :");
            string ageStr = Console.ReadLine().Trim();

            if (!Regex.IsMatch(ageStr, @"^\d+$"))
            {
                Console.WriteLine("Invalid input. Please enter numbers only.");
                return;
            }

            int age = int.Parse(ageStr);

            Console.WriteLine($"Hello, {name}.You are {age} years old.");
        }
    }
}
