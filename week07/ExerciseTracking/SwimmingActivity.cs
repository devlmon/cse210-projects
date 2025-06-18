using System;

public class SwimmingActivity : Activity
{
    // A child class that stores and calculate information about: swimming activity.

    // Attributes --------------------------------------------------------------------------------------------------------------
    private float _numberOfLaps;

    // Constructors -----------------------------------------------------------------------------------------------------------
    public SwimmingActivity(string date, string length, string numberOfLaps) : base(date, length)
    {
        // Constructor that stores the activity information.
        base.SetName("Swimming");
        _numberOfLaps = int.Parse(numberOfLaps);
    }


    // Methods ----------------------------------------------------------------------------------------------------------------

    public override float GetDistance()
    {
        // Calculate distance.    Distance = number of laps * 50 / 1000
        return _numberOfLaps * 50 / 1000;
    }

    public override float GetSpeed()
    {
        // Calculate speed.    Speed = 60 / Pace
        return 60 / GetPace();
    }

    public override float GetPace()
    {
        // Calculate pace.     Pace = minutes / distance
        return float.Parse(base.GetLength()) / GetDistance();
    }
}