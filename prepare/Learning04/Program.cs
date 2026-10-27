using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment assignment1 = new MathAssignment("7 Addition through the ages","12-18","Mark","Medieval Addition");
        string Summary1 = assignment1.GetSummary();
        string HomeworkList1 = assignment1.GetHomeworkList();
        Console.WriteLine(Summary1);
        Console.WriteLine(HomeworkList1);
        Console.WriteLine("\n");
        WritingAssignment assignment2 = new WritingAssignment("Primitive Teaching Methods","Mark","Medieval Addition");
        string Summary2 = assignment2.GetSummary();
        string HomeworkList2 = assignment2.GetWritingInfo();
        Console.WriteLine(Summary2);
        Console.WriteLine(HomeworkList2);
        Console.WriteLine("\n");
        
    }
}