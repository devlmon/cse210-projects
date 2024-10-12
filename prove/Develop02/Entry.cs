public class Entry{
    //Attributes
    public string _date;
    public string _promptText;
    public string _entryText;

    //methods
    public void Display(){
        //Display the date, prompt, and response recorded
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"{_entryText}\n");
    }
}