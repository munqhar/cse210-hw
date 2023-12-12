public class Cycling:Activity
{
    private float _speed;
    public Cycling(string date, float length, float speed): base(date,length)
    {
        _date = date;
        _length = length;
        _speed = speed;
        _kindOfActivity = "Cycling";
    }
    public  override float TheSpeed()
    {
        return _speed;
    }
    public  override float ThePace()
    {
        return 60/_speed;
    }
    public  override float TheDistance()
    {
        return _length * _speed;
    }
    

}