using System.Reflection.Metadata.Ecma335;

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;
    private bool _inUSA;

    public Address(string Street, string City,string State, string Country)
    {
        _streetAddress = Street;
        _city = City;
        _state = State;
        _country = Country;
        if (_country.ToLower() == "united states of america")
        {
            _inUSA = true;
        }
        else
        {
            _inUSA = false;
        }
    }
    public string ReturnAdress()
    {
        return $"{_streetAddress}\n{_city} {_state}\n{_country}";
    }
    public bool InUSA()
    {
        return _inUSA;
    }
}