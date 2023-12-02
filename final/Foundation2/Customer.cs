public class Customer
{
    private string _name;
    private Address _address;
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    public bool LiveInUsa()
    {
        return _address.LiveInUsa();
    }
     public string GetName() //customer
    {
        return $"{_name}";
    }
    public Address GetAddress()
    {
        return _address;
    }
}