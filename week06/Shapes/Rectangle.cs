using System;
using System.Drawing;

public class Rectangle : Shape
{
    // Child class that will allow storing and using data from rectangles.

    // Attributes --------------------------------------------------------------------------------------------------------------

    private double _length;
    private double _width;


    // Constructors -----------------------------------------------------------------------------------------------------------

    public Rectangle(string color, double length, double width) : base(color)
    {
        // Store the rectangle data.
        _length = length;
        _width = width;
    }


    // Methods ----------------------------------------------------------------------------------------------------------------
    public override double GetArea()
    {
        // Calculate Rectangle Area.
        return _length * _width;
    }
}