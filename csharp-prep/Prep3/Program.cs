using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();

        int guessNumber = 0;
        int magicNumber = randomGenerator.Next(1, 20);
        string answer = "";

        Console.WriteLine("Guess a number between 1 and 20");

        while (guessNumber != magicNumber)
        {
            Console.WriteLine("What is your guess?");
            answer = Console.ReadLine();
            guessNumber = int.Parse(answer);

            if (guessNumber > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guessNumber < magicNumber)
            {
                Console.WriteLine("Higher");
            }
        }

        Console.WriteLine("Correct! Congratulations");
    }
}