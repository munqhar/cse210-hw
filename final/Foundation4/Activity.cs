public abstract class Activity
{
    protected string _date;
    protected float _length;
    protected string _kindOfActivity;
    public Activity(string date, float length)
    {
        _date = date;
        _length = length;
    }
    public abstract float TheDistance();
   
    public abstract float TheSpeed();
   
    public abstract float ThePace();
   
    public void GetSummary()
    {
        Console.WriteLine($"{_date} {_kindOfActivity} ({_length} min)- Distance: {TheDistance()} km, Speed: {TheSpeed()} kph, Pace: {ThePace()} min per km");

    }
}