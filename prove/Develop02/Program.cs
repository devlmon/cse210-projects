using System;

class Program
{
    static void Main(string[] args)
    {
        //Preparing the Journal class and PromptGeneretor class for use.
        Journal userJournal = new Journal();
        PromptGenerator prompt = new PromptGenerator();

        //Main loop of the program menu.
        string userInput = "0";
        do {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            userInput = Console.ReadLine();

            //Write
            if (userInput == "1") {
                //Get a random prompt from the class PromptGeneretor
                string promptForUser = prompt.GetRandomPrompt();
                Console.WriteLine($"{promptForUser}");
                Console.Write("> ");

                //Get user response.
                string userResponse = Console.ReadLine();

                //Save entry in new object and add it to the list.
                Entry newEntry = new Entry();

                newEntry._entryText = userResponse;                       //User response to the prompt
                newEntry._promptText = promptForUser;                     //Prompt that the user has answered
                DateTime theCurrentTime = DateTime.Now;                   //Today's date
                newEntry._date = theCurrentTime.ToShortDateString();      //Today's date

                userJournal.AddEntry(newEntry);
            }
            //Display
            else if (userInput == "2"){
                //Show all user entries.
                userJournal.DisplayAll();
            }
            //Load
            else if (userInput == "3"){
                //Ask for the name of the file to load
                Console.WriteLine("What is the filename? (the filename always ends with .csv)");
                string userFilename = Console.ReadLine();

                //Load the file.
                userJournal.LoadFromFile(userFilename);
            }
            //Save
            else if (userInput == "4"){
                //Ask for the name of the file to save.
                Console.WriteLine("What is the filename? (please end the filename with .csv)");
                string userFilename = Console.ReadLine();

                //Save the file.
                userJournal.SaveToFile(userFilename);
            }
            //Type error.
            else if (userInput != "5"){
                Console.WriteLine("\nOption typed incorrectly. Please only enter the menu options.\n");
            }
        } while (userInput != "5");

        PromptGenerator newPrompt = new PromptGenerator();
        newPrompt.GetRandomPrompt();
    }
}