using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> ListOfNumbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int EnteredNumberInt = 1;
        while (EnteredNumberInt != 0)
        {
            Console.Write("Enter a number :");
            string EnteredNumberString = Console.ReadLine();
            EnteredNumberInt = int.Parse(EnteredNumberString);
            ListOfNumbers.Add(EnteredNumberInt);
        }
        int SumOfListInt = ListOfNumbers.Sum();
        int AmountInListInt = ListOfNumbers.Count;
        int AvgOfListInt = SumOfListInt / AmountInListInt;
        int LargestOfListInt = ListOfNumbers.Max();
        Console.WriteLine($"The sum of the list is {SumOfListInt}");
        Console.WriteLine($"The average of the list is {AvgOfListInt}");
        Console.WriteLine($"The largest number of the list is {LargestOfListInt}");

    }
}