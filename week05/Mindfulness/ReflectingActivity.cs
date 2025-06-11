using System;

public class ReflectingActivity : Activity
{
    // Child class responsible for storing and showing data related to the reflecting activity.

    // Attributes --------------------------------------------------------------------------------------------------------------
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();
    private List<int> _usedPrompts = new List<int>();    // <- Create new lists to store what prompts and questions have been used.
    private List<int> _usedQuestions = new List<int>();


    // Constructors -----------------------------------------------------------------------------------------------------------

    public ReflectingActivity()
    {
        // Store the data of the reflecting activity.
        // Name, Description, Duration
        base.SetName("Reflecting Activity");
        base.SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        base.SetDuration(0);   // <- Default value

        // Prompts
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        // Questions
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you fell when it was complete?");
        _questions.Add("What made his time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you lear from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }


    // Methods ----------------------------------------------------------------------------------------------------------------

    public void Run()
    {
        // Execute the reflecting activity.
        base.DisplayStartingMessage();
        DisplayPrompt();

        Console.Write("Now ponder on each of the following questions as they related to this experience.\nYou may beging in: ");
        base.ShowCountDown(5);

        Console.Clear();

        // Start the time.
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(base.GetDuration());

        // Repeat until time runs out.
        do
        {
            DisplayQuestions();
            base.ShowSpinner(10);
            Console.WriteLine();

        } while (DateTime.Now < endTime);

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

    public string GetRandomQuestion()
    {
        // Search for a random question that has not been repeated before.
        bool readyToContinue = false;
        int selectedQuestion;

        do
        {
            // Loop that will repeat until a previously undisplayed question is obtained.
            Random randomGenerator = new Random();
            selectedQuestion = randomGenerator.Next(0, _questions.Count - 1);

            // If all questions have already been used, reuse them all.
            if (_questions.Count == _usedQuestions.Count)
            {
                _usedQuestions.Clear();
            }


            // If the question has not been shown before, it is chosen.
            if (!_usedQuestions.Contains(selectedQuestion))
            {
                readyToContinue = true;
                _usedQuestions.Add(selectedQuestion);
            }
        } while (readyToContinue != true);

        return _questions[selectedQuestion];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"Consider the following prompt:\n\n --- {GetRandomPrompt()} ---\n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
    }

    public void DisplayQuestions()
    {
        Console.Write($" > {GetRandomQuestion()} ");
    }
}