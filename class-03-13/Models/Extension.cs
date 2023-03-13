namespace class_03_13.Models;

internal static class Extension
{
    public static bool IsOdd(this int number)
    {
        return number % 2 != 0;
    }
    public static bool IsEven(this int number)
    {
        return number % 2 == 0;
    }
    public static bool IsContainsDigit(this string word)
    {
        bool have=false;
        for (int i=0;i<word.Length;i++)
        {

            if (char.IsDigit(word[i]))
            {
                have = true;
            }

        }
        return have;

    }
}
