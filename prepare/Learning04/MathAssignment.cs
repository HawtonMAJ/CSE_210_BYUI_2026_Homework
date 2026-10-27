using System;
public class MathAssignment : AssignmentParent
{
    private string _textbookSection;
    private string _problems;
    public MathAssignment(string NewTextbookSection, string NewProblems, string NewStudentName, string NewTopic) : base(NewStudentName,NewTopic)
    {
        _textbookSection = NewTextbookSection;
        _problems = NewProblems;
    }
    public string GetHomeworkList()
    {
        string HomeworkList = $"Section:{_textbookSection}, Problems: {_problems}";
        return HomeworkList;
    }
}