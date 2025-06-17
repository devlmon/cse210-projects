using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.IO;
using System.Reflection.Metadata;

public class GoalManager
{
    // Class responsible for storing, displaying, and processing information about user goals.

    // Attributes --------------------------------------------------------------------------------------------------------------
    private List<Goal> _goalList = new List<Goal>();
    private int _score;
    private string _playerRank;
    private int _nextRankIn;


    // Constructors -----------------------------------------------------------------------------------------------------------
    public GoalManager()
    {
        // Initializes the goal manager with default values.
        _score = 0;
        _playerRank = "Newbie Goalseeker";
        _nextRankIn = 250;
    }


    // Methods ----------------------------------------------------------------------------------------------------------------
    public void Start()
    {
        // This is the "main" function for this class. It is called by Program.cs, and then runs the menu loop.
        string userInput;          // <- Variable to store user input within the loop.
        Console.Clear();

        do
        {
            // Displays player information.
            RankCheck();
            DisplayPlayerInfo();
            Console.WriteLine();

            // Show the menu.
            Console.WriteLine("Menu Options:\n\t1. Create New Goal\n\t2. List Goals\n\t3. Save Goals\n\t4. Load Goals\n\t5. Record Event\n\t6. Quit");
            Console.Write("Select a choice from the menu: ");
            userInput = Console.ReadLine();   // <- Get user input.
            Console.WriteLine();

            // Perform the player's request.
            switch (userInput)
            {
                case "1":
                    // Create a new goal for the user.
                    CreateGoal();
                    break;

                case "2":
                    // Display the list of goals.
                    ListGoalDetails();
                    break;

                case "3":
                    // Create/overwrite a file to save the user's goals.
                    SaveGoals();
                    break;

                case "4":
                    // Load user goals from a file.
                    LoadGoals();
                    break;

                case "5":
                    // Mark a goal as complete/done.
                    RecordEvent();
                    Console.WriteLine($"You currently have {_score} points!");
                    break;

                case "6":
                    // The program ends.
                    Console.WriteLine("\nHave a successful day!");
                    break;

                default:
                    // The user entered an invalid option.
                    Console.WriteLine("\nThat is not a valid option. Please select a valid option.");
                    Thread.Sleep(6000);
                    break;
            }
            Console.WriteLine("\n\n");
        } while (userInput != "6");
    }

    public void DisplayPlayerInfo()
    {
        // Displays the user's points.
        Console.WriteLine($"You have {_score} points.");
        Console.WriteLine($"Your current rank is {_playerRank}!");
        Console.WriteLine($"You are {_nextRankIn} points away from your next rank.");
    }

    public void ListGoalNames()
    {
        // Display just the names of the goals.
        if (_goalList.Count() == 0)
        {
            // If there are no goals, nothing is displayed.
            Console.WriteLine("There are no goals recorded.");
        }
        else
        {
            // If there are goals, a list of names is displayed.
            int i = 1;
            Console.WriteLine("The goals are:");

            foreach (Goal goal in _goalList)
            {
                Console.WriteLine($"{i}. {goal.GetShortName()}");
                i++;
            }
        }
    }

    public void ListGoalDetails()
    {
        // Display the details of the goals.
        if (_goalList.Count() == 0)
        {
            // If there are no goals, nothing is displayed.
            Console.WriteLine("There are no goals recorded.");
        }
        else
        {
            // If there are goals, a list with the details of each goal is displayed.
            int i = 1;
            Console.WriteLine("The goals are:");

            foreach (Goal goal in _goalList)
            {
                Console.WriteLine($"{i}. {goal.GetDetailsString()}");
                i++;
            }
        }
    }

    public void CreateGoal()
    {
        // Create a new goal for the user.
        // Show options.
        Console.WriteLine("The types of Goals are:\n\t1. Simple Goal\n\t2. Eternal Goal\n\t3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string userInput = Console.ReadLine();   // <- Get user input.



        // Create the new goal depending on the option chosen by the user.
        if (userInput == "1" || userInput == "2" || userInput == "3")
        {
            // Obtain the data for the new goal.
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();

            Console.Write("What is a short descripion of it? ");
            string description = Console.ReadLine();

            Console.Write("What is the amount of points associated with this goal? ");
            string points = Console.ReadLine();

            // Create the new goal. 
            Goal newGoal;
            if (userInput == "1")
            {
                // 1 = Simple Goal.
                newGoal = new SimpleGoal(name, description, points, false);
            }
            else if (userInput == "2")
            {
                // 2 = Eternal Goal.
                newGoal = new EternalGoal(name, description, points);
            }
            else
            {
                // 3 = Checklist Goal.
                // Get extra data for the goal.
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());

                newGoal = new ChecklistGoal(name, description, points, 0, target, bonus);
            }

            // Add goal to the list.
            _goalList.Add(newGoal);
        }
        else
        {
            // The user entered an invalid option.
            Console.WriteLine("\nThat is not a valid option. Please select a valid option next time.");
            Thread.Sleep(6000);
        }
    }

