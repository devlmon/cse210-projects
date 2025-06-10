using System;

public class BreathingActivity : Activity
{
    // Child class responsible for storing and showing data related to the breathing activity.

    // Constructors -----------------------------------------------------------------------------------------------------------

    public BreathingActivity()
    {
        // Store the name, description, and duration of the breathing activity.
        base.SetName("Breathing Activity");
        base.SetDescription("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        base.SetDuration(0);   // <- Default value
    }


    // Methods ----------------------------------------------------------------------------------------------------------------

    public void Run()
    {
        // Execute the breathing activity.
        base.DisplayStartingMessage();

        // Start the time.
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(base.GetDuration());

        // Repeat until time runs out.
        do
        {
            Console.Write("Breathe in...");
            base.ShowCountDown(GetRepTime(endTime));
            Console.WriteLine();

            Console.Write("Now breathe out...");
            base.ShowCountDown(GetRepTime(endTime));
            Console.WriteLine("\n");

        } while (DateTime.Now < endTime);

        // End the activity.
        base.DisplayEndingMessage();
    }
    private int GetRepTime(DateTime endTime)
    {
        // Get the amount of seconds to wait for the next step of the activity.
        TimeSpan difference = endTime - DateTime.Now;                    // <- Calculate how much time is left in the activity.
        int secondsUntilEnd = (int)difference.TotalSeconds + 1;
        
        if (secondsUntilEnd % 5 == 0)                                    // <- If the division is exact, the number is chosen.
        {
            return 5;
        }
        if (secondsUntilEnd % 4 == 0)
        {
            return 4;
        }
        else if (secondsUntilEnd % 2 == 0)
        {
            return 2;
        }
        else
        {
            return 1;
        }
    }
}