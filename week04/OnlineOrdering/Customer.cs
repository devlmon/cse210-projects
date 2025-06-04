using System;
using System.Net.Sockets;

public class Customer
{
    // Class responsible for storing the customer data.

    // Attributes --------------------------------------------------------------------------------------------------------------
    private string _name;
    private Address _address;


    // Constructors -----------------------------------------------------------------------------------------------------------

    public Customer(string customerName, string customerAddress)
    {
        // Constructor that has parameters to store the customer data like name and address.
        _name = customerName;
        _address = new Address(customerAddress);
    }


    // Methods ----------------------------------------------------------------------------------------------------------------

    public bool IsInUSA()
    {
        // If the customer is in USA, return true. If the customer is not in USA, return false.
        if (_address.IsInUSA() == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetCustomerDetails()
    {
        // Return as a string the customer name and full address.
        return $"Customer name: {_name}. Address: {_address.GetFullAddress()}";
    }
}