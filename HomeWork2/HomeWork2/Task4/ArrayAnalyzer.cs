using System.Text.RegularExpressions;

namespace HomeWork2.Task4
{
    public class ArrayAnalyzer
    {
        public void Run()
        {
            int max = 0;
            double average = 0.0;

            Console.WriteLine("Please Enter the length of array : ");

            var arraySize = Console.ReadLine().Trim();
            (bool resultSizeBool, int size) = ValidateArraySize(arraySize);

            while (!resultSizeBool || size == 0)
            {
                Console.WriteLine("Please Enter valid number : ");
                arraySize = Console.ReadLine().Trim();
                (resultSizeBool, size) = ValidateArraySize(arraySize);
            }

            Console.WriteLine("\nPlease Enter array of numbers to analyze (like [1,2,3,...]: ");

            var userInput = Console.ReadLine().Trim();
            (bool resultBool, int[] numbers) = ValidateUserInput(userInput, size);

            while (!resultBool || numbers.Length == 0)
            {
                Console.WriteLine("Please Enter valid array : ");
                userInput = Console.ReadLine().Trim();
                (resultBool, numbers) = ValidateUserInput(userInput, size);
            }

            AnalyzeArray(numbers, ref max, out average);

        }
        public void AnalyzeArray(int[] numbers, ref int max, out double average)
        {
            max = numbers.Max();
            average = numbers.Average();

            Console.WriteLine($"\nThe max is : {max} and the average is : {average}");
        }
        public (bool, int) ValidateArraySize(string input)
        {
            bool resultBool = false;
            int arraySize = 0;

            if (int.TryParse(input, out int inputInt))
            {
                
                if (inputInt <= 0)
                {
                    Console.WriteLine("Please enter valid size.");
                }
                resultBool = true;
                arraySize = inputInt;
            }

            return (resultBool, inputInt);
        }
        public (bool, int[]) ValidateUserInput(string input, int size)
        {
            var isMatch = Regex.IsMatch(input, @"^\[\d+(,\d+)*\]$");

            if (!isMatch)
            {
                return (false, [0]);
            }

            string cleanedInput = input.Trim('[', ']');
            string[] parts = cleanedInput.Split(',');

            if (parts.Length != size)
            {
                Console.WriteLine("\nThe length of the array is not equal to the size.");
                return (false, new int[0]);
            }

            int[] numbers = new int[size];

            for (int i = 0; i < parts.Length; i++)
            {
                if (int.TryParse(parts[i], out int number))
                {
                    numbers[i] = number;
                }
                else
                {
                    return (false, [0]);
                }
            }

            return (true, numbers);
        }
    }
}
