public class Prompt
{
    public List<string> _promptList = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    private string _prompt = "";
    DateTime _date = DateTime.Now;
    //string _date = _date.ToShortDateString();

    private string _response = "";

    public string GetRandomPrompt()
    {
        var random = new Random();
        var randomNumber = random.Next(0, _promptList.Count);
        string randomPrompt = _promptList[randomNumber];
        return randomPrompt;
    }

}