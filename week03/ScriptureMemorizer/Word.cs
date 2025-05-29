using System;

public class Word
{
    // Class responsible for storing and managing words.

    // Attributes --------------------------------------------------------------------------------------------------------------
    private string _text;
    private bool _isHidden;


    // Constructors -----------------------------------------------------------------------------------------------------------

    public Word(string text)
    {
        // Constructor that has a parameter to store the text of the word.
        _text = text;
        Show();
    }

    // Getters and Setters ----------------------------------------------------------------------------------------------------

    public void Hide()
    {
        // Setter: Set the word as hidden.
        _text = new string('_',_text.Length);
        _isHidden = true;
    }

    public bool IsHidden()
    {
        // Getter: Get the current status of the word.
        return _isHidden;
    }

    public string GetDisplayText()
    {
        // Getter: Get the text of the word.
        return _text;
    }

    // Methods ----------------------------------------------------------------------------------------------------------------

    private void Show()
    {
        // Set the text as visible.
        _isHidden = false;
    }

}