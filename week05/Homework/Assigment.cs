using System;

public class Assigment
{
    // Class responsible for storing general data related to assigments.

    // Attributes --------------------------------------------------------------------------------------------------------------
    private string _studentName;
    private string _topic;


    // Constructors -----------------------------------------------------------------------------------------------------------

    public Assigment(string studentName, string topic)
    {
        // Store the student name and topic of the assigment.
        _studentName = studentName;
        _topic = topic;
    }


    // Getters and Setters ----------------------------------------------------------------------------------------------------

    public string GetStudentName()
    {
        // Getter: Get the student name.
        return _studentName;
    }

    // Methods ----------------------------------------------------------------------------------------------------------------
    public string GetSummary()
    {
        // Return the Summary.
        return _studentName + " - " + _topic;
    }
}