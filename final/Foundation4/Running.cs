public class Running:Activity
{
    private float _distance;
    public Running (string date, float length, float distance):base(date, length)
    {
        _date = date;
        _length = length;
        _distance = distance;
        _kindOfActivity = "Running";
    }
     public  override float TheSpeed()
    {        
       return _distance/_length*60;
    }
    public  override float ThePace()
    {
        return _length/_distance;
    }
    public  override float TheDistance()
    {
        return _distance;
    }
}