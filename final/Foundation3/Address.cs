public class Address{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public Address(string Street, string City,string State, string Country)
    {
        _streetAddress = Street;
        _city = City;
        _state = State;
        _country = Country;
    }
    public string ReturnAddress()
    {
        return $"{_streetAddress}, {_city}, {_state}, {_country}";
    }
}