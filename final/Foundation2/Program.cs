using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create products
        Product product1 = new Product("Laptop", 1, 1200, 2);
        Product product2 = new Product("Mouse", 2, 25, 3);
        Product product3 = new Product("Headphones", 3, 80, 1);

        Product product4 = new Product("Smartphone", 4, 800, 1);
        Product product5 = new Product("Tablet", 5, 300, 2);

        // Create addresses
        Address address1 = new Address("123 Main St", "Cityville", "CA", "United States of America");
        Address address2 = new Address("456 Oak St", "Townsville", "NY", "Canada");

        // Create orders
        Order order1 = new Order(new List<Product> { product1, product2, product3 }, "John Doe", address1);
        Order order2 = new Order(new List<Product> { product4, product5 }, "Jane Doe", address2);

        // Display information for Order 1
        Console.WriteLine("Order 1:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.PackingLabel());

        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(order1.ShippingLabel());

        Console.WriteLine($"\nTotal Price: ${order1.TotalPrice()}");

        // Display information for Order 2
        Console.WriteLine("\nOrder 2:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.PackingLabel());

        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(order2.ShippingLabel());

        Console.WriteLine($"\nTotal Price: ${order2.TotalPrice()}");
    }
}