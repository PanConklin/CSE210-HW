public class Entry
{
    private string _prompt; //rand prompt from prompt class
    private string _date;
    private string _emotion;
    private string _dailyQuote;

    public Entry(string prompt, string date, string emotion, string dailyQuote)
    {
        _prompt = prompt;
        _date = date;
        _emotion = emotion;
        _dailyQuote = dailyQuote;
    }

    public void WriteEntry()
    {

    }
}