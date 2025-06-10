// To exceed the requirements, I made sure that no random prompts/quetions were re-selected until all had been used at least once in the session.
using System;

class Program
{
    static void Main(string[] args)
    {
        // Main Class
        int userInput = 0;
        do
        {
            // Show Menu
            Console.Clear();
            Console.WriteLine("Menu Options:\n\t1. Start breathing activity.\n\t2. Start reflecting activity\n\t3. Start listing activity\n\t4. Quit");
            Console.Write("Select a choice from the menu: ");
            userInput = int.Parse(Console.ReadLine());  // <- Save user input

            // Direct the program to the activity chosen by the user.
            if (userInput == 1)
            {
                BreathingActivity _newBreathingActivity = new BreathingActivity();
                _newBreathingActivity.Run();
            }
            else if (userInput == 2)
            {
                ReflectingActivity _reflectingActivity = new ReflectingActivity();
                _reflectingActivity.Run();
            }
            else if (userInput == 3)
            {
                ListingActivity _newListingActivity = new ListingActivity();
                _newListingActivity.Run();
            }
            else if (userInput != 4)
            {
                Console.WriteLine("Error: Wrong Option");
                Console.ReadLine();
            }
        } while (userInput != 4);
    }
}