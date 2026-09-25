using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Program!");
        Console.Write("What is your name? :");
        string NameString = Console.ReadLine();
        Console.Write("What is your favorite number? :");
        string FaveNumString = Console.ReadLine();
        int FaveNumInt = int.Parse(FaveNumString);
        Console.Write("What is your birth year? :");
        string BirthYearString = Console.ReadLine();
        int BirthYearInt = int.Parse(BirthYearString);
    }
}