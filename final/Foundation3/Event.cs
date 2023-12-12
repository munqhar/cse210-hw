public class Event
{
    protected string _eventTittle;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _adress;
    protected  string _typeofEvent;
    public void StandardDetails()
    {
        Console.WriteLine($"{_eventTittle}, {_description}, {_date}, {_time}, {_adress.TheAdress()}");
        
    }
    public void ShortDescription()
    {
        Console.WriteLine($"{_typeofEvent}, {_eventTittle}, {_date}");
    }
}