    public void RecordEvent()
    {
        // Mark a goal as complete/done.
        // Show registered goals.
        ListGoalNames();

        Console.Write("Which goal did you accomplish? ");
        string userInput = Console.ReadLine();            // <- Get user input.

        if (int.TryParse(userInput, out int userInputNumber))
        {
            // If the input entered is in the correct range
            if (userInputNumber > 0 && userInputNumber <= _goalList.Count())
            {
                if (_goalList[userInputNumber - 1].IsComplete() != true)
                {
                    // Record the goal indicated by the user, and increase their points.
                    _score = _score + _goalList[userInputNumber - 1].RecordEvent();
                }
                else
                {
                    // If the goal has already been completed, nothing is done.
                    Console.WriteLine("\nThat goal has already been completed.");
                    Thread.Sleep(6000);
                }

            }
            else
            {
                // The user entered an invalid option.
                Console.WriteLine("\nThat is not a valid option. Please select a valid option next time.");
                Thread.Sleep(6000);
            }

        }
        else
        {
            // The user entered an invalid option.
            Console.WriteLine("\nThat is not a valid option. Please select a valid option next time.");
            Thread.Sleep(6000);
        }
    }

    public void SaveGoals()
    {
        // Create/overwrite a file to save the user's goals.
        Console.WriteLine("What is the filename for the goal file? (Please make sure the file extension is .txt)");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            // Create the file
            outputFile.WriteLine(_score);

            foreach (Goal goal in _goalList)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        // Load user goals from a file.
        Console.WriteLine("What is the filename for the goal file? (Please make sure the file extension is .txt)");
        string fileName = Console.ReadLine();

        // Verify that the user has entered the name correctly.
        try
        {
            // Get information from the file.
            string[] lines = File.ReadAllLines(fileName);
            bool isFirstLine = true;

            foreach (string line in lines)
            {
                // Loop to read the entire file.
                if (isFirstLine)
                {
                    // If it is the first line, get it and record the score.
                    _score = int.Parse(line);
                    isFirstLine = false;
                }
                else
                {
                    // If it is not the first line, read the user's goal data line by line.
                    // Split up the info.
                    string[] goalData = line.Split(":");
                    string[] goalDetails = goalData[1].Split(",");

                    // Prepare the goal that has been read.
                    Goal newGoal;

                    if (goalData[0] == "SimpleGoal")
                    {
                        // If it is a simple goal: SimpleGoal(name,description,points,isComplete)
                        newGoal = new SimpleGoal(TextValidator(goalDetails[0]), TextValidator(goalDetails[1]), goalDetails[2], bool.Parse(goalDetails[3]));
                    }
                    else if (goalData[0] == "EternalGoal")
                    {
                        // If it is an eternal goal: EternalGoal(name,description,points)
                        newGoal = new EternalGoal(TextValidator(goalDetails[0]), TextValidator(goalDetails[1]), goalDetails[2]);
                    }
                    else
                    {
                        // If it is a checklist goal: ChecklistGoal(name,description,points,amountComplete,target,bonus)
                        newGoal = new ChecklistGoal(TextValidator(goalDetails[0]), TextValidator(goalDetails[1]), goalDetails[2], int.Parse(goalDetails[3]), int.Parse(goalDetails[4]), int.Parse(goalDetails[5]));
                    }
                    // Add the goal that has been read to the list.
                    _goalList.Add(newGoal);
                }
            }
        }
        catch (System.Exception)
        {
            // If the user has not done so, the error is indicated.
            Console.WriteLine($"Error loading file: {fileName}. Verify the name and try again.\n");
            Thread.Sleep(6000);
        }
    }

    protected string TextValidator(string text)
    {
        // Check that the text is formatted correctly.
        if (text.Contains("%#") || text.Contains("%*"))
        {
            // If the text has special characters, the string is modified to be valid.
            text = text.Replace("%#", "\"");
            text = text.Replace("%*", ",");
            return text;
        }
        else
        {
            // If the text does not contain any special characters, then the same text is returned.
            return text;
        }
    }

    protected void RankCheck()
    {
        // Check the user's rank and how many score points they need to reach the next rank.
        if (_score >= 250 && _score < 725)
        {
            _playerRank = "Novice Goalseeker";
            _nextRankIn = 725 - _score;
        }
        else if (_score >= 725 && _score < 2670)
        {
            _playerRank = "Apprentice Goalseeker";
            _nextRankIn = 2670 - _score;
        }
        else if (_score >= 2670 && _score < 6015)
        {
            _playerRank = "Trained Goalseeker";
            _nextRankIn = 6015 - _score;
        }
        else if (_score >= 6015 && _score < 13900)
        {
            _playerRank = "Expert Goalseeker";
            _nextRankIn = 13900 - _score;
        }
        else if (_score >= 13900 && _score < 25435)
        {
            _playerRank = "Master Goalseeker";
            _nextRankIn = 25435 - _score;
        }
        else if (_score >= 25435 && _score < 59100)
        {
            _playerRank = "Legendary Goalseeker";
            _nextRankIn = 59100 - _score;
        }
        else if (_score >= 59100 && _score < 999999999)
        {
            _playerRank = "The Goalseeker";
            _nextRankIn = 999999999;
            Console.WriteLine("I don't think you even need this program anymore");
        }
        else
        {
            _nextRankIn = 250 - _score;
        }
    }
}