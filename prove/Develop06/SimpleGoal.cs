using System;

public class SimpleGoal : Goal  
{  
    private bool IsCompleteFlag;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)  
    {  
        IsCompleteFlag = false;  
    }  

    public override void RecordEvent()  
    {  
        // Implementation goes here  
    }  

    public override bool IsComplete()  
    {  
        return IsCompleteFlag;  
    }  

    public override string GetStringRepresentation()  
    {  
        return $"{ShortName}: {Description} - Points: {Points}";  
    }  
}  