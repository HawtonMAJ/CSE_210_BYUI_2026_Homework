using System;
public class Goal
{
    protected string _description;
    protected string _title;
    protected int _points;
    public Goal(string name, string description, int points)
    {
        _title = name;
        _description = description;
        _points = points;
    }
    public virtual void Display()
    {
        Console.WriteLine($"{_title}: {_description}");
    }
    public virtual string GetSaveString()
    {
        return $"{GetType().Name}:{_title}|{_description}|{_points}";
    }
    public string GetTitle()
    {
        return _title;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetPoints()
    {
        return _points;
    }
    public virtual int RecordEvent()
    {
        return 0;
    }
    public virtual bool IsComplete()
    {
        return false;
    }
}