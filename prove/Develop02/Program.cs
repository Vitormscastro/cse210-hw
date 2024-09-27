using System;

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
                newEntry.Display();
            }
            else if (run == "2")
            {
                
            }
            else if (run == "3")
            {
                /*Console.Write("What file would you like to save to? ");
                file = Console.ReadLine();
                Journal.SaveToFile(file);*/
            }
            else if (run == "4")
            {
                /*Console.Write("What file would you like to load from? ");
                file = Console.ReadLine();
                Journal.LoadFromFile(file);*/
            }
        } while (run != "5");
    }
}