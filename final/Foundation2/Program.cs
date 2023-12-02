using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Order 1");
        Product product11 = new Product("milk","001",2000,2);
        Product product12 = new Product("rice","002",2500,3);
        List<Product> _products1 = new List<Product>();
        _products1.Add(product11);
        _products1.Add(product12);
        Address address1 = new Address("456 White Finch St.","Cecelia Havens","North Augusta","USA");
        Customer customer1 = new Customer("Andrew",address1);
        Order order1 = new Order(_products1,customer1);
        Console.WriteLine($"The total cost is: {order1.TotalCostOfTheOrder()}");
        Console.WriteLine($"The total cost of the products: {order1.TotalPrice()}");
        Console.WriteLine("The packing Label is:");
        foreach(String packing in order1.ThePackingLabel())
        {
            Console.WriteLine(packing);
        }
        Console.WriteLine("The shipping label is:");
        foreach(String shipping in order1.TheShippingLabel())
        {
            Console.WriteLine(shipping);
        }
        //-----order 2----------------------------------------
        Console.WriteLine("Order2");
         Product product21 = new Product("hot dog","021",100,2);
        Product product22 = new Product("soda","302",2500,3);
        List<Product> _products2 = new List<Product>();
        _products2.Add(product21);
        _products2.Add(product22);
        Address address = new Address("456 White Finch St.","Cecelia Havens","North Augusta","Colombia");
        Customer customer2 = new Customer("Ethan",address);
        Order order2 = new Order(_products2,customer2);
        Console.WriteLine($"The total cost is: {order2.TotalCostOfTheOrder()}");
        Console.WriteLine($"The total cost of the products: {order2.TotalPrice()}");
        Console.WriteLine("The packing Label is:");
        foreach(String packing in order2.ThePackingLabel())
        {
            Console.WriteLine(packing);
        }
        Console.WriteLine("The shipping label is:");
        foreach(String shipping in order2.TheShippingLabel())
        {
            Console.WriteLine(shipping);
        }

    }
}