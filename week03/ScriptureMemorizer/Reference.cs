using System;

public class Reference
{
    // Class responsible for storing and managing the reference.

    // Attributes --------------------------------------------------------------------------------------------------------------
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;


    // Constructors -----------------------------------------------------------------------------------------------------------

    public Reference(string book, int chapter, int verse)
    {
        // Constructor that has parameters to store the scripture book, chapter, and verse.
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = -1;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        // Constructor that has parameters to store the scripture book, chapter, start and end verses.
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    // Methods ----------------------------------------------------------------------------------------------------------------

    public string GetDisplayText()
    {
        // Return the text of the reference...
        if (_endVerse != -1)
        {
            // ... If it is a long reference
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
        else
        {
            // ... If it is not a long reference
            return $"{_book} {_chapter}:{_verse}";
        }
    }

}