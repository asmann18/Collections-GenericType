namespace PracticeConsoleApp.Exceptions;

public class BookAlreadyExistException:Exception
{
    public string Message;
    public BookAlreadyExistException(string messsage = "Book Already Exist!! .") : base(messsage)
    {

    }
}
