public class WritingAssignment : Assignment
{
    private string _title;

    public string GetWritingInformation()
    {
        return $"Title {_title}";
    }

    public WritingAssignment(string name, string topic, string title)
    : base(name, topic)
    {
        _title = title;
    }
}