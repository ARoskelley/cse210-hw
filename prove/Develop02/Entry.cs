public class Entry
{
    public DateTime _entryDateTime;
    public List<string> _entryText = new List<string>();
    public string _givenPrompt;

    //Behaviors
    public void Display()
    {
        Console.Write($"{_entryDateTime} -- ");
        Console.WriteLine($"{_givenPrompt}");

        foreach
        Console.WriteLine($"{_entryText}");
    }
    }