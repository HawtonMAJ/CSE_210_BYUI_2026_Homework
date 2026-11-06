using System;

public class Activity
{
    protected int _duration;
    protected string _description;

    public Activity(string description)
    {
        _description = description;
    }
    public void SetDuration()
    {
        Console.Write("How long (in seconds) would you like to do this mindfulness activity? :");
        string DurationString = Console.ReadLine();
        int Duration = int.Parse(DurationString);
        _duration = Duration;
    }

    public void Spinner()
    {
        char[] frames = { '|', '/', '-', '\\' };

        for (int i = 0; i < frames.Length * 2; i++)
        {
            Console.Write(frames[i % frames.Length]);
            Thread.Sleep(100);
            Console.Write('\b');
        }
    }

    public void Spinner(int seconds, DateTime endTime)
    {
        DateTime spinEndTime = DateTime.Now.AddSeconds(seconds);
        if (spinEndTime > endTime)
        {
            spinEndTime = endTime;
        }

        while (DateTime.Now < spinEndTime)
        {
            Spinner();
        }
    }

    public void ShowPrologue(string Prologue)
    {
        Console.WriteLine(Prologue);
    }

    public void ShowEpilogue()
    {
        Console.Write($"You have completed another {_duration} seconds of a mindfulness activity (Press enter to continue).");
        Console.ReadLine();
    }
}