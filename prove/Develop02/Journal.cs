using System;
using System.IO;
// Behavior: Stores a list of journal entries.
/* Attributes: 
        List<Entry> _entries;*/
/* Methods: 
        EntryAdd(), 
        DisplayAllEntries(), 
        SaveToFile(), 
        LoadFromFile(),
        AutoEntry()*/

public class Journal
{
        public List<Entry> _entries = new List<Entry>();

        public void AddEntry(Entry newEntry)
        {
                DateTime theCurrentTime = DateTime.Now;
                newEntry._date = theCurrentTime.ToShortDateString();

                PromptGenerator newGenerator = new PromptGenerator();
                newEntry._promptText = newGenerator.GetRandomPrompt();

                Console.WriteLine(newEntry._promptText);
                newEntry._entryText = Console.ReadLine();

                _entries.Add(newEntry);
        }

        public void AutoEntry(string date, string promptText, string entryText)
        {
                Entry newEntry = new Entry();
                newEntry._date = date;
                newEntry._promptText = promptText;
                newEntry._entryText = entryText;
                _entries.Add(newEntry);
        }

        public void DisplayAll()
        {
                foreach (Entry entry in _entries)
                {
                        Console.WriteLine();
                        entry.Display();
                }
        }

        public void SaveToFile(string file)
        {
                using (StreamWriter outputFile = new StreamWriter(file))
                {
                        foreach (Entry entry in _entries)
                        {
                                outputFile.WriteLine($"{entry._date} | {entry._promptText} | {entry._entryText},");
                        }
                }
        }

        public void LoadFromFile(string file)
        {
                string[] lines = System.IO.File.ReadAllLines(file);

                foreach (string line in lines)
                {
                string[] parts = line.Split(" | ");

                string _date = parts[0];
                string _promptText = parts[1];
                string _entryText = parts[2];

                AutoEntry(_date, _promptText, _entryText);
                }
        }
}