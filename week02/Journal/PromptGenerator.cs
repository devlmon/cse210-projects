using System;

public class PromptGenerator
{
    // Class in charge of generating random prompts

    // Attributes --------------------------------------------------------------------------------------------------------------
    public List<string> _prompts = new List<string>()                                // List to save prompts
    {
        "\"Did anything surprise me today, good or bad?\"",                              // 8 reflective prompts
        "\"What small win or progress did I make today?\"",                              // All initialized from the very beginning.
        "\"What's one thing I learned today (about myself, others, or the world)?\"",
        "\"How did I show kindness (to myself or others) today?\"",
        "\"What challenged me today, and how did I handle it?\"",
        "\"Did i do something today that I'm proud of?\"",
        "\"What made me smile or laugh today?\"",
        "\"Who or what am I grateful for from today?\""
    };       

    // Methods ----------------------------------------------------------------------------------------------------------------

    public string GetRandomPrompt()
    {
        // Method that returns a random prompt.
        // Variables -> randomNumber

        Random randomGenerator = new Random();              // Instance of the Random Class
        int randomNumber = randomGenerator.Next(0, 8);      // Initialize the randomNumber variable (From 0 to 7)

        return _prompts[randomNumber];                      // <- Return the prompt that is in the index equal to the random number.
    }
}