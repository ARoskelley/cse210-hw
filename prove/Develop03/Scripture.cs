using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Verse> _verses;

    public Scripture(Reference reference, List<Verse> verses)
    {
        _reference = reference;
        _verses = verses;
    }

    public void Display()
    {
        Console.WriteLine($"\n{_reference}\n");
        foreach (var verse in _verses)
        {
            Console.WriteLine(verse.GetDisplayText());
        }
    }

    public void HideMoreWords(int count)
    {
        foreach (var verse in _verses)
        {
            verse.HideRandomWords(count);
        }
    }

    public bool FullyHidden()
    {
        return _verses.All(v => v.AllHidden());
    }
}
