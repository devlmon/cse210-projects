using System;

public class ListingActivity : Activity
{
    // Child class responsible for storing and showing data related to the listing activity.

    // Attributes --------------------------------------------------------------------------------------------------------------
    private int _count;
    private List<string> _prompts = new List<string>();
    private List<int> _usedPrompts = new List<int>();


    // Constructors -----------------------------------------------------------------------------------------------------------

    public ListingActivity()
    {
        // Store the data of the listing activity.
        // Name, Description, Duration
        base.SetName("Listing Activity");
        base.SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        base.SetDuration(0);   // <- Default value

        // Prompts
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of your?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");

    }


    // Methods ----------------------------------------------------------------------------------------------------------------

    public void Run()
    {
        // Execute the listing activity.
        base.DisplayStartingMessage();

        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($" --- {GetRandomPrompt()} ---");

        Console.Write("You may begin in: ");
        base.ShowCountDown(6);
        Console.WriteLine();

        // Get how many responses the user wrote.
        _count = GetListFromUser().Count;
        Console.WriteLine($"You listed {_count} items!");

        // End the activity.
        Console.WriteLine();
        base.DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        // Search for a random prompt that has not been repeated before.
        bool readyToContinue = false;
        int selectedPrompt;

        do
        {
            // Loop that will repeat until a previously undisplayed prompt is obtained.
            Random randomGenerator = new Random();
            selectedPrompt = randomGenerator.Next(0, _prompts.Count);

            // If all prompts have already been used, reuse them all.
            if (_prompts.Count == _usedPrompts.Count)
            {
                _usedPrompts.Clear();
            }


            // If the prompt has not been shown before, it is chosen.
            if (!_usedPrompts.Contains(selectedPrompt))
            {
                readyToContinue = true;
                _usedPrompts.Add(selectedPrompt);
            }
        } while (readyToContinue != true);

        return _prompts[selectedPrompt];
    }

    public List<string> GetListFromUser()
    {
        // Loop to save in a list he user's answers until the time is up.
        List<string> listFromUser = new List<string>();

        // Start the time.
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(base.GetDuration());

        // Repeat until time runs out.
        do
        {
            Console.Write(" > ");
            listFromUser.Add(Console.ReadLine());

        } while (DateTime.Now < endTime);

        return listFromUser;    // <- Return the list.
    }
}