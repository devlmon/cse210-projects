using System;

public class Video
{
    // Class responsible for storing data related to videos.

    // Attributes --------------------------------------------------------------------------------------------------------------
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    private List<Comment> _comments = new List<Comment>();


    // Constructors -----------------------------------------------------------------------------------------------------------

    public Video(string title, string author, int seconds, string comments)
    {
        // Constructor that has parameters to store the data related to videos.
        _title = title;
        _author = author;
        _lengthInSeconds = seconds;

        // Split user comments.
        string[] userComment = comments.Split('\n');
        // Create instances of the Comment Class to store the user comments.
        foreach (string comment in userComment)
        {
            string[] commentData = comment.Split('|');
            Comment newComment = new Comment(commentData[0], commentData[1]);
            _comments.Add(newComment);
        }
    }


    // Getters and Setters ----------------------------------------------------------------------------------------------------
    public string GetTitle()
    {
        // Return the video title.
        return _title;
    }

    public string GetAuthor()
    {
        // Return the video author.
        return _author;
    }

    public int GetLengthInSeconds()
    {
        // Return the video length in seconds.
        return _lengthInSeconds;
    }


    // Methods ----------------------------------------------------------------------------------------------------------------
    public string GetComments()
    {
        // Return all the comments in a string.
        string comments = "";                            // <-- String that will be returned
        foreach (Comment comment in _comments)
        {
            comments = comments + $"{comment.GetUserName()}: {comment.GetUserComment()}\n";  // <-- Concatenate the strring with each user comment.
        }
        return comments;
    }

    public int GetNumberOfComments()
    {
        // Return the number of comments of the video.
        return _comments.Count;
    }
}