using System;

class Program
{
    static void Main(string[] args)
    {
        string user_guess;
        int user_guess_number;

        Random randomGenerator = new Random();
        int magic_number = randomGenerator.Next(1, 101);
        Console.WriteLine("The magic number has been generated.");

        do{
            Console.Write("What is your guess? ");
            user_guess        = Console.ReadLine();
            user_guess_number = int.Parse(user_guess);

            if (user_guess_number > magic_number){
                Console.WriteLine("Higher");
            }
            else if (user_guess_number < magic_number){
                Console.WriteLine("Lower");
            }
            Console.WriteLine("");
        }while(user_guess_number != magic_number);

        Console.WriteLine("You guessed it!");
    }
}