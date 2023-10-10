// using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    // public string _userFileName;

    public Journal()
    {

    }
    public void AddEntry(string prompts)
    {
        Console.WriteLine(prompts);
        Console.Write("> ");
        string userInput = Console.ReadLine();
        DateTime theCurrentTime = DateTime.Now;
        string dateTime = theCurrentTime.ToShortDateString();
        _entries.Add(new Entry(prompts, userInput, dateTime));
    }

    public void DisplayJournal()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry.DisplayJournal());
        }
    }

    public void SaveToFile()
    {
        Console.WriteLine("What is the name of the file? ");
        string userFileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(userFileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry.DisplayDate()}; {entry.DisplayPrompt()}; {entry.DisplayEntry()}");
            }
        }

        Console.WriteLine("Saving To File....");
        Console.WriteLine($"Successfully saved to {userFileName}");
    }

    public void LoadFromFile()
    {
        // List<Entry> _entries = new List<Entry>();
        Console.WriteLine("What is the name of the file? ");
        string userFileName = Console.ReadLine();
        Console.WriteLine("Reading From File...");

        string[] lines = System.IO.File.ReadAllLines(userFileName);
        
        foreach (string line in lines)
        {
            // Console.WriteLine(line);
            // line will have something like this Date; Prompt; userInput
            string[] parts = line.Split(";");
            // parts[0] = Date
            // parts[1] = Prompt
            // parts[2] = UserInput
            string dateTime = parts[0];
            string prompts =parts[1];
            string userInput = parts[2];
            // string newEntry = new Entry();
            // newEntry._dateTime = parts[0];
            // newEntry._prompts = parts[1];
            // newEntry._userInput = parts[2];

            _entries.Add(new Entry(prompts, userInput, dateTime));
        }

        Console.WriteLine("Loading Complete");
    }
}