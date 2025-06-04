using System;
using System.Net.Sockets;

public class Order
{
    // Class responsible for storing and handle orders

    // Attributes --------------------------------------------------------------------------------------------------------------
    private List<Product> _products = new List<Product>();
    private Customer _customer;


    // Constructors -----------------------------------------------------------------------------------------------------------

    public Order(string products, string customerName, string customerAddress)
    {
        // Constructor that has parameters to split and store the order data
        // Loop for splitting and storing product data
        string[] product = products.Split('\n');
        foreach (string productData in product)
        {
            // Create instances to store product data
            Product newProduct = new Product(productData);
            _products.Add(newProduct);
        }
        // Create instance to store customer data
        _customer = new Customer(customerName, customerAddress);
    }


    // Methods ----------------------------------------------------------------------------------------------------------------

    public float GetTotalCost()
    {
        // Return the total cost of the order
        float totalCost = 0;
        foreach (Product product in _products)
        {
            // Sum up all product costs
            totalCost += product.GetTotalCost();
        }

        // If the customer is in USA, add USA shipping cost (5$). If the customer is not in USA, add international shipping cost (35$).
        if (_customer.IsInUSA() == true)
        {
            return totalCost + 5;
        }
        else
        {
            return totalCost + 35;
        }
    }

    public string GetPackingLabel()
    {
        // Return as a single string all the product names and IDs.
        string packingLabel = "";
        int i = 1;
        foreach (Product product in _products)
        {
            // Loop to add to the packingLabel variable all the data.
            packingLabel = packingLabel + i.ToString() + "- " + product.GetProductNameAndID() + '\n';
            i++;
        }
        return packingLabel;
    }
    
    public string GetShippingLabel()
    {
        // Return as a single string the customer name and address.
        return $"{_customer.GetCustomerDetails()}\n";
    }
}