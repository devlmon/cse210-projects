using System;

public class RunningActivity : Activity
{
    // A child class that stores and calculate information about: running activity.

    // Attributes --------------------------------------------------------------------------------------------------------------
    private float _distance;

    // Constructors -----------------------------------------------------------------------------------------------------------
    public RunningActivity(string date, string length, string distance) : base(date, length)
    {
        // Constructor that stores the activity information.
        base.SetName("Running");
        _distance = float.Parse(distance);
    }


    // Methods ----------------------------------------------------------------------------------------------------------------

    public override float GetDistance()
    {
        // Return the distance.
        return _distance;
    }

    public override float GetSpeed()
    {
        // Calculate speed.    Speed = 60 / Pace
        return 60 / GetPace();
    }

    public override float GetPace()
    {
        // Calculate pace.     Pace = minutes / distance
        return float.Parse(base.GetLength()) / _distance;
    }
}