void PrintMessage(string txt) { Console.WriteLine(txt); }
void PrintMessageUpperCase(string txt) { Console.WriteLine(txt.ToUpper()); }
void PrintMessageReverse(string txt) 
{
    string newoone=string.Empty;
    for(int i=txt.Length;i<0;i--)
    {
        newoone += txt[i];
    }
    Console.WriteLine(newoone);
}



Print printele = PrintMessage;
printele += PrintMessageReverse;
printele += PrintMessageUpperCase;





string word = "asd";
printele(word);


delegate void Print(string txt);
