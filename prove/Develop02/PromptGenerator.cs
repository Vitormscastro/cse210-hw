using System;
// Behavior: Supplies random prompts whenever needed.
/* Attributes: 
        List<string> _prompts;*/
/* Methods: 
        string GetRandomPrompt();*/

public class PromptGenerator
{
        public List<string> _prompts;

        public string GetRandomPrompt()
        {
                _prompts.Add("Who was the most interesting person I interacted with today?");
                _prompts.Add("What made me happiest today?");
                _prompts.Add("How did the Lord bless today?");
                _prompts.Add("What moment would I want to always remember from today?");
                _prompts.Add("What is something I could improve on?");

                Random rnd = new Random();
                int num = rnd.Next(0,5);
                return _prompts[num];
        }
}