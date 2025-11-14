public class Rectangle : Shape
{
    private double _shortSide;
    private double _longSide;

    public Rectangle(double shortside,double longside, string color) : base(color)
    {
        _shortSide = shortside;
        _longSide = longside;
    }

    public override double GetArea()
    {
        return _longSide * _shortSide;
    }
}