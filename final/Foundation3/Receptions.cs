public class Receptions:Event
{
    private string _email;
    public Receptions(string eventTittle, string description,string date, string time, Address address, string email)
    {
        _eventTittle = eventTittle;
        _description = description;
        _date = date;
        _time = time;
        _adress = address;
        _email = email;
        _typeofEvent = "Reception";
    }
    public void FullDetails()
    {
        Console.WriteLine($"{_eventTittle}, {_description}, {_date}, {_time}, {_adress.TheAdress()}, {_email}");
    }

}