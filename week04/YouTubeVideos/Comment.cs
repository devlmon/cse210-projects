using System;

public class Comment
{
    // Class responsible for storing user comments.

    // Attributes --------------------------------------------------------------------------------------------------------------
    private string _userName;
    private string _userComment;


    // Constructors -----------------------------------------------------------------------------------------------------------

    public Comment(string name, string comment)
    {
        // Constructor that has parameters to store the user name and comment.
        _userName = name;
        _userComment = comment;

    }

    // Getters and Setters ----------------------------------------------------------------------------------------------------

    public string GetUserName()
    {
        // Return the user name.
        return _userName;
    }

    public string GetUserComment()
    {
        // Return the user comment.
        return _userComment;
    }

}