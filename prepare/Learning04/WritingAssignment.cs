using System;
public class WritingAssignment : AssignmentParent
{
    private string _title;
    public WritingAssignment(string NewTitle, string NewStudentName, string NewTopic) : base(NewStudentName,NewTopic)
    {
        _title = NewTitle;
    }
    public string GetWritingInfo()
    {
        string WritingInfo = $"Title: {_title}";
        return WritingInfo;
    }
}