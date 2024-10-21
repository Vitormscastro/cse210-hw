using System.Threading;  

namespace MindfulnessProgram{  
    class BreathingActivity : Activity {  
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")  
    {  
    }  

    public override void Run()  
    {  
    DisplayStartingMessage();  
    DateTime endTime = DateTime.Now.AddSeconds(_duration);  
    while (DateTime.Now < endTime)  
    {  
    Console.WriteLine("Breathe in...");  
    ShowSpinner(4);  
    Console.WriteLine("Breathe out...");  
    ShowSpinner(4);  
    }  
    DisplayEndingMessage();  
    }  
    }  
}  