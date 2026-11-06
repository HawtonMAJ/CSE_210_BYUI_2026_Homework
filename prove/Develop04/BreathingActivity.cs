using System;
public class BreathingActivty : Activity
{
    public BreathingActivty(string description):base(description)
    {
        
    }
    public void BreathCycle()
    {
        Console.Clear();
        ShowPrologue("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        SetDuration();
        Console.WriteLine("Get ready to breathe");
        Spinner();
        int totalSeconds = _duration;
        DateTime endTime = DateTime.Now.AddSeconds(totalSeconds);
        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in... ");
            for (int i = 5; i > 0; i--)
            {
                Console.Write($"{i}");
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine();
            if (DateTime.Now >= endTime)
            {
                break;
            }
            Console.Write("Breathe out... ");
            for (int i = 5; i > 0; i--)
            {
                Console.Write($"{i}");
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine();
        }
        ShowEpilogue();
    }
}