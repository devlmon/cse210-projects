using System;

class Program
{
    static void Main(string[] args)
    {
        // Main Class
        List<Activity> activityList = new List<Activity>();

        RunningActivity newRunningActivity = new RunningActivity("03 Nov 2022", "30", "3.0");
        activityList.Add(newRunningActivity);

        CyclingActivity newCyclingActivity = new CyclingActivity("11 Nov 2022", "40", "25.4");
        activityList.Add(newCyclingActivity);

        SwimmingActivity newSwimmingActivity = new SwimmingActivity("15 Nov 2022", "60", "6");
        activityList.Add(newSwimmingActivity);


        Console.Clear();
        foreach (Activity activity in activityList)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
    }
}