public class Word
{

    private string _word;
    private bool _isHidden;


    public Word(string word, bool isHidden)
    {
        _word = word;
        _isHidden = isHidden;
    }

    public void HideWord()
    {
        if (!string.IsNullOrEmpty(_word)) //checks to see if word can be hidden
        {
            _isHidden = true;       //sets x open word to hidden or "-" values
        }
    }

    public void ShowWord()
    {
        _isHidden = false;      //makes sure word is visible
    }

    public bool IsHidden
    {
        get { return _isHidden; }
        set { _isHidden = value; }
    }

    public void Display()
    {
        if (_isHidden)
        {
            Console.Write(new string('-', _word.Length) + " ");
        }
        else
        {
            Console.Write(_word + " ");
        }
    }
}