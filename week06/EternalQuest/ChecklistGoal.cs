using System;

public class ChecklistGoal : Goal
{
    // A child class that stores and processes information about the user's checklist goal.

    // Attributes --------------------------------------------------------------------------------------------------------------
    private int _amountCompleted;
    private int _target;
    private int _bonus;


    // Constructors -----------------------------------------------------------------------------------------------------------
    public ChecklistGoal(string name, string description, string points, int amountCompleted, int target, int bonus) : base(name, description, points)
    {
        // Constructor that stores the checklist goal information.
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }


    // Methods ----------------------------------------------------------------------------------------------------------------
    public override int RecordEvent()
    {
        // Mark the goal as achieved once again.
        _amountCompleted = _amountCompleted + 1;

        if (_amountCompleted == _target)
        {
            // If the goal was achieved as many times as the objective indicated, then give the bonus for full completion.
            Console.WriteLine($"Amazing! You've earned {base.GetPoints()} points!");
            Console.WriteLine($"My sincere congratulations!! You have accomplished a great feat by completing this goal in its entirety. You get a bonus of {_bonus} points!");

            // Returns the number of points earned.
            return int.Parse(base.GetPoints()) + _bonus;
        }
        else
        {
            // If the goal has not yet been fully completed, only award the points without the bonus.
            return int.Parse(base.GetPoints());
        }
    }

    public override bool IsComplete()
    {
        // Return whether the goal was fully completed or not.
        if (_amountCompleted == _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetDetailsString()
    {
        // Display the goal details in text format.
        if (IsComplete() == true)
        {
            // If it is complete, display the checkbox as checked.
            return $"[X] {base.GetShortName()} ({base.GetDescription()}) -- Currently completed {_amountCompleted}/{_target}";
        }
        else
        {
            // If it is not complete, display the checkbox as unchecked.
            return $"[ ] {base.GetShortName()} ({base.GetDescription()}) -- Currently completed {_amountCompleted}/{_target}";
        }
    }

    public override string GetStringRepresentation()
    {
        // Get a representation of the goal in text format so that it can be saved/loaded to a file correctly.
        string stringRepresentation = $"ChecklistGoal:{base.TextValidator(base.GetShortName())},{base.TextValidator(base.GetDescription())},{base.GetPoints()},{_amountCompleted},{_target},{_bonus}";
        return stringRepresentation;
    }
}