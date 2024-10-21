using System.Threading;  

namespace MindfulnessProgram{  
    abstract class Activity {  
    protected string _name;  
    protected string _description;  
    protected int _duration;  

    public Activity(string name, string description)  
    {  
    _name = name;  
    _description = description;  
    }  

    public void DisplayStartingMessage()  
    {  
    Console.WriteLine($"Starting {_name}...");  
    Console.WriteLine(_description);  
    Console.Write("Enter duration in seconds: ");  
    _duration = int.Parse(Console.ReadLine());  
    Console.WriteLine("Get ready to begin...");  
    ShowCountDown(3);  
    }  

    public void DisplayEndingMessage()  
    {  
    Console.WriteLine("Good job!");  
    ShowCountDown(3);  
    Console.WriteLine($"You completed the {_name} for {_duration} seconds.");  
    ShowCountDown(3);  
    }  

    protected void ShowSpinner(int seconds)  
    {  
    char[] spinner = { '|', '/', '-', '\\' }; // Corrected backslash 
    int spinnerIndex =0;  
    for (int i =0; i < seconds; i++)  
    {  
    Console.Write(spinner[spinnerIndex]);  
    Thread.Sleep(500);  
    Console.Write("\b \b"); // Erase the spinner character 
    spinnerIndex = (spinnerIndex +1) % spinner.Length; // Move to the next spinner character 
    }  
    Console.WriteLine(); // Move to the next line after spinner 
    }  

    protected void ShowCountDown(int seconds)  
    {  
    for (int i = seconds; i >0; i--)  
    {  
    Console.Write(i);  
    Thread.Sleep(1000);  
    Console.Write("\b \b"); // Erase the countdown number 
    }  
    Console.WriteLine(); // Move to the next line after countdown 
    }  

    public abstract void Run();  
    }  
}  