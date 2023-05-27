public class Scripture
{
    List<Word> _words = new List<Word>();
    Reference _reference;
    private string _verse;


    public Scripture(Reference reference, string verse)
    {
        _reference = reference;
        _verse = verse;
        ConvertStringToList();
    }

    private void ConvertStringToList()
    {
        string[] verseWords = _verse.Split(' ');
        foreach (string word in verseWords)
        {
            _words.Add(new Word(word, false));
        }
    }

    public void HideWords()
    {
        Console.Clear();
        DisplayScripture();
        Console.WriteLine("\nPress Enter to hide words...");
        Console.WriteLine();

        int hiddenCount = 0;
        //int wordsToRemove = 1; //idk if i even need this here

        while (hiddenCount < _words.Count)
        {
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                // Wait for the Enter key to be pressed
            }

            Random random = new Random();

            foreach (Word word in _words)
            {
                if (!word.IsHidden)
                {
                    if (random.NextDouble() < 0.3)
                    {
                        word.HideWord();
                        hiddenCount++;
                    }
                }
            }

            Console.Clear();
            DisplayScripture();
            Console.WriteLine("\nPress Enter to hide more words...");
            Console.WriteLine();
        }

        Console.Clear();
    }

    //public void ShowAllWords()
    //{
    //    DisplayScripture();
    //}

    public void DisplayScripture()
    {
        Console.WriteLine($"Scripture Reference: {_reference.DisplayReference()}");
        Console.WriteLine("Scripture Text:");

        foreach (Word word in _words)
        {
            word.Display();
        }
    }
}




//public bool LeavePunctuation(string word)
//{
//    foreach (char c in word)
//    {
//        if (char.IsPunctuation(c))
//        {
//            return true;
//        }
//    }
//    return false;
//}