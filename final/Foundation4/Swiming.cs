public class Swiming:Activity
{
    private float _lapsNumbers;
    public Swiming(string date, int length, float lapsNumbers):base(date,length)
    {
        _date = date;
        _length = length;
        _lapsNumbers = lapsNumbers;
        _kindOfActivity = "Swiming";
    }
    public override float TheSpeed()
    {
        return TheDistance()/_length * 60;
    }
    public override float TheDistance()
    {
        return _lapsNumbers*50/1000;
    }
    public override float ThePace()
    {
        return _length/TheDistance();
    }
    
}