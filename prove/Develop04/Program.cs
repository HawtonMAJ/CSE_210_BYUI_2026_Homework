using System;

class Program
{
    static void Main(string[] args)
    {
        int UserInput;
        do
        {
            Console.Clear();
            Console.WriteLine("Please choose one of the following options by choosing the corresponding number and entering it.");
            Console.WriteLine("(1): Breathing Mindfulness");
            Console.WriteLine("(2): Reflection Mindfulness");
            Console.WriteLine("(3): Listing Mindfulness");
            Console.WriteLine("(0): Quit being Mindful");
            Console.Write("What is your choice of activity? :");
            string UserInputstring = Console.ReadLine();
            UserInput = int.Parse(UserInputstring);

            if (UserInput == 1)
            {
                BreathingActivty Breathing1 = new BreathingActivty("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                Breathing1.BreathCycle();
            }
            else if (UserInput == 2)
            {
                ReflectionActivty Reflection1 = new ReflectionActivty("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                Reflection1.ReflectionCycle();
            }
            else if (UserInput == 3)
            {
                ListingActivty Listing1 = new ListingActivty("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                Listing1.ListingCycle();
            }

        }while (UserInput != 0); 
    }
}