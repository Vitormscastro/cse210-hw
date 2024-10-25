using System;

public abstract class Goal  
{  
    protected string ShortName; 
    protected string Description;
    protected int Points;

    public Goal(string name, string description, int points)  
    {  
        ShortName = name;  
        Description = description;  
        Points = points;  
    }  

    public abstract void RecordEvent();  
    public abstract bool IsComplete();  
    public abstract string GetDetailsString();  
    public abstract string GetStringRepresentation();  
}  