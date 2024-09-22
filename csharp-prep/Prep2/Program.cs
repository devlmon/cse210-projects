using System;

class Program
{
    static void Main(string[] args)
    {
        string letter = "";
        string user_grade;
        int    grade;
        
        Console.Write("Grade percentage: ");
        user_grade = Console.ReadLine();

        grade = int.Parse(user_grade);

        if (grade >= 90){
            letter = "A";
        }
        else if (grade >= 80){
            letter = "B";
        }
        else if (grade >= 70){
            letter = "C";
        }
        else if (grade >= 60){
            letter = "D";
        }
        else if (grade < 60){
            letter = "F";
        }

        Console.WriteLine("");
        Console.WriteLine($"You got an {letter}.");
        if (grade >=70){
            Console.WriteLine("Congrats!");
        }
        else{
            Console.WriteLine("Better luck next time!");
        }
    }
}