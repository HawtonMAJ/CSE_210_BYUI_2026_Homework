using System;
public class AssignmentParent
{
    private string _studentName;
    private string _topic;
    public AssignmentParent(string NewStudentName, string NewTopic)
    {
        _studentName = NewStudentName;
        _topic = NewTopic;
    }
    public string GetSummary()
    {
        string Summary = $"Name:{_studentName}, Topic:{_topic}";
        return Summary;
    }
}