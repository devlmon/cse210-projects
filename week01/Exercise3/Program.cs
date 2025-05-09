using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        
        int magic_number = randomGenerator.Next(1, 100);
        int user_guess   = 0;

        do {
            Console.WriteLine("What is your guess? ");
            user_guess = int.Parse(Console.ReadLine());

            if (user_guess > magic_number) {
                Console.WriteLine("Lower");
            }
            else if (user_guess < magic_number) {
                Console.WriteLine("Higher");
            }
            else {
                Console.WriteLine("You guessed it!");
            }
        } while(user_guess != magic_number);
    }
}