public class PromptGenerator
{
    List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
    };

    public PromptGenerator()
    {

    }

    // a method that displays the prompt
    public string RandomPromptGenerator()
    {
        Random randomPrompt = new Random();
        int index = randomPrompt.Next(_prompts.Count);
        string prompt = _prompts[index];
        return prompt;
    }

    public void DisplayJournal()
    {
        Random randomPrompt = new Random();
        int index = randomPrompt.Next(_prompts.Count);
        string prompt = _prompts[index];
        Console.WriteLine(prompt);
    }


}

