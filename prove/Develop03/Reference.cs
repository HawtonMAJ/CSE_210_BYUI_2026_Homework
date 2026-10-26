using System;
public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;
    public Reference()
    {
        // placeholder values, this constructor is not meant to be used as is
        _book = ("");
        _chapter = 0;
        _startVerse = 0;
        _endVerse = 0;
    }
    public Reference(string Book, int Chapter, int StartVerse)
    {
        _book = Book;
        _chapter = Chapter;
        _startVerse = StartVerse;
    }
    public Reference(string Book, int Chapter, int StartVerse, int Endverse)
    {
        _book = Book;
        _chapter = Chapter;
        _startVerse = StartVerse;
        _endVerse = Endverse;
    }
    public void DisplayReferenceOneVerse()
    {
        Console.Write($"{_book} {_chapter} {_startVerse}");
    }
    public void DisplayReferenceMultipleVerses()
    {
        Console.Write($"{_book} {_chapter} {_startVerse}-{_endVerse} ");
    }

}