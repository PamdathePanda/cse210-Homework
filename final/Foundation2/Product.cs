class Product{

    private string _name;
    private int _productID;
    private int _priceEach;
    private int _quantity;
    private int totalPrice;
    public Product(string Name, int ProductId, int PriceEach, int Quantity)
    {
        _name = Name;
        _productID = ProductId;
        _priceEach = PriceEach;
        _quantity = Quantity;

    }
    public int ReturnPrice()
    {
        totalPrice = _priceEach * _quantity;
        return totalPrice;
    }
    public string PackingInfo()
    {
        return $"{_name} {_productID}";
    }
}

