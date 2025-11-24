using System;
using System.Collections.Generic; // Needed to use List<T>

public class Order
{
    // Private member variables (Encapsulation)
    private List<Product> _products = new List<Product>(); // An order has many products
    private Customer _customer; // An order belongs to one customer

    // Constructor: requires a customer when creating the order
    public Order(Customer customer)
    {
        _customer = customer;
    }

    // Method to add a product to the order
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // Method to calculate the total price of the order
    public double GetTotalPrice()
    {
        double total = 0;

        // Add up total cost of all products
        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

        // Determine shipping cost
        if (_customer.LivesInUSA())
        {
            total += 5;   // USA shipping
        }
        else
        {
            total += 35;  // International shipping
        }

        return total;
    }

    // Generates the Packing Label
    // Shows the name and ID of each product
    public string GetPackingLabel()
    {
        string label = "PACKING LABEL:\n";

        foreach (Product product in _products)
        {
            label += $"{product.GetName()} (ID: {product.GetProductId()})\n";
        }

        return label;
    }

    // Generates the Shipping Label
    // Shows the customer name and full address
    public string GetShippingLabel()
    {
        return $"SHIPPING LABEL:\n{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
}
