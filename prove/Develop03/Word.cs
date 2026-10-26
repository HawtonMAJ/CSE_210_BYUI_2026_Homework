using System;
public class Word
{
    private string _text;
    private bool _isHidden;

    public Word()
    {
        _text = ("");
        _isHidden = false;
    }

    public Word(string NewText, bool IsHiddenState)
    {
        _isHidden = IsHiddenState;
        _text = NewText;
    }
    public void Hide()
    {
        _isHidden = true;
    }
    public bool IsItHidden()
    {
        return _isHidden;
    }
    public string GetText()
    {
        return _text;
    }
    public void SetText(string NewText)
    {
        _text = NewText;
    }
}