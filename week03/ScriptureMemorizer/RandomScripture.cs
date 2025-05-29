using System;

public class RandomScripture
{
    // Class in charge of returning references and texts of scriptures randomly.

    // Attributes --------------------------------------------------------------------------------------------------------------
    private List<string> _reference = new List<string>();
    private List<string> _text = new List<string>();
    private int _numberOfScriptures;
    private int _selectedScripture = -1;

    // Constructors -----------------------------------------------------------------------------------------------------------

    public RandomScripture()
    {
        // Constructor that has no parameters. In charge of storing 5 scriptures by default.
        _numberOfScriptures = 5;

        _reference.Add("2Nephi 4:16-17");
        _text.Add("Behold, my soul deligteth in the things of the Lord; and my heart pondereth continually upon the things which I have seen and heard. Nevertheless, notwithstanding the great goodness of the Lordm in showing me his great and marvelous works, my heart exclaimeth: O wretched man that I am! Yea, my heart soroweth because of my flesh; my soul grieveth because of mine iniquities.");

        _reference.Add("Mosiah 2:17");
        _text.Add("And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God.");

        _reference.Add("Alma 37:6");
        _text.Add("Now ye may suppose that this is foolishness in me; but behold I say unto you, that by small and simple things are great things brought to pass; and small means in many instances doth confound the wise.");

        _reference.Add("Ether 12:27");
        _text.Add("And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them.");

        _reference.Add("3Nephi 11:29-30");
        _text.Add("For verily, verily, I say unto you, he that hath the spirit of contention is not of me, but is of the devil, who is the father of contention, and he stirreth up the hearts of men to contend with anger, one with another. Behold this is not my doctrine, to stir up the hearts of men with anger, one against another; but this is my doctrine, that such things should be done away.");
    }

    // Methods ----------------------------------------------------------------------------------------------------------------

    private void SelectRandomScripture()
    {
        // It is in charge of picking a random number to choose which scripture will be chosen.
        Random randomGenerator = new Random();
        _selectedScripture = randomGenerator.Next(0, _numberOfScriptures);
    }

    public string GetRandomReference()
    {
        // Returns the reference of the scripture.
        if (_selectedScripture == -1)
        {
            // If the scripture has not yet been chosen, one is chosen at random.
            SelectRandomScripture();
        }
        return _reference[_selectedScripture];
    }
    
    public string GetRandomText()
    {
        // Returns the text of the scripture.
        if (_selectedScripture == -1)
        {
            // If the scripture has not yet been chosen, one is chosen at random.
            SelectRandomScripture();
        }
        return _text[_selectedScripture];
    }

}