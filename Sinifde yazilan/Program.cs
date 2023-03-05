using Sinifde_yazilan.Models;

public class Program
{
    public static void Main()
    {
        Book Info = new Book("Sade Heyat", 25, 50, "Memmedaga", 128, 50);
        Info.GetInfo();
    }
}