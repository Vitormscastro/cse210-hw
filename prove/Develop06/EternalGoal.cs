using System;

public class EternalGoal : Goal  
{  
    public EternalGoal(string name, string description, int points) : base(name, description, points)  
    {  
    }  

    public override void RecordEvent()  
    {  
        // Implementation goes here  
    }  

    public override bool IsComplete()  
    {  
        return false; // Eternal goals are never complete  
    }  

    public override string GetStringRepresentation()  
    {  
        return $"{ShortName}: {Description} - Points: {Points}";  
    }  
}  