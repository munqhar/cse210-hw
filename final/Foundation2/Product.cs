public class Product
{
    private string _name;
    private string _productid;
    private float _price;
    private int _quantity;
    public Product(string name,string productid,float price, int quantity)
    {
        _name = name;
        _productid = productid;
        _price = price;
        _quantity = quantity;
    }
    public float price()
    {
        return _price*_quantity;
    }
    public string GetNameAndProductID()
    {
        return $"{_name},{_productid}";
    }
   


}