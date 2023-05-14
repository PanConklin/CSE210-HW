public class Menu
{


    Journal journal = new Journal();



    public Menu()
    {

    }

    public void Display()
    {
        string response = "";
        string[] options = { "Write", "Display", "Load", "Save", "Quit" };
        while (response != "Quit")
        {
            while (options.Contains(response) == false)
            {
                Console.Write("\n Write\n Display\n Load\n Save\n Quit\n \nWhat do you want to do? ");
                response = Console.ReadLine() ?? String.Empty;
            }
            switch (response)
            {
                case "Write":
                    Prompt prompt1 = new Prompt();
                    string randPrompt = prompt1.GetRandomPrompt();
                    Console.WriteLine(randPrompt);
                    string promptAnswer = Console.ReadLine();
                    Entry entry = new Entry(randPrompt, promptAnswer);
                    journal.AddEntry(entry);

                    break;
                case "Display":
                    journal.DisplayJournal();
                    break;
                case "Load":
                    journal.LoadJournal();
                    break;
                case "Save":
                    journal.SaveJournal();
                    break;
                case "Quit":
                    Environment.Exit(0);
                    break;
            }
            response = "";
        }



    }





}
