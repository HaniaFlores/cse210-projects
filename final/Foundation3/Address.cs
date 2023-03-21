public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public string GetCompleteAddress()
    {
        if (_country == "USA") {
            return $"{_street}, {_city}, {_state}";
        } 
        else {
            return $"{_street}, {_city}, {_state}, {_country}";
        }
    }
}