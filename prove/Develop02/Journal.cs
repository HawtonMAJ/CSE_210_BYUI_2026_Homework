using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
public class Journal
{
    public List<Entry> _journal;
    public List<Entry> listOfEntries = new List<Entry>();
    public void DisplayJournalMenu()
    {
        int choice;
        do
        {
            Console.WriteLine("1: New Entry");
            Console.WriteLine("2: Display Journal");
            Console.WriteLine("3: Save Journal");
            Console.WriteLine("4: Load Journal");
            Console.WriteLine("5: Exit Journal");
            Console.Write("Please enter the option of your choosing: ");
            choice = ParseUserResponse();
            if (choice == 1)
            {
                listOfEntries.Add(Entry.WriteAnEntry());
            }
            else if (choice == 2)
            {
                foreach(object Entry in listOfEntries)
                {
                    Console.WriteLine(Entry);
                }
            }
            else if (choice == 3)
            {
                Console.Write("Please enter the filename in full :");
                string filename = Console.ReadLine();
                WriteEntriesToCSV(listOfEntries, filename);
            }
            else if (choice == 4)
            {
                
            }
            else if (choice == 5)
            {
            Menu menu = new Menu();
            menu.ChooseWhereToGo();
            }
        } while (choice != 5);
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
    public static void WriteEntriesToCSV<T>(IEnumerable<T> entries, string filename)
    {
        using(StreamWriter outputfile = new StreamWriter(filename))
        {
            foreach (object Entry in entries)
            {
                outputfile.Write(Entry);
            }
        }
    }

}