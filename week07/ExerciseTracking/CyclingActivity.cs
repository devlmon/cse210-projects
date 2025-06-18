using System;

public class CyclingActivity : Activity
{
    // A child class that stores and calculate information about: cycling activity.

    // Attributes --------------------------------------------------------------------------------------------------------------
    private float _speed;

    // Constructors -----------------------------------------------------------------------------------------------------------
    public CyclingActivity(string date, string length, string speed) : base(date, length)
    {
        // Constructor that stores the activity information.
        base.SetName("Cycling");
        _speed = float.Parse(speed);
    }


    // Methods ----------------------------------------------------------------------------------------------------------------

    public override float GetDistance()
    {
        // Calculate distance.    Distance = (speed * minutes) / 60
        return (_speed * float.Parse(base.GetLength())) / 60;
    }

    public override float GetSpeed()
    {
        // Return the speed.
        return _speed;
    }

    public override float GetPace()
    {
        // Calculate pace.     Pace = minutes / distance
        return float.Parse(base.GetLength()) / GetDistance();
    }
}