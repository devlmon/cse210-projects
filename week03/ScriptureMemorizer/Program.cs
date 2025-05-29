// To exceed the requirements, I have created a new Class that chooses scriptures at random to present to the user.
using System;

class Program
{
    static void Main(string[] args)
    {
        // Main class

        // Get a Random Scripture
        RandomScripture newRandomScripture = new RandomScripture();

        string referenceOfScrpiture = newRandomScripture.GetRandomReference();
        string textOfScripture = newRandomScripture.GetRandomText();

        // Create the new instance of the class to store and handle the scripture and a variable for the input.
        Scripture newScripture = new Scripture(referenceOfScrpiture,textOfScripture);
        string userInput;
        do
        {
            // Displays the scripture and the question for the user.
            Console.Clear();                     // Clear the console
            Console.WriteLine($"{newScripture.GetDisplayText()}");
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            userInput = Console.ReadLine();      // Read the input
            newScripture.HideRandomWords(3);     // Hide random words
        } while (!newScripture.IsCompletelyHidden() && !(userInput.ToLower() == "quit"));
    }
}