using System;

public class Entry
{
    // Class responsible for having stored and displaying the entries made by the user.

    // Attributes --------------------------------------------------------------------------------------------------------------
    public string _date;                //User entry data
    public string _promptText;
    public string _entryText;

    // Methods ----------------------------------------------------------------------------------------------------------------

    public void Display()
    {
        // Method in charge of displaying the stored entry data.
        Console.WriteLine($"\n[{_date}] {_promptText}\n - {_entryText}\n");
    }
}