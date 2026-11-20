using System;
public class SimpleGoal : Goal
{
    private bool _completed;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _completed = false;
    }

    public SimpleGoal(string name, string description, int points, bool completed)
        : base(name, description, points)
    {
        _completed = completed;
    }

    public override void Display()
    {
        string status = _completed ? "[X]" : "[ ]";
        Console.WriteLine($"{status} {_title}: {_description}");
    }

    public override int RecordEvent()
    {
        if (_completed)
        {
            return 0;
        }

        _completed = true;
        return _points;
    }

    public override bool IsComplete()
    {
        return _completed;
    }

    public override string GetSaveString()
    {
        return $"SimpleGoal:{_title}|{_description}|{_points}|{_completed}";
    }
}