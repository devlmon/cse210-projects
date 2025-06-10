using System;
using System.ComponentModel;

public class Activity
{
    // Class responsible for storing and showing general data related to mindfull activities.

    // Attributes --------------------------------------------------------------------------------------------------------------
    private string _name;
    private string _description;
    private int _duration;


    // Constructors -----------------------------------------------------------------------------------------------------------

    public Activity()
    {
        // Store the student name, topic, and duration of the assigment. (Default values)
        _name = "Default Activity";
        _description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna.";
        _duration = 0;
    }


    // Getters and Setters ----------------------------------------------------------------------------------------------------

    public string GetName()
    {
        // Getter: Get the activity name.
        return _name;
    }

    public string GetDescription()
    {
        // Getter: Get the activity description.
        return _description;
    }

    public void SetName(string name)
    {
        // Setter: Set the activity name.
        _name = name;
    }

    public void SetDescription(string description)
    {
        // Setter: Set the activity description.
        _description = description;
    }

    public void SetDuration(int duration)
    {
        // Setter: Set the activity description.
        _duration = duration;
    }
    public int GetDuration()
    {
        // Getter: Get the activity duration.
        return _duration;
    }

    // Methods ----------------------------------------------------------------------------------------------------------------

    public void DisplayStartingMessage()
    {
        // Show the starting message of the activity.
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.\n");
        Console.WriteLine($"{_description}\n");

        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        
        Console.Clear();

        Console.WriteLine("Get Ready...");
        ShowSpinner(4);
        Console.WriteLine("");
    }

    public void DisplayEndingMessage()
    {
        // Show the ending message of the activity.
        Console.WriteLine("Well done!!");
        ShowSpinner(3);
        Console.WriteLine();

        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(6);

        Console.Clear();
    }

    public void ShowSpinner(int seconds = 0)
    {
        // Loop that will repeat for n seconds, displaying a spinner on the screen.
        DateTime startTime = DateTime.Now;                                      // <- Variables storing the time
        DateTime endTime = startTime.AddSeconds(seconds);

        string[] spinnerCharacters = ["|", "/", "-", "\\", "|", "/", "-", "\\"];     // <- Array storing the characters of the spinner
        int iterator = 0;                                                       // <- Iterator that indicates the character to be displayed in the spinner

        do
        {
            Console.Write(spinnerCharacters[iterator]);   // <- Write the new character
            iterator++;

            Thread.Sleep(350);
            Console.Write("\b \b");                       // <- Erase the previous character

            if (iterator > 7)                             // <- If the array reaches the end, start again
            {
                iterator = 0;
            }
        } while (DateTime.Now < endTime);
    }

    public void ShowCountDown(int seconds)
    {
        // Loop that will repeat for n seconds, displaying a count down on the screen.
        DateTime startTime = DateTime.Now;                                      // <- Variables storing the time
        DateTime endTime = startTime.AddSeconds(seconds);

        int second = seconds;                                                   // <- Variable storing the current second of the count down

        do
        {
            Console.Write(second);     // <- Write the new character
            second--;

            Thread.Sleep(1000);
            Console.Write("\b \b");    // <- Erase the previous character

        } while (DateTime.Now < endTime);
    }
}