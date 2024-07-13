using System;

class Program
{
    static void Main(string[] args)
    {
        var address1 = new Address("123 Elm St", "Springfield", "IL", "USA");
        var address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");
        var customer1 = new Customer("Amy Le Feuvre", address1);
        var customer2 = new Customer("Mary Stoddard", address2);
        var order1 = new Order(customer1);
        var order2 = new Order(customer2);
        order1.AddProduct(new Product("Picture Frame", 101, 3.00m, 5));
        order1.AddProduct(new Product("Colored Pencils", 102, 4.50m, 3));
        order2.AddProduct(new Product("Journal A", 201, 10.00m, 2));
        order2.AddProduct(new Product("Wallet", 202, 20.00m, 1));
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: {order1.TotalCost():C}\n");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: {order2.TotalCost():C}");
    }
}