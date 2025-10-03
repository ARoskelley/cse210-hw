public class Job
{
    public string _jobTitle = "";
    public string _company = "";
    public string _timeOfEmplyment = "";

    public void Display()
    {
        Console.WriteLine($"{_company} ({_jobTitle}) {_timeOfEmplyment}");

    }
}