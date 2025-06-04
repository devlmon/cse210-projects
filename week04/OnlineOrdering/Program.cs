using System;

class Program
{
    static void Main(string[] args)
    {
        // Create the instances of the two orders
        Order order1 = new Order("Ice cream,P010101,1.75,2\nChips,P020202,1.24,3", "Finn White", "USA,Utah,Aurora,East 100 South");
        Order order2 = new Order("Chocolate,P030303,2.25,1\nHusky Plush,P040404,7.77,1", "Moon Silver", "Venezuela,Carabobo,Valencia,Av. Bolivar");

        // Order 1: Show on the output the packing label, the shipping label, and the total price.
        Console.WriteLine("-----------------------");
        Console.WriteLine("Order 1: ");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine($"Total Cost: {order1.GetTotalCost()}");
        Console.WriteLine();

        // Order 2: Show on the output the packing label, the shipping label, and the total price.
        Console.WriteLine("-----------------------");
        Console.WriteLine("Order 2: ");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine($"Total Cost: {order2.GetTotalCost()}");
        Console.WriteLine();
    }
}