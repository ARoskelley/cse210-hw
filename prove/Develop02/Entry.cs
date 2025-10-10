using System;
using System.Collections.Generic;
using System.IO;

// ------------------- Entry Class -------------------
public class Entry
{
    public string _entryDateTime;
    public List<string> _entryText = new List<string>();

    public void Display()
    {
        Console.WriteLine($"Date: {_entryDateTime}");
        foreach (string text in _entryText)
        {
            Console.WriteLine(text);
            Console.WriteLine();
        }
    }

    public string FormatForFile()
    {
        // Combines the date and all text blocks for file saving
        string combinedText = string.Join("\n---\n", _entryText);
        return $"[{_entryDateTime}]\n{combinedText}\n===\n";
    }

    public static Entry FromFileBlock(string block)
    {
        // Splits a text block (loaded from file) into an Entry object
        var lines = block.Split('\n', StringSplitOptions.RemoveEmptyEntries);
        if (lines.Length == 0) return null;

        Entry entry = new Entry();
        entry._entryDateTime = lines[0].Trim('[', ']');
        List<string> entryText = new List<string>();
        for (int i = 1; i < lines.Length; i++)
        {
            entryText.Add(lines[i]);
        }
        entry._entryText = entryText;
        return entry;
    }
}
