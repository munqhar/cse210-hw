public class Lectures: Event
{
    private string _speakerName;
    private int _capacity;
    public Lectures(string eventTittle,string description,string date,string time,Address address,string speakerName,int capacity )
    {
        _eventTittle = eventTittle;
        _description = description;
        _date = date;
        _time = time;
        _adress = address;
        _speakerName = speakerName;
        _capacity = capacity;
        _typeofEvent = "Lecture";
    }
    public void FullDetails()
    {
        Console.WriteLine($"{_eventTittle}, {_description}, {_date}, {_time}, {_adress.TheAdress()}, {_speakerName}, {_capacity}");
    }
}