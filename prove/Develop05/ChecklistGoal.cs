using System;
public class ChecklistGoal : Goal
{
    private int _timesToDo;
    private int _repetitionCount;
    private int _bonusPoints;
    private bool _completed;

    public ChecklistGoal(string name, string description, int points, int timesToDo, int bonusPoints)
        : base(name, description, points)
    {
        _timesToDo = timesToDo;
        _repetitionCount = 0;
        _bonusPoints = bonusPoints;
        _completed = false;
    }

    public ChecklistGoal(string name, string description, int points, int timesToDo,
        int repetitionCount, int bonusPoints)
        : base(name, description, points)
    {
        _timesToDo = timesToDo;
        _repetitionCount = repetitionCount;
        _bonusPoints = bonusPoints;
        _completed = repetitionCount >= timesToDo;
    }

    public ChecklistGoal(string name, string description, int points, int timesToDo,
        int repetitionCount, int bonusPoints, bool completed)
        : base(name, description, points)
    {
        _timesToDo = timesToDo;
        _repetitionCount = repetitionCount;
        _bonusPoints = bonusPoints;
        _completed = completed;
    }

    public override void Display()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        Console.WriteLine($"{status} {_title}: {_description} -- Currently completed {_repetitionCount}/{_timesToDo}");
    }

    public override int RecordEvent()
    {
        if (IsComplete())
        {
            return 0;
        }

        _repetitionCount++;
        if (IsComplete())
        {
            return _points + _bonusPoints;
        }

        return _points;
    }

    public override bool IsComplete()
    {
        if (_repetitionCount >= _timesToDo)
        {
            _completed = true;
        }
        return _completed;
    }

    public override string GetSaveString()
    {
        return $"ChecklistGoal:{_title}|{_description}|{_points}|{_timesToDo}|{_repetitionCount}|{_bonusPoints}|{IsComplete()}";
    }
}