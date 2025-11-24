using System;
public class Customer
{
    // Private number variables (Encapsulation)
    private string _name;
    private Address _address; //A customer has an address object

    // Constructor: when creating a customer, we must pass in the name and address
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Method to check if customer lives in the USA
    // Instead of checking here, we call the method from the Address class

    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }

    // Getter for the customer's name
    public string GetName()
    {
        return _name;
    }

    // Getter for the customer's name
    // The order class will need this to build the shipping label.
    public Address GetAddress()
    {
        return _address;
    }
}