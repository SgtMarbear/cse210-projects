using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Console.Write("What is your guess? ");
        string guessWord = Console.ReadLine();
        int guess = int.Parse(guessWord);
        Random randomGenerator = new Random();
        int magicNum = randomGenerator.Next(1, 100);
        do
        {
            if (magicNum > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNum < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
            Console.Write("What is your guess? ");
            guessWord = Console.ReadLine();
            guess = int.Parse(guessWord);

        } while (guess != magicNum);
        Console.WriteLine("You guessed it!");

    }
}