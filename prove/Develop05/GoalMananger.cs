using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _totalPoints;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _totalPoints = 0;
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");

        string type = Console.ReadLine();
        Console.Write("What is the name of your goal? ");
        string title = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        if (type == "1")
        {
            Console.Write("How many points is this goal worth? ");
            int points = ReadInt();
            _goals.Add(new SimpleGoal(title, description, points));
        }
        else if (type == "2")
        {
            Console.Write("How many points is this goal worth? ");
            int points = ReadInt();
            _goals.Add(new EternalGoal(title, description, points));
        }
        else if (type == "3")
        {
            Console.Write("How many times does this goal need to be completed? ");
            int timesToDo = ReadInt();
            Console.Write("How many points does each completion earn? ");
            int points = ReadInt();
            Console.Write("How many bonus points are awarded after completing it that many times? ");
            int bonusPoints = ReadInt();
            _goals.Add(new ChecklistGoal(title, description, points, timesToDo, bonusPoints));
        }
        else
        {
            Console.WriteLine("Invalid goal type.");
        }
    }

    public void ListGoals()
    {
        Console.WriteLine($"You have {_totalPoints} points.");
        Console.WriteLine();
        Console.WriteLine("The goals are:");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            _goals[i].Display();
        }
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? (The .txt extension is optional.) ");
        string filename = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(filename))
        {
            Console.WriteLine("A filename is required. Goals were not saved.");
            return;
        }

        if (string.IsNullOrEmpty(Path.GetExtension(filename)))
        {
            filename += ".txt";
        }

        string fullPath = Path.GetFullPath(filename);
        using StreamWriter writer = new StreamWriter(fullPath);
        writer.WriteLine(_totalPoints);
        foreach (Goal goal in _goals)
        {
            writer.WriteLine(goal.GetSaveString());
        }

        Console.WriteLine($"Goals saved to: {fullPath}");
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? (The .txt extension is optional.) ");
        string filename = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(filename))
        {
            Console.WriteLine("A filename is required. Goals were not loaded.");
            return;
        }

        try
        {
            if (string.IsNullOrEmpty(Path.GetExtension(filename)))
            {
                filename += ".txt";
            }

            string fullPath = Path.GetFullPath(filename);
            if (!File.Exists(fullPath))
            {
                Console.WriteLine($"The goal file does not exist: {fullPath}");
                return;
            }

            string[] lines = File.ReadAllLines(fullPath);
            _goals.Clear();
            _totalPoints = lines.Length > 0 ? ReadInt(lines[0]) : 0;

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(':', 2);
                if (parts.Length != 2)
                {
                    continue;
                }

                string[] values = parts[1].Split('|');
                if (parts[0] == "SimpleGoal" && values.Length == 4)
                {
                    _goals.Add(new SimpleGoal(values[0], values[1],
                        int.Parse(values[2]), bool.Parse(values[3])));
                }
                else if (parts[0] == "EternalGoal" && values.Length == 3)
                {
                    _goals.Add(new EternalGoal(values[0], values[1], int.Parse(values[2])));
                }
                else if (parts[0] == "ChecklistGoal" && values.Length == 7)
                {
                    _goals.Add(new ChecklistGoal(values[0], values[1], int.Parse(values[2]),
                        int.Parse(values[3]), int.Parse(values[4]), int.Parse(values[5]),
                        bool.Parse(values[6])));
                }
                else if (parts[0] == "ChecklistGoal" && values.Length == 6)
                {
                    _goals.Add(new ChecklistGoal(values[0], values[1], int.Parse(values[2]),
                        int.Parse(values[3]), int.Parse(values[4]), int.Parse(values[5])));
                }
            }

            Console.WriteLine($"Goals loaded from: {fullPath}");
        }
        catch (IOException exception)
        {
            Console.WriteLine($"Could not load goals: {exception.Message}");
        }
        catch (UnauthorizedAccessException exception)
        {
            Console.WriteLine($"Could not load goals: {exception.Message}");
        }
        catch (ArgumentException exception)
        {
            Console.WriteLine($"Could not load goals: {exception.Message}");
        }
        catch (NotSupportedException exception)
        {
            Console.WriteLine($"Could not load goals: {exception.Message}");
        }
    }

    public void RecordEvent()
    {
        while (true)
        {
            if (_goals.Count == 0)
            {
                Console.WriteLine("There are no goals to record.");
                return;
            }

            Console.WriteLine("The goals are:");
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetTitle()}");
            }
            Console.WriteLine("0. Go back to the main menu");

            Console.Write("Which goal did you accomplish? ");
            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Please enter a valid goal number.");
                continue;
            }
            if (choice == 0)
            {
                return;
            }
            if (choice < 1 || choice > _goals.Count)
            {
                Console.WriteLine("Invalid goal.");
                continue;
            }

            int pointsEarned = _goals[choice - 1].RecordEvent();
            _totalPoints += pointsEarned;
            Console.WriteLine($"Congratulations! You have earned {pointsEarned} points.");
            Console.WriteLine($"You now have {_totalPoints} points.");
            Console.WriteLine();
        }
    }

    public List<Goal> GetGoalList()
    {
        return _goals;
    }

    public int GetTotalPoints()
    {
        return _totalPoints;
    }

    private int ReadInt()
    {
        int value;
        while (!int.TryParse(Console.ReadLine(), out value))
        {
            Console.Write("Please enter a whole number: ");
        }
        return value;
    }

    private int ReadInt(string value)
    {
        return int.TryParse(value, out int number) ? number : 0;
    }
}