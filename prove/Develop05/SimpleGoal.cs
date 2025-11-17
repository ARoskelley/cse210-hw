using System.Reflection;
using System.Runtime.CompilerServices;

public class SimpleGoal : Goal{

    private int _numberAwarded;
    public SimpleGoal(int points, string title, string description) : base (title, description)
    {
        _numberAwarded = points;
    }

    public override void Award()
    {
        _cumulativeScore += _numberAwarded;
    }
    public void Display()
    {
        
    }
    public string GetStringRepresentation()
    {
        string bigString = 
        return "";
    }
}