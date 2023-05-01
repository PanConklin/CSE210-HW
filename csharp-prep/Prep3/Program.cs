using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, 101);

        //Console.Write("What is the magic number?");
        //int number = int.Parse(Console.ReadLine());
        int guess = 0;

        while (guess != number)
        {
            Console.WriteLine("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess < number)
            {
                Console.Write("Higher");
                Console.WriteLine("");
            }
            else if (guess > number)
            {
                Console.Write("Lower");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }

    }
}