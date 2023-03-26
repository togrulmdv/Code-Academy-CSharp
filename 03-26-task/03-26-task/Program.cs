using Core.Entities;
using Utils.Exceptions;


try
{
    Book book1 = new("Qara", "Filankes", 236);
    Book book2 = new("Melikmemmed", "Filankes2", 228);
    Book book3 = new("Tiq-Tiq xanim", "Filankes3", 18);
    Book book4 = new("Qara", "Filankes4", 248);
    Book book5 = new("Hello World", "Filankes", 11);

    Library BigLibrary = new(4);

    BigLibrary.AddBook(book1);
    BigLibrary.AddBook(book2);
    BigLibrary.AddBook(book3);
    BigLibrary.AddBook(book4);
    BigLibrary.AddBook(book5);

    foreach(var item in BigLibrary.GetAllBooks())
    {
        Console.WriteLine(item.ShowInfo());
    }
}
catch (AlreadyExistsException ex)
{
    Console.WriteLine(ex.Message);
}
catch (CapacityLimitException ex)
{
    Console.WriteLine(ex.Message);
}
catch (NotFoundException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
