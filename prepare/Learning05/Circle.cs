public class Circle : Shape
{
    protected double _radius;
    public override double GetArea()
    {
        return System.Math.PI * _radius * _radius;
    }
}