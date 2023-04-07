public static class StringExtensions
{
    public static string Shorten(this string str, int numberOfWords)
    {
        var words = str.Split(" ");

        if (words.Length < numberOfWords)
            return str;

        return string.Join(" ", words.Take(numberOfWords));
    }
}