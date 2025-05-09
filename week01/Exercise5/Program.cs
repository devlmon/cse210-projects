using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int favorite_number)
    {
        return favorite_number * favorite_number;
    }

    static void DisplayResult(string user_name, int square_number)
    {
        Console.WriteLine($"{user_name}, the square of your number is {square_number}");
    }

    static void Main(string[] args)
    {
        string user_name            = "";
        int    user_favorite_number = 0;
        int    user_square_number   = 0;

        DisplayWelcome();

        user_name            =   PromptUserName();
        user_favorite_number = PromptUserNumber();

        user_square_number = SquareNumber(user_favorite_number);

        DisplayResult(user_name,user_square_number);
    }
}