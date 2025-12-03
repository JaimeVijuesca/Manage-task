public class InvalidCredentialsException : Exception
{

    // Constructor that accepts a message and an optional inner exception parameter
    public InvalidCredentialsException(string message, Exception? innerException = null)
    : base(message, innerException)
    {
    }
}