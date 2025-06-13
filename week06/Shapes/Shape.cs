using System;

public abstract class Shape
{
    // Abstract class that will allow storing and using data from figures/shapes.

    // Attributes --------------------------------------------------------------------------------------------------------------

    private string _color;


    // Constructors -----------------------------------------------------------------------------------------------------------

    public Shape(string color) {
        // Store the shape data.
        _color = color;
    }


    // Getters and Setters ----------------------------------------------------------------------------------------------------

    public string GetColor()
    {
        // Getter: Get the shape color.
        return _color;
    }

    public void SetColor(string color)
    {
        // Setter: Set the shape color.
        _color = color;
    }


    // Methods ----------------------------------------------------------------------------------------------------------------
    public abstract double GetArea();         // <- Calculate Shape Area.
}