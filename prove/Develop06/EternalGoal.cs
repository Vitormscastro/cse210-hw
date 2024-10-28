public class EternalGoal : Goal  
{  
    public EternalGoal() : base("", "", 0)  
    {  
    }
    public EternalGoal(string name, string description, int points) : base(name, description, points)  
    {  
    }  

    public override void RecordEvent()  
    {  
        // No specific implementation needed for eternal goals  
    }  

    public override bool IsComplete()  
    {  
        return false; // Eternal goals are never complete  
    }  

    public override string GetStringRepresentation()  
    {  
        return $"{ShortName}: {Description} - Points: {Points}";  
    }  

    public override string GetDetailsString()  
    {  
        return $"[ ] {ShortName}: {Description}";  
    }  
}