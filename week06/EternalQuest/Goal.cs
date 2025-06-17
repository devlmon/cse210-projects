using System;

public abstract class Goal
{
    // Abstract class that stores and processes information about the user's goals.

    // Attributes --------------------------------------------------------------------------------------------------------------
    private string _shortName;
    private string _description;
    private string _points;

    // Constructors -----------------------------------------------------------------------------------------------------------
    public Goal(string name, string description, string points)
    {
        // Constructor that stores the goal information.
        _shortName = name;
        _description = description;
        _points = points;
    }

    // Getters and Setters ----------------------------------------------------------------------------------------------------
    public string GetPoints()
    {
        // Get points to award for recording the goal.
        return _points;
    }

    public string GetShortName()
    {
        // Get goal short name.
        return _shortName;
    }

    public string GetDescription()
    {
        // Get goal description.
        return _description;
    }

    // Methods ----------------------------------------------------------------------------------------------------------------
    public abstract int RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        // Display the goal details in text format.
        if (IsComplete() == true)
        {
            // If it is complete, display the checkbox as checked.
            return $"[X] {_shortName} ({_description})";
        }
        else
        {
            // If it is not complete, display the checkbox as unchecked.
            return $"[ ] {_shortName} ({_description})";
        }
    }

    public abstract string GetStringRepresentation();

    protected string TextValidator(string text)
    {
        // Check that the text is formatted correctly for a file.
        if (text.Contains(",") || text.Contains("\""))
        {
            // If the text has special characters, the string is modified to be valid.
            text = text.Replace("\"", "%#");
            text = text.Replace(",","%*");
            return text;
        }
        else
        {
            // If the text does not contain any special characters, then the same text is returned.
            return text;
        }
    }
}