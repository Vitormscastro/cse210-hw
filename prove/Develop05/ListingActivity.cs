using System.Collections.Generic;
using System.Threading;

namespace MindfulnessProgram{
    class ListingActivity : Activity {
    private List<string> _prompts = new List<string>
    {
    "Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public override void Run()
    {
    DisplayStartingMessage();
    string prompt = GetRandomPrompt();
    Console.WriteLine(prompt);
    ShowSpinner(3);
    Console.WriteLine("Start listing items (press Enter after each item).");
    List<string> items = GetListFromUser();
    Console.WriteLine($"You listed {items.Count} items.");
    DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
    Random random = new Random();
    return _prompts[random.Next(_prompts.Count)];
    }

    public List<string> GetListFromUser()
    {
    List<string> items = new List<string>();
    DateTime endTime = DateTime.Now.AddSeconds(_duration);
    while (DateTime.Now < endTime)
    {
    string item = Console.ReadLine();
    if (!string.IsNullOrEmpty(item))
    {
    items.Add(item);
    }
    }
    return items;
    }
    }
}