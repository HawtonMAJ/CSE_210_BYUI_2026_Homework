using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade in percentage? %");
        string gradeString = Console.ReadLine();
        int grade = int.Parse(gradeString);
        string letter = "";
        // left empty on purpose, will be filled in the coming if else block
        if (grade > 100)
        {
            Console.WriteLine("Please restart and enter a valid score");
            letter = "N/A";
        }
        else if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else if (grade < 60)
        {
            letter = "F";
        }


        string sign = "";
        int gradeSign = grade %10;
        // Will be set as plus or minus in following block
        if (gradeSign >= 7)
        {
            sign = "+";
        }
        else if (gradeSign < 3)
        {
            sign = "-";
        }
        if (grade < 70 || grade >= 95)
        {
            sign = "";
        }

        Console.WriteLine($"Grade = {letter}{sign}");

        if (grade >= 101)
        {
            Console.WriteLine("Congrats! You broke the rules of math you did so well!");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("Congrats! Keep moving forward!");
        }
        else if (grade < 70)
        {
            Console.WriteLine("You didn't quite get it this time. Try again with the knowledge you've learned!");
        }
    }
}