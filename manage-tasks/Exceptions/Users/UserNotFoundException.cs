public class UserNotFoundException : Exception
{

    // Constructors y create the base Exception class with the message and inner exception if provided
    public UserNotFoundException(string message, Exception? innerException = null)
         : base(message, innerException)
    {
    }
}