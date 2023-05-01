//How to create a class
public class Book
{

    private string _author;
    private string _name;
    private int _timesRed = 0;
    private bool _available = true;

    //This creates a constructor
    public Book(string name, string author)
    {
        _name = name;
        _author = author;
    }

    public void Display()
    {
        Console.WriteLine($"{_name} by {_author}");
        if (!_available)
        {
            Console.WriteLine("[Checked Out]");
        }
        else
        {
            Console.WriteLine("[Checked In]");
        }
    }

    public bool IsAvailable()
    {
        return _available;
    }

    public void CheckOut()
    {
        _available = false;
        _timesRed += 1;
    }

    public void CheckIn()
    {
        _available = true;
    }

    public bool HasAuthor(string author)
    {
        return _author.Contains(author);
    }
}