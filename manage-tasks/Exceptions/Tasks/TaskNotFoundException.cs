public class TaskNotFoundException : Exception
{

    // Constructor that accepts a message and an optional inner exception parameter
    public TaskNotFoundException(string message, Exception? innerException = null)
        : base(message, innerException)
    {
    }
}