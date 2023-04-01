namespace Delegates;

public class ReturnStringDelegate
{
    private char[] _vowels = new[] { 'a', 'e', 'i', 'o', 'u' };

    private delegate string StringDelegate(string word);

    private string GetReversedWordString(string word)
    {
        string[] splittedWord = word.Split();
        IEnumerable<string> reversedString = splittedWord.Reverse();

        return reversedString.ToString();
    }

    private string GetVowelsString(string word)
    {
        string vowelsString = "";

        for (var i = 0; i < word.Length; i++)
        {
            if (_vowels.Contains(word[i]))
                vowelsString.Append(word[i]);
        }

        return vowelsString;
    }

    private string GetUnspkenString(string word)
    {
        string vowelsString = "";

        for (var i = 0; i < word.Length; i++)
        {
            if (!_vowels.Contains(word[i]))
                vowelsString.Append(word[i]);
        }

        return vowelsString;
    }

    public ReturnStringDelegate()
    {
        string word = "Hello";

        StringDelegate stringDelegate = GetReversedWordString;
        stringDelegate += GetVowelsString;
        stringDelegate += GetUnspkenString;

        stringDelegate += GetUnspkenString;

        var result = stringDelegate(word);

        Console.ReadLine();
    }
}