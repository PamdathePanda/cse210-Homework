using System.Reflection.Metadata.Ecma335;

class Order
{

    private List<Product> _products;
    private Customer _customer;
    private int shippingCost;
    

    public Order(List<Product> Products, string CustName, Address CustAddress)
    {
        _customer = new Customer(CustName, CustAddress);
        _products = Products;

    }

    public int TotalPrice()
    {
        if (_customer.CheckLocation() == true)
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }
        int totalPrice = 0;
        foreach(var product in _products)
        {
            totalPrice += product.ReturnPrice();
        }
        totalPrice += shippingCost;
        return totalPrice;
    }
    public string PackingLabel()
    {
        List<string> packingInfoList = new List<string>();

        foreach(var product in _products)
        {
            packingInfoList.Add(product.PackingInfo());
        }
        string packingLabel = string.Join("\n", packingInfoList);
        return packingLabel;
    }
    public string ShippingLabel()
    {
        return _customer.ReturnInfo();
    }


}

