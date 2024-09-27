using System;
// Behavior: Represents a single journal entry.
/* Attributes: 
        string _date, 
        string _promptText, 
        string _entryText;*/
/* Methods: 
        Display();*/

public class Entry
{
        public string _date;
        public string _promptText;
        public string _entryText;

        public void Display()
        {
                Console.WriteLine(_date);
                Console.WriteLine(_promptText);
                Console.WriteLine(_entryText);
        }
}