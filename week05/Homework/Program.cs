using System;

class Program
{
    static void Main(string[] args)
    {
        // Sample Output 1
        Assigment newAssigment = new Assigment("Samuel Bennett", "Multiplication");
        Console.WriteLine(newAssigment.GetSummary());
        Console.WriteLine();

        // Sample Output 2
        MathAssigment newMathAssigment = new MathAssigment("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 8-19");
        Console.WriteLine(newMathAssigment.GetSummary());
        Console.WriteLine(newMathAssigment.GetHomeworkList());
        Console.WriteLine();

        // Sample Output 3
        WritingAssigment newWritingAssigment = new WritingAssigment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(newWritingAssigment.GetSummary());
        Console.WriteLine(newWritingAssigment.GetWritingInformation());
        Console.WriteLine();
    }
}