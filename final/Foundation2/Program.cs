using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Program 2: Online Ordering Cloth Store");

        /* ORDER 1 */
        /* CUSTOMER INFO */
        Customer customer1 = new Customer("John Smith", new Address("45-57 Bowne St", "Queens", "NY", "USA"));
        /* PRODUCTS */
        Product p1 = new Product("T-Shirt", 1234, 12.99, 2);
        Product p2 = new Product("Leggings", 5678, 29.35, 3);
        Product p3 = new Product("Blazer", 9098, 34.90, 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(p1);
        order1.AddProduct(p2);
        order1.AddProduct(p3);

        /* DISPLAY ORDER */
        Console.WriteLine("\nOrder 1");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("\nTotal: $" + order1.CalculateTotal());

        Console.WriteLine("\n------------------------------------------");

        /* ORDER 2 */
        /* CUSTOMER INFO */
        Customer customer2 = new Customer("Jane Doe", new Address("463 Saint-Catherine St W", "Montreal", "QC", "Canada"));
        /* PRODUCTS */

        Product p4 = new Product("Shorts", 7654, 14.99, 3);
        Product p5 = new Product("T-Shirt", 1234, 12.99, 2);
        Product p6 = new Product("Jeans", 3210, 30.50, 2);

        Order order2 = new Order(customer2);
        order2.AddProduct(p4);
        order2.AddProduct(p5);
        order2.AddProduct(p6);

        /* DISPLAY ORDER */
        Console.WriteLine("\nOrder 2");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("\nTotal: $" + order2.CalculateTotal());
    }
}