using System;
using System.Text;
using Microsoft.Win32.SafeHandles;

public class Scripture
{
    // Class responsible for storing and managing the entire scripture.

    // Attributes --------------------------------------------------------------------------------------------------------------

    private Reference _reference;
    private List<Word> _words = new List<Word>();

    // Constructors -----------------------------------------------------------------------------------------------------------

    public Scripture(string reference, string text)
    {
        // Constructor that has parameter to store the reference and text of the scripture.

        // -------- Reference of the Scripture: Split the reference ----------
        string[] referenceItem = reference.Split(new[] { ' ', ':', '-' });
        string book = referenceItem[0];
        int chapter = int.Parse(referenceItem[1]);
        int startVerse = int.Parse(referenceItem[2]);
        if (referenceItem.Length > 3)
        {
            // -------- Save the long reference ---------
            int endVerse = int.Parse(referenceItem[3]);
            _reference = new Reference(book, chapter, startVerse, endVerse);
        }
        else
        {
            // -------- Save the short reference --------
            _reference = new Reference(book, chapter, startVerse);
        }

        // -------- Text of the Scripture: Split the text ---------
        string[] wordList = text.Split();
        foreach (var word in wordList)
        {
            // -------- Save the splitted words ---------
            Word newWord = new Word(word);
            _words.Add(newWord);
        }
    }

    // Methods ----------------------------------------------------------------------------------------------------------------

    public void HideRandomWords(int numberToHide)
    {
        // Hides as many words as indicated by the numberToHide parameter
        for (int i = 0; i < numberToHide; i++)
        {
            // First loop to hide as many words as indicated
            bool readyToContinue = true;
            while (readyToContinue == true && IsCompletelyHidden() == false)
            {
                // Second loop to hide only words that are not already hidden while there are still words to hide.
                Random randomGenerator = new Random();
                int randomNumber = randomGenerator.Next(0, _words.Count());

                // If the word is not already hidden.
                if (!_words[randomNumber].IsHidden())
                {
                    // Hide the word and continue.
                    _words[randomNumber].Hide();
                    readyToContinue = false;
                }
            }
        }
    }

    public string GetDisplayText()
    {
        // Creates a new StringBuilder to store all the text.
        StringBuilder text = new StringBuilder();

        text.Append($"{_reference.GetDisplayText()}\n");
        foreach (var word in _words)
        {
            text.Append($"{word.GetDisplayText()} ");
        }

        return text.ToString();
    }

    public bool IsCompletelyHidden()
    {
        // Check if all words are already hidden.
        bool isCompletlyHidden = true;
        foreach (var word in _words)
        {
            if (!word.IsHidden())
            {
                isCompletlyHidden = false;
                break;
            }
        }
        return isCompletlyHidden;
    }
}

