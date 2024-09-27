using System;
// Behavior: Stores a list of journal entries.
/* Attributes: 
        List<Entry> _entries;*/
/* Methods: 
        EntryAdd(), 
        DisplayAllEntries(), 
        SaveToFile(), 
        LoadFromFile();*/

public class Journal
{
        public List<Entry> _entries;

        public void AddEntry(Entry newEntry)
        {
                DateTime theCurrentTime = DateTime.Now;
                newEntry._date = theCurrentTime.ToShortDateString();

                PromptGenerator newGenerator = new PromptGenerator();
                newEntry._promptText = newGenerator.GetRandomPrompt();

                Console.WriteLine(newEntry._promptText);
                newEntry._entryText = Console.ReadLine();
        }

        public void DisplayAll()
        {

        }

        public void SaveToFile(string file)
        {

        }

        public void LoadFromFile(string file)
        {
                
        }
}