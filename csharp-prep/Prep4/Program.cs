using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        var numbers = new List<int>();
        int number = -1;

        while (number != 0)
        {
            Console.Write("Enter number: ");
            string providedNumber = Console.ReadLine();
            number = int.Parse(providedNumber);

            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        int sum = numbers.Sum();
        Console.Write($"The sum is: {sum}");
        float average = sum / numbers.Count;
        Console.Write($"The average is: {average}");
        int largest = numbers.Max();
        Console.Write($"The largest number is: {largest}");
    }
}