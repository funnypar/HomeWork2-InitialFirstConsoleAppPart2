using System.Text.RegularExpressions;

namespace HomeWork2.Task3
{
    public class Statistics
    {
        public void Run()
        {
            Console.WriteLine("Please Enter 3 numbers to analyze (like 1,2,3): ");

            var userInput = Console.ReadLine().Trim();
            (bool resultBool, string[] numbers) = ValidateUserInput(userInput);

            while (!resultBool){
                Console.WriteLine("Please enter numbers right (like 1,2,3): ");
                userInput = Console.ReadLine().Trim();
                (resultBool, numbers) = ValidateUserInput(userInput);
            }

            int num1 = int.Parse(numbers[0]);
            int num2 = int.Parse(numbers[1]);
            int num3 = int.Parse(numbers[2]);


            Console.WriteLine($@"
Numbers at initialize step:
                                
Number1 : {num1}
Number2 : {num2}
Number3 : {num3}
");

            AnalyzeNumbers(num1, ref num2, out num3);

            Console.WriteLine($@"
Numbers after calculations:
                                
Number1 : {num1}
Number2 : {num2}
Number3 : {num3}
");

        }
        public void AnalyzeNumbers(int num1, ref int num2, out int num3)
        {
            num3 = num1 + num2;
            num2 *= num2;
            Console.WriteLine($"First number ==> {num1}");
        }

        public (bool,string[]) ValidateUserInput(string input)
        {
            bool resultBool = false;
            string[] numbers = [];

            var isMatch =  Regex.IsMatch(input, @"^\d+(,\d+)*$");
            if (isMatch) {
                var numbersSpilted = input.Split(",");
                if (numbersSpilted.Length > 3) { 
                    Console.WriteLine("Please Enter Only 3 numbers.");
                }
                resultBool = true;
                numbers = numbersSpilted;
            }

            return (resultBool, numbers);
        }
    }
}
