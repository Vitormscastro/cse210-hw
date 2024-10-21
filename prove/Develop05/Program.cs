namespace MindfulnessProgram{
class Program {
static void Main(string[] args)
{
while (true)
{
Console.WriteLine("Choose an activity:");
Console.WriteLine("1. Breathing Activity");
Console.WriteLine("2. Listing Activity");
Console.WriteLine("3. Reflecting Activity");
Console.WriteLine("4. Exit");
string choice = Console.ReadLine();

Activity activity = null;
switch (choice)
{
case "1":
activity = new BreathingActivity();
break;
case "2":
activity = new ListingActivity();
break;
case "3":
activity = new ReflectingActivity();
break;
case "4":
return;
default:
Console.WriteLine("Invalid choice. Please try again.");
continue;
}

activity.Run();
}
}
}
}