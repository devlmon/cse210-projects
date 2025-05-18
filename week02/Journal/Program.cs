// To exceed the requirements, I improve the process of saving and loading to save as a .csv file that could be opened in Excel.
using System;

class Program
{
    static void Main(string[] args)
    {
        // Main Class
        // Variables -> userMenuInput

        string userMenuInput = "-1";                                         // Initialize the variable userMenuInput before starting the loop
        Journal theJournal = new Journal();                                  // Creating an instance of the Journal Class before starting the loop
        PromptGenerator newPromptGenerator = new PromptGenerator();          // Creating an instance of the PromptGenerator Class before starting the loop
        
        Console.WriteLine(" -- Journal Project -----------------------");    // Display menu at the beggining of the program.

        // A loop starts. At each repetition the user is shown the menu options, when the user chooses an option the program continues.
        do
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1: Add Entry to the Journal.");
            Console.WriteLine("2: Display the Journal.");
            Console.WriteLine("3: Save the Journal.");
            Console.WriteLine("4: Load the Journal.");
            Console.WriteLine("0: Exit the program.");

            Console.Write("Type your choice (From 0 to 4): ");
            userMenuInput = Console.ReadLine();

            // A switch to handle each of inputs that the user can give.
            switch (userMenuInput)
            {
                case "1":
                    // When the user wants to add a new entry
                    string newPrompt = newPromptGenerator.GetRandomPrompt();   // Get a random prompt
                    Console.WriteLine($"\n{newPrompt}");                       // Print the Prompt
                    Console.Write(" - ");

                    Entry newEntry = new Entry();                              // Create the new Entry
                    newEntry._date = DateTime.Now.ToString("MM-dd-yyyy");      // Get the current date
                    newEntry._entryText = Console.ReadLine();                  // Get the user response
                    newEntry._promptText = newPrompt;                          // Save the prompt

                    theJournal.AddEntry(newEntry);                             // Save the new Entry
                    Console.WriteLine();
                    break;

                case "2":
                    // When the user wants to see all the Journal
                    theJournal.DisplayAll();
                    break;

                case "3":
                    // When the user wants to save the Journal
                    Console.Write("Type the name of the file (plase add .csv to the end of the name): ");
                    string newFileName = Console.ReadLine();
                    theJournal.SaveToFile(newFileName);
                    Console.WriteLine("File saved!\n");
                    break;

                case "4":
                    // When the user wants to load the Journal
                    Console.Write("Type the name of the file (plase add .csv to the end of the name): ");
                    string fileName = Console.ReadLine();
                    theJournal.LoadFromFile(fileName);
                    Console.WriteLine();
                    break;

                case "0":
                    // When the user wants to exit the program
                    Console.WriteLine("Thank you for using the program!");
                    break;

                default:
                    // When the user has not entered a valid option. 
                    Console.WriteLine("Please, type a valid option.\n");
                    break;
            }
        } while (userMenuInput != "0");                                     // When the user types 0 the program terminates.
    }
}