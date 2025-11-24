using System;

class Program
{
    static void Main(string[] args)
    {
        // -------------------------------
        // ORDER 1 SETUP
        // -------------------------------

        // Create Address for Customer 1
        Address address1 = new Address("123 Main St", "Provo", "UT", "USA");

        // Create Customer 1
        Customer customer1 = new Customer("John Doe", address1);

        // Create Products for Order 1
        Product p1 = new Product("Laptop", "A100", 800, 1);
        Product p2 = new Product("Mouse", "A200", 20, 2);

        // Create Order 1 and add products
        Order order1 = new Order(customer1);
        order1.AddProduct(p1);
        order1.AddProduct(p2);

        // Display Order 1 Results
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice()}\n");


        // -------------------------------
        // ORDER 2 SETUP
        // -------------------------------

        // Create Address for Customer 2
        Address address2 = new Address("45 Independence Road", "Accra", "Greater Accra", "Ghana");

        // Create Customer 2
        Customer customer2 = new Customer("Ama Kwabena", address2);

        // Create Products for Order 2
        Product p3 = new Product("Phone Case", "B300", 15, 3);
        Product p4 = new Product("Charger", "B400", 25, 1);

        // Create Order 2 and add products
        Order order2 = new Order(customer2);
        order2.AddProduct(p3);
        order2.AddProduct(p4);

        // Display Order 2 Results
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice()}");
    }
}
