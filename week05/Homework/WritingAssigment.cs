using System;

public class WritingAssigment : Assigment
{
    // Child class responsible for storing data related to writing assigments.

    // Attributes --------------------------------------------------------------------------------------------------------------
    private string _title;


    // Constructors -----------------------------------------------------------------------------------------------------------

    public WritingAssigment(string studentName, string topic, string title) : base(studentName, topic)
    {
        // Store the title of the assigment.
        _title = title;
    }


    // Methods ----------------------------------------------------------------------------------------------------------------
    public string GetWritingInformation()
    {
        // Return the Writing Information.
        return _title + " by " + base.GetStudentName();
    }
}