using System;
using System.Collections.Generic;
public class Verse
{
    private Reference _reference;
    private List<Word> _words;

    public Verse(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ')
                     .Select(w => new Word(w))
                     .ToList();
    }

    public List<Word> Words => _words;

    public string GetDisplayText()
    {
        return string.Join(" ", _words.Select(w => w.ToString()));
    }

    public void HideRandomWords(int count)
    {
        Random rand = new Random();
        for (int i = 0; i < count; i++)
        {
            int index = rand.Next(_words.Count);
            _words[index].Hide();
        }
    }

    public bool AllHidden()
    {
        return _words.All(w => !w.IsVisible);
    }
}
