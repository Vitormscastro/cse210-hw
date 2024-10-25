using System;

public class ChecklistGoal : Goal  
{  
    private int AmountCompleted;
    private int Target;
    private int Bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)   
        : base(name, description, points)  
    {  
        AmountCompleted = 0;  
        Target = target;  
        Bonus = bonus;  
    }  

    public override void RecordEvent()  
    {  
        // Implementation goes here  
    }  

    public override bool IsComplete()  
    {  
        return AmountCompleted >= Target;  
    }  

    public override string GetDetailsString()  
    {  
        return $"{ShortName}: {Description} - Points: {Points}, Completed: {AmountCompleted}/{Target}";  
    }  

    public override string GetStringRepresentation()  
    {  
        return $"{ShortName}: {Description} - Points: {Points}";  
    }  
}  