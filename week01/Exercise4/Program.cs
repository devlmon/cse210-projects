using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers        = new List<int>();
        int    user_input        =               0;
        int    numbers_sum       =               0;
        double numbers_average   =             0.0;
        int    numbers_largest   =               0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do {
            Console.Write("Enter number: ");
            user_input = int.Parse(Console.ReadLine());

            if (user_input != 0) {
                numbers.Add(user_input);
            }

        } while(user_input != 0);

        numbers_sum     = numbers.Sum();
        numbers_average = numbers.Average();
        numbers_largest = numbers.Max();


        Console.WriteLine($"The sum is: {numbers_sum}");
        Console.WriteLine($"The average is: {numbers_average}");
        Console.WriteLine($"The largest number is: {numbers_largest}");
    }
}