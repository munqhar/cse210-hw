public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer ;    
    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }
    public float TotalCostOfTheOrder()
    {
        if(_customer.LiveInUsa() == true)
        {
            return TotalPrice()+5;
        }
        else
        {
            return TotalPrice()+35;
        }
        
    }
    public float TotalPrice()
    {
        float total = 0;
        foreach (Product product in _products)
        {
            total = product.price()+total;
        }
        return total;
    }
    public List<string> ThePackingLabel()
    {
        List<string> _packingLabel = new List<string>();
        foreach(Product product in _products)
        {
            _packingLabel.Add(product.GetNameAndProductID());
        }
        return _packingLabel;
    }
    public List<string> TheShippingLabel()
    {
        List<string> _shippingLabel = new List<string>();        
        
        _shippingLabel.Add($"{_customer.GetName()}, {_customer.GetAddress().TheAdress()}");
        
        return _shippingLabel;
    }
}