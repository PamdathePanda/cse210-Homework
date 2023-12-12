class Customer
{
    private string _name;
    private Address _address;

    public Customer(string Name, Address Address)
    {
        _name = Name;
        _address = Address;
    }
    public bool CheckLocation()
    {
        return _address.InUSA();
    }
    public string ReturnInfo(){
        return $"{_name}, {_address.ReturnAdress()}";
    }
}

