namespace PracticeConsoleApp.Exceptions;

public class InvalidInputException:Exception
{
    public string Message;
    public InvalidInputException(string message= "Invalid Input"):base(message)
    {
        
    }
}
