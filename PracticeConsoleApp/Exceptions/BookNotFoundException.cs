namespace PracticeConsoleApp.Exceptions;

public class BookNotFoundException:Exception
{
    public string Message ;
    public BookNotFoundException(string messsage= "Book is not foun!404.") : base(messsage)
    {

    }                               
}
