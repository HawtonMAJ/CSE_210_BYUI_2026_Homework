using System;
using System.Xml.Serialization;

public class Menu
{
    
    public void ChooseWhereToGo()
    {
        Console.WriteLine("1: New Journal");
        Console.WriteLine("2: Load Journal");
        Console.WriteLine("3: Exit Program");
        Console.Write("Please enter the option of your choosing: ");
        int choice = ParseUserResponse();
        if (choice == 1)
        {
            Journal journal = new Journal();
            journal.DisplayJournalMenu();
        }
        else if (choice == 2)
        {
            Console.Write("Please enter the filename in full :");
            string filename = Console.ReadLine();
            Journal journal = new Journal();
            journal.DisplayJournalMenu();
        }
        else if (choice == 3)
        {
            Environment.Exit(0);
        }           
    }
        public int ParseUserResponse()
    {
        string userOption = Console.ReadLine();
        int choice;
        while(! int.TryParse(userOption , out choice))
        {
            userOption = Console.ReadLine();
        }
        return choice;
    }
}