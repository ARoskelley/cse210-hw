public class Journal
{
    //attribute

    public List<Entry> _entryList = new List<Entry>();

    //behaviors

    public void AppendEntry(Entry e)
    {
        _entryList.Add(e);
    }
    public void Display()
    {
        
        foreach (Entry e in _entryList) {
            e.Display();
            Console.WriteLine("------------");  
        }
    }
}