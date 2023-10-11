public class PromptGenerator
{
    List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What did I learn today?",
        "What is the funniest thing that happened today?",
        "If you could become an expert in any subject or activity, what would it be?",
        "What scripture just popped into my head right now?",
        "How can I make tomorrow (even) better than today?",
        "What do I need to let go of today?",
        "Who do I wish I had talked to today? What would I say?",
        "Reflect on how my body feels. Sore, Stressed, Tired, Energized",
        "Did I watch a movie today? If so what?",
        "Identify three times that I felt challenged today.",
        "Did I watch a TV show today? If so what?",
        "Did I watch a TV show today? If so what?",
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

