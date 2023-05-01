using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string finalName = PromptUserName();
        int finalNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(finalNumber);
        DisplayResult(finalName, squaredNumber);

    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.Write($"{name}, the square of your number is {square}");
    }

}