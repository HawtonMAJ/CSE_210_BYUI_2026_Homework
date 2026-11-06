using System;
public class ListingActivty : Activity
{
    private List<string> _prompts = new List<string> {"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};

    public ListingActivty(string description):base(description)
    {
        
    }
    public void ListingCycle()
    {
        Console.Clear();
        ShowPrologue("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        SetDuration();
        Console.WriteLine($"\n--- {_prompts[new Random().Next(_prompts.Count)]} ---");
        Console.WriteLine("List items related to this prompt, pressing Enter after each one.");

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        int itemCount = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
            {
                itemCount++;
            }
        }

        Console.WriteLine($"\nTime is up! You listed {itemCount} items. Enter one final item to finish:");
        Console.Write("> ");
        Console.ReadLine();
        ShowEpilogue();
    }
}