using PracticeConsoleApp.Exceptions;
using PracticeConsoleApp.Models.Common;

namespace PracticeConsoleApp.Models;

public class Libary:BaseEntity
{
    static int count = 0;

    List<Book> _books=new List<Book>();
    public Libary(string name):base(name)
    {
        Id= ++count;
    }

    public void AddBook(Book book)
    {
        foreach (var item in _books)
        {
            if(item.Id == book.Id)
            {
                throw new BookAlreadyExistException();
            }

        }
        _books.Add(book);
        Console.WriteLine("books added");
    }

    public void ListAllBooks()
    {
        if (_books.Count == 0)
        {
            throw new BookNotFoundException();
        }
        foreach (Book book in _books)
        {
            Console.WriteLine(book);
        }
    }
}
