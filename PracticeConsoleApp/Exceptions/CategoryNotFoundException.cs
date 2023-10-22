namespace PracticeConsoleApp.Exceptions;

public class CategoryNotFoundException:Exception
{
    public  string Message;
    public CategoryNotFoundException(string message = "Category is not foun!404."):base(message)
    {
        
    }
}
