using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";

        while (playAgain.ToLower() == "yes")
        {
            // Ask the user for the magic number
            Console.Write("What is the magic number? ");
            int magicNumber = int.Parse(Console.ReadLine());

            int guess = -1;   // Start the loop
            int guessCount = 0;

            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;

                if (guess > magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You guessed it in {guessCount} tries!");
                }
            }

            Console.Write("Do you want to play again? ");
            playAgain = Console.ReadLine();
        }

        Console.WriteLine("Thanks for Playing!");
    }
}
