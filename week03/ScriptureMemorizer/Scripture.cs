using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] splitWords = text.Split(' ');
        _words = new List<Word>();
        foreach (string w in splitWords)
        {
            _words.Add(new Word(w));
        }
    }

    // Hide a few random words
    public void HideRandomWords(int count = 3)
    {
        Random rand = new Random();
        for (int i = 0; i < count; i++)
        {
            int index = rand.Next(_words.Count);
            _words[index].Hide();
        }
    }

    // Check if all words are hidden
    public bool IsCompletelyHidden()
    {
        foreach (Word w in _words)
        {
            if (!w.IsHidden())
                return false;
        }
        return true;
    }

    // Display scripture text
    public string GetDisplayText()
    {
        string scriptureText = _reference.GetDisplayText() + " ";
        foreach (Word w in _words)
        {
            scriptureText += w.GetDisplayText() + " ";
        }
        return scriptureText.Trim();
    }
}
