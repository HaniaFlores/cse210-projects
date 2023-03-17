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

    public string GetCountry()
    {
        return _country;
    }

    public string GetStringAddress()
    {
        if (_country == "USA") {
            return $"{_street}\n{_city}, {_state}"; /* Country is not necessary for local shipments. */
        } 
        else {
            return $"{_street}\n{_city}, {_state}\n{_country}";
        }
    }
}