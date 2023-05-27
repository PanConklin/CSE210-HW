using System;

class Program
{
    static void Main(string[] args)
    {

        List<Scripture> _scriptList = new List<Scripture>();
        //Reference reference = new Reference("Hebrews", 13, 8);
        //Scripture testScripture = new Scripture(new Reference("Hebrews", 13, 8), "Jesus Christ the same yesterday, and to day, and for ever");

        //Word testWord = new Word("Brett", false);
        //testWord.ManipulateWord();

        Reference reference1 = new Reference("Alma", 37, 6, 7);
        string verse1 = "Now ye may suppose that this is foolishness in me, but behold I say unto you, that by small and simple things are great things brought to pass; and small means in many instances doth confound the wise. And the Lord God doth work by Means to bring about his great and eternal purposes; and by very small means the Lord doth confound the wise and bringith about the salvation of many souls";
        Scripture scripture1 = new Scripture(reference1, verse1);


        Reference reference2 = new Reference("John", 7, 17);
        string verse2 = "If any man will do his will, he shall know of the doctrine, whether it be of God, or whether I speak of myself";
        Scripture scripture2 = new Scripture(reference2, verse2);


        Reference reference3 = new Reference("Ether", 12, 6);
        string verse3 = "And now, I, Moroni, would speak somewhat concerning these things; I would show unto the world that faith is things which are hoped for and not seen; wherefore, dispute not because ye see not, for ye receive no witness until after the trial of your faith.";
        Scripture scripture3 = new Scripture(reference3, verse3);

        //scripture1.HideWords();
        //scripture1.DisplayScripture();

        _scriptList.Add(scripture1);
        _scriptList.Add(scripture2);
        _scriptList.Add(scripture3);

        Random random = new Random();
        int r = random.Next(_scriptList.Count);
        Scripture randomScripture = _scriptList[r];

        randomScripture.HideWords();
        randomScripture.DisplayScripture();

        //randomScripture.ShowAllWords();

    }
}