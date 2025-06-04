using System;
using System.Net.Sockets;

public class Product
{
    // Class responsible for storing product data.

    // Attributes --------------------------------------------------------------------------------------------------------------
    private string _name;
    private string _id;
    private float _price;
    private int _quantity;


    // Constructors -----------------------------------------------------------------------------------------------------------

    public Product(string productDetails)
    {
        // Constructor that has a parameter to split and store the product data.
        string[] productDetail = productDetails.Split(',');
        _name = productDetail[0];
        _id = productDetail[1];
        _price = float.Parse(productDetail[2]);
        _quantity = int.Parse(productDetail[3]);
    }


    // Methods ----------------------------------------------------------------------------------------------------------------

    public float GetTotalCost()
    {
        // Return the total cost of the product (price times quantity).
        return _price * _quantity;
    }

    public string GetProductNameAndID()
    {
        // Return as a string the product name and ID.
        return $"{_name} ({_id}).";
    }
}