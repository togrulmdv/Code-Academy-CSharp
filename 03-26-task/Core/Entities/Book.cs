using Core.Interfaces;

namespace Core.Entities;

public class Book : IEntity
{
    private static int _id;
    public int ID => ++_id;
    public string Name { get; set; }
    public string AuthorName { get; set; }
    public int PageCount { get; set; }
    public bool IsDeleted { get; set; }


    public Book(string name, string authorName, int pageCount)
    {
        Name = name;
        AuthorName = authorName;
        PageCount = pageCount;
        IsDeleted = false;
    }


    public string ShowInfo()
    {
        return $"{ID} - {Name} - {AuthorName} - {PageCount} - {IsDeleted}";
    }
    public static bool operator >(Book book1, Book book2)
    {
        return book1.PageCount > book2.PageCount;
    }
    public static bool operator <(Book book1, Book book2)
    {
        return book1.PageCount < book2.PageCount;
    }
}
