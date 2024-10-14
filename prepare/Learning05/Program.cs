using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment assignment1 = new MathAssignment("Vitor Castro", "Sciences", "Section 2.8", "Problems 3 and 5");
        Console.WriteLine(assignment1.GetHomeworkList());

        WritingAssignment assignment2 = new WritingAssignment("Vitor Castro", "Sciences", "The final war");
        Console.WriteLine(assignment2.GetWritingInformation());
    }
}