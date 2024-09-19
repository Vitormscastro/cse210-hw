using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the number guessing game!\n");
        bool play = true;
        while (play == true)
        {
            Console.WriteLine("A random number has been generated, and you have to guess what it is!\n");
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1,101);
            int tries = 0;
            int guess = 0;

            do 
            {
                Console.Write("What is your guess? ");
                string magic_guess = Console.ReadLine();
                guess = int.Parse(magic_guess);
                tries = tries + 1;

                if (guess > number)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < number)
                {
                    Console.WriteLine("Higher");
                }
            } while (guess != number);

            Console.WriteLine($"You guessed it! It took you {tries} tries.\n");
            Console.Write("Would you like to play again? [y/n] ");
            string answer = Console.ReadLine();
            if (answer == "n" || answer == "N")
            {
                play = false;
            }
        }
    }
}