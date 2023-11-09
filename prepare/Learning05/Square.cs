public class Square: Shape
{
    protected double _side;
    public override double GetArea()
    {
        return _side * _side;
    }
    public void Set(double side)
    {
        _side = side;
    }
}