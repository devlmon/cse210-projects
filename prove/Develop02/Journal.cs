using System.IO;

public class Journal{
    //Attributes
    public List<Entry> _entries = new List<Entry>();

    //Methods
    public void AddEntry(Entry newEntry){
        _entries.Add(newEntry);
    }

    public void DisplayAll(){
        foreach (Entry data in _entries){
            data.Display();
        }
    }

    public void SaveToFile(string file){
        using (StreamWriter outputFile = new StreamWriter(file)){
            foreach (Entry data in _entries){
                outputFile.WriteLine($"{data._date},{data._entryText},{data._promptText}");
            }
        }
    }

    public void LoadFromFile(string file){
        string[] fileLines = System.IO.File.ReadAllLines(file);
        foreach (string line in fileLines){
            string[] parts = line.Split(",");

            Entry newEntry = new Entry();

            newEntry._date = parts[0];                           //Today's date
            newEntry._entryText = parts[1];                      //User response to the prompt
            newEntry._promptText = parts[2];                     //Prompt that the user has answered

            AddEntry(newEntry);
        }
    }
}