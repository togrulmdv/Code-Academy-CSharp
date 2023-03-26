using Core.Interfaces;
using Utils.Exceptions;

namespace Core.Entities;

public class Library : IEntity
{
    private static int _id;
    public int ID => ++_id;
    public int BookLimit { get; set; }
    private Book[] books;
    public Library(int bookLimit)
    {
        BookLimit= bookLimit;
        books= new Book[0];
    }

    public void AddBook(Book bookObject)
    {
        if (books.Length == 0)
        {
            books[0] = bookObject;
        }
        else
        {
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i].Name != bookObject.Name && books[i].IsDeleted == false)
                {
                    if (books.Length < BookLimit)
                    {
                        Array.Resize(ref books, books.Length + 1);
                        books[books.Length - 1] = bookObject;
                    }
                    else
                    {
                        throw new CapacityLimitException("Library is full!");
                    }
                }
                else
                {
                    throw new AlreadyExistsException("This book already exists!");
                }
            }
        }
    }

    public Book GetBook(int id)
    {
        foreach (var book in books)
        {
            if (book.IsDeleted==false && book.ID == id)
                return book;
        }
        throw new NotFoundException("Such book does not exist!");
    }

    public Book[] GetAllBooks()
    {
        Book[] newone=new Book[0];
        for(int i=0;i<books.Length;i++) 
        {
            newone[i]=books[i];
        }
        return newone;
    }

    public void DeleteBookByID(int id)
    {
        foreach (var book in books)
        {
            if (book.IsDeleted == false && book.ID == id)
            {book.IsDeleted= true;}
            else
            { throw new NotFoundException("Such book does not exist!"); }
        }
    }

    public void Sort()
    {
        for (int i = 0; i < books.Length - 1; i++)
        {
            for (int j = 0; j < books.Length - i - 1; j++)
            {
                if (books[j].PageCount > books[j + 1].PageCount)
                {
                    Book kitab = books[j];
                    books[j] = books[j + 1];
                    books[j + 1] = kitab;
                }
            }
        }
    }
}
