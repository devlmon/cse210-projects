using System;

public class Fraction
{
    // Class responsible for having stored and displaying the entries made by the user.

    // Attributes --------------------------------------------------------------------------------------------------------------
    private int _top;                // Numerator
    private int _bottom;             // Denominator


    // Constructors -----------------------------------------------------------------------------------------------------------

    public Fraction()
    {
        // Constructor that has no parameters that initializes the number to 1/1.
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        // Constructor that has one parameter for the top and that initializes the denominator to 1. So that if you pass in the number 5, the fraction would be initialized to 5/1.
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        // Constructor that has two parameters, one for the top and one for the bottom.
        _top = top;
        _bottom = bottom;
    }

    // Getters and Setters ----------------------------------------------------------------------------------------------------

    public int GetTop()
    {
        // Get the numerator
        return _top;
    }

    public int GetBottom()
    {
        // Get the denominator
        return _bottom;
    }

    public void SetTop(int top)
    {
        // Set the numerator
        _top = top;
    }

    public void SetBottom(int bottom)
    {
        // Set the denominator
        _bottom = bottom;
    }

    // Methods ----------------------------------------------------------------------------------------------------------------

    public string GetFractionString()
    {
        // Return the fraction as a string value
        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue()
    {
        // Return the fraction as a double value
        return (double)_top / _bottom;
    }
}