public class Rectangle : Shape
{
    protected double _length;
    protected double _width;
    public override double GetArea()
    {
        return _length * _width;
    }
    public void Set(double length, double width)
    {
        _length = length;
        _width = width;
    }
}