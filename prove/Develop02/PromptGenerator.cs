public class PromptGenerator{
    //attributes
    public List<string> _prompts = new List<string>();

    //methods
    public string GetRandomPrompt(){
        //List of prompts
        _prompts.Add("What Scripture passage did you read today?");
        _prompts.Add("What was your favorite meal today?");
        _prompts.Add("Were you able to spend time today on your hobbies?");
        _prompts.Add("Did the work go smoothly?");
        _prompts.Add("Did you go out for a walk?");
        _prompts.Add("How are your pets today?");

        //Choose randomly the number of the prompt to use.
        Random random = new Random();
        int selectedPrompt = random.Next(1, _prompts.Count);

        //Return the selected prompt.
        return _prompts[selectedPrompt];
    }
}