using System;

class Program
{
    static void Main(string[] args)
    {
        Random RandomNumber = new Random();
        int MagicNumberInt = RandomNumber.Next(1,101);
        Console.WriteLine(MagicNumberInt);
        int GuessInt;
        do
        {
            Console.Write("What is your guess? :");
            string GuessString = Console.ReadLine();
            GuessInt = int.Parse(GuessString);
            if (GuessInt > MagicNumberInt)
            {
                Console.WriteLine("Too High");
            }
            else if (GuessInt < MagicNumberInt)
            {
                Console.WriteLine("Too Low");
            }   
        } while (GuessInt != MagicNumberInt);
        if (GuessInt == MagicNumberInt)
        {
            Console.WriteLine("You did it!");
        }
    }
}