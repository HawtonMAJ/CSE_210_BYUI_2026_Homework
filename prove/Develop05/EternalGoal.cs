using System;
public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override void Display()
    {
        Console.WriteLine($"[ ] {_title}: {_description}");
    }

    public override int RecordEvent()
    {
        return _points;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetSaveString()
    {
        return $"EternalGoal:{_title}|{_description}|{_points}";
    }
}