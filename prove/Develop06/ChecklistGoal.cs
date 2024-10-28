public class ChecklistGoal : Goal  
{  
    public int AmountCompleted { get; set; }  
    public int Target { get; set; }  
    public int Bonus { get; set; }

    public ChecklistGoal() : base("", "", 0)  
    {  
        AmountCompleted = 0;  
        Target = 0;  
        Bonus = 0;  
    } 

    public ChecklistGoal(string name, string description, int points, int target, int bonus)   
        : base(name, description, points)  
    {  
        AmountCompleted = 0;  
        Target = target;  
        Bonus = bonus;  
    }  

    public override void RecordEvent()  
    {  
        AmountCompleted++;  
    }  

    public override bool IsComplete()  
    {  
        return AmountCompleted >= Target;  
    }  

    public override string GetDetailsString()  
    {  
        return IsComplete() ? $"[X] {ShortName}: {Description} - Completed {AmountCompleted}/{Target} times"   
                            : $"[ ] {ShortName}: {Description} - Completed {AmountCompleted}/{Target} times";  
    }  

    public override string GetStringRepresentation()  
    {  
        return $"{ShortName}: {Description} - Points: {Points}, Completed: {AmountCompleted}/{Target}";  
    }  
}