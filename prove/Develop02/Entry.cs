using System;

public class Entry
{
    public string _currentDate;
    public string _randomPrompt;
    public string _userEntry;
    public static Entry WriteAnEntry()
    {
        Entry entry1 = new Entry();
        DateTime theCurrentTime = DateTime.Now;
        entry1._currentDate = theCurrentTime.ToShortDateString();
        Console.WriteLine(entry1._currentDate);
        entry1._randomPrompt = "this is a random prompt";
        Console.Write($"{entry1._randomPrompt} \nWrite the entry here please: ");
        entry1._userEntry = Console.ReadLine();
        return entry1;
    }
}