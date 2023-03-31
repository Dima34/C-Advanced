namespace Delegates;

public class FuncDelegate
{
    private char[] _vowels = new[] { 'a', 'e', 'i', 'o', 'u' };

    private int GetWordLength(string word)
    {
        return word.Length;
    }

    private int GetWordVowel(string word)
    {
        int vowelCount = 0;
        
        for (var i = 0; i < word.Length; i++)
        {
            if (_vowels.Contains(word[i]))
                vowelCount++;
        }

        return vowelCount;
    }

    private int GetWordUnspoken(string word)
    {
        int unspokenCount = 0;
        
        for (var i = 0; i < word.Length; i++)
        {
            if (!_vowels.Contains(word[i]))
                unspokenCount++;
        }

        return unspokenCount;
    }

    public FuncDelegate(){
        Func<string, int> StringCounterDelegate = GetWordLength;
        StringCounterDelegate += GetWordVowel;
        StringCounterDelegate += GetWordUnspoken;

        var answe = StringCounterDelegate("Hello");
        Console.WriteLine();
    }
}