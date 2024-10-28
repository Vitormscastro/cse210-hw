public abstract class Goal  
{  
    public string ShortName { get; set; }  
    public string Description { get; set; }  
    public int Points { get; set; }  

    protected Goal() { } // Parameterless constructor for serialization  

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