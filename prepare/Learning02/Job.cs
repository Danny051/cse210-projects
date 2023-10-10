// A code template for the category of things known as Job. The
// responsibility of a Job is to hold and display job information.
// Create the class (Hint this is the public class Job syntax)
// class
public class Job
{
    // Create member variables in the class for each element that this class should contain. 
    // By convention these member variables should begin with an underscore and a lowercase letter such as _jobTitle .
    // member variables
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;


    // A method that displays the person's job details
        // <job title, company, start year, end year>.
    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }

}