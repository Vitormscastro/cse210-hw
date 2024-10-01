using System;

//   To exceed requirements, I created a new behavior in the Journal class that allows the
// program save each line from a loaded file as a new entry. This allows the "AddEntry"
// behavior to be more concise and specific for writing a new entry.

class Program
{
    static void Main(string[] args)
    {
        string run = "0";
        string file = "";
        Journal theJournal = new Journal();

        do
        {
            Console.WriteLine("Welcome to the Journal program!");
            Console.WriteLine("1.Write\n2.Display\n3.Save journal\n4.Load journal\n5.Quit");
            Console.Write("What would you like to do? ");
            run = Console.ReadLine();

            if (run == "1")
            {
                Entry newEntry = new Entry();
                theJournal.AddEntry(newEntry);
            }
            else if (run == "2")
            {
                theJournal.DisplayAll();
            }
            else if (run == "3")
            {
                Console.Write("What file would you like to save to? ");
                file = Console.ReadLine();
                theJournal.SaveToFile(file);
            }
            else if (run == "4")
            {
                Console.Write("What file would you like to load from? ");
                file = Console.ReadLine();
                theJournal.LoadFromFile(file);
            }
        } while (run != "5");
    }
}