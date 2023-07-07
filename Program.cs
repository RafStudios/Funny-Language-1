using System;

class FunnyLanguage
{
    static void Main()
    {
        Console.WriteLine("Enter your funny language phrase:");
        string phrase = Console.ReadLine(); // Read the user's input

        InterpretPhrase(phrase); // Interpret and execute the phrase

        Console.ReadKey();
    }

    static void InterpretPhrase(string phrase)
    {
        string[] words = phrase.Split(' ');

        if (words[0] != "Hey")
        {
            Console.WriteLine("Invalid phrase. The program should start with 'Hey'.");
            return;
        }

        if (words[1] != "I" || words[2] != "Want" || words[3] != "to" || words[4] != "Make" || words[5] != "a" ||
            words[6] != "text" || words[7] != "that" || words[8] != "appeared" || words[9] != "and" || words[10] != "says" ||
            words[11] != "(" || !words[12].EndsWith(")"))
        {
            Console.WriteLine("Invalid phrase. The phrase should follow the format: 'Hey I Want to Make a text that appeared and says (Text Specified)'");
            return;
        }

        string text = phrase.Substring(phrase.IndexOf('(') + 1, phrase.LastIndexOf(')') - phrase.IndexOf('(') - 1);
        Console.WriteLine(text);
    }
}
