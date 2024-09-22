using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int user_number;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do{
            Console.Write("Enter number: ");
            string user_input = Console.ReadLine();
            user_number = int.Parse(user_input);

            if (user_number != 0){
                numbers.Add(user_number);
            }
        }while(user_number != 0);

        int list_sum = numbers.Sum();
        Console.WriteLine($"The sum is: {list_sum}");

        double list_average = numbers.Average();
        Console.WriteLine($"The average is: {list_average}");

        int list_largest = numbers.Max();
        Console.WriteLine($"The largest number is: {list_largest}");
    }
}