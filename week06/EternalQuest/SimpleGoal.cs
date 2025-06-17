using System;

public class SimpleGoal : Goal
{
    // A child class that stores and processes information about the user's simple goal.

    // Attributes --------------------------------------------------------------------------------------------------------------
    private bool _isComplete;


    // Constructors -----------------------------------------------------------------------------------------------------------
    public SimpleGoal(string name, string description, string points, bool isComplete) : base(name, description, points)
    {
        // Constructor that stores the simple goal information.
        // Is Complete?
        if (isComplete == true)
        {
            _isComplete = true;
        }
        else
        {
            _isComplete = false;
        }
    }


    // Methods ----------------------------------------------------------------------------------------------------------------
    public override int RecordEvent()
    {
        // Mark goal as complete.
        _isComplete = true;
        Console.WriteLine($"Congratulations! You've earned {base.GetPoints()} points!");

        // Returns the number of points earned.
        return int.Parse(base.GetPoints());
    }

    public override bool IsComplete()
    {
        // Returns whether the goal was completed or not.
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        // Get a representation of the goal in text format so that it can be saved/loaded to a file correctly.
        string stringRepresentation = $"SimpleGoal:{base.TextValidator(base.GetShortName())},{base.TextValidator(base.GetDescription())},{base.GetPoints()},{_isComplete}";
        return stringRepresentation;
    }
}