namespace Homework1.Task4
{
    public class FourthTask
    {
        public void Run()
        {
            string answer = "CSharp";
            bool isOk = true;
            int counter = 1;

            while (isOk)
            {
                Console.WriteLine("Please guess the word: ");
                string userInput = Console.ReadLine().Trim();

                if (answer.ToLower() != userInput.ToLower())
                {
                    Console.WriteLine("That was wrong, guess again.\n");
                    counter++;
                    continue;
                }
                
                isOk = false;
            }
            Console.WriteLine("Congratulations! You guessed the word correctly.");
            Console.WriteLine($"You tried for {counter} times.");
        }
    }
}
