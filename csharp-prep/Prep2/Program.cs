using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string percent = Console.ReadLine();
        int grade = int.Parse(percent);
        int secondDigit = grade % 10;
        string modifier = "";
        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade < 90 && grade >= 80)
        {
            letter = "B";
        }
        else if (grade < 80 && grade >= 70)
        {
            letter = "C";
        }
        else if (grade < 70 && grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }


        if (secondDigit >= 7 && grade < 97 && grade > 59)
        {
            modifier = "+";
        }
        else if (secondDigit <= 3 && grade > 59)
        {
            modifier = "-";
        }
        else
        {
            modifier = "";
        }
        Console.WriteLine($"You have a {modifier}{letter}");



        if (grade >= 70)
        {
            Console.WriteLine("You have passed the class! Congratulations!");
        }
        else
        {
            Console.WriteLine("You have failed the class. You must retake it.");
        }
    }
}