public class Entry
{
    // // public string _ownerName;
    public string _dateTime;
    public string _prompts;
    public string _userInput;


    public Entry(string prompts, string userInput, string dateTime)
    {
        _prompts = prompts;
        _userInput = userInput;
        _dateTime = dateTime;
    }

    public string DisplayDate()
    {
        // DateTime theCurrentTime = DateTime.Now;
        // string dateText = theCurrentTime.ToShortDateString();
        return _dateTime;
    }
    
    public string DisplayEntry()
    {
        // Console.WriteLine($"Date: {_dateTime} - Prompt: {_prompts}");
        // Console.WriteLine($"{_userInput}");
        return _userInput;
    }

    public string DisplayPrompt()
    {
        return _prompts;
    }

    public string DisplayJournal()
    {
        return $"\nDate: {_dateTime} -- Prompt: {_prompts} \n>>>{_userInput}";
    }
}