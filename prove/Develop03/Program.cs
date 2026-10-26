using System;

class Program
{
    static void Main(string[] args)
    {
        string Book = "Doctrine and Covenants";
        int Chapter = 76;
        int StartVerse = 22;
        int Endverse = 24;
        List<string> ListOfWords = ["And", "now,", "after", "the", "many", "testimonies", "which", "have", "been", "given", "of", "him,", "this", "is", "the", "testimony,", "last", "of", "all,", "which", "we", "give", "of", "him:", "That", "he", "lives!", "For", "we", "saw", "him,", "even", "on", "the", "right", "hand", "of", "God;", "and", "we", "heard", "the", "voice", "bearing", "record", "that", "he", "is", "the", "Only", "Begotten", "of", "the", "Father—", "That", "by", "him,", "and", "through", "him,", "and", "of", "him,", "the", "worlds", "are", "and", "were", "created,", "and", "the", "inhabitants", "thereof", "are", "begotten", "sons", "and", "daughters", "unto", "God."];

        Scripture NewScriptureToMemorize = new Scripture(ListOfWords, Book, Chapter, StartVerse, Endverse);
        string UserInput;

        do
        {
            Console.Clear();
            NewScriptureToMemorize.DisplayScriptureToMemorize();
            Console.Write("\nPress Enter or Return to disappear three random words. enter 'quit' to quit the program:");
            UserInput = Console.ReadLine();
            if (UserInput != "quit")
            {
                NewScriptureToMemorize.HideThreeWords();
            }
        }
        while (UserInput != "quit");
    }
}