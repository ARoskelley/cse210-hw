using System;
using System.Collections.Generic;
public class Reference
{
    private string _book;
    private int _chapter;
    private List<int> _verses;

    public Reference(string book, int chapter, List<int> verses)
    {
        _book = book;
        _chapter = chapter;
        _verses = verses;
    }

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verses.Add(verse);
    }

    public override string ToString()
    {
        string verseText = _verses.Count == 1
            ? _verses[0].ToString()
            : $"{_verses.First()}–{_verses.Last()}";
        return $"{_book} {_chapter}:{verseText}";
    }
}