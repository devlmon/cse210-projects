using System;

class Program
{
    static void Main(string[] args)
    {
        int grade_percentage =  0;
        string letter        = "";
        string sign          = "";
        
        Console.Write("What is your grade percentage? ");
        grade_percentage = int.Parse(Console.ReadLine());


        if (grade_percentage >= 90) {
            letter = "A";
        }
        else if (grade_percentage >= 80) {
            letter = "B";
        }
        else if (grade_percentage >= 70) {
            letter = "C";
        }
        else if (grade_percentage >= 60) {
            letter = "D";
        }
        else {
            letter = "F";
        }

        
        int gp_last_digit = grade_percentage % 10;
        if (gp_last_digit >= 7 && (letter != "A" && letter != "F")) {
            sign = "+";
        }
        else if (gp_last_digit < 3 && letter != "F" && grade_percentage != 100) {
            sign = "-";
        }

        Console.WriteLine($"{sign}{letter}");

        if (grade_percentage >= 70) {
            Console.WriteLine("Congratulations on passing the course!!");
        }
        else {
            Console.WriteLine("You didn't pass, but I'm sure you'll make it next time!");
        }
    }
}