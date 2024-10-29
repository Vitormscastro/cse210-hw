using System;

class Program
{
    static void Main(string[] args)
    {
        List<Exercise> exercises = new List<Exercise>();

        exercises.Add(new Running("29 Oct 2024", 60, 10));
        exercises.Add(new Cycling("29 Oct 2024", 40, 30));
        exercises.Add(new Swimming("29 Oct 2024", 30, 60));
        
        foreach (var exercise in exercises)
        {
            Console.WriteLine(exercise.GetSummary());
            Console.WriteLine();
        }
    }
}