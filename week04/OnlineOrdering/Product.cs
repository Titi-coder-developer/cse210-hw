using System;

public class Product
{
    // Private member variable (Encapsulation)
    private string _name;
    private string _productId;
    private double _pricePerUnit;
    private int _quantity;

    // Constructor: set all product details when creating the object 
    public Product(string name, string productId, double pricePerUnit, int quantity)
    {
        _name = name;
        _productId = productId;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }

    // Method to calculate the total of the product
    // Formula: price per unit x quantity
    public double GetTotalCost()
    {
        return _pricePerUnit * _quantity;
    }
    // / Getter: returns the product name(used in packing label)
    public string GetName()
    {
        return _name;
    }

    // Getter: returns the product ID (used in packing label)
    public string GetProductId()
    {
        return _productId;
    }

}