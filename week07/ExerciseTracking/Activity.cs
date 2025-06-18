using System;

public abstract class Activity
{
    // Abstract class that stores and calculate information about physical activities.

    // Attributes --------------------------------------------------------------------------------------------------------------
    private string _date;
    private string _length;
    private string _name;


    // Constructors -----------------------------------------------------------------------------------------------------------
    public Activity(string date, string length)
    {
        // Constructor that stores the activity information.
        _date = date;
        _length = length;
        _name = "default";
    }

    // Getters and Setters ----------------------------------------------------------------------------------------------------
    public string GetLength()
    {
        // Get activity length (in minutes).
        return _length;
    }

    public void SetName(string name)
    {
        _name = name;
    }


    // Methods ----------------------------------------------------------------------------------------------------------------
    public abstract float GetDistance();

    public abstract float GetSpeed();

    public abstract float GetPace();

    public string GetSummary()
    {
        // Summary of the activity that has been done.
        return $"{_date} {_name} ({_length}): Distance {GetDistance().ToString("F2")} km, Speed: {GetSpeed().ToString("F2")} kph, Pace: {GetPace().ToString("F2")} min per km";
    }
}