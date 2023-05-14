public class Entry
{
    private string _randomPrompt = "";

    private string _promptAnswer = "";

    string _date = "";

    public Entry(string randomPrompt, string promptAnswer)
    {
        _randomPrompt = randomPrompt;
        _promptAnswer = promptAnswer;
        _date = GetDate();
    }

    public string GetDate()
    {
        DateTime _date = DateTime.Now;
        string entryDate = _date.ToShortDateString();
        return entryDate;
    }

    public string DisplayEntries()
    {
        return $"{_randomPrompt}\n{_promptAnswer}\n{GetDate()}";
    }

}