using System;

public class MathAssigment : Assigment
{
    // Child class responsible for storing data related to math assigments.

    // Attributes --------------------------------------------------------------------------------------------------------------
    private string _textbookSection;
    private string _problems;


    // Constructors -----------------------------------------------------------------------------------------------------------

    public MathAssigment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        // Store the textbook section and problems of the assigment.
        _textbookSection = textbookSection;
        _problems = problems;
    }


    // Methods ----------------------------------------------------------------------------------------------------------------
    public string GetHomeworkList()
    {
        // Return the Homework List.
        return _textbookSection + " " + _problems;
    }
}