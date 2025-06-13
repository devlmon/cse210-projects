using System;
using System.Drawing;

public class Circle : Shape
{
    // Child class that will allow storing and using data from circles.

    // Attributes --------------------------------------------------------------------------------------------------------------

    private double _radius;


    // Constructors -----------------------------------------------------------------------------------------------------------

    public Circle(string color, double radius) : base(color)
    {
        // Store the cicle data.
        _radius = radius;
    }


    // Methods ----------------------------------------------------------------------------------------------------------------
    public override double GetArea()
    {
        // Calculate Circle Area.
        return Math.PI * Math.Pow(_radius, 2);
    }
}