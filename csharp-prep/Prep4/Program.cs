using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int new_number = -1;
        int total = 0;
        int largest = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            Console.Write("Enter a number: ");
            new_number = int.Parse(Console.ReadLine());
            numbers.Add(new_number);

            total = total + new_number;
            if (new_number > largest)
            {
                largest = new_number;
            }
        } while (new_number != 0);

        double average = ((float)total) / (numbers.Count - 1);

        Console.WriteLine($"The sum is: {total}.");
        Console.WriteLine($"The average is: {average}.");
        Console.WriteLine($"The largest number is: {largest}.");
    }
}