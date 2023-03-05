static string DeleteSpace(string sentence)
{
    char space = ' ';
    char nospace = '\0';
    string newone = string.Empty;
    for (int i = 0; i < sentence.Length; i++)
    {
        if (sentence[i] == space)
        {
            newone = newone + nospace;
        }
        else
        {
            newone = newone + sentence[i];
        }
    }
    return newone;
}
Console.WriteLine(DeleteSpace("Hello World"));