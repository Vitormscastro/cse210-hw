public class SimpleGoal : Goal  
{  
    private bool IsCompleteFlag { get; set; }  

    public SimpleGoal() : base("", "", 0)  
    {  
        IsCompleteFlag = false;  
    } 

    public SimpleGoal(string name, string description, int points) : base(name, description, points)  
    {  
        IsCompleteFlag = false;  
    }  

    public override void RecordEvent()  
    {  
        IsCompleteFlag = true;  
    }  

    public override bool IsComplete()  
    {  
        return IsCompleteFlag;  
    }  

    public override string GetStringRepresentation()  
    {  
        return $"{ShortName}: {Description} - Points: {Points}";  
    }  

    public override string GetDetailsString()  
    {  
        return IsComplete() ? $"[X] {ShortName}: {Description}" : $"[ ] {ShortName}: {Description}";  
    }  
}