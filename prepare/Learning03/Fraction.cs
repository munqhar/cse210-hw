public class Fraction
{
    private double _top;
    private double _bottom;
    public Fraction ()
    {
        _top=1;
        _bottom=1;
        
    }
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }
    public Fraction (int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
        
    }
    public double GetTop()
    {
        return _top;

    }
    public void SetTop(int top)
    {
        _top=top;
        
    }
    public double GetBottom()
    {
        return _bottom;

    }
    public void SetBottom(int bottom)
    {
        _bottom=bottom;
        
    }
    public string GetFractionString ()
    {
        return ($"{_top}/{_bottom}");
    }
    public double GetDecimalValue ()
    {
        
        return  _top/_bottom;
    }

}