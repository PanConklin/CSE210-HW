using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job("Sofware engineer", "Microsoft", 2019, 2022);
        Job job2 = new Job("Manger", "Apple", 2022, 2023);

        job1.Display();
        job2.Display();
    }
}