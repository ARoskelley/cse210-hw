public class MathAssignment : Assignment
{
    private string _textbookSections;
    private string _problems;

    public string GetHomeworkList() 
    {
        return $"Section {_textbookSections}, Problems {_problems}";
    }

    public MathAssignment(string name, string topic,  string tbSections, string problems)
    : base (name, topic)
    {
        _textbookSections = tbSections;
        _problems = problems;
    }
}