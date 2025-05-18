using System;
using System.IO.Enumeration;
using Microsoft.VisualBasic.FileIO;

public class Journal
{
    // Class in charge of the program journal.

    // Attributes --------------------------------------------------------------------------------------------------------------

    public List<Entry> _entries = new List<Entry>();               // List of entries (Journal Data)

    // Methods ----------------------------------------------------------------------------------------------------------------

    public void AddEntry(Entry newEntry)
    {
        // Method for adding new entries to the journal
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        // Method in charge of displaying all journal entries that currently exist in the _entries attribute.
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        // Method to store (in a .csv file) all entries that currently exist in the _entries attribute.
        using (StreamWriter writer = new StreamWriter(file))
        {
            // Initial line of the file.csv
            writer.WriteLine($"date,entryText,prompt");
            
            // For each entry in the journal, write a new line in the file.csv
            foreach (Entry entry in _entries)
            {
                string validEntryText = "";
                // If the user entry has these special characters, the string is modified to be valid.
                if (entry._entryText.Contains(",") || entry._entryText.Contains("\"") || entry._entryText.Contains("\r") || entry._entryText.Contains("\n"))
                {
                    validEntryText = "\"" + entry._entryText.Replace("\"", "\"\"") + "\"";
                }
                else // Otherwise, only new quotation marks are added.
                {
                    validEntryText = "\"" + entry._entryText + "\"";
                }

                writer.WriteLine($"{entry._date},{validEntryText},{entry._promptText}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        // Method to load all entries that currently exist in a .csv file.
        try
        {
            bool isFirstLine = true;                                            // <- This variable is to skip the first line in the document (the header)

            using (TextFieldParser reader = new TextFieldParser(file))          // <- Using the TextFieldParser I can read with ease the csv document
            {
                reader.TextFieldType = FieldType.Delimited;                     // <- Set the TextFieldParser to read correctly the csv file.
                reader.SetDelimiters(",");
                reader.HasFieldsEnclosedInQuotes = true;

                // Loop every line in the document to read all the information and create in the program the journal again.
                while (!reader.EndOfData)
                {
                    string[] field = reader.ReadFields(); // Read the line

                    // If this is the first time reading the document, skip the line, because I don't want to save the header of the document.
                    if (isFirstLine)
                    {
                        isFirstLine = false;
                        continue;
                    }

                    Entry newEntry = new Entry();                             // Create the Entry of the data read.
                    newEntry._date = field[0];                                // Save the date
                    newEntry._entryText = "\"" + field[1] + "\"";             // Save the entry text
                    newEntry._promptText = "\"" + field[2] + "\"";            // Save the prompt
                    AddEntry(newEntry);                                       // Save the entry
                }


            }
        }
        catch (System.Exception)                                     // If there is an error, report the error.
        {
            Console.WriteLine($"Error loading file: {file}. Verify the name and try again.\n");
        }
    }
}