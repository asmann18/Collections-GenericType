namespace PracticeConsoleApp.Exceptions;

public class LibaryNotFoundException:Exception
{
    public  string Message ;
    public LibaryNotFoundException(string message = "Libary is not found!404.") : base(message)
    {

    }
}
