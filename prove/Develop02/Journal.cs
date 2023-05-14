public class Journal
{
    public List<Entry> _entryList = new List<Entry>();



    public void DisplayJournal()
    {
        foreach (Entry entry in _entryList)
        {
            Console.WriteLine(entry.DisplayEntries());
        }
    }
    public void AddEntry(Entry entry)
    {
        _entryList.Add(entry);
    }

    public void SaveJournal() //in the txt file it still only returns "Entry" ---ask Andres durning meeting on Friday
    {
        string txtFile = "journalFile.txt";

        using (StreamWriter journalFile = new StreamWriter(txtFile))
        {
            foreach (Entry entry in _entryList)
            {
                journalFile.WriteLine(entry);
            }
        }
    }

    public void LoadJournal() //Because save still isnt working i have nothing to Load 8(
    {
        string txtFile = "journalFile.txt";
        string[] lines = System.IO.File.ReadAllLines(txtFile);
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string prompt = parts[0];
            string response = parts[1];
            string date = parts[2];
        }
    }
}