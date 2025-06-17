// To exceed requirements, I created a ranking system for users. The higher the user's score, the higher their rank.
// The menu also shows how many points they need to reach the next rank.
using System;

class Program
{
    static void Main(string[] args)
    {
        // Main Class
        GoalManager newGoalManager = new GoalManager();
        newGoalManager.Start();
    }
}