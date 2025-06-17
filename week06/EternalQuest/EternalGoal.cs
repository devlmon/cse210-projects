using System;

public class EternalGoal : Goal
{
    // A child class that stores and processes information about the user's eternal goal.

    // Constructors -----------------------------------------------------------------------------------------------------------
    public EternalGoal(string name, string description, string points) : base(name, description, points){}


    // Methods ----------------------------------------------------------------------------------------------------------------
    public override int RecordEvent()
    {
        // Get the points for the goal but don't mark it as completed.
        Console.WriteLine($"Congratulations! You've earned {base.GetPoints()} points!");

        // Returns the number of points earned.
        return int.Parse(base.GetPoints());
    }

    public override bool IsComplete()
    {
        // The goal will never be complete.
        return false;
    }
    
    public override string GetStringRepresentation()
    {
        // Get a representation of the goal in text format so that it can be saved/loaded to a file correctly.
        string stringRepresentation = $"EternalGoal:{base.TextValidator(base.GetShortName())},{base.TextValidator(base.GetDescription())},{base.GetPoints()}";
        return stringRepresentation;
    }
}