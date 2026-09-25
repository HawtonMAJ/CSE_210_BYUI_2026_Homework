using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> ListOfNumbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int EnteredNumberInt = 1;
        // Has to be set to something, will be overwritten before being used
        while (EnteredNumberInt != 0)
        {
            Console.Write("Enter a number :");
            string EnteredNumberString = Console.ReadLine();
            EnteredNumberInt = int.Parse(EnteredNumberString);
            if (EnteredNumberInt != 0)
            {
                ListOfNumbers.Add(EnteredNumberInt);
            }
        }
        float SumOfListFloat = ListOfNumbers.Sum();
        int AmountInListInt = ListOfNumbers.Count;
        float AvgOfListInt = SumOfListFloat / AmountInListInt;
        int LargestOfListInt = ListOfNumbers.Max();
        Console.WriteLine($"The sum of the list is {SumOfListFloat}");
        Console.WriteLine($"The average of the list is {AvgOfListInt}");
        Console.WriteLine($"The largest number of the list is {LargestOfListInt}");

    }
}