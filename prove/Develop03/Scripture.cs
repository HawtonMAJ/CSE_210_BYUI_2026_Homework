using System;
using System.ComponentModel.DataAnnotations;
public class Scripture
{
    private List<Word> _wordList = new List<Word>();
    private Reference _reference;

    public Scripture()
    {
        
    }
    public Scripture(List<string> NewWords, string Book, int Chapter, int StartVerse, int Endverse)
    {
        foreach (string NewWord in NewWords)
        {
            Word AnotherWord = new Word(NewWord, false);
            _wordList.Add(AnotherWord);
        }
        _reference = new Reference(Book, Chapter, StartVerse, Endverse);
    }
    public void AddWords(string WordToAdd)
    {
            Word AnotherWord = new Word(WordToAdd, false);
            _wordList.Add(AnotherWord);
    }
    public void SetReference(string Book, int Chapter, int StartVerse, int Endverse)
    {
        _reference = new Reference(Book, Chapter, StartVerse, Endverse);
    }
    public void DisplayScriptureToMemorize()
    {
        _reference.DisplayReferenceMultipleVerses();
        foreach(Word DisplayWord in _wordList)
        {
            if (DisplayWord.IsItHidden())
            {
                Console.Write("____ ");
            }
            else
            {
                Console.Write($"{DisplayWord.GetText()} ");
            }
        }
    }
    // The following code was written in part by Ai with overview by me, I couldnt figure out the random word selection for the life of me
    // With this I was able to get it working and I believe i 
    public void HideThreeWords()
    {
        List<Word> VisibleWords = _wordList
            .Where(WordToCheck => !WordToCheck.IsItHidden())
            .ToList();

        for (int i = 0; i < 3 && VisibleWords.Count > 0; i++)
        {
            int RandomIndex = Random.Shared.Next(VisibleWords.Count);
            VisibleWords[RandomIndex].Hide();
            VisibleWords.RemoveAt(RandomIndex);
        }
    }
}