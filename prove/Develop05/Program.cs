using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        string choice = "";

        while (choice != "0")
        {
            Console.WriteLine();
            Console.WriteLine("Please choose one of the following options:");
            Console.WriteLine("1: Create a new Goal");
            Console.WriteLine("2: List Goals");
            Console.WriteLine("3: Save Goals");
            Console.WriteLine("4: Load Goals");
            Console.WriteLine("5: Record Completion of Goals");
            Console.WriteLine("0: Quit Program");
            Console.Write("Which option would you like? ");

            choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    goalManager.CreateGoal();
                    break;
                case "2":
                    goalManager.ListGoals();
                    break;
                case "3":
                    goalManager.SaveGoals();
                    break;
                case "4":
                    goalManager.LoadGoals();
                    break;
                case "5":
                    goalManager.RecordEvent();
                    break;
                case "0":
                    break;
                default:
                    Console.WriteLine("Please enter a number from 0 to 5.");
                    break;
            }
        }
    }
}