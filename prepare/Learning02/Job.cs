public class Job
{
    // company string (attribute / member variable)
    public string _company = "";
    // job title string (attribute / member variable)
    public string _jobName = "";
    // start year int (attribute / member variable)
    public int _startYear;
    // end year int (attribute / member variable)
    public int _endYear;
    public void Display()
    {
        Console.WriteLine($"{_jobName} {_company} {_startYear}->{_endYear}");
    }

}