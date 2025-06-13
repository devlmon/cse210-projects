using System;
using System.Drawing;

public class Square : Shape
{
    // Child class that will allow storing and using data from squares.

    // Attributes --------------------------------------------------------------------------------------------------------------

    private double _side;


    // Constructors -----------------------------------------------------------------------------------------------------------

    public Square(string color, double side) : base(color) {
        // Store the square data.
        _side = side;
    }


    // Methods ----------------------------------------------------------------------------------------------------------------
    public override double GetArea()
    {
        // Calculate Square Area.
        return _side * _side;
    }
}