using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome() 
        {
            Console.WriteLine("Welcome to the Program!");
        }
        static string PromptUserName() 
        {
            Console.Write("What is your name? :");
            string NameString = Console.ReadLine();
            return NameString;
        }
        static int PromptUserNumber() 
        {
            Console.Write("What is your favorite number? :");
            string FaveNumString = Console.ReadLine();
            int FaveNumInt = int.Parse(FaveNumString);
            return FaveNumInt;
        }
        static void PromtUserBirthYear(out int BirthYearInt) 
        {
            Console.Write("What is your birth year? :");
            string BirthYearString = Console.ReadLine();
            BirthYearInt = int.Parse(BirthYearString);
        }
        static int SquareNumber(int NumberInt) 
        {
            int SquaredNumberInt = NumberInt * NumberInt;
            return SquaredNumberInt; 
        }
        static void DisplayResult(string UsersName, int SquaredNumber, int UsersBirthyear)
        {
            Console.WriteLine($"{UsersName}, your favorite number squared is {SquaredNumber}");
            int YearsOldInt = 2026 - UsersBirthyear;
            Console.WriteLine($"{UsersName}, you will turn {YearsOldInt} this year.");
        }
        DisplayWelcome();
        string UsersName = PromptUserName();
        int UsersFaveNumber = PromptUserNumber();
        PromtUserBirthYear(out int BirthYearInt);
        int SquaredNumber = SquareNumber(UsersFaveNumber);
        DisplayResult(UsersName,SquaredNumber,BirthYearInt);
    }
}