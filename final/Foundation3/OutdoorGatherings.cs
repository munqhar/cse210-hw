public class OutdoorGatherings: Event
{
    private string _weather;
    public OutdoorGatherings(string eventTittle, string description,string date, string time, Address address, string weather)
    {
        _eventTittle = eventTittle;
        _description = description;
        _date = date;
        _time = time;
        _adress = address;
        _weather = weather;
        _typeofEvent = "Outdoor Gathering";
    }
    public void FullDetails()
    {
        Console.WriteLine($"{_eventTittle}, {_description}, {_date}, {_time}, {_adress.TheAdress()}, {_weather}");
    }
}