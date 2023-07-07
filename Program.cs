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

        string text = phrase.Substring(phrase.IndexOf("says ") + 5);
        Console.WriteLine(text);
    }
}
