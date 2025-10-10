// ------------------- Journal Class -------------------
public class Journal
{
    public List<Entry> _entryList = new List<Entry>();

    public void AppendEntry(Entry e)
    {
        _entryList.Add(e);
    }

    public void Display()
    {
        if (_entryList.Count == 0)
        {
            Console.WriteLine("No entries to display.\n");
            return;
        }

        foreach (Entry e in _entryList)
        {
            e.Display();
            Console.WriteLine("------------\n");
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename, append: false))
        {
            foreach (Entry e in _entryList)
            {
                writer.WriteLine(e.FormatForFile());
            }
        }
        Console.WriteLine($"Journal saved to {filename}\n");
    }

    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.\n");
            return;
        }

        _entryList.Clear();
        string fileContent = File.ReadAllText(filename);
        string[] blocks = fileContent.Split("===\n", StringSplitOptions.RemoveEmptyEntries);

        foreach (string block in blocks)
        {
            Entry e = Entry.FromFileBlock(block);
            if (e != null)
            {
                _entryList.Add(e);
            }
        }

        Console.WriteLine("Journal loaded successfully!\n");
    }
}