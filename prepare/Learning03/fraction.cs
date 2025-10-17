using System.Dynamic;

public class Fraction
{
    private int _top;
    private int _bottom;

    //-----Constructors-----//
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int topNumber)
    {
        _top = topNumber;
        _bottom = 1;
    }
    public Fraction(int topNumber, int bottomNumber)
    {
        _top = topNumber;
        _bottom = bottomNumber;
    }

    //-----Getters/Setters-----//

    public int GetTop()
    {
        return _top;
    }
    public void SetTop(int top)
    {
        _top = top;
    }
    public int GetBottom()
    {
        return _bottom;
    }
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    //-----Outputs-----//

    public string GetFractionString()
    {
        string result = $"{_top}/{_bottom}";
        return result;
    }
    public double GetDecimalValue()
    {
        return (double)_top/(double)_bottom;
    }

}
