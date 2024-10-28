using System;  
using System.Collections.Generic;  
using System.IO;  

public class GoalManager  
{  
    private List<Goal> Goals { get; set; }  
    public int Score { get; private set; } // Make Score public to access it outside  

    public GoalManager()  
    {  
        Goals = new List<Goal>();  
        Score = 0;  
    }  

    public void Start()  
    {  
        // Main menu loop  
        while (true)  
        {  
            Console.WriteLine("1. Display Player Info");  
            Console.WriteLine("2. List Goal Names");  
            Console.WriteLine("3. List Goal Details");  
            Console.WriteLine("4. Create Goal");  
            Console.WriteLine("5. Record Event");  
            Console.WriteLine("6. Save Goals");  
            Console.WriteLine("7. Load Goals");  
            Console.WriteLine("8. Exit");  
            Console.Write("Choose an option: ");  
            string choice = Console.ReadLine();  

            switch (choice)  
            {  
                case "1":  
                    DisplayPlayerInfo();  
                    break;  
                case "2":  
                    ListGoalNames();  
                    break;  
                case "3":  
                    ListGoalDetails();  
                    break;  
                case "4":  
                    CreateGoal();  
                    break;  
                case "5":  
                    RecordEvent();  
                    break;  
                case "6":  
                    SaveGoals();  
                    break;  
                case "7":  
                    LoadGoals();  
                    break;  
                case "8":  
                    return;  
                default:  
                    Console.WriteLine("Invalid choice. Please try again.");  
                    break;  
            }  
        }  
    }  

    public void DisplayPlayerInfo()  
    {  
        Console.WriteLine($"Current Score: {Score}");  
    }  

    public void ListGoalNames()  
    {  
        foreach (var goal in Goals)  
        {  
            Console.WriteLine(goal.ShortName);  
        }  
    }  

    public void ListGoalDetails()  
    {  
        foreach (var goal in Goals)  
        {  
            Console.WriteLine(goal.GetDetailsString());  
        }  
    }  

    public void CreateGoal()  
    {  
        Console.WriteLine("Choose goal type: 1. Simple 2. Eternal 3. Checklist");  
        string type = Console.ReadLine();  
        Console.Write("Enter goal name: ");  
        string name = Console.ReadLine();  
        Console.Write("Enter goal description: ");  
        string description = Console.ReadLine();  
        Console.Write("Enter points: ");  
        int points = int.Parse(Console.ReadLine());  

        if (type == "1")  
        {  
            Goals.Add(new SimpleGoal(name, description, points));  
        }  
        else if (type == "2")  
        {  
            Goals.Add(new EternalGoal(name, description, points));  
        }  
        else if (type == "3")  
        {  
            Console.Write("Enter target: ");  
            int target = int.Parse(Console.ReadLine());  
            Console.Write("Enter bonus: ");  
            int bonus = int.Parse(Console.ReadLine());  
            Goals.Add(new ChecklistGoal(name, description, points, target, bonus));  
        }  
    }  

    public void RecordEvent()  
    {  
        Console.WriteLine("Select a goal to record an event (please enter a number):");  
        ListGoalNames();  
        int index = int.Parse(Console.ReadLine()) - 1;  
        if (index >= 0 && index < Goals.Count)  
        {  
            Goals[index].RecordEvent();  
            Score += Goals[index].Points;  
            if (Goals[index] is ChecklistGoal checklistGoal && checklistGoal.IsComplete())  
            {  
                Score += checklistGoal.Bonus; // Add bonus points if checklist goal is complete  
            }  
        }  
    }  

    public void SaveGoals()  
    {  
        Console.Write("Enter the file name to save goals (e.g., goals.txt): ");  
        string fileName = Console.ReadLine();  

        using (StreamWriter writer = new StreamWriter(fileName))  
        {  
            // Save the score at the top of the file  
            writer.WriteLine(Score);  

            foreach (var goal in Goals)  
            {  
                string line = goal.GetType().Name + "|" + goal.ShortName + "|" + goal.Description + "|" + goal.Points;  
                if (goal is ChecklistGoal checklistGoal)  
                {  
                    line += "|" + checklistGoal.AmountCompleted + "|" + checklistGoal.Target + "|" + checklistGoal.Bonus;  
                }  
                writer.WriteLine(line);  
            }  
        }  
        Console.WriteLine("Goals saved successfully.");  
    }  

    public void LoadGoals()  
    {  
        Console.Write("Enter the file name to load goals from (e.g., goals.txt): ");  
        string fileName = Console.ReadLine();  

        if (File.Exists(fileName))  
        {  
            Goals.Clear(); // Clear existing goals  
            using (StreamReader reader = new StreamReader(fileName))  
            {  
                // Load the score from the first line  
                if (int.TryParse(reader.ReadLine(), out int loadedScore))  
                {  
                    Score = loadedScore; // Set the loaded score  
                }  

                string line;  
                while ((line = reader.ReadLine()) != null)  
                {  
                    string[] parts = line.Split('|');  
                    string goalType = parts[0];  

                    if (goalType == nameof(SimpleGoal))  
                    {  
                        Goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3])));  
                    }  
                    else if (goalType == nameof(EternalGoal))  
                    {  
                        Goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));  
                    }  
                    else if (goalType == nameof(ChecklistGoal))  
                    {  
                        int amountCompleted = int.Parse(parts[4]);  
                        int target = int.Parse(parts[5]);  
                        int bonus = int.Parse(parts[6]);  
                        var checklistGoal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), target, bonus);  
                        checklistGoal.AmountCompleted = amountCompleted; // Set the amount completed  
                        Goals.Add(checklistGoal);  
                    }  
                }  
            }  
            Console.WriteLine("Goals loaded successfully.");  
        }  
        else  
        {  
            Console.WriteLine("No saved goals found.");  
        }  
    }  
}