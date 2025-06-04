using System;
using System.Net.Sockets;

public class Address
{
    // Class responsible for storing the customer address.

    // Attributes --------------------------------------------------------------------------------------------------------------
    private string _street;
    private string _city;
    private string _stateOrProvince;
    private string _country;


    // Constructors -----------------------------------------------------------------------------------------------------------

    public Address(string customerAddress)
    {
        // Constructor that has a parameter to split and store the address data.
        string[] addressData = customerAddress.Split(',');
        _country = addressData[0];
        _stateOrProvince = addressData[1];
        _city = addressData[2];;
        _street = addressData[3];;
    }


    // Methods ----------------------------------------------------------------------------------------------------------------

    public bool IsInUSA()
    {
        // If the customer is in USA, return true. If the customer is not in USA, return false.
        if (_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetFullAddress()
    {
        // Return as a string the full address in this format: street, city, state/province, country.
        return $"{_street}, {_city}, {_stateOrProvince}, {_country}.";
    }
}