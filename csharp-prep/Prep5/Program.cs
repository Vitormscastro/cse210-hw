using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string number = Console.ReadLine();
            return int.Parse(number);
        }

        static int SquareNumber(int number)
        {
            int squared_number = number * number;
            return squared_number;
        }

        static void DisplayResult(int squared_number, string name)
        {
            Console.WriteLine($"{name}, the square of your number is {squared_number}");
        }

        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squared_number = SquareNumber(number);
        DisplayResult(squared_number, name);
    }
}