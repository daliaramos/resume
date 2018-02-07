namespace Jobs.Models
{
  public class Job
  {
    private string _jobTitle;
    private string _companyName;
    private string _location;
    private string _startDate;
    private string _endDate;
    private string _description;

    public Job(string jobTitle, string companyName, string location, string start, string end, string desc)
    {
      _jobTitle = jobTitle;
      _companyName = companyName;
      _location = location;
      _startDate = start;
      _endDate = end;
      _description = desc;
    }

    public string GetJobTitle()
    {
      return _jobTitle;
    }

    public void SetJobTitle(string jobTitle)
    {
      _jobTitle = jobTitle;
    }

    public string GetCompanyName()
    {
      return _companyName;
    }

    public void SetCompanyName(string companyName)
    {
      _companyName = companyName;
    }

    public string GetLocation()
    {
      return _location;
    }

    public void SetLocation(string location)
    {
      _location = location;
    }

    public string GetStartDate()
    {
      return _startDate;
    }

    public void SetStartDate(string startDate)
    {
      _startDate = startDate;
    }

    public string GetEndDate()
    {
      return _endDate;
    }

    public void SetEndDate(string endDate)
    {
      _endDate = endDate;
    }

    public string GetDescription()
    {
      return _description;
    }

    public void SetDescription(string desc)
    {
      _description = desc;
    }
  }

}
