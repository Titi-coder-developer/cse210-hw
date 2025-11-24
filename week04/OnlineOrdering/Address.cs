using System;

public class Address
{
    // Private member variables (Encapsulation)
    // These hold parts of the customer's address but cannot be accessed directly outside the class.
    private string _street = "";
    private string _city = "";
    private string _state = "";
    private string _country = "";

    // Constructor: This sets up the Address object when it is created.
    // It receives four strings and assigns them to the private variable.
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    // Method to check if the address is in the USA
    // The assignment requires this so that shipping cost can be calculated in the Order class.
    public bool IsInUSA()
    {
        // Convert the country to uppercase so "usa", "UsA", "USA" all match correctly.
        return _country.ToUpper() == "USA";
    }

    // Method to return the full address as a formatted string.
    // The shipping label uses this method.

    public string GetFullAddress()
    {
        //  Return the address in standard mailling format with line breaks.
        return $"{_street}\n{_city}, {_state}\n{_country}";
    }

}
