public class Entry
{
    public string _entryDateTime;
    public string _entryText;
    public string _givenPrompt;

    //Behaviors

    public void Display()
    {
        Console.Write($"{_entryDateTime} -- ");
        Console.WriteLine($"{_givenPrompt}");
        Console.WriteLine($"{_entryText}");
    }
    